// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/enums/recommendation_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/enums/recommendation_type.proto</summary>
  public static partial class RecommendationTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/enums/recommendation_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZW51bXMvcmVjb21tZW5kYXRp",
            "b25fdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2LmVudW1z",
            "IvMNChZSZWNvbW1lbmRhdGlvblR5cGVFbnVtItgNChJSZWNvbW1lbmRhdGlv",
            "blR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEwoPQ0FNUEFJ",
            "R05fQlVER0VUEAISCwoHS0VZV09SRBADEgsKB1RFWFRfQUQQBBIVChFUQVJH",
            "RVRfQ1BBX09QVF9JThAFEh8KG01BWElNSVpFX0NPTlZFUlNJT05TX09QVF9J",
            "ThAGEhcKE0VOSEFOQ0VEX0NQQ19PUFRfSU4QBxIaChZTRUFSQ0hfUEFSVE5F",
            "UlNfT1BUX0lOEAgSGgoWTUFYSU1JWkVfQ0xJQ0tTX09QVF9JThAJEhgKFE9Q",
            "VElNSVpFX0FEX1JPVEFUSU9OEAoSFgoSS0VZV09SRF9NQVRDSF9UWVBFEA4S",
            "FgoSTU9WRV9VTlVTRURfQlVER0VUEA8SHwobRk9SRUNBU1RJTkdfQ0FNUEFJ",
            "R05fQlVER0VUEBASFgoSVEFSR0VUX1JPQVNfT1BUX0lOEBESGAoUUkVTUE9O",
            "U0lWRV9TRUFSQ0hfQUQQEhIgChxNQVJHSU5BTF9ST0lfQ0FNUEFJR05fQlVE",
            "R0VUEBMSGwoXVVNFX0JST0FEX01BVENIX0tFWVdPUkQQFBIeChpSRVNQT05T",
            "SVZFX1NFQVJDSF9BRF9BU1NFVBAVEjYKMlVQR1JBREVfU01BUlRfU0hPUFBJ",
            "TkdfQ0FNUEFJR05fVE9fUEVSRk9STUFOQ0VfTUFYEBYSLAooUkVTUE9OU0lW",
            "RV9TRUFSQ0hfQURfSU1QUk9WRV9BRF9TVFJFTkdUSBAXEhwKGERJU1BMQVlf",
            "RVhQQU5TSU9OX09QVF9JThAYEi0KKVVQR1JBREVfTE9DQUxfQ0FNUEFJR05f",
            "VE9fUEVSRk9STUFOQ0VfTUFYEBkSIAocUkFJU0VfVEFSR0VUX0NQQV9CSURf",
            "VE9PX0xPVxAaEh8KG0ZPUkVDQVNUSU5HX1NFVF9UQVJHRVRfUk9BUxAbEhEK",
            "DUNBTExPVVRfQVNTRVQQHBISCg5TSVRFTElOS19BU1NFVBAdEg4KCkNBTExf",
            "QVNTRVQQHhIaChZTSE9QUElOR19BRERfQUdFX0dST1VQEB8SFgoSU0hPUFBJ",
            "TkdfQUREX0NPTE9SECASFwoTU0hPUFBJTkdfQUREX0dFTkRFUhAhEhUKEVNI",
            "T1BQSU5HX0FERF9HVElOECISIQodU0hPUFBJTkdfQUREX01PUkVfSURFTlRJ",
            "RklFUlMQIxIVChFTSE9QUElOR19BRERfU0laRRAkEiUKIVNIT1BQSU5HX0FE",
            "RF9QUk9EVUNUU19UT19DQU1QQUlHThAlEiUKIVNIT1BQSU5HX0ZJWF9ESVNB",
            "UFBST1ZFRF9QUk9EVUNUUxAmEh4KGlNIT1BQSU5HX1RBUkdFVF9BTExfT0ZG",
            "RVJTECcSMgouU0hPUFBJTkdfRklYX1NVU1BFTkRFRF9NRVJDSEFOVF9DRU5U",
            "RVJfQUNDT1VOVBAoEjsKN1NIT1BQSU5HX0ZJWF9NRVJDSEFOVF9DRU5URVJf",
            "QUNDT1VOVF9TVVNQRU5TSU9OX1dBUk5JTkcQKRJICkRTSE9QUElOR19NSUdS",
            "QVRFX1JFR1VMQVJfU0hPUFBJTkdfQ0FNUEFJR05fT0ZGRVJTX1RPX1BFUkZP",
            "Uk1BTkNFX01BWBAqEiIKHkRZTkFNSUNfSU1BR0VfRVhURU5TSU9OX09QVF9J",
            "ThArEhQKEFJBSVNFX1RBUkdFVF9DUEEQLBIVChFMT1dFUl9UQVJHRVRfUk9B",
            "UxAtEhoKFlBFUkZPUk1BTkNFX01BWF9PUFRfSU4QLhInCiNJTVBST1ZFX1BF",
            "UkZPUk1BTkNFX01BWF9BRF9TVFJFTkdUSBAvEjoKNk1JR1JBVEVfRFlOQU1J",
            "Q19TRUFSQ0hfQURTX0NBTVBBSUdOX1RPX1BFUkZPUk1BTkNFX01BWBAwEh4K",
            "GkZPUkVDQVNUSU5HX1NFVF9UQVJHRVRfQ1BBEDESEgoOU0VUX1RBUkdFVF9D",
            "UEEQMhITCg9TRVRfVEFSR0VUX1JPQVMQMxIkCiBNQVhJTUlaRV9DT05WRVJT",
            "SU9OX1ZBTFVFX09QVF9JThA0Eh8KG0lNUFJPVkVfR09PR0xFX1RBR19DT1ZF",
            "UkFHRRA1EiQKIFBFUkZPUk1BTkNFX01BWF9GSU5BTF9VUkxfT1BUX0lOEDYS",
            "HwobUkVGUkVTSF9DVVNUT01FUl9NQVRDSF9MSVNUEDcSGgoWQ1VTVE9NX0FV",
            "RElFTkNFX09QVF9JThA4EhMKD0xFQURfRk9STV9BU1NFVBA5EiIKHklNUFJP",
            "VkVfREVNQU5EX0dFTl9BRF9TVFJFTkdUSBA6QvEBCiJjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjE2LmVudW1zQhdSZWNvbW1lbmRhdGlvblR5cGVQcm90",
            "b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjE2L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjE2LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjE2XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE2OjpFbnVt",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Enums.RecommendationTypeEnum), global::Google.Ads.GoogleAds.V16.Enums.RecommendationTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Enums.RecommendationTypeEnum.Types.RecommendationType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing types of recommendations.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RecommendationTypeEnum : pb::IMessage<RecommendationTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecommendationTypeEnum> _parser = new pb::MessageParser<RecommendationTypeEnum>(() => new RecommendationTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecommendationTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Enums.RecommendationTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationTypeEnum(RecommendationTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationTypeEnum Clone() {
      return new RecommendationTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecommendationTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecommendationTypeEnum other) {
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
    public void MergeFrom(RecommendationTypeEnum other) {
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
    /// <summary>Container for nested types declared in the RecommendationTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Types of recommendations.
      /// </summary>
      public enum RecommendationType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Budget recommendation for campaigns that are currently budget-constrained
        /// (as opposed to the FORECASTING_CAMPAIGN_BUDGET recommendation, which
        /// applies to campaigns that are expected to become budget-constrained in
        /// the future).
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET")] CampaignBudget = 2,
        /// <summary>
        /// Keyword recommendation.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 3,
        /// <summary>
        /// Recommendation to add a new text ad.
        /// </summary>
        [pbr::OriginalName("TEXT_AD")] TextAd = 4,
        /// <summary>
        /// Recommendation to update a campaign to use a Target CPA bidding strategy.
        /// </summary>
        [pbr::OriginalName("TARGET_CPA_OPT_IN")] TargetCpaOptIn = 5,
        /// <summary>
        /// Recommendation to update a campaign to use the Maximize Conversions
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("MAXIMIZE_CONVERSIONS_OPT_IN")] MaximizeConversionsOptIn = 6,
        /// <summary>
        /// Recommendation to enable Enhanced Cost Per Click for a campaign.
        /// </summary>
        [pbr::OriginalName("ENHANCED_CPC_OPT_IN")] EnhancedCpcOptIn = 7,
        /// <summary>
        /// Recommendation to start showing your campaign's ads on Google Search
        /// Partners Websites.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNERS_OPT_IN")] SearchPartnersOptIn = 8,
        /// <summary>
        /// Recommendation to update a campaign to use a Maximize Clicks bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("MAXIMIZE_CLICKS_OPT_IN")] MaximizeClicksOptIn = 9,
        /// <summary>
        /// Recommendation to start using the "Optimize" ad rotation setting for the
        /// given ad group.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_AD_ROTATION")] OptimizeAdRotation = 10,
        /// <summary>
        /// Recommendation to change an existing keyword from one match type to a
        /// broader match type.
        /// </summary>
        [pbr::OriginalName("KEYWORD_MATCH_TYPE")] KeywordMatchType = 14,
        /// <summary>
        /// Recommendation to move unused budget from one budget to a constrained
        /// budget.
        /// </summary>
        [pbr::OriginalName("MOVE_UNUSED_BUDGET")] MoveUnusedBudget = 15,
        /// <summary>
        /// Budget recommendation for campaigns that are expected to become
        /// budget-constrained in the future (as opposed to the CAMPAIGN_BUDGET
        /// recommendation, which applies to campaigns that are currently
        /// budget-constrained).
        /// </summary>
        [pbr::OriginalName("FORECASTING_CAMPAIGN_BUDGET")] ForecastingCampaignBudget = 16,
        /// <summary>
        /// Recommendation to update a campaign to use a Target ROAS bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("TARGET_ROAS_OPT_IN")] TargetRoasOptIn = 17,
        /// <summary>
        /// Recommendation to add a new responsive search ad.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_SEARCH_AD")] ResponsiveSearchAd = 18,
        /// <summary>
        /// Budget recommendation for campaigns whose ROI is predicted to increase
        /// with a budget adjustment.
        /// </summary>
        [pbr::OriginalName("MARGINAL_ROI_CAMPAIGN_BUDGET")] MarginalRoiCampaignBudget = 19,
        /// <summary>
        /// Recommendation to add broad match versions of keywords for fully
        /// automated conversion-based bidding campaigns.
        /// </summary>
        [pbr::OriginalName("USE_BROAD_MATCH_KEYWORD")] UseBroadMatchKeyword = 20,
        /// <summary>
        /// Recommendation to add new responsive search ad assets.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_SEARCH_AD_ASSET")] ResponsiveSearchAdAsset = 21,
        /// <summary>
        /// Recommendation to upgrade a Smart Shopping campaign to a Performance Max
        /// campaign.
        /// </summary>
        [pbr::OriginalName("UPGRADE_SMART_SHOPPING_CAMPAIGN_TO_PERFORMANCE_MAX")] UpgradeSmartShoppingCampaignToPerformanceMax = 22,
        /// <summary>
        /// Recommendation to improve strength of responsive search ad.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_SEARCH_AD_IMPROVE_AD_STRENGTH")] ResponsiveSearchAdImproveAdStrength = 23,
        /// <summary>
        /// Recommendation to update a campaign to use Display Expansion.
        /// </summary>
        [pbr::OriginalName("DISPLAY_EXPANSION_OPT_IN")] DisplayExpansionOptIn = 24,
        /// <summary>
        /// Recommendation to upgrade a Local campaign to a Performance Max
        /// campaign.
        /// </summary>
        [pbr::OriginalName("UPGRADE_LOCAL_CAMPAIGN_TO_PERFORMANCE_MAX")] UpgradeLocalCampaignToPerformanceMax = 25,
        /// <summary>
        /// Recommendation to raise target CPA when it is too low and there are very
        /// few or no conversions.
        /// It is applied asynchronously and can take minutes
        /// depending on the number of ad groups there are in the related campaign.
        /// </summary>
        [pbr::OriginalName("RAISE_TARGET_CPA_BID_TOO_LOW")] RaiseTargetCpaBidTooLow = 26,
        /// <summary>
        /// Recommendation to raise the budget in advance of a seasonal event that is
        /// forecasted to increase traffic, and change bidding strategy from maximize
        /// conversion value to target ROAS.
        /// </summary>
        [pbr::OriginalName("FORECASTING_SET_TARGET_ROAS")] ForecastingSetTargetRoas = 27,
        /// <summary>
        /// Recommendation to add callout assets to campaign or customer level.
        /// </summary>
        [pbr::OriginalName("CALLOUT_ASSET")] CalloutAsset = 28,
        /// <summary>
        /// Recommendation to add sitelink assets to campaign or customer level.
        /// </summary>
        [pbr::OriginalName("SITELINK_ASSET")] SitelinkAsset = 29,
        /// <summary>
        /// Recommendation to add call assets to campaign or customer level.
        /// </summary>
        [pbr::OriginalName("CALL_ASSET")] CallAsset = 30,
        /// <summary>
        /// Recommendation to add the age group attribute to offers that are
        /// demoted because of a missing age group.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_AGE_GROUP")] ShoppingAddAgeGroup = 31,
        /// <summary>
        /// Recommendation to add a color to offers that are demoted
        /// because of a missing color.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_COLOR")] ShoppingAddColor = 32,
        /// <summary>
        /// Recommendation to add a gender to offers that are demoted
        /// because of a missing gender.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_GENDER")] ShoppingAddGender = 33,
        /// <summary>
        /// Recommendation to add a GTIN (Global Trade Item Number) to offers
        /// that are demoted because of a missing GTIN.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_GTIN")] ShoppingAddGtin = 34,
        /// <summary>
        /// Recommendation to add more identifiers to offers that are demoted because
        /// of missing identifiers.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_MORE_IDENTIFIERS")] ShoppingAddMoreIdentifiers = 35,
        /// <summary>
        /// Recommendation to add the size to offers that are demoted
        /// because of a missing size.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_SIZE")] ShoppingAddSize = 36,
        /// <summary>
        /// Recommendation informing a customer about a campaign that cannot serve
        /// because no products are being targeted.
        /// </summary>
        [pbr::OriginalName("SHOPPING_ADD_PRODUCTS_TO_CAMPAIGN")] ShoppingAddProductsToCampaign = 37,
        /// <summary>
        /// The shopping recommendation informing a customer about campaign with a
        /// high percentage of disapproved products.
        /// </summary>
        [pbr::OriginalName("SHOPPING_FIX_DISAPPROVED_PRODUCTS")] ShoppingFixDisapprovedProducts = 38,
        /// <summary>
        /// Recommendation to create a catch-all campaign that targets all offers.
        /// </summary>
        [pbr::OriginalName("SHOPPING_TARGET_ALL_OFFERS")] ShoppingTargetAllOffers = 39,
        /// <summary>
        /// Recommendation to fix Merchant Center account suspension issues.
        /// </summary>
        [pbr::OriginalName("SHOPPING_FIX_SUSPENDED_MERCHANT_CENTER_ACCOUNT")] ShoppingFixSuspendedMerchantCenterAccount = 40,
        /// <summary>
        /// Recommendation to fix Merchant Center account suspension warning issues.
        /// </summary>
        [pbr::OriginalName("SHOPPING_FIX_MERCHANT_CENTER_ACCOUNT_SUSPENSION_WARNING")] ShoppingFixMerchantCenterAccountSuspensionWarning = 41,
        /// <summary>
        /// Recommendation to migrate offers targeted by Regular Shopping Campaigns
        /// to existing Performance Max campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_MIGRATE_REGULAR_SHOPPING_CAMPAIGN_OFFERS_TO_PERFORMANCE_MAX")] ShoppingMigrateRegularShoppingCampaignOffersToPerformanceMax = 42,
        /// <summary>
        /// Recommendation to enable dynamic image extensions on the account,
        /// allowing Google to find the best images from ad landing pages and
        /// complement text ads.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_IMAGE_EXTENSION_OPT_IN")] DynamicImageExtensionOptIn = 43,
        /// <summary>
        /// Recommendation to raise Target CPA based on Google predictions modeled
        /// from past conversions. It is applied asynchronously and can take minutes
        /// depending on the number of ad groups there are in the related campaign.
        /// </summary>
        [pbr::OriginalName("RAISE_TARGET_CPA")] RaiseTargetCpa = 44,
        /// <summary>
        /// Recommendation to lower Target ROAS.
        /// </summary>
        [pbr::OriginalName("LOWER_TARGET_ROAS")] LowerTargetRoas = 45,
        /// <summary>
        /// Recommendation to opt into Performance Max campaigns.
        /// </summary>
        [pbr::OriginalName("PERFORMANCE_MAX_OPT_IN")] PerformanceMaxOptIn = 46,
        /// <summary>
        /// Recommendation to improve the asset group strength of a Performance Max
        /// campaign to an "Excellent" rating.
        /// </summary>
        [pbr::OriginalName("IMPROVE_PERFORMANCE_MAX_AD_STRENGTH")] ImprovePerformanceMaxAdStrength = 47,
        /// <summary>
        /// Recommendation to migrate Dynamic Search Ads to Performance Max
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("MIGRATE_DYNAMIC_SEARCH_ADS_CAMPAIGN_TO_PERFORMANCE_MAX")] MigrateDynamicSearchAdsCampaignToPerformanceMax = 48,
        /// <summary>
        /// Recommendation to set a target CPA for campaigns that do not have one
        /// specified, in advance of a seasonal event that is forecasted to increase
        /// traffic.
        /// </summary>
        [pbr::OriginalName("FORECASTING_SET_TARGET_CPA")] ForecastingSetTargetCpa = 49,
        /// <summary>
        /// Recommendation to set a target CPA for campaigns that do not have one
        /// specified.
        /// </summary>
        [pbr::OriginalName("SET_TARGET_CPA")] SetTargetCpa = 50,
        /// <summary>
        /// Recommendation to set a target ROAS for campaigns that do not have one
        /// specified.
        /// </summary>
        [pbr::OriginalName("SET_TARGET_ROAS")] SetTargetRoas = 51,
        /// <summary>
        /// Recommendation to update a campaign to use the Maximize Conversion Value
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("MAXIMIZE_CONVERSION_VALUE_OPT_IN")] MaximizeConversionValueOptIn = 52,
        /// <summary>
        /// Recommendation to deploy Google Tag on more pages.
        /// </summary>
        [pbr::OriginalName("IMPROVE_GOOGLE_TAG_COVERAGE")] ImproveGoogleTagCoverage = 53,
        /// <summary>
        /// Recommendation to turn on Final URL expansion for your Performance Max
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("PERFORMANCE_MAX_FINAL_URL_OPT_IN")] PerformanceMaxFinalUrlOptIn = 54,
        /// <summary>
        /// Recommendation to update a customer list that hasn't been updated
        /// in the last 90 days.
        /// </summary>
        [pbr::OriginalName("REFRESH_CUSTOMER_MATCH_LIST")] RefreshCustomerMatchList = 55,
        /// <summary>
        /// Recommendation to create a custom audience.
        /// </summary>
        [pbr::OriginalName("CUSTOM_AUDIENCE_OPT_IN")] CustomAudienceOptIn = 56,
        /// <summary>
        /// Recommendation to add lead form assets to campaign or customer level.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_ASSET")] LeadFormAsset = 57,
        /// <summary>
        /// Recommendation to improve the strength of ads in
        /// Demand Gen campaigns.
        /// </summary>
        [pbr::OriginalName("IMPROVE_DEMAND_GEN_AD_STRENGTH")] ImproveDemandGenAdStrength = 58,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
