// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/errors/third_party_app_analytics_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/errors/third_party_app_analytics_link_error.proto</summary>
  public static partial class ThirdPartyAppAnalyticsLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/errors/third_party_app_analytics_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ThirdPartyAppAnalyticsLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZXJyb3JzL3RoaXJkX3BhcnR5",
            "X2FwcF9hbmFseXRpY3NfbGlua19lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE3LmVycm9ycyL+AQojVGhpcmRQYXJ0eUFwcEFuYWx5dGlj",
            "c0xpbmtFcnJvckVudW0i1gEKH1RoaXJkUGFydHlBcHBBbmFseXRpY3NMaW5r",
            "RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESIQodSU5WQUxJ",
            "RF9BTkFMWVRJQ1NfUFJPVklERVJfSUQQAhIZChVJTlZBTElEX01PQklMRV9B",
            "UFBfSUQQAxIdChlNT0JJTEVfQVBQX0lTX05PVF9FTkFCTEVEEAQSOAo0Q0FO",
            "Tk9UX1JFR0VORVJBVEVfU0hBUkVBQkxFX0xJTktfSURfRk9SX1JFTU9WRURf",
            "TElOSxAFQoQCCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LmVycm9y",
            "c0IkVGhpcmRQYXJ0eUFwcEFuYWx5dGljc0xpbmtFcnJvclByb3RvUAFaRWdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTcvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxNy5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTdc",
            "RXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE3OjpFcnJvcnNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Errors.ThirdPartyAppAnalyticsLinkErrorEnum), global::Google.Ads.GoogleAds.V17.Errors.ThirdPartyAppAnalyticsLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Errors.ThirdPartyAppAnalyticsLinkErrorEnum.Types.ThirdPartyAppAnalyticsLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible third party app analytics link errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ThirdPartyAppAnalyticsLinkErrorEnum : pb::IMessage<ThirdPartyAppAnalyticsLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum> _parser = new pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum>(() => new ThirdPartyAppAnalyticsLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ThirdPartyAppAnalyticsLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Errors.ThirdPartyAppAnalyticsLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLinkErrorEnum(ThirdPartyAppAnalyticsLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLinkErrorEnum Clone() {
      return new ThirdPartyAppAnalyticsLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ThirdPartyAppAnalyticsLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ThirdPartyAppAnalyticsLinkErrorEnum other) {
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
    public void MergeFrom(ThirdPartyAppAnalyticsLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ThirdPartyAppAnalyticsLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible third party app analytics link errors.
      /// </summary>
      public enum ThirdPartyAppAnalyticsLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The provided analytics provider ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_ANALYTICS_PROVIDER_ID")] InvalidAnalyticsProviderId = 2,
        /// <summary>
        /// The provided mobile app ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_APP_ID")] InvalidMobileAppId = 3,
        /// <summary>
        /// The mobile app corresponding to the provided app ID is not
        /// active/enabled.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_IS_NOT_ENABLED")] MobileAppIsNotEnabled = 4,
        /// <summary>
        /// Regenerating shareable link ID is only allowed on active links
        /// </summary>
        [pbr::OriginalName("CANNOT_REGENERATE_SHAREABLE_LINK_ID_FOR_REMOVED_LINK")] CannotRegenerateShareableLinkIdForRemovedLink = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
