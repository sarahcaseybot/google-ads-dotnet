// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/webpage_condition_operand.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/webpage_condition_operand.proto</summary>
  public static partial class WebpageConditionOperandReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/webpage_condition_operand.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WebpageConditionOperandReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy93ZWJwYWdlX2NvbmRp",
            "dGlvbl9vcGVyYW5kLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKiAQobV2VicGFn",
            "ZUNvbmRpdGlvbk9wZXJhbmRFbnVtIoIBChdXZWJwYWdlQ29uZGl0aW9uT3Bl",
            "cmFuZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIHCgNVUkwQAhIM",
            "CghDQVRFR09SWRADEg4KClBBR0VfVElUTEUQBBIQCgxQQUdFX0NPTlRFTlQQ",
            "BRIQCgxDVVNUT01fTEFCRUwQBkLxAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYyLmVudW1zQhxXZWJwYWdlQ29uZGl0aW9uT3BlcmFuZFByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92Mi9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYyLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.WebpageConditionOperandEnum), global::Google.Ads.GoogleAds.V2.Enums.WebpageConditionOperandEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.WebpageConditionOperandEnum.Types.WebpageConditionOperand) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing webpage condition operand in webpage criterion.
  /// </summary>
  public sealed partial class WebpageConditionOperandEnum : pb::IMessage<WebpageConditionOperandEnum> {
    private static readonly pb::MessageParser<WebpageConditionOperandEnum> _parser = new pb::MessageParser<WebpageConditionOperandEnum>(() => new WebpageConditionOperandEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WebpageConditionOperandEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.WebpageConditionOperandReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperandEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperandEnum(WebpageConditionOperandEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebpageConditionOperandEnum Clone() {
      return new WebpageConditionOperandEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WebpageConditionOperandEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WebpageConditionOperandEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WebpageConditionOperandEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the WebpageConditionOperandEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The webpage condition operand in webpage criterion.
      /// </summary>
      public enum WebpageConditionOperand {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Operand denoting a webpage URL targeting condition.
        /// </summary>
        [pbr::OriginalName("URL")] Url = 2,
        /// <summary>
        /// Operand denoting a webpage category targeting condition.
        /// </summary>
        [pbr::OriginalName("CATEGORY")] Category = 3,
        /// <summary>
        /// Operand denoting a webpage title targeting condition.
        /// </summary>
        [pbr::OriginalName("PAGE_TITLE")] PageTitle = 4,
        /// <summary>
        /// Operand denoting a webpage content targeting condition.
        /// </summary>
        [pbr::OriginalName("PAGE_CONTENT")] PageContent = 5,
        /// <summary>
        /// Operand denoting a webpage custom label targeting condition.
        /// </summary>
        [pbr::OriginalName("CUSTOM_LABEL")] CustomLabel = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
