// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/ad_group_criterion_primary_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/ad_group_criterion_primary_status.proto</summary>
  public static partial class AdGroupCriterionPrimaryStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/ad_group_criterion_primary_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionPrimaryStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvYWRfZ3JvdXBfY3Jp",
            "dGVyaW9uX3ByaW1hcnlfc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTcuZW51bXMiqQEKIUFkR3JvdXBDcml0ZXJpb25QcmltYXJ5U3Rh",
            "dHVzRW51bSKDAQodQWRHcm91cENyaXRlcmlvblByaW1hcnlTdGF0dXMSDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIRUxJR0lCTEUQAhIKCgZQ",
            "QVVTRUQQAxILCgdSRU1PVkVEEAQSCwoHUEVORElORxAFEhAKDE5PVF9FTElH",
            "SUJMRRAGQvwBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LmVudW1z",
            "QiJBZEdyb3VwQ3JpdGVyaW9uUHJpbWFyeVN0YXR1c1Byb3RvUAFaQ2dvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MTcvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMTcuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTdcRW51bXPq",
            "AiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTc6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.AdGroupCriterionPrimaryStatusEnum), global::Google.Ads.GoogleAds.V17.Enums.AdGroupCriterionPrimaryStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.AdGroupCriterionPrimaryStatusEnum.Types.AdGroupCriterionPrimaryStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group criterion primary status.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdGroupCriterionPrimaryStatusEnum : pb::IMessage<AdGroupCriterionPrimaryStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupCriterionPrimaryStatusEnum> _parser = new pb::MessageParser<AdGroupCriterionPrimaryStatusEnum>(() => new AdGroupCriterionPrimaryStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupCriterionPrimaryStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.AdGroupCriterionPrimaryStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionPrimaryStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionPrimaryStatusEnum(AdGroupCriterionPrimaryStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionPrimaryStatusEnum Clone() {
      return new AdGroupCriterionPrimaryStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupCriterionPrimaryStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupCriterionPrimaryStatusEnum other) {
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
    public void MergeFrom(AdGroupCriterionPrimaryStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupCriterionPrimaryStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the possible ad group criterion primary status. Provides
      /// insight into why an ad group criterion is not serving or not serving
      /// optimally.
      /// </summary>
      public enum AdGroupCriterionPrimaryStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The ad group criterion is eligible to serve.
        /// </summary>
        [pbr::OriginalName("ELIGIBLE")] Eligible = 2,
        /// <summary>
        /// The ad group criterion is paused.
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 3,
        /// <summary>
        /// The ad group criterion is removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 4,
        /// <summary>
        /// The ad group criterion is pending.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 5,
        /// <summary>
        /// The ad group criterion is not eligible to serve.
        /// </summary>
        [pbr::OriginalName("NOT_ELIGIBLE")] NotEligible = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
