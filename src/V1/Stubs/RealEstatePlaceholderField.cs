// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/real_estate_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/real_estate_placeholder_field.proto</summary>
  public static partial class RealEstatePlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/real_estate_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RealEstatePlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9yZWFsX2VzdGF0ZV9w",
            "bGFjZWhvbGRlcl9maWVsZC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iqQMKHlJl",
            "YWxFc3RhdGVQbGFjZWhvbGRlckZpZWxkRW51bSKGAwoaUmVhbEVzdGF0ZVBs",
            "YWNlaG9sZGVyRmllbGQSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "DgoKTElTVElOR19JRBACEhAKDExJU1RJTkdfTkFNRRADEg0KCUNJVFlfTkFN",
            "RRAEEg8KC0RFU0NSSVBUSU9OEAUSCwoHQUREUkVTUxAGEgkKBVBSSUNFEAcS",
            "EwoPRk9STUFUVEVEX1BSSUNFEAgSDQoJSU1BR0VfVVJMEAkSEQoNUFJPUEVS",
            "VFlfVFlQRRAKEhAKDExJU1RJTkdfVFlQRRALEhcKE0NPTlRFWFRVQUxfS0VZ",
            "V09SRFMQDBIOCgpGSU5BTF9VUkxTEA0SFQoRRklOQUxfTU9CSUxFX1VSTFMQ",
            "DhIQCgxUUkFDS0lOR19VUkwQDxIUChBBTkRST0lEX0FQUF9MSU5LEBASFwoT",
            "U0lNSUxBUl9MSVNUSU5HX0lEUxAREhAKDElPU19BUFBfTElOSxASEhQKEElP",
            "U19BUFBfU1RPUkVfSUQQE0L0AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zQh9SZWFsRXN0YXRlUGxhY2Vob2xkZXJGaWVsZFByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.RealEstatePlaceholderFieldEnum), global::Google.Ads.GoogleAds.V1.Enums.RealEstatePlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.RealEstatePlaceholderFieldEnum.Types.RealEstatePlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Real Estate placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class RealEstatePlaceholderFieldEnum : pb::IMessage<RealEstatePlaceholderFieldEnum> {
    private static readonly pb::MessageParser<RealEstatePlaceholderFieldEnum> _parser = new pb::MessageParser<RealEstatePlaceholderFieldEnum>(() => new RealEstatePlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RealEstatePlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.RealEstatePlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealEstatePlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealEstatePlaceholderFieldEnum(RealEstatePlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealEstatePlaceholderFieldEnum Clone() {
      return new RealEstatePlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RealEstatePlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RealEstatePlaceholderFieldEnum other) {
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
    public void MergeFrom(RealEstatePlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the RealEstatePlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Real Estate placeholder fields.
      /// </summary>
      public enum RealEstatePlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Unique ID.
        /// </summary>
        [pbr::OriginalName("LISTING_ID")] ListingId = 2,
        /// <summary>
        /// Data Type: STRING. Main headline with listing name to be shown in dynamic
        /// ad.
        /// </summary>
        [pbr::OriginalName("LISTING_NAME")] ListingName = 3,
        /// <summary>
        /// Data Type: STRING. City name to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("CITY_NAME")] CityName = 4,
        /// <summary>
        /// Data Type: STRING. Description of listing to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 5,
        /// <summary>
        /// Data Type: STRING. Complete listing address, including postal code.
        /// </summary>
        [pbr::OriginalName("ADDRESS")] Address = 6,
        /// <summary>
        /// Data Type: STRING. Price to be shown in the ad.
        /// Example: "100.00 USD"
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 7,
        /// <summary>
        /// Data Type: STRING. Formatted price to be shown in the ad.
        /// Example: "Starting at $100.00 USD", "$80 - $100"
        /// </summary>
        [pbr::OriginalName("FORMATTED_PRICE")] FormattedPrice = 8,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 9,
        /// <summary>
        /// Data Type: STRING. Type of property (house, condo, apartment, etc.) used
        /// to group like items together for recommendation engine.
        /// </summary>
        [pbr::OriginalName("PROPERTY_TYPE")] PropertyType = 10,
        /// <summary>
        /// Data Type: STRING. Type of listing (resale, rental, foreclosure, etc.)
        /// used to group like items together for recommendation engine.
        /// </summary>
        [pbr::OriginalName("LISTING_TYPE")] ListingType = 11,
        /// <summary>
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 12,
        /// <summary>
        /// Data Type: URL_LIST. Final URLs to be used in ad when using Upgraded
        /// URLs; the more specific the better (e.g. the individual URL of a specific
        /// listing and its location).
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 13,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 14,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 15,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 16,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended listing IDs to show together
        /// with this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_LISTING_IDS")] SimilarListingIds = 17,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 18,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
