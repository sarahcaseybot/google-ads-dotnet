// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/sitelink_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/sitelink_placeholder_field.proto</summary>
  public static partial class SitelinkPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/sitelink_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SitelinkPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9zaXRlbGlua19wbGFj",
            "ZWhvbGRlcl9maWVsZC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjku",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iygEKHFNpdGVs",
            "aW5rUGxhY2Vob2xkZXJGaWVsZEVudW0iqQEKGFNpdGVsaW5rUGxhY2Vob2xk",
            "ZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIICgRURVhU",
            "EAISCgoGTElORV8xEAMSCgoGTElORV8yEAQSDgoKRklOQUxfVVJMUxAFEhUK",
            "EUZJTkFMX01PQklMRV9VUkxTEAYSEAoMVFJBQ0tJTkdfVVJMEAcSFAoQRklO",
            "QUxfVVJMX1NVRkZJWBAIQvIBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djkuZW51bXNCHVNpdGVsaW5rUGxhY2Vob2xkZXJGaWVsZFByb3RvUAFaQmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92OS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlY5LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcRW51bXPq",
            "AiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.SitelinkPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V9.Enums.SitelinkPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.SitelinkPlaceholderFieldEnum.Types.SitelinkPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Sitelink placeholder fields.
  /// </summary>
  public sealed partial class SitelinkPlaceholderFieldEnum : pb::IMessage<SitelinkPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SitelinkPlaceholderFieldEnum> _parser = new pb::MessageParser<SitelinkPlaceholderFieldEnum>(() => new SitelinkPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SitelinkPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.SitelinkPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SitelinkPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SitelinkPlaceholderFieldEnum(SitelinkPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SitelinkPlaceholderFieldEnum Clone() {
      return new SitelinkPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SitelinkPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SitelinkPlaceholderFieldEnum other) {
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
    public void MergeFrom(SitelinkPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the SitelinkPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Sitelink placeholder fields.
      /// </summary>
      public enum SitelinkPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The link text for your sitelink.
        /// </summary>
        [pbr::OriginalName("TEXT")] Text = 2,
        /// <summary>
        /// Data Type: STRING. First line of the sitelink description.
        /// </summary>
        [pbr::OriginalName("LINE_1")] Line1 = 3,
        /// <summary>
        /// Data Type: STRING. Second line of the sitelink description.
        /// </summary>
        [pbr::OriginalName("LINE_2")] Line2 = 4,
        /// <summary>
        /// Data Type: URL_LIST. Final URLs for the sitelink when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 5,
        /// <summary>
        /// Data Type: URL_LIST. Final Mobile URLs for the sitelink when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 6,
        /// <summary>
        /// Data Type: URL. Tracking template for the sitelink when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 7,
        /// <summary>
        /// Data Type: STRING. Final URL suffix for sitelink when using parallel
        /// tracking.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX")] FinalUrlSuffix = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
