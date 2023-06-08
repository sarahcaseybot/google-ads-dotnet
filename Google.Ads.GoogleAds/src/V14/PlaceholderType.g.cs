// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/placeholder_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/placeholder_type.proto</summary>
  public static partial class PlaceholderTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/placeholder_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlaceholderTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvcGxhY2Vob2xkZXJf",
            "dHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1zIpsD",
            "ChNQbGFjZWhvbGRlclR5cGVFbnVtIoMDCg9QbGFjZWhvbGRlclR5cGUSDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIU0lURUxJTksQAhIICgRD",
            "QUxMEAMSBwoDQVBQEAQSDAoITE9DQVRJT04QBRIWChJBRkZJTElBVEVfTE9D",
            "QVRJT04QBhILCgdDQUxMT1VUEAcSFgoSU1RSVUNUVVJFRF9TTklQUEVUEAgS",
            "CwoHTUVTU0FHRRAJEgkKBVBSSUNFEAoSDQoJUFJPTU9USU9OEAsSEQoNQURf",
            "Q1VTVE9NSVpFUhAMEhUKEURZTkFNSUNfRURVQ0FUSU9OEA0SEgoORFlOQU1J",
            "Q19GTElHSFQQDhISCg5EWU5BTUlDX0NVU1RPTRAPEhEKDURZTkFNSUNfSE9U",
            "RUwQEBIXChNEWU5BTUlDX1JFQUxfRVNUQVRFEBESEgoORFlOQU1JQ19UUkFW",
            "RUwQEhIRCg1EWU5BTUlDX0xPQ0FMEBMSDwoLRFlOQU1JQ19KT0IQFBIJCgVJ",
            "TUFHRRAVQu4BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1z",
            "QhRQbGFjZWhvbGRlclR5cGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE0L2VudW1zO2Vu",
            "dW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE0LkVudW1zygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0XEVudW1z6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjE0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.PlaceholderTypeEnum), global::Google.Ads.GoogleAds.V14.Enums.PlaceholderTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.PlaceholderTypeEnum.Types.PlaceholderType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible placeholder types for a feed mapping.
  /// </summary>
  public sealed partial class PlaceholderTypeEnum : pb::IMessage<PlaceholderTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlaceholderTypeEnum> _parser = new pb::MessageParser<PlaceholderTypeEnum>(() => new PlaceholderTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlaceholderTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.PlaceholderTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlaceholderTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlaceholderTypeEnum(PlaceholderTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlaceholderTypeEnum Clone() {
      return new PlaceholderTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlaceholderTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlaceholderTypeEnum other) {
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
    public void MergeFrom(PlaceholderTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PlaceholderTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible placeholder types for a feed mapping.
      /// </summary>
      public enum PlaceholderType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Lets you show links in your ad to pages from your website, including the
        /// main landing page.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 2,
        /// <summary>
        /// Lets you attach a phone number to an ad, allowing customers to call
        /// directly from the ad.
        /// </summary>
        [pbr::OriginalName("CALL")] Call = 3,
        /// <summary>
        /// Lets you provide users with a link that points to a mobile app in
        /// addition to a website.
        /// </summary>
        [pbr::OriginalName("APP")] App = 4,
        /// <summary>
        /// Lets you show locations of businesses from your Business Profile
        /// in your ad. This helps people find your locations by showing your
        /// ads with your address, a map to your location, or the distance to your
        /// business. This extension type is useful to draw customers to your
        /// brick-and-mortar location.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 5,
        /// <summary>
        /// If you sell your product through retail chains, affiliate location
        /// extensions let you show nearby stores that carry your products.
        /// </summary>
        [pbr::OriginalName("AFFILIATE_LOCATION")] AffiliateLocation = 6,
        /// <summary>
        /// Lets you include additional text with your search ads that provide
        /// detailed information about your business, including products and services
        /// you offer. Callouts appear in ads at the top and bottom of Google search
        /// results.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 7,
        /// <summary>
        /// Lets you add more info to your ad, specific to some predefined categories
        /// such as types, brands, styles, etc. A minimum of 3 text (SNIPPETS) values
        /// are required.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 8,
        /// <summary>
        /// Allows users to see your ad, click an icon, and contact you directly by
        /// text message. With one tap on your ad, people can contact you to book an
        /// appointment, get a quote, ask for information, or request a service.
        /// </summary>
        [pbr::OriginalName("MESSAGE")] Message = 9,
        /// <summary>
        /// Lets you display prices for a list of items along with your ads. A price
        /// feed is composed of three to eight price table rows.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 10,
        /// <summary>
        /// Lets you highlight sales and other promotions that let users see how
        /// they can save by buying now.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 11,
        /// <summary>
        /// Lets you dynamically inject custom data into the title and description
        /// of your ads.
        /// </summary>
        [pbr::OriginalName("AD_CUSTOMIZER")] AdCustomizer = 12,
        /// <summary>
        /// Indicates that this feed is for education dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_EDUCATION")] DynamicEducation = 13,
        /// <summary>
        /// Indicates that this feed is for flight dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_FLIGHT")] DynamicFlight = 14,
        /// <summary>
        /// Indicates that this feed is for a custom dynamic remarketing type. Use
        /// this only if the other business types don't apply to your products or
        /// services.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_CUSTOM")] DynamicCustom = 15,
        /// <summary>
        /// Indicates that this feed is for hotels and rentals dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_HOTEL")] DynamicHotel = 16,
        /// <summary>
        /// Indicates that this feed is for real estate dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_REAL_ESTATE")] DynamicRealEstate = 17,
        /// <summary>
        /// Indicates that this feed is for travel dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_TRAVEL")] DynamicTravel = 18,
        /// <summary>
        /// Indicates that this feed is for local deals dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_LOCAL")] DynamicLocal = 19,
        /// <summary>
        /// Indicates that this feed is for job dynamic remarketing.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_JOB")] DynamicJob = 20,
        /// <summary>
        /// Lets you attach an image to an ad.
        /// </summary>
        [pbr::OriginalName("IMAGE")] Image = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
