// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/authorizer/v2/api/module.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Authorizer.V2.API {

  /// <summary>Holder for reflection information generated from aserto/authorizer/v2/api/module.proto</summary>
  public static partial class ModuleReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/authorizer/v2/api/module.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModuleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVhc2VydG8vYXV0aG9yaXplci92Mi9hcGkvbW9kdWxlLnByb3RvEhhhc2Vy",
            "dG8uYXV0aG9yaXplci52Mi5hcGkaHGdvb2dsZS9wcm90b2J1Zi9zdHJ1Y3Qu",
            "cHJvdG8ixAEKBk1vZHVsZRIPCgJpZBgBIAEoCUgAiAEBEhAKA3JhdxgCIAEo",
            "CUgBiAEBEhkKDHBhY2thZ2VfcGF0aBgDIAEoCUgCiAEBEigKA2FzdBgEIAEo",
            "CzIWLmdvb2dsZS5wcm90b2J1Zi5WYWx1ZUgDiAEBEhkKDHBhY2thZ2Vfcm9v",
            "dBgFIAEoCUgEiAEBQgUKA19pZEIGCgRfcmF3Qg8KDV9wYWNrYWdlX3BhdGhC",
            "BgoEX2FzdEIPCg1fcGFja2FnZV9yb290Ql1aQGdpdGh1Yi5jb20vYXNlcnRv",
            "LWRldi9nby1hdXRob3JpemVyL2FzZXJ0by9hdXRob3JpemVyL3YyL2FwaTth",
            "cGmqAhhBc2VydG8uQXV0aG9yaXplci5WMi5BUEliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Authorizer.V2.API.Module), global::Aserto.Authorizer.V2.API.Module.Parser, new[]{ "Id", "Raw", "PackagePath", "Ast", "PackageRoot" }, new[]{ "Id", "Raw", "PackagePath", "Ast", "PackageRoot" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Module : pb::IMessage<Module>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Module> _parser = new pb::MessageParser<Module>(() => new Module());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Module> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Authorizer.V2.API.ModuleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Module() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Module(Module other) : this() {
      id_ = other.id_;
      raw_ = other.raw_;
      packagePath_ = other.packagePath_;
      ast_ = other.ast_ != null ? other.ast_.Clone() : null;
      packageRoot_ = other.packageRoot_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Module Clone() {
      return new Module(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_ ?? ""; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return id_ != null; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      id_ = null;
    }

    /// <summary>Field number for the "raw" field.</summary>
    public const int RawFieldNumber = 2;
    private string raw_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Raw {
      get { return raw_ ?? ""; }
      set {
        raw_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "raw" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRaw {
      get { return raw_ != null; }
    }
    /// <summary>Clears the value of the "raw" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRaw() {
      raw_ = null;
    }

    /// <summary>Field number for the "package_path" field.</summary>
    public const int PackagePathFieldNumber = 3;
    private string packagePath_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PackagePath {
      get { return packagePath_ ?? ""; }
      set {
        packagePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "package_path" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasPackagePath {
      get { return packagePath_ != null; }
    }
    /// <summary>Clears the value of the "package_path" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPackagePath() {
      packagePath_ = null;
    }

    /// <summary>Field number for the "ast" field.</summary>
    public const int AstFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Value ast_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Value Ast {
      get { return ast_; }
      set {
        ast_ = value;
      }
    }

    /// <summary>Field number for the "package_root" field.</summary>
    public const int PackageRootFieldNumber = 5;
    private string packageRoot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PackageRoot {
      get { return packageRoot_ ?? ""; }
      set {
        packageRoot_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "package_root" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasPackageRoot {
      get { return packageRoot_ != null; }
    }
    /// <summary>Clears the value of the "package_root" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPackageRoot() {
      packageRoot_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Module);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Module other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Raw != other.Raw) return false;
      if (PackagePath != other.PackagePath) return false;
      if (!object.Equals(Ast, other.Ast)) return false;
      if (PackageRoot != other.PackageRoot) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasId) hash ^= Id.GetHashCode();
      if (HasRaw) hash ^= Raw.GetHashCode();
      if (HasPackagePath) hash ^= PackagePath.GetHashCode();
      if (ast_ != null) hash ^= Ast.GetHashCode();
      if (HasPackageRoot) hash ^= PackageRoot.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasId) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (HasRaw) {
        output.WriteRawTag(18);
        output.WriteString(Raw);
      }
      if (HasPackagePath) {
        output.WriteRawTag(26);
        output.WriteString(PackagePath);
      }
      if (ast_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Ast);
      }
      if (HasPackageRoot) {
        output.WriteRawTag(42);
        output.WriteString(PackageRoot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasId) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (HasRaw) {
        output.WriteRawTag(18);
        output.WriteString(Raw);
      }
      if (HasPackagePath) {
        output.WriteRawTag(26);
        output.WriteString(PackagePath);
      }
      if (ast_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Ast);
      }
      if (HasPackageRoot) {
        output.WriteRawTag(42);
        output.WriteString(PackageRoot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (HasRaw) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Raw);
      }
      if (HasPackagePath) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PackagePath);
      }
      if (ast_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ast);
      }
      if (HasPackageRoot) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PackageRoot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Module other) {
      if (other == null) {
        return;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasRaw) {
        Raw = other.Raw;
      }
      if (other.HasPackagePath) {
        PackagePath = other.PackagePath;
      }
      if (other.ast_ != null) {
        if (ast_ == null) {
          Ast = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Ast.MergeFrom(other.Ast);
      }
      if (other.HasPackageRoot) {
        PackageRoot = other.PackageRoot;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Raw = input.ReadString();
            break;
          }
          case 26: {
            PackagePath = input.ReadString();
            break;
          }
          case 34: {
            if (ast_ == null) {
              Ast = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Ast);
            break;
          }
          case 42: {
            PackageRoot = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Raw = input.ReadString();
            break;
          }
          case 26: {
            PackagePath = input.ReadString();
            break;
          }
          case 34: {
            if (ast_ == null) {
              Ast = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Ast);
            break;
          }
          case 42: {
            PackageRoot = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
