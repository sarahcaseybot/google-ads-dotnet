// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/errors/url_field_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/errors/url_field_error.proto</summary>
  public static partial class UrlFieldErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/errors/url_field_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UrlFieldErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZXJyb3JzL3VybF9maWVsZF9l",
            "cnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LmVycm9ycyLf",
            "DgoRVXJsRmllbGRFcnJvckVudW0iyQ4KDVVybEZpZWxkRXJyb3ISDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESIQodSU5WQUxJRF9UUkFDS0lOR19V",
            "UkxfVEVNUExBVEUQAhIoCiRJTlZBTElEX1RBR19JTl9UUkFDS0lOR19VUkxf",
            "VEVNUExBVEUQAxIlCiFNSVNTSU5HX1RSQUNLSU5HX1VSTF9URU1QTEFURV9U",
            "QUcQBBItCilNSVNTSU5HX1BST1RPQ09MX0lOX1RSQUNLSU5HX1VSTF9URU1Q",
            "TEFURRAFEi0KKUlOVkFMSURfUFJPVE9DT0xfSU5fVFJBQ0tJTkdfVVJMX1RF",
            "TVBMQVRFEAYSIwofTUFMRk9STUVEX1RSQUNLSU5HX1VSTF9URU1QTEFURRAH",
            "EikKJU1JU1NJTkdfSE9TVF9JTl9UUkFDS0lOR19VUkxfVEVNUExBVEUQCBIo",
            "CiRJTlZBTElEX1RMRF9JTl9UUkFDS0lOR19VUkxfVEVNUExBVEUQCRIuCipS",
            "RURVTkRBTlRfTkVTVEVEX1RSQUNLSU5HX1VSTF9URU1QTEFURV9UQUcQChIV",
            "ChFJTlZBTElEX0ZJTkFMX1VSTBALEhwKGElOVkFMSURfVEFHX0lOX0ZJTkFM",
            "X1VSTBAMEiIKHlJFRFVOREFOVF9ORVNURURfRklOQUxfVVJMX1RBRxANEiEK",
            "HU1JU1NJTkdfUFJPVE9DT0xfSU5fRklOQUxfVVJMEA4SIQodSU5WQUxJRF9Q",
            "Uk9UT0NPTF9JTl9GSU5BTF9VUkwQDxIXChNNQUxGT1JNRURfRklOQUxfVVJM",
            "EBASHQoZTUlTU0lOR19IT1NUX0lOX0ZJTkFMX1VSTBAREhwKGElOVkFMSURf",
            "VExEX0lOX0ZJTkFMX1VSTBASEhwKGElOVkFMSURfRklOQUxfTU9CSUxFX1VS",
            "TBATEiMKH0lOVkFMSURfVEFHX0lOX0ZJTkFMX01PQklMRV9VUkwQFBIpCiVS",
            "RURVTkRBTlRfTkVTVEVEX0ZJTkFMX01PQklMRV9VUkxfVEFHEBUSKAokTUlT",
            "U0lOR19QUk9UT0NPTF9JTl9GSU5BTF9NT0JJTEVfVVJMEBYSKAokSU5WQUxJ",
            "RF9QUk9UT0NPTF9JTl9GSU5BTF9NT0JJTEVfVVJMEBcSHgoaTUFMRk9STUVE",
            "X0ZJTkFMX01PQklMRV9VUkwQGBIkCiBNSVNTSU5HX0hPU1RfSU5fRklOQUxf",
            "TU9CSUxFX1VSTBAZEiMKH0lOVkFMSURfVExEX0lOX0ZJTkFMX01PQklMRV9V",
            "UkwQGhIZChVJTlZBTElEX0ZJTkFMX0FQUF9VUkwQGxIgChxJTlZBTElEX1RB",
            "R19JTl9GSU5BTF9BUFBfVVJMEBwSJgoiUkVEVU5EQU5UX05FU1RFRF9GSU5B",
            "TF9BUFBfVVJMX1RBRxAdEiAKHE1VTFRJUExFX0FQUF9VUkxTX0ZPUl9PU1RZ",
            "UEUQHhISCg5JTlZBTElEX09TVFlQRRAfEiAKHElOVkFMSURfUFJPVE9DT0xf",
            "Rk9SX0FQUF9VUkwQIBIiCh5JTlZBTElEX1BBQ0tBR0VfSURfRk9SX0FQUF9V",
            "UkwQIRItCilVUkxfQ1VTVE9NX1BBUkFNRVRFUlNfQ09VTlRfRVhDRUVEU19M",
            "SU1JVBAiEjIKLklOVkFMSURfQ0hBUkFDVEVSU19JTl9VUkxfQ1VTVE9NX1BB",
            "UkFNRVRFUl9LRVkQJxI0CjBJTlZBTElEX0NIQVJBQ1RFUlNfSU5fVVJMX0NV",
            "U1RPTV9QQVJBTUVURVJfVkFMVUUQKBItCilJTlZBTElEX1RBR19JTl9VUkxf",
            "Q1VTVE9NX1BBUkFNRVRFUl9WQUxVRRApEi0KKVJFRFVOREFOVF9ORVNURURf",
            "VVJMX0NVU1RPTV9QQVJBTUVURVJfVEFHECoSFAoQTUlTU0lOR19QUk9UT0NP",
            "TBArEhQKEElOVkFMSURfUFJPVE9DT0wQNBIPCgtJTlZBTElEX1VSTBAsEh4K",
            "GkRFU1RJTkFUSU9OX1VSTF9ERVBSRUNBVEVEEC0SFgoSSU5WQUxJRF9UQUdf",
            "SU5fVVJMEC4SEwoPTUlTU0lOR19VUkxfVEFHEC8SFAoQRFVQTElDQVRFX1VS",
            "TF9JRBAwEhIKDklOVkFMSURfVVJMX0lEEDESHgoaRklOQUxfVVJMX1NVRkZJ",
            "WF9NQUxGT1JNRUQQMhIjCh9JTlZBTElEX1RBR19JTl9GSU5BTF9VUkxfU1VG",
            "RklYEDMSHAoYSU5WQUxJRF9UT1BfTEVWRUxfRE9NQUlOEDUSHgoaTUFMRk9S",
            "TUVEX1RPUF9MRVZFTF9ET01BSU4QNhIRCg1NQUxGT1JNRURfVVJMEDcSEAoM",
            "TUlTU0lOR19IT1NUEDgSHwobTlVMTF9DVVNUT01fUEFSQU1FVEVSX1ZBTFVF",
            "EDkSJwojVkFMVUVfVFJBQ0tfUEFSQU1FVEVSX05PVF9TVVBQT1JURUQQOkLy",
            "AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5lcnJvcnNCElVybEZp",
            "ZWxkRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE3L2Vycm9ycztlcnJvcnOiAgNH",
            "QUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTcuRXJyb3JzygIfR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjE3XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxNzo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Errors.UrlFieldErrorEnum), global::Google.Ads.GoogleAds.V17.Errors.UrlFieldErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Errors.UrlFieldErrorEnum.Types.UrlFieldError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible url field errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UrlFieldErrorEnum : pb::IMessage<UrlFieldErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UrlFieldErrorEnum> _parser = new pb::MessageParser<UrlFieldErrorEnum>(() => new UrlFieldErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UrlFieldErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Errors.UrlFieldErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlFieldErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlFieldErrorEnum(UrlFieldErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlFieldErrorEnum Clone() {
      return new UrlFieldErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UrlFieldErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UrlFieldErrorEnum other) {
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
    public void MergeFrom(UrlFieldErrorEnum other) {
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
    /// <summary>Container for nested types declared in the UrlFieldErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible url field errors.
      /// </summary>
      public enum UrlFieldError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The tracking url template is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL_TEMPLATE")] InvalidTrackingUrlTemplate = 2,
        /// <summary>
        /// The tracking url template contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_TRACKING_URL_TEMPLATE")] InvalidTagInTrackingUrlTemplate = 3,
        /// <summary>
        /// The tracking url template must contain at least one tag (for example,
        /// {lpurl}), This applies only to tracking url template associated with
        /// website ads or product ads.
        /// </summary>
        [pbr::OriginalName("MISSING_TRACKING_URL_TEMPLATE_TAG")] MissingTrackingUrlTemplateTag = 4,
        /// <summary>
        /// The tracking url template must start with a valid protocol (or lpurl
        /// tag).
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_TRACKING_URL_TEMPLATE")] MissingProtocolInTrackingUrlTemplate = 5,
        /// <summary>
        /// The tracking url template starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_TRACKING_URL_TEMPLATE")] InvalidProtocolInTrackingUrlTemplate = 6,
        /// <summary>
        /// The tracking url template contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_TRACKING_URL_TEMPLATE")] MalformedTrackingUrlTemplate = 7,
        /// <summary>
        /// The tracking url template must contain a host name (or lpurl tag).
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_TRACKING_URL_TEMPLATE")] MissingHostInTrackingUrlTemplate = 8,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_TRACKING_URL_TEMPLATE")] InvalidTldInTrackingUrlTemplate = 9,
        /// <summary>
        /// The tracking url template contains nested occurrences of the same
        /// conditional tag (for example, {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_TRACKING_URL_TEMPLATE_TAG")] RedundantNestedTrackingUrlTemplateTag = 10,
        /// <summary>
        /// The final url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL")] InvalidFinalUrl = 11,
        /// <summary>
        /// The final url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_URL")] InvalidTagInFinalUrl = 12,
        /// <summary>
        /// The final url contains nested occurrences of the same conditional tag
        /// (for example, {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_URL_TAG")] RedundantNestedFinalUrlTag = 13,
        /// <summary>
        /// The final url must start with a valid protocol.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_FINAL_URL")] MissingProtocolInFinalUrl = 14,
        /// <summary>
        /// The final url starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_FINAL_URL")] InvalidProtocolInFinalUrl = 15,
        /// <summary>
        /// The final url contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_FINAL_URL")] MalformedFinalUrl = 16,
        /// <summary>
        /// The final url must contain a host name.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_FINAL_URL")] MissingHostInFinalUrl = 17,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_FINAL_URL")] InvalidTldInFinalUrl = 18,
        /// <summary>
        /// The final mobile url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_MOBILE_URL")] InvalidFinalMobileUrl = 19,
        /// <summary>
        /// The final mobile url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_MOBILE_URL")] InvalidTagInFinalMobileUrl = 20,
        /// <summary>
        /// The final mobile url contains nested occurrences of the same conditional
        /// tag (for example, {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_MOBILE_URL_TAG")] RedundantNestedFinalMobileUrlTag = 21,
        /// <summary>
        /// The final mobile url must start with a valid protocol.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL_IN_FINAL_MOBILE_URL")] MissingProtocolInFinalMobileUrl = 22,
        /// <summary>
        /// The final mobile url starts with an invalid protocol.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_IN_FINAL_MOBILE_URL")] InvalidProtocolInFinalMobileUrl = 23,
        /// <summary>
        /// The final mobile url contains illegal characters.
        /// </summary>
        [pbr::OriginalName("MALFORMED_FINAL_MOBILE_URL")] MalformedFinalMobileUrl = 24,
        /// <summary>
        /// The final mobile url must contain a host name.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST_IN_FINAL_MOBILE_URL")] MissingHostInFinalMobileUrl = 25,
        /// <summary>
        /// The tracking url template has an invalid or missing top level domain
        /// extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TLD_IN_FINAL_MOBILE_URL")] InvalidTldInFinalMobileUrl = 26,
        /// <summary>
        /// The final app url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_APP_URL")] InvalidFinalAppUrl = 27,
        /// <summary>
        /// The final app url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_APP_URL")] InvalidTagInFinalAppUrl = 28,
        /// <summary>
        /// The final app url contains nested occurrences of the same conditional tag
        /// (for example, {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_FINAL_APP_URL_TAG")] RedundantNestedFinalAppUrlTag = 29,
        /// <summary>
        /// More than one app url found for the same OS type.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_APP_URLS_FOR_OSTYPE")] MultipleAppUrlsForOstype = 30,
        /// <summary>
        /// The OS type given for an app url is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_OSTYPE")] InvalidOstype = 31,
        /// <summary>
        /// The protocol given for an app url is not valid. (For example,
        /// "android-app://")
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL_FOR_APP_URL")] InvalidProtocolForAppUrl = 32,
        /// <summary>
        /// The package id (app id) given for an app url is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_PACKAGE_ID_FOR_APP_URL")] InvalidPackageIdForAppUrl = 33,
        /// <summary>
        /// The number of url custom parameters for an resource exceeds the maximum
        /// limit allowed.
        /// </summary>
        [pbr::OriginalName("URL_CUSTOM_PARAMETERS_COUNT_EXCEEDS_LIMIT")] UrlCustomParametersCountExceedsLimit = 34,
        /// <summary>
        /// An invalid character appears in the parameter key.
        /// </summary>
        [pbr::OriginalName("INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_KEY")] InvalidCharactersInUrlCustomParameterKey = 39,
        /// <summary>
        /// An invalid character appears in the parameter value.
        /// </summary>
        [pbr::OriginalName("INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_VALUE")] InvalidCharactersInUrlCustomParameterValue = 40,
        /// <summary>
        /// The url custom parameter value fails url tag validation.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_URL_CUSTOM_PARAMETER_VALUE")] InvalidTagInUrlCustomParameterValue = 41,
        /// <summary>
        /// The custom parameter contains nested occurrences of the same conditional
        /// tag (for example, {ifmobile:{ifmobile:x}}).
        /// </summary>
        [pbr::OriginalName("REDUNDANT_NESTED_URL_CUSTOM_PARAMETER_TAG")] RedundantNestedUrlCustomParameterTag = 42,
        /// <summary>
        /// The protocol (http:// or https://) is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_PROTOCOL")] MissingProtocol = 43,
        /// <summary>
        /// Unsupported protocol in URL. Only http and https are supported.
        /// </summary>
        [pbr::OriginalName("INVALID_PROTOCOL")] InvalidProtocol = 52,
        /// <summary>
        /// The url is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_URL")] InvalidUrl = 44,
        /// <summary>
        /// Destination Url is deprecated.
        /// </summary>
        [pbr::OriginalName("DESTINATION_URL_DEPRECATED")] DestinationUrlDeprecated = 45,
        /// <summary>
        /// The url contains invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_URL")] InvalidTagInUrl = 46,
        /// <summary>
        /// The url must contain at least one tag (for example, {lpurl}).
        /// </summary>
        [pbr::OriginalName("MISSING_URL_TAG")] MissingUrlTag = 47,
        /// <summary>
        /// Duplicate url id.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_URL_ID")] DuplicateUrlId = 48,
        /// <summary>
        /// Invalid url id.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_ID")] InvalidUrlId = 49,
        /// <summary>
        /// The final url suffix cannot begin with '?' or '&amp;' characters and must be
        /// a valid query string.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX_MALFORMED")] FinalUrlSuffixMalformed = 50,
        /// <summary>
        /// The final url suffix cannot contain {lpurl} related or {ignore} tags.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_URL_SUFFIX")] InvalidTagInFinalUrlSuffix = 51,
        /// <summary>
        /// The top level domain is invalid, for example, not a public top level
        /// domain listed in publicsuffix.org.
        /// </summary>
        [pbr::OriginalName("INVALID_TOP_LEVEL_DOMAIN")] InvalidTopLevelDomain = 53,
        /// <summary>
        /// Malformed top level domain in URL.
        /// </summary>
        [pbr::OriginalName("MALFORMED_TOP_LEVEL_DOMAIN")] MalformedTopLevelDomain = 54,
        /// <summary>
        /// Malformed URL.
        /// </summary>
        [pbr::OriginalName("MALFORMED_URL")] MalformedUrl = 55,
        /// <summary>
        /// No host found in URL.
        /// </summary>
        [pbr::OriginalName("MISSING_HOST")] MissingHost = 56,
        /// <summary>
        /// Custom parameter value cannot be null.
        /// </summary>
        [pbr::OriginalName("NULL_CUSTOM_PARAMETER_VALUE")] NullCustomParameterValue = 57,
        /// <summary>
        /// Track parameter is not supported.
        /// </summary>
        [pbr::OriginalName("VALUE_TRACK_PARAMETER_NOT_SUPPORTED")] ValueTrackParameterNotSupported = 58,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
