// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/custom_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/custom_placeholder_field.proto</summary>
  public static partial class CustomPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/custom_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9jdXN0b21fcGxhY2Vo",
            "b2xkZXJfZmllbGQucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIr4DChpDdXN0b21Q",
            "bGFjZWhvbGRlckZpZWxkRW51bSKfAwoWQ3VzdG9tUGxhY2Vob2xkZXJGaWVs",
            "ZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIGCgJJRBACEgcKA0lE",
            "MhADEg4KCklURU1fVElUTEUQBBIRCg1JVEVNX1NVQlRJVExFEAUSFAoQSVRF",
            "TV9ERVNDUklQVElPThAGEhAKDElURU1fQUREUkVTUxAHEgkKBVBSSUNFEAgS",
            "EwoPRk9STUFUVEVEX1BSSUNFEAkSDgoKU0FMRV9QUklDRRAKEhgKFEZPUk1B",
            "VFRFRF9TQUxFX1BSSUNFEAsSDQoJSU1BR0VfVVJMEAwSEQoNSVRFTV9DQVRF",
            "R09SWRANEg4KCkZJTkFMX1VSTFMQDhIVChFGSU5BTF9NT0JJTEVfVVJMUxAP",
            "EhAKDFRSQUNLSU5HX1VSTBAQEhcKE0NPTlRFWFRVQUxfS0VZV09SRFMQERIU",
            "ChBBTkRST0lEX0FQUF9MSU5LEBISDwoLU0lNSUxBUl9JRFMQExIQCgxJT1Nf",
            "QVBQX0xJTksQFBIUChBJT1NfQVBQX1NUT1JFX0lEEBVC8AEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtc0IbQ3VzdG9tUGxhY2Vob2xkZXJG",
            "aWVsZFByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcztlbnVtc6ICA0dBQaoCHUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVudW1zygIdR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjJcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6",
            "RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.CustomPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V2.Enums.CustomPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.CustomPlaceholderFieldEnum.Types.CustomPlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Custom placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class CustomPlaceholderFieldEnum : pb::IMessage<CustomPlaceholderFieldEnum> {
    private static readonly pb::MessageParser<CustomPlaceholderFieldEnum> _parser = new pb::MessageParser<CustomPlaceholderFieldEnum>(() => new CustomPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.CustomPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomPlaceholderFieldEnum(CustomPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomPlaceholderFieldEnum Clone() {
      return new CustomPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomPlaceholderFieldEnum other) {
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
    public void MergeFrom(CustomPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the CustomPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Custom placeholder fields.
      /// </summary>
      public enum CustomPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. Combination ID and ID2 must be unique per
        /// offer.
        /// </summary>
        [pbr::OriginalName("ID")] Id = 2,
        /// <summary>
        /// Data Type: STRING. Combination ID and ID2 must be unique per offer.
        /// </summary>
        [pbr::OriginalName("ID2")] Id2 = 3,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with product name to be shown
        /// in dynamic ad.
        /// </summary>
        [pbr::OriginalName("ITEM_TITLE")] ItemTitle = 4,
        /// <summary>
        /// Data Type: STRING. Optional text to be shown in the image ad.
        /// </summary>
        [pbr::OriginalName("ITEM_SUBTITLE")] ItemSubtitle = 5,
        /// <summary>
        /// Data Type: STRING. Optional description of the product to be shown in the
        /// ad.
        /// </summary>
        [pbr::OriginalName("ITEM_DESCRIPTION")] ItemDescription = 6,
        /// <summary>
        /// Data Type: STRING. Full address of your offer or service, including
        /// postal code. This will be used to identify the closest product to the
        /// user when there are multiple offers in the feed that are relevant to the
        /// user.
        /// </summary>
        [pbr::OriginalName("ITEM_ADDRESS")] ItemAddress = 7,
        /// <summary>
        /// Data Type: STRING. Price to be shown in the ad.
        /// Example: "100.00 USD"
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 8,
        /// <summary>
        /// Data Type: STRING. Formatted price to be shown in the ad.
        /// Example: "Starting at $100.00 USD", "$80 - $100"
        /// </summary>
        [pbr::OriginalName("FORMATTED_PRICE")] FormattedPrice = 9,
        /// <summary>
        /// Data Type: STRING. Sale price to be shown in the ad.
        /// Example: "80.00 USD"
        /// </summary>
        [pbr::OriginalName("SALE_PRICE")] SalePrice = 10,
        /// <summary>
        /// Data Type: STRING. Formatted sale price to be shown in the ad.
        /// Example: "On sale for $80.00", "$60 - $80"
        /// </summary>
        [pbr::OriginalName("FORMATTED_SALE_PRICE")] FormattedSalePrice = 11,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad. Highly recommended for
        /// image ads.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 12,
        /// <summary>
        /// Data Type: STRING. Used as a recommendation engine signal to serve items
        /// in the same category.
        /// </summary>
        [pbr::OriginalName("ITEM_CATEGORY")] ItemCategory = 13,
        /// <summary>
        /// Data Type: URL_LIST. Final URLs for the ad when using Upgraded
        /// URLs. User will be redirected to these URLs when they click on an ad, or
        /// when they click on a specific product for ads that have multiple
        /// products.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 14,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 15,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 16,
        /// <summary>
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 17,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 18,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended IDs to show together with
        /// this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_IDS")] SimilarIds = 19,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 20,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
