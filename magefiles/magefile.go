//go:build mage
// +build mage

package main

import (
	"fmt"
	"os"
	"path"
	"path/filepath"
	"strings"

	"github.com/aserto-dev/mage-loot/buf"
	"github.com/aserto-dev/mage-loot/common"
	"github.com/aserto-dev/mage-loot/deps"
	"github.com/aserto-dev/mage-loot/dotnet/dotnetbuild"
	"github.com/aserto-dev/mage-loot/fsutil"
	"github.com/aserto-dev/mage-loot/mage"
	"github.com/pkg/errors"
)

func init() {
	os.Setenv("GO_VERSION", "1.17")
	os.Setenv("GOPRIVATE", "github.com/aserto-dev")
}

func All() error {
	Deps()
	err := Clean()
	if err != nil {
		return err
	}
	err = Generate()
	if err != nil {
		return err
	}
	return Build()

}

// install required dependencies.
func Deps() {
	deps.GetAllDeps()
}

func Generate() error {
	bufImage := "buf.build/aserto-dev/authorizer"

	tag, err := buf.GetLatestTag(bufImage)
	if err != nil {
		fmt.Printf("Could not retrieve tags, using latest: %s\n", err)
	} else {
		bufImage = fmt.Sprintf("%s:%s", bufImage, tag.Name)
	}

	return gen(bufImage)
}

// Generates from a dev build.
func GenerateDev() error {
	err := BuildDev()
	if err != nil {
		return err
	}

	fileSources := filepath.Join(getProtoRepo(), "proto#format=dir")

	return gen(fileSources)
}

// Builds the aserto proto image
func BuildDev() error {
	return mage.RunDirs(path.Join(getProtoRepo(), "magefiles"), getProtoRepo(), mage.AddArg("build"))
}

func getProtoRepo() string {
	protoRepo := os.Getenv("PROTO_REPO")
	if protoRepo == "" {
		protoRepo = "../pb-authorizer"
	}
	return protoRepo
}

//Generate the code
func gen(fileSources string) error {

	bufExportDir := filepath.Join(deps.ExtTmpDir(), "export")
	defer os.RemoveAll(bufExportDir)

	authorizerPatterns := []string{
		filepath.Join(bufExportDir, "aserto", "authorizer", "**", "*.proto"),
		filepath.Join(bufExportDir, "protoc-gen-openapiv2", "options", "**", "*.proto"),
		filepath.Join(bufExportDir, "google", "api", "**", "*.proto"),
	}

	err := os.RemoveAll(bufExportDir)
	if err != nil {
		return err
	}

	fsutil.EnsureDir(bufExportDir)

	err = buf.Run(
		buf.AddArg("export"),
		buf.AddArg(fileSources),
		buf.AddArg("-o"),
		buf.AddArg(bufExportDir),
	)

	bufGenDir := filepath.Join(deps.ExtTmpDir(), "proto")
	fsutil.EnsureDir(bufGenDir)
	defer os.RemoveAll(bufGenDir)

	for _, fp := range authorizerPatterns {
		files, err := fsutil.Glob(fp, "")
		if err != nil {
			return errors.Wrapf(err, "failed to glob %s", fp)
		}

		for _, f := range files {

			genFile := strings.Replace(f, bufExportDir, bufGenDir, -1)
			fsutil.EnsureDir(filepath.Dir(genFile))

			err = os.Rename(f, genFile)
			if err != nil {
				return errors.Wrapf(err, "failed to rename %s", f)
			}
		}
	}

	return dotnetbuild.Run(
		dotnetbuild.Project(filepath.Join(common.WorkDir(), "build", "generate.csproj")),
	)
}

// Builds the Dotnet client projects.
func Build() error {
	return dotnetbuild.Run(
		dotnetbuild.Project(filepath.Join(common.WorkDir(), "build", "generate.csproj")),
	)
}

// Clean generated files
func Clean() error {
	err := os.RemoveAll(filepath.Join("src", "Aserto.Authorizer.V2.Client.Grpc", "aserto"))
	if err != nil {
		return err
	}

	err = os.RemoveAll(filepath.Join("src", "Aserto.Authorizer.V2.Client.Grpc", "protoc-gen-openapiv2"))
	if err != nil {
		return err
	}

	return os.RemoveAll(filepath.Join("src", "Aserto.Authorizer.V2.Client.Grpc", "google"))
}
