// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/user_list_string_rule_item_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/user_list_string_rule_item_operator.proto</summary>
  public static partial class UserListStringRuleItemOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/user_list_string_rule_item_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListStringRuleItemOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvdXNlcl9saXN0X3N0",
            "cmluZ19ydWxlX2l0ZW1fb3BlcmF0b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNy5lbnVtcyLpAQoiVXNlckxpc3RTdHJpbmdSdWxlSXRlbU9w",
            "ZXJhdG9yRW51bSLCAQoeVXNlckxpc3RTdHJpbmdSdWxlSXRlbU9wZXJhdG9y",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgwKCENPTlRBSU5TEAIS",
            "CgoGRVFVQUxTEAMSDwoLU1RBUlRTX1dJVEgQBBINCglFTkRTX1dJVEgQBRIO",
            "CgpOT1RfRVFVQUxTEAYSEAoMTk9UX0NPTlRBSU5TEAcSEwoPTk9UX1NUQVJU",
            "U19XSVRIEAgSEQoNTk9UX0VORFNfV0lUSBAJQv0BCiJjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjE3LmVudW1zQiNVc2VyTGlzdFN0cmluZ1J1bGVJdGVt",
            "T3BlcmF0b3JQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE3L2VudW1zO2VudW1zogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE3LkVudW1zygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjE3XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjE3OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.UserListStringRuleItemOperatorEnum), global::Google.Ads.GoogleAds.V17.Enums.UserListStringRuleItemOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.UserListStringRuleItemOperatorEnum.Types.UserListStringRuleItemOperator) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Supported rule operator for string type.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserListStringRuleItemOperatorEnum : pb::IMessage<UserListStringRuleItemOperatorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserListStringRuleItemOperatorEnum> _parser = new pb::MessageParser<UserListStringRuleItemOperatorEnum>(() => new UserListStringRuleItemOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserListStringRuleItemOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.UserListStringRuleItemOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListStringRuleItemOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListStringRuleItemOperatorEnum(UserListStringRuleItemOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListStringRuleItemOperatorEnum Clone() {
      return new UserListStringRuleItemOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserListStringRuleItemOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserListStringRuleItemOperatorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserListStringRuleItemOperatorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the UserListStringRuleItemOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list string rule item operators.
      /// </summary>
      public enum UserListStringRuleItemOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Contains.
        /// </summary>
        [pbr::OriginalName("CONTAINS")] Contains = 2,
        /// <summary>
        /// Equals.
        /// </summary>
        [pbr::OriginalName("EQUALS")] Equals = 3,
        /// <summary>
        /// Starts with.
        /// </summary>
        [pbr::OriginalName("STARTS_WITH")] StartsWith = 4,
        /// <summary>
        /// Ends with.
        /// </summary>
        [pbr::OriginalName("ENDS_WITH")] EndsWith = 5,
        /// <summary>
        /// Not equals.
        /// </summary>
        [pbr::OriginalName("NOT_EQUALS")] NotEquals = 6,
        /// <summary>
        /// Not contains.
        /// </summary>
        [pbr::OriginalName("NOT_CONTAINS")] NotContains = 7,
        /// <summary>
        /// Not starts with.
        /// </summary>
        [pbr::OriginalName("NOT_STARTS_WITH")] NotStartsWith = 8,
        /// <summary>
        /// Not ends with.
        /// </summary>
        [pbr::OriginalName("NOT_ENDS_WITH")] NotEndsWith = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
