// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/errors/recommendation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/errors/recommendation_error.proto</summary>
  public static partial class RecommendationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/errors/recommendation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZXJyb3JzL3JlY29tbWVuZGF0",
            "aW9uX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTguZXJy",
            "b3JzIvEPChdSZWNvbW1lbmRhdGlvbkVycm9yRW51bSLVDwoTUmVjb21tZW5k",
            "YXRpb25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIbChdC",
            "VURHRVRfQU1PVU5UX1RPT19TTUFMTBACEhsKF0JVREdFVF9BTU9VTlRfVE9P",
            "X0xBUkdFEAMSGQoVSU5WQUxJRF9CVURHRVRfQU1PVU5UEAQSEAoMUE9MSUNZ",
            "X0VSUk9SEAUSFgoSSU5WQUxJRF9CSURfQU1PVU5UEAYSGQoVQURHUk9VUF9L",
            "RVlXT1JEX0xJTUlUEAcSIgoeUkVDT01NRU5EQVRJT05fQUxSRUFEWV9BUFBM",
            "SUVEEAgSHgoaUkVDT01NRU5EQVRJT05fSU5WQUxJREFURUQQCRIXChNUT09f",
            "TUFOWV9PUEVSQVRJT05TEAoSEQoNTk9fT1BFUkFUSU9OUxALEiEKHURJRkZF",
            "UkVOVF9UWVBFU19OT1RfU1VQUE9SVEVEEAwSGwoXRFVQTElDQVRFX1JFU09V",
            "UkNFX05BTUUQDRIkCiBSRUNPTU1FTkRBVElPTl9BTFJFQURZX0RJU01JU1NF",
            "RBAOEhkKFUlOVkFMSURfQVBQTFlfUkVRVUVTVBAPEisKJ1JFQ09NTUVOREFU",
            "SU9OX1RZUEVfQVBQTFlfTk9UX1NVUFBPUlRFRBAREhYKEklOVkFMSURfTVVM",
            "VElQTElFUhASEjMKL0FEVkVSVElTSU5HX0NIQU5ORUxfVFlQRV9HRU5FUkFU",
            "RV9OT1RfU1VQUE9SVEVEEBMSLgoqUkVDT01NRU5EQVRJT05fVFlQRV9HRU5F",
            "UkFURV9OT1RfU1VQUE9SVEVEEBQSKAokUkVDT01NRU5EQVRJT05fVFlQRVNf",
            "Q0FOTk9UX0JFX0VNUFRZEBUSPQo5Q0FNUEFJR05fQlVER0VUX1JFQ09NTUVO",
            "REFUSU9OX1RZUEVfUkVRVUlSRVNfQklERElOR19JTkZPEBYSRgpCQ0FNUEFJ",
            "R05fQlVER0VUX1JFQ09NTUVOREFUSU9OX1RZUEVfUkVRVUlSRVNfQklERElO",
            "R19TVFJBVEVHWV9UWVBFEBcSQQo9Q0FNUEFJR05fQlVER0VUX1JFQ09NTUVO",
            "REFUSU9OX1RZUEVfUkVRVUlSRVNfQVNTRVRfR1JPVVBfSU5GTxAYElAKTENB",
            "TVBBSUdOX0JVREdFVF9SRUNPTU1FTkRBVElPTl9UWVBFX1JFUVVJUkVTX0FT",
            "U0VUX0dST1VQX0lORk9fV0lUSF9GSU5BTF9VUkwQGRJRCk1DQU1QQUlHTl9C",
            "VURHRVRfUkVDT01NRU5EQVRJT05fVFlQRV9SRVFVSVJFU19DT1VOVFJZX0NP",
            "REVTX0ZPUl9TRUFSQ0hfQ0hBTk5FTBAaEk8KS0NBTVBBSUdOX0JVREdFVF9S",
            "RUNPTU1FTkRBVElPTl9UWVBFX0lOVkFMSURfQ09VTlRSWV9DT0RFX0ZPUl9T",
            "RUFSQ0hfQ0hBTk5FTBAbElIKTkNBTVBBSUdOX0JVREdFVF9SRUNPTU1FTkRB",
            "VElPTl9UWVBFX1JFUVVJUkVTX0xBTkdVQUdFX0NPREVTX0ZPUl9TRUFSQ0hf",
            "Q0hBTk5FTBAcEmwKaENBTVBBSUdOX0JVREdFVF9SRUNPTU1FTkRBVElPTl9U",
            "WVBFX1JFUVVJUkVTX0VJVEhFUl9QT1NJVElWRV9PUl9ORUdBVElWRV9MT0NB",
            "VElPTl9JRFNfRk9SX1NFQVJDSF9DSEFOTkVMEB0SUQpNQ0FNUEFJR05fQlVE",
            "R0VUX1JFQ09NTUVOREFUSU9OX1RZUEVfUkVRVUlSRVNfQURfR1JPVVBfSU5G",
            "T19GT1JfU0VBUkNIX0NIQU5ORUwQHhJMCkhDQU1QQUlHTl9CVURHRVRfUkVD",
            "T01NRU5EQVRJT05fVFlQRV9SRVFVSVJFU19LRVlXT1JEU19GT1JfU0VBUkNI",
            "X0NIQU5ORUwQHxKFAQqAAUNBTVBBSUdOX0JVREdFVF9SRUNPTU1FTkRBVElP",
            "Tl9UWVBFX1dJVEhfQ0hBTk5FTF9UWVBFX1NFQVJDSF9BTkRfQklERElOR19T",
            "VFJBVEVHWV9UWVBFX1RBUkdFVF9JTVBSRVNTSU9OX1NIQVJFX1JFUVVJUkVT",
            "X0xPQ0FUSU9OECASmwEKlgFDQU1QQUlHTl9CVURHRVRfUkVDT01NRU5EQVRJ",
            "T05fVFlQRV9XSVRIX0NIQU5ORUxfVFlQRV9TRUFSQ0hfQU5EX0JJRERJTkdf",
            "U1RSQVRFR1lfVFlQRV9UQVJHRVRfSU1QUkVTU0lPTl9TSEFSRV9SRVFVSVJF",
            "U19UQVJHRVRfSU1QUkVTU0lPTl9TSEFSRV9NSUNST1MQIRJcClhDQU1QQUlH",
            "Tl9CVURHRVRfUkVDT01NRU5EQVRJT05fVFlQRV9UQVJHRVRfSU1QUkVTU0lP",
            "Tl9TSEFSRV9NSUNST1NfQkVUV0VFTl8xX0FORF8xMDAwMDAwECISmQEKlAFD",
            "QU1QQUlHTl9CVURHRVRfUkVDT01NRU5EQVRJT05fVFlQRV9XSVRIX0NIQU5O",
            "RUxfVFlQRV9TRUFSQ0hfQU5EX0JJRERJTkdfU1RSQVRFR1lfVFlQRV9UQVJH",
            "RVRfSU1QUkVTU0lPTl9TSEFSRV9SRVFVSVJFU19UQVJHRVRfSU1QUkVTU0lP",
            "Tl9TSEFSRV9JTkZPECNC+AEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTguZXJyb3JzQhhSZWNvbW1lbmRhdGlvbkVycm9yUHJvdG9QAVpFZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YxOC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjE4LkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxOFxFcnJv",
            "cnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTg6OkVycm9yc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Errors.RecommendationErrorEnum), global::Google.Ads.GoogleAds.V18.Errors.RecommendationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Errors.RecommendationErrorEnum.Types.RecommendationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a recommendation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RecommendationErrorEnum : pb::IMessage<RecommendationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecommendationErrorEnum> _parser = new pb::MessageParser<RecommendationErrorEnum>(() => new RecommendationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecommendationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Errors.RecommendationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum(RecommendationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum Clone() {
      return new RecommendationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecommendationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecommendationErrorEnum other) {
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
    public void MergeFrom(RecommendationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the RecommendationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a recommendation.
      /// </summary>
      public enum RecommendationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The specified budget amount is too low for example, lower than minimum
        /// currency unit or lower than ad group minimum cost-per-click.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_SMALL")] BudgetAmountTooSmall = 2,
        /// <summary>
        /// The specified budget amount is too large.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_LARGE")] BudgetAmountTooLarge = 3,
        /// <summary>
        /// The specified budget amount is not a valid amount, for example, not a
        /// multiple of minimum currency unit.
        /// </summary>
        [pbr::OriginalName("INVALID_BUDGET_AMOUNT")] InvalidBudgetAmount = 4,
        /// <summary>
        /// The specified keyword or ad violates ad policy.
        /// </summary>
        [pbr::OriginalName("POLICY_ERROR")] PolicyError = 5,
        /// <summary>
        /// The specified bid amount is not valid, for example, too many fractional
        /// digits, or negative amount.
        /// </summary>
        [pbr::OriginalName("INVALID_BID_AMOUNT")] InvalidBidAmount = 6,
        /// <summary>
        /// The number of keywords in ad group have reached the maximum allowed.
        /// </summary>
        [pbr::OriginalName("ADGROUP_KEYWORD_LIMIT")] AdgroupKeywordLimit = 7,
        /// <summary>
        /// The recommendation requested to apply has already been applied.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_APPLIED")] RecommendationAlreadyApplied = 8,
        /// <summary>
        /// The recommendation requested to apply has been invalidated.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_INVALIDATED")] RecommendationInvalidated = 9,
        /// <summary>
        /// The number of operations in a single request exceeds the maximum allowed.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 10,
        /// <summary>
        /// There are no operations in the request.
        /// </summary>
        [pbr::OriginalName("NO_OPERATIONS")] NoOperations = 11,
        /// <summary>
        /// Operations with multiple recommendation types are not supported when
        /// partial failure mode is not enabled.
        /// </summary>
        [pbr::OriginalName("DIFFERENT_TYPES_NOT_SUPPORTED")] DifferentTypesNotSupported = 12,
        /// <summary>
        /// Request contains multiple operations with the same resource_name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_RESOURCE_NAME")] DuplicateResourceName = 13,
        /// <summary>
        /// The recommendation requested to dismiss has already been dismissed.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_DISMISSED")] RecommendationAlreadyDismissed = 14,
        /// <summary>
        /// The recommendation apply request was malformed and invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APPLY_REQUEST")] InvalidApplyRequest = 15,
        /// <summary>
        /// The type of recommendation requested to apply is not supported.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_TYPE_APPLY_NOT_SUPPORTED")] RecommendationTypeApplyNotSupported = 17,
        /// <summary>
        /// The target multiplier specified is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MULTIPLIER")] InvalidMultiplier = 18,
        /// <summary>
        /// The passed in advertising_channel_type is not supported.
        /// </summary>
        [pbr::OriginalName("ADVERTISING_CHANNEL_TYPE_GENERATE_NOT_SUPPORTED")] AdvertisingChannelTypeGenerateNotSupported = 19,
        /// <summary>
        /// The passed in recommendation_type is not supported.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_TYPE_GENERATE_NOT_SUPPORTED")] RecommendationTypeGenerateNotSupported = 20,
        /// <summary>
        /// One or more recommendation_types need to be passed into the generate
        /// recommendations request.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_TYPES_CANNOT_BE_EMPTY")] RecommendationTypesCannotBeEmpty = 21,
        /// <summary>
        /// Bidding info is required for the CAMPAIGN_BUDGET recommendation type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_BIDDING_INFO")] CampaignBudgetRecommendationTypeRequiresBiddingInfo = 22,
        /// <summary>
        /// Bidding strategy type is required for the CAMPAIGN_BUDGET
        /// recommendation type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_BIDDING_STRATEGY_TYPE")] CampaignBudgetRecommendationTypeRequiresBiddingStrategyType = 23,
        /// <summary>
        /// Asset group info is required for the campaign budget recommendation type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_ASSET_GROUP_INFO")] CampaignBudgetRecommendationTypeRequiresAssetGroupInfo = 24,
        /// <summary>
        /// Asset group info with final url is required for the CAMPAIGN_BUDGET
        /// recommendation type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_ASSET_GROUP_INFO_WITH_FINAL_URL")] CampaignBudgetRecommendationTypeRequiresAssetGroupInfoWithFinalUrl = 25,
        /// <summary>
        /// Country codes are required for the CAMPAIGN_BUDGET recommendation type
        /// for SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_COUNTRY_CODES_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeRequiresCountryCodesForSearchChannel = 26,
        /// <summary>
        /// Country code is invalid for the CAMPAIGN_BUDGET recommendation type for
        /// SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_INVALID_COUNTRY_CODE_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeInvalidCountryCodeForSearchChannel = 27,
        /// <summary>
        /// Language codes are required for the CAMPAIGN_BUDGET recommendation type
        /// for SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_LANGUAGE_CODES_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeRequiresLanguageCodesForSearchChannel = 28,
        /// <summary>
        /// Either positive or negative location ids are required for the
        /// CAMPAIGN_BUDGET recommendation type for SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_EITHER_POSITIVE_OR_NEGATIVE_LOCATION_IDS_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeRequiresEitherPositiveOrNegativeLocationIdsForSearchChannel = 29,
        /// <summary>
        /// Ad group info is required for the CAMPAIGN_BUDGET recommendation type for
        /// SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_AD_GROUP_INFO_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeRequiresAdGroupInfoForSearchChannel = 30,
        /// <summary>
        /// Keywords are required for the CAMPAIGN_BUDGET recommendation type for
        /// SEARCH channel.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_REQUIRES_KEYWORDS_FOR_SEARCH_CHANNEL")] CampaignBudgetRecommendationTypeRequiresKeywordsForSearchChannel = 31,
        /// <summary>
        /// Location is required for the CAMPAIGN_BUDGET recommendation type for
        /// bidding strategy type TARGET_IMPRESSION_SHARE.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_WITH_CHANNEL_TYPE_SEARCH_AND_BIDDING_STRATEGY_TYPE_TARGET_IMPRESSION_SHARE_REQUIRES_LOCATION")] CampaignBudgetRecommendationTypeWithChannelTypeSearchAndBiddingStrategyTypeTargetImpressionShareRequiresLocation = 32,
        /// <summary>
        /// Target impression share micros are required for the CAMPAIGN_BUDGET
        /// recommendation type for bidding strategy type TARGET_IMPRESSION_SHARE.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_WITH_CHANNEL_TYPE_SEARCH_AND_BIDDING_STRATEGY_TYPE_TARGET_IMPRESSION_SHARE_REQUIRES_TARGET_IMPRESSION_SHARE_MICROS")] CampaignBudgetRecommendationTypeWithChannelTypeSearchAndBiddingStrategyTypeTargetImpressionShareRequiresTargetImpressionShareMicros = 33,
        /// <summary>
        /// Target impression share micros are required to be between 1 and 1000000
        /// for the CAMPAIGN_BUDGET recommendation type for bidding strategy type
        /// TARGET_IMPRESSION_SHARE.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_TARGET_IMPRESSION_SHARE_MICROS_BETWEEN_1_AND_1000000")] CampaignBudgetRecommendationTypeTargetImpressionShareMicrosBetween1And1000000 = 34,
        /// <summary>
        /// Target impression share info is required for the CAMPAIGN_BUDGET
        /// recommendation type for bidding strategy type TARGET_IMPRESSION_SHARE.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_RECOMMENDATION_TYPE_WITH_CHANNEL_TYPE_SEARCH_AND_BIDDING_STRATEGY_TYPE_TARGET_IMPRESSION_SHARE_REQUIRES_TARGET_IMPRESSION_SHARE_INFO")] CampaignBudgetRecommendationTypeWithChannelTypeSearchAndBiddingStrategyTypeTargetImpressionShareRequiresTargetImpressionShareInfo = 35,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
