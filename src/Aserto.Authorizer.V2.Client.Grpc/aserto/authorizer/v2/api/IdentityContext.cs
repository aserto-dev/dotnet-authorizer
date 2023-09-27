// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/authorizer/v2/api/identity_context.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Authorizer.V2.API {

  /// <summary>Holder for reflection information generated from aserto/authorizer/v2/api/identity_context.proto</summary>
  public static partial class IdentityContextReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/authorizer/v2/api/identity_context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IdentityContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9hc2VydG8vYXV0aG9yaXplci92Mi9hcGkvaWRlbnRpdHlfY29udGV4dC5w",
            "cm90bxIYYXNlcnRvLmF1dGhvcml6ZXIudjIuYXBpIlkKD0lkZW50aXR5Q29u",
            "dGV4dBIQCghpZGVudGl0eRgBIAEoCRI0CgR0eXBlGAIgASgOMiYuYXNlcnRv",
            "LmF1dGhvcml6ZXIudjIuYXBpLklkZW50aXR5VHlwZSqJAQoMSWRlbnRpdHlU",
            "eXBlEhkKFUlERU5USVRZX1RZUEVfVU5LTk9XThAAEhYKEklERU5USVRZX1RZ",
            "UEVfTk9ORRABEhUKEUlERU5USVRZX1RZUEVfU1VCEAISFQoRSURFTlRJVFlf",
            "VFlQRV9KV1QQAxIYChRJREVOVElUWV9UWVBFX01BTlVBTBAEQl1aQGdpdGh1",
            "Yi5jb20vYXNlcnRvLWRldi9nby1hdXRob3JpemVyL2FzZXJ0by9hdXRob3Jp",
            "emVyL3YyL2FwaTthcGmqAhhBc2VydG8uQXV0aG9yaXplci5WMi5BUEliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Aserto.Authorizer.V2.API.IdentityType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Authorizer.V2.API.IdentityContext), global::Aserto.Authorizer.V2.API.IdentityContext.Parser, new[]{ "Identity", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Identity types, describes the payload type of the identity field inside the IdentityContext message.
  /// </summary>
  public enum IdentityType {
    /// <summary>
    /// Unknown, value not set, requests will fail with identity type not set error.
    /// </summary>
    [pbr::OriginalName("IDENTITY_TYPE_UNKNOWN")] Unknown = 0,
    /// <summary>
    /// None, no explicit identity context set, equals anonymous.
    /// </summary>
    [pbr::OriginalName("IDENTITY_TYPE_NONE")] None = 1,
    /// <summary>
    /// Sub(ject), identity field contains an oAUTH subject.
    /// </summary>
    [pbr::OriginalName("IDENTITY_TYPE_SUB")] Sub = 2,
    /// <summary>
    /// JWT, identity field contains a JWT access token.
    /// </summary>
    [pbr::OriginalName("IDENTITY_TYPE_JWT")] Jwt = 3,
    /// <summary>
    /// Manual, propagates thw identity field as-is, without validation, into the input object.
    /// </summary>
    [pbr::OriginalName("IDENTITY_TYPE_MANUAL")] Manual = 4,
  }

  #endregion

  #region Messages
  public sealed partial class IdentityContext : pb::IMessage<IdentityContext>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IdentityContext> _parser = new pb::MessageParser<IdentityContext>(() => new IdentityContext());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdentityContext> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Authorizer.V2.API.IdentityContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityContext(IdentityContext other) : this() {
      identity_ = other.identity_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityContext Clone() {
      return new IdentityContext(this);
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 1;
    private string identity_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Identity {
      get { return identity_; }
      set {
        identity_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Aserto.Authorizer.V2.API.IdentityType type_ = global::Aserto.Authorizer.V2.API.IdentityType.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Aserto.Authorizer.V2.API.IdentityType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdentityContext);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdentityContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Identity != other.Identity) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Identity.Length != 0) hash ^= Identity.GetHashCode();
      if (Type != global::Aserto.Authorizer.V2.API.IdentityType.Unknown) hash ^= Type.GetHashCode();
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
      if (Identity.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Identity);
      }
      if (Type != global::Aserto.Authorizer.V2.API.IdentityType.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Identity.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Identity);
      }
      if (Type != global::Aserto.Authorizer.V2.API.IdentityType.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Identity.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Identity);
      }
      if (Type != global::Aserto.Authorizer.V2.API.IdentityType.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdentityContext other) {
      if (other == null) {
        return;
      }
      if (other.Identity.Length != 0) {
        Identity = other.Identity;
      }
      if (other.Type != global::Aserto.Authorizer.V2.API.IdentityType.Unknown) {
        Type = other.Type;
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
            Identity = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Aserto.Authorizer.V2.API.IdentityType) input.ReadEnum();
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
            Identity = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Aserto.Authorizer.V2.API.IdentityType) input.ReadEnum();
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
