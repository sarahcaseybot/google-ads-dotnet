// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/listing_custom_attribute_index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/listing_custom_attribute_index.proto</summary>
  public static partial class ListingCustomAttributeIndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/listing_custom_attribute_index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingCustomAttributeIndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9saXN0aW5nX2N1c3Rv",
            "bV9hdHRyaWJ1dGVfaW5kZXgucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpoBCh9M",
            "aXN0aW5nQ3VzdG9tQXR0cmlidXRlSW5kZXhFbnVtIncKG0xpc3RpbmdDdXN0",
            "b21BdHRyaWJ1dGVJbmRleBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIKCgZJTkRFWDAQBxIKCgZJTkRFWDEQCBIKCgZJTkRFWDIQCRIKCgZJTkRF",
            "WDMQChIKCgZJTkRFWDQQC0L1AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zQiBMaXN0aW5nQ3VzdG9tQXR0cmlidXRlSW5kZXhQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.ListingCustomAttributeIndexEnum), global::Google.Ads.GoogleAds.V1.Enums.ListingCustomAttributeIndexEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.ListingCustomAttributeIndexEnum.Types.ListingCustomAttributeIndex) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the index of the listing custom attribute.
  /// </summary>
  public sealed partial class ListingCustomAttributeIndexEnum : pb::IMessage<ListingCustomAttributeIndexEnum> {
    private static readonly pb::MessageParser<ListingCustomAttributeIndexEnum> _parser = new pb::MessageParser<ListingCustomAttributeIndexEnum>(() => new ListingCustomAttributeIndexEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListingCustomAttributeIndexEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.ListingCustomAttributeIndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum(ListingCustomAttributeIndexEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListingCustomAttributeIndexEnum Clone() {
      return new ListingCustomAttributeIndexEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListingCustomAttributeIndexEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListingCustomAttributeIndexEnum other) {
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
    public void MergeFrom(ListingCustomAttributeIndexEnum other) {
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
    /// <summary>Container for nested types declared in the ListingCustomAttributeIndexEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The index of the listing custom attribute.
      /// </summary>
      public enum ListingCustomAttributeIndex {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// First listing custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX0")] Index0 = 7,
        /// <summary>
        /// Second listing custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX1")] Index1 = 8,
        /// <summary>
        /// Third listing custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX2")] Index2 = 9,
        /// <summary>
        /// Fourth listing custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX3")] Index3 = 10,
        /// <summary>
        /// Fifth listing custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX4")] Index4 = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
