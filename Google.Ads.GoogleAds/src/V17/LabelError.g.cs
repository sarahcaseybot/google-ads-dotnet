// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/errors/label_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/errors/label_error.proto</summary>
  public static partial class LabelErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/errors/label_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LabelErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZXJyb3JzL2xhYmVsX2Vycm9y",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcuZXJyb3JzIpYDCg5M",
            "YWJlbEVycm9yRW51bSKDAwoKTGFiZWxFcnJvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIfChtDQU5OT1RfQVBQTFlfSU5BQ1RJVkVfTEFCRUwQ",
            "AhI1CjFDQU5OT1RfQVBQTFlfTEFCRUxfVE9fRElTQUJMRURfQURfR1JPVVBf",
            "Q1JJVEVSSU9OEAMSNQoxQ0FOTk9UX0FQUExZX0xBQkVMX1RPX05FR0FUSVZF",
            "X0FEX0dST1VQX0NSSVRFUklPThAEEiEKHUVYQ0VFREVEX0xBQkVMX0xJTUlU",
            "X1BFUl9UWVBFEAUSJgoiSU5WQUxJRF9SRVNPVVJDRV9GT1JfTUFOQUdFUl9M",
            "QUJFTBAGEhIKDkRVUExJQ0FURV9OQU1FEAcSFgoSSU5WQUxJRF9MQUJFTF9O",
            "QU1FEAgSIAocQ0FOTk9UX0FUVEFDSF9MQUJFTF9UT19EUkFGVBAJEi8KK0NB",
            "Tk5PVF9BVFRBQ0hfTk9OX01BTkFHRVJfTEFCRUxfVE9fQ1VTVE9NRVIQCkLv",
            "AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5lcnJvcnNCD0xhYmVs",
            "RXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE3L2Vycm9ycztlcnJvcnOiAgNHQUGq",
            "Ah9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTcuRXJyb3JzygIfR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjE3XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxNzo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Errors.LabelErrorEnum), global::Google.Ads.GoogleAds.V17.Errors.LabelErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Errors.LabelErrorEnum.Types.LabelError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible label errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LabelErrorEnum : pb::IMessage<LabelErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LabelErrorEnum> _parser = new pb::MessageParser<LabelErrorEnum>(() => new LabelErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LabelErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Errors.LabelErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LabelErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LabelErrorEnum(LabelErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LabelErrorEnum Clone() {
      return new LabelErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LabelErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LabelErrorEnum other) {
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
    public void MergeFrom(LabelErrorEnum other) {
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
    /// <summary>Container for nested types declared in the LabelErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible label errors.
      /// </summary>
      public enum LabelError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An inactive label cannot be applied.
        /// </summary>
        [pbr::OriginalName("CANNOT_APPLY_INACTIVE_LABEL")] CannotApplyInactiveLabel = 2,
        /// <summary>
        /// A label cannot be applied to a disabled ad group criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_APPLY_LABEL_TO_DISABLED_AD_GROUP_CRITERION")] CannotApplyLabelToDisabledAdGroupCriterion = 3,
        /// <summary>
        /// A label cannot be applied to a negative ad group criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_APPLY_LABEL_TO_NEGATIVE_AD_GROUP_CRITERION")] CannotApplyLabelToNegativeAdGroupCriterion = 4,
        /// <summary>
        /// Cannot apply more than 50 labels per resource.
        /// </summary>
        [pbr::OriginalName("EXCEEDED_LABEL_LIMIT_PER_TYPE")] ExceededLabelLimitPerType = 5,
        /// <summary>
        /// Labels from a manager account cannot be applied to campaign, ad group,
        /// ad group ad, or ad group criterion resources.
        /// </summary>
        [pbr::OriginalName("INVALID_RESOURCE_FOR_MANAGER_LABEL")] InvalidResourceForManagerLabel = 6,
        /// <summary>
        /// Label names must be unique.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 7,
        /// <summary>
        /// Label names cannot be empty.
        /// </summary>
        [pbr::OriginalName("INVALID_LABEL_NAME")] InvalidLabelName = 8,
        /// <summary>
        /// Labels cannot be applied to a draft.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_LABEL_TO_DRAFT")] CannotAttachLabelToDraft = 9,
        /// <summary>
        /// Labels not from a manager account cannot be applied to the customer
        /// resource.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_NON_MANAGER_LABEL_TO_CUSTOMER")] CannotAttachNonManagerLabelToCustomer = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
