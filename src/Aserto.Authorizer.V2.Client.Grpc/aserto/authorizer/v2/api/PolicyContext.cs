// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/authorizer/v2/api/policy_context.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Authorizer.V2.API {

  /// <summary>Holder for reflection information generated from aserto/authorizer/v2/api/policy_context.proto</summary>
  public static partial class PolicyContextReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/authorizer/v2/api/policy_context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1hc2VydG8vYXV0aG9yaXplci92Mi9hcGkvcG9saWN5X2NvbnRleHQucHJv",
            "dG8SGGFzZXJ0by5hdXRob3JpemVyLnYyLmFwaSJWCg1Qb2xpY3lDb250ZXh0",
            "EgwKBG5hbWUYASABKAkSFgoOaW5zdGFuY2VfbGFiZWwYAiABKAkSDAoEcGF0",
            "aBgDIAEoCRIRCglkZWNpc2lvbnMYBCADKAlCXVpAZ2l0aHViLmNvbS9hc2Vy",
            "dG8tZGV2L2dvLWF1dGhvcml6ZXIvYXNlcnRvL2F1dGhvcml6ZXIvdjIvYXBp",
            "O2FwaaoCGEFzZXJ0by5BdXRob3JpemVyLlYyLkFQSWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Authorizer.V2.API.PolicyContext), global::Aserto.Authorizer.V2.API.PolicyContext.Parser, new[]{ "Name", "InstanceLabel", "Path", "Decisions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PolicyContext : pb::IMessage<PolicyContext>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyContext> _parser = new pb::MessageParser<PolicyContext>(() => new PolicyContext());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyContext> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Authorizer.V2.API.PolicyContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyContext(PolicyContext other) : this() {
      name_ = other.name_;
      instanceLabel_ = other.instanceLabel_;
      path_ = other.path_;
      decisions_ = other.decisions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyContext Clone() {
      return new PolicyContext(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// policy name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instance_label" field.</summary>
    public const int InstanceLabelFieldNumber = 2;
    private string instanceLabel_ = "";
    /// <summary>
    /// label identifying the instance of the policy
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstanceLabel {
      get { return instanceLabel_; }
      set {
        instanceLabel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 3;
    private string path_ = "";
    /// <summary>
    /// policy path aka package name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "decisions" field.</summary>
    public const int DecisionsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_decisions_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> decisions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// list (1..N) of policy decisions (aka rules)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Decisions {
      get { return decisions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyContext);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (InstanceLabel != other.InstanceLabel) return false;
      if (Path != other.Path) return false;
      if(!decisions_.Equals(other.decisions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (InstanceLabel.Length != 0) hash ^= InstanceLabel.GetHashCode();
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      hash ^= decisions_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (InstanceLabel.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InstanceLabel);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Path);
      }
      decisions_.WriteTo(output, _repeated_decisions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (InstanceLabel.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InstanceLabel);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Path);
      }
      decisions_.WriteTo(ref output, _repeated_decisions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (InstanceLabel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstanceLabel);
      }
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      size += decisions_.CalculateSize(_repeated_decisions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PolicyContext other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.InstanceLabel.Length != 0) {
        InstanceLabel = other.InstanceLabel;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      decisions_.Add(other.decisions_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            InstanceLabel = input.ReadString();
            break;
          }
          case 26: {
            Path = input.ReadString();
            break;
          }
          case 34: {
            decisions_.AddEntriesFrom(input, _repeated_decisions_codec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            InstanceLabel = input.ReadString();
            break;
          }
          case 26: {
            Path = input.ReadString();
            break;
          }
          case 34: {
            decisions_.AddEntriesFrom(ref input, _repeated_decisions_codec);
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