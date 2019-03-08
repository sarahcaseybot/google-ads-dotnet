// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/served_asset_field_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/served_asset_field_type.proto</summary>
  public static partial class ServedAssetFieldTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/served_asset_field_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServedAssetFieldTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9zZXJ2ZWRfYXNzZXRf",
            "ZmllbGRfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ipwEKGFNlcnZlZEFz",
            "c2V0RmllbGRUeXBlRW51bSKKAQoUU2VydmVkQXNzZXRGaWVsZFR5cGUSDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDgoKSEVBRExJTkVfMRACEg4K",
            "CkhFQURMSU5FXzIQAxIOCgpIRUFETElORV8zEAQSEQoNREVTQ1JJUFRJT05f",
            "MRAFEhEKDURFU0NSSVBUSU9OXzIQBkLuAQohY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxLmVudW1zQhlTZXJ2ZWRBc3NldEZpZWxkVHlwZVByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum), global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset field types.
  /// </summary>
  public sealed partial class ServedAssetFieldTypeEnum : pb::IMessage<ServedAssetFieldTypeEnum> {
    private static readonly pb::MessageParser<ServedAssetFieldTypeEnum> _parser = new pb::MessageParser<ServedAssetFieldTypeEnum>(() => new ServedAssetFieldTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServedAssetFieldTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServedAssetFieldTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServedAssetFieldTypeEnum(ServedAssetFieldTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServedAssetFieldTypeEnum Clone() {
      return new ServedAssetFieldTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServedAssetFieldTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServedAssetFieldTypeEnum other) {
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
    public void MergeFrom(ServedAssetFieldTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ServedAssetFieldTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible asset field types.
      /// </summary>
      public enum ServedAssetFieldType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The asset is used in headline 1.
        /// </summary>
        [pbr::OriginalName("HEADLINE_1")] Headline1 = 2,
        /// <summary>
        /// The asset is used in headline 2.
        /// </summary>
        [pbr::OriginalName("HEADLINE_2")] Headline2 = 3,
        /// <summary>
        /// The asset is used in headline 3.
        /// </summary>
        [pbr::OriginalName("HEADLINE_3")] Headline3 = 4,
        /// <summary>
        /// The asset is used in description 1.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION_1")] Description1 = 5,
        /// <summary>
        /// The asset is used in description 2.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION_2")] Description2 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
