// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/bidding_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/bidding_error.proto</summary>
  public static partial class BiddingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/bidding_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvYmlkZGluZ19lcnJv",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZXJyb3JzGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIu4IChBCaWRkaW5nRXJyb3JFbnVt",
            "ItkICgxCaWRkaW5nRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESKwonQklERElOR19TVFJBVEVHWV9UUkFOU0lUSU9OX05PVF9BTExPV0VE",
            "EAISLgoqQ0FOTk9UX0FUVEFDSF9CSURESU5HX1NUUkFURUdZX1RPX0NBTVBB",
            "SUdOEAcSKwonSU5WQUxJRF9BTk9OWU1PVVNfQklERElOR19TVFJBVEVHWV9U",
            "WVBFEAoSIQodSU5WQUxJRF9CSURESU5HX1NUUkFURUdZX1RZUEUQDhIPCgtJ",
            "TlZBTElEX0JJRBAREjMKL0JJRERJTkdfU1RSQVRFR1lfTk9UX0FWQUlMQUJM",
            "RV9GT1JfQUNDT1VOVF9UWVBFEBISIwofQ09OVkVSU0lPTl9UUkFDS0lOR19O",
            "T1RfRU5BQkxFRBATEhoKFk5PVF9FTk9VR0hfQ09OVkVSU0lPTlMQFBIwCixD",
            "QU5OT1RfQ1JFQVRFX0NBTVBBSUdOX1dJVEhfQklERElOR19TVFJBVEVHWRAV",
            "Ek8KS0NBTk5PVF9UQVJHRVRfQ09OVEVOVF9ORVRXT1JLX09OTFlfV0lUSF9D",
            "QU1QQUlHTl9MRVZFTF9QT1BfQklERElOR19TVFJBVEVHWRAXEjMKL0JJRERJ",
            "TkdfU1RSQVRFR1lfTk9UX1NVUFBPUlRFRF9XSVRIX0FEX1NDSEVEVUxFEBgS",
            "MQotUEFZX1BFUl9DT05WRVJTSU9OX05PVF9BVkFJTEFCTEVfRk9SX0NVU1RP",
            "TUVSEBkSMgouUEFZX1BFUl9DT05WRVJTSU9OX05PVF9BTExPV0VEX1dJVEhf",
            "VEFSR0VUX0NQQRAaEjoKNkJJRERJTkdfU1RSQVRFR1lfTk9UX0FMTE9XRURf",
            "Rk9SX1NFQVJDSF9PTkxZX0NBTVBBSUdOUxAbEjsKN0JJRERJTkdfU1RSQVRF",
            "R1lfTk9UX1NVUFBPUlRFRF9JTl9EUkFGVFNfT1JfRVhQRVJJTUVOVFMQHBJJ",
            "CkVCSURESU5HX1NUUkFURUdZX1RZUEVfRE9FU19OT1RfU1VQUE9SVF9QUk9E",
            "VUNUX1RZUEVfQURHUk9VUF9DUklURVJJT04QHRIRCg1CSURfVE9PX1NNQUxM",
            "EB4SDwoLQklEX1RPT19CSUcQHxIiCh5CSURfVE9PX01BTllfRlJBQ1RJT05B",
            "TF9ESUdJVFMQIBIXChNJTlZBTElEX0RPTUFJTl9OQU1FECESJAogTk9UX0NP",
            "TVBBVElCTEVfV0lUSF9QQVlNRU5UX01PREUQIhIjCh9OT1RfQ09NUEFUSUJM",
            "RV9XSVRIX0JVREdFVF9UWVBFECMSLQopTk9UX0NPTVBBVElCTEVfV0lUSF9C",
            "SURESU5HX1NUUkFURUdZX1RZUEUQJBI5CjVCSURESU5HX1NUUkFURUdZX1RZ",
            "UEVfSU5DT01QQVRJQkxFX1dJVEhfU0hBUkVEX0JVREdFVBAlQuwBCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZXJyb3JzQhFCaWRkaW5nRXJyb3JQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjMvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYzLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYzXEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpF",
            "cnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.BiddingErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.BiddingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.BiddingErrorEnum.Types.BiddingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding errors.
  /// </summary>
  public sealed partial class BiddingErrorEnum : pb::IMessage<BiddingErrorEnum> {
    private static readonly pb::MessageParser<BiddingErrorEnum> _parser = new pb::MessageParser<BiddingErrorEnum>(() => new BiddingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.BiddingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingErrorEnum(BiddingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingErrorEnum Clone() {
      return new BiddingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BiddingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BiddingErrorEnum other) {
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
    public void MergeFrom(BiddingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the BiddingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible bidding errors.
      /// </summary>
      public enum BiddingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot transition to new bidding strategy.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TRANSITION_NOT_ALLOWED")] BiddingStrategyTransitionNotAllowed = 2,
        /// <summary>
        /// Cannot attach bidding strategy to campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_BIDDING_STRATEGY_TO_CAMPAIGN")] CannotAttachBiddingStrategyToCampaign = 7,
        /// <summary>
        /// Bidding strategy is not supported or cannot be used as anonymous.
        /// </summary>
        [pbr::OriginalName("INVALID_ANONYMOUS_BIDDING_STRATEGY_TYPE")] InvalidAnonymousBiddingStrategyType = 10,
        /// <summary>
        /// The type does not match the named strategy's type.
        /// </summary>
        [pbr::OriginalName("INVALID_BIDDING_STRATEGY_TYPE")] InvalidBiddingStrategyType = 14,
        /// <summary>
        /// The bid is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_BID")] InvalidBid = 17,
        /// <summary>
        /// Bidding strategy is not available for the account type.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE")] BiddingStrategyNotAvailableForAccountType = 18,
        /// <summary>
        /// Conversion tracking is not enabled for the campaign for VBB transition.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED")] ConversionTrackingNotEnabled = 19,
        /// <summary>
        /// Not enough conversions tracked for VBB transitions.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_CONVERSIONS")] NotEnoughConversions = 20,
        /// <summary>
        /// Campaign can not be created with given bidding strategy. It can be
        /// transitioned to the strategy, once eligible.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_CAMPAIGN_WITH_BIDDING_STRATEGY")] CannotCreateCampaignWithBiddingStrategy = 21,
        /// <summary>
        /// Cannot target content network only as campaign uses Page One Promoted
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CAMPAIGN_LEVEL_POP_BIDDING_STRATEGY")] CannotTargetContentNetworkOnlyWithCampaignLevelPopBiddingStrategy = 23,
        /// <summary>
        /// Budget Optimizer and Target Spend bidding strategies are not supported
        /// for campaigns with AdSchedule targeting.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_SUPPORTED_WITH_AD_SCHEDULE")] BiddingStrategyNotSupportedWithAdSchedule = 24,
        /// <summary>
        /// Pay per conversion is not available to all the customer, only few
        /// whitelisted customers can use this.
        /// </summary>
        [pbr::OriginalName("PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER")] PayPerConversionNotAvailableForCustomer = 25,
        /// <summary>
        /// Pay per conversion is not allowed with Target CPA.
        /// </summary>
        [pbr::OriginalName("PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA")] PayPerConversionNotAllowedWithTargetCpa = 26,
        /// <summary>
        /// Cannot set bidding strategy to Manual CPM for search network only
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_ALLOWED_FOR_SEARCH_ONLY_CAMPAIGNS")] BiddingStrategyNotAllowedForSearchOnlyCampaigns = 27,
        /// <summary>
        /// The bidding strategy is not supported for use in drafts or experiments.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_SUPPORTED_IN_DRAFTS_OR_EXPERIMENTS")] BiddingStrategyNotSupportedInDraftsOrExperiments = 28,
        /// <summary>
        /// Bidding strategy type does not support product type ad group criterion.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TYPE_DOES_NOT_SUPPORT_PRODUCT_TYPE_ADGROUP_CRITERION")] BiddingStrategyTypeDoesNotSupportProductTypeAdgroupCriterion = 29,
        /// <summary>
        /// Bid amount is too small.
        /// </summary>
        [pbr::OriginalName("BID_TOO_SMALL")] BidTooSmall = 30,
        /// <summary>
        /// Bid amount is too big.
        /// </summary>
        [pbr::OriginalName("BID_TOO_BIG")] BidTooBig = 31,
        /// <summary>
        /// Bid has too many fractional digit precision.
        /// </summary>
        [pbr::OriginalName("BID_TOO_MANY_FRACTIONAL_DIGITS")] BidTooManyFractionalDigits = 32,
        /// <summary>
        /// Invalid domain name specified.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMAIN_NAME")] InvalidDomainName = 33,
        /// <summary>
        /// The field is not compatible with the payment mode.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_PAYMENT_MODE")] NotCompatibleWithPaymentMode = 34,
        /// <summary>
        /// The field is not compatible with the budget type.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_BUDGET_TYPE")] NotCompatibleWithBudgetType = 35,
        /// <summary>
        /// The field is not compatible with the bidding strategy type.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_BIDDING_STRATEGY_TYPE")] NotCompatibleWithBiddingStrategyType = 36,
        /// <summary>
        /// Bidding strategy type is incompatible with shared budget.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TYPE_INCOMPATIBLE_WITH_SHARED_BUDGET")] BiddingStrategyTypeIncompatibleWithSharedBudget = 37,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
