// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/errors/smart_campaign_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/errors/smart_campaign_error.proto</summary>
  public static partial class SmartCampaignErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/errors/smart_campaign_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SmartCampaignErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZXJyb3JzL3NtYXJ0X2NhbXBh",
            "aWduX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQuZXJy",
            "b3JzIr4CChZTbWFydENhbXBhaWduRXJyb3JFbnVtIqMCChJTbWFydENhbXBh",
            "aWduRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESIAocSU5W",
            "QUxJRF9CVVNJTkVTU19MT0NBVElPTl9JRBACEhQKEElOVkFMSURfQ0FNUEFJ",
            "R04QAxIxCi1CVVNJTkVTU19OQU1FX09SX0JVU0lORVNTX0xPQ0FUSU9OX0lE",
            "X01JU1NJTkcQBBIlCiFSRVFVSVJFRF9TVUdHRVNUSU9OX0ZJRUxEX01JU1NJ",
            "TkcQBRIYChRHRU9fVEFSR0VUU19SRVFVSVJFRBAGEiYKIkNBTk5PVF9ERVRF",
            "Uk1JTkVfU1VHR0VTVElPTl9MT0NBTEUQBxIbChdGSU5BTF9VUkxfTk9UX0NS",
            "QVdMQUJMRRAIQvcBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVy",
            "cm9yc0IXU21hcnRDYW1wYWlnbkVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNC9l",
            "cnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE0",
            "LkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNFxFcnJvcnPqAiNH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTQ6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Errors.SmartCampaignErrorEnum), global::Google.Ads.GoogleAds.V14.Errors.SmartCampaignErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Errors.SmartCampaignErrorEnum.Types.SmartCampaignError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible Smart campaign errors.
  /// </summary>
  public sealed partial class SmartCampaignErrorEnum : pb::IMessage<SmartCampaignErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SmartCampaignErrorEnum> _parser = new pb::MessageParser<SmartCampaignErrorEnum>(() => new SmartCampaignErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SmartCampaignErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Errors.SmartCampaignErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignErrorEnum(SmartCampaignErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignErrorEnum Clone() {
      return new SmartCampaignErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SmartCampaignErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SmartCampaignErrorEnum other) {
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
    public void MergeFrom(SmartCampaignErrorEnum other) {
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
    /// <summary>Container for nested types declared in the SmartCampaignErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible Smart campaign errors.
      /// </summary>
      public enum SmartCampaignError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The business location id is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_BUSINESS_LOCATION_ID")] InvalidBusinessLocationId = 2,
        /// <summary>
        /// The SmartCampaignSetting resource is only applicable for campaigns
        /// with advertising channel type SMART.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN")] InvalidCampaign = 3,
        /// <summary>
        /// The business name or business location id is required.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME_OR_BUSINESS_LOCATION_ID_MISSING")] BusinessNameOrBusinessLocationIdMissing = 4,
        /// <summary>
        /// A Smart campaign suggestion request field is required.
        /// </summary>
        [pbr::OriginalName("REQUIRED_SUGGESTION_FIELD_MISSING")] RequiredSuggestionFieldMissing = 5,
        /// <summary>
        /// A location list or proximity is required.
        /// </summary>
        [pbr::OriginalName("GEO_TARGETS_REQUIRED")] GeoTargetsRequired = 6,
        /// <summary>
        /// The locale could not be determined.
        /// </summary>
        [pbr::OriginalName("CANNOT_DETERMINE_SUGGESTION_LOCALE")] CannotDetermineSuggestionLocale = 7,
        /// <summary>
        /// The final URL could not be crawled.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_NOT_CRAWLABLE")] FinalUrlNotCrawlable = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
