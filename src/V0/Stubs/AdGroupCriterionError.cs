// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/ad_group_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/ad_group_criterion_error.proto</summary>
  public static partial class AdGroupCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/ad_group_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvYWRfZ3JvdXBfY3Jp",
            "dGVyaW9uX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5l",
            "cnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i1wwKGUFkR3Jv",
            "dXBDcml0ZXJpb25FcnJvckVudW0iuQwKFUFkR3JvdXBDcml0ZXJpb25FcnJv",
            "chIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIrCidBRF9HUk9VUF9D",
            "UklURVJJT05fTEFCRUxfRE9FU19OT1RfRVhJU1QQAhIrCidBRF9HUk9VUF9D",
            "UklURVJJT05fTEFCRUxfQUxSRUFEWV9FWElTVFMQAxIqCiZDQU5OT1RfQURE",
            "X0xBQkVMX1RPX05FR0FUSVZFX0NSSVRFUklPThAEEhcKE1RPT19NQU5ZX09Q",
            "RVJBVElPTlMQBRIYChRDQU5UX1VQREFURV9ORUdBVElWRRAGEhoKFkNPTkNS",
            "RVRFX1RZUEVfUkVRVUlSRUQQBxIhCh1CSURfSU5DT01QQVRJQkxFX1dJVEhf",
            "QURHUk9VUBAIEh0KGUNBTk5PVF9UQVJHRVRfQU5EX0VYQ0xVREUQCRIPCgtJ",
            "TExFR0FMX1VSTBAKEhgKFElOVkFMSURfS0VZV09SRF9URVhUEAsSGwoXSU5W",
            "QUxJRF9ERVNUSU5BVElPTl9VUkwQDBIfChtNSVNTSU5HX0RFU1RJTkFUSU9O",
            "X1VSTF9UQUcQDRIxCi1LRVlXT1JEX0xFVkVMX0JJRF9OT1RfU1VQUE9SVEVE",
            "X0ZPUl9NQU5VQUxDUE0QDhIXChNJTlZBTElEX1VTRVJfU1RBVFVTEA8SHAoY",
            "Q0FOTk9UX0FERF9DUklURVJJQV9UWVBFEBASIAocQ0FOTk9UX0VYQ0xVREVf",
            "Q1JJVEVSSUFfVFlQRRAREjUKMUNBTVBBSUdOX1RZUEVfTk9UX0NPTVBBVElC",
            "TEVfV0lUSF9QQVJUSUFMX0ZBSUxVUkUQGxItCilPUEVSQVRJT05TX0ZPUl9U",
            "T09fTUFOWV9TSE9QUElOR19BREdST1VQUxAcEjQKMENBTk5PVF9NT0RJRllf",
            "VVJMX0ZJRUxEU19XSVRIX0RVUExJQ0FURV9FTEVNRU5UUxAdEiEKHUNBTk5P",
            "VF9TRVRfV0lUSE9VVF9GSU5BTF9VUkxTEB4SNgoyQ0FOTk9UX0NMRUFSX0ZJ",
            "TkFMX1VSTFNfSUZfRklOQUxfTU9CSUxFX1VSTFNfRVhJU1QQHxIzCi9DQU5O",
            "T1RfQ0xFQVJfRklOQUxfVVJMU19JRl9GSU5BTF9BUFBfVVJMU19FWElTVBAg",
            "EjsKN0NBTk5PVF9DTEVBUl9GSU5BTF9VUkxTX0lGX1RSQUNLSU5HX1VSTF9U",
            "RU1QTEFURV9FWElTVFMQIRI6CjZDQU5OT1RfQ0xFQVJfRklOQUxfVVJMU19J",
            "Rl9VUkxfQ1VTVE9NX1BBUkFNRVRFUlNfRVhJU1QQIhIyCi5DQU5OT1RfU0VU",
            "X0JPVEhfREVTVElOQVRJT05fVVJMX0FORF9GSU5BTF9VUkxTECMSPQo5Q0FO",
            "Tk9UX1NFVF9CT1RIX0RFU1RJTkFUSU9OX1VSTF9BTkRfVFJBQ0tJTkdfVVJM",
            "X1RFTVBMQVRFECQSLworRklOQUxfVVJMU19OT1RfU1VQUE9SVEVEX0ZPUl9D",
            "UklURVJJT05fVFlQRRAlEjYKMkZJTkFMX01PQklMRV9VUkxTX05PVF9TVVBQ",
            "T1JURURfRk9SX0NSSVRFUklPTl9UWVBFECYSIwofSU5WQUxJRF9MSVNUSU5H",
            "X0dST1VQX0hJRVJBUkNIWRAnEisKJ0xJU1RJTkdfR1JPVVBfVU5JVF9DQU5O",
            "T1RfSEFWRV9DSElMRFJFThAoEjIKLkxJU1RJTkdfR1JPVVBfU1VCRElWSVNJ",
            "T05fUkVRVUlSRVNfT1RIRVJTX0NBU0UQKRI6CjZMSVNUSU5HX0dST1VQX1JF",
            "UVVJUkVTX1NBTUVfRElNRU5TSU9OX1RZUEVfQVNfU0lCTElOR1MQKhIgChxM",
            "SVNUSU5HX0dST1VQX0FMUkVBRFlfRVhJU1RTECsSIAocTElTVElOR19HUk9V",
            "UF9ET0VTX05PVF9FWElTVBAsEiMKH0xJU1RJTkdfR1JPVVBfQ0FOTk9UX0JF",
            "X1JFTU9WRUQQLRIeChpJTlZBTElEX0xJU1RJTkdfR1JPVVBfVFlQRRAuEioK",
            "JkxJU1RJTkdfR1JPVVBfQUREX01BWV9PTkxZX1VTRV9URU1QX0lEEC9C9QEK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnNCGkFkR3JvdXBD",
            "cml0ZXJpb25FcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnM7ZXJyb3Jz",
            "ogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRXJyb3JzygIeR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjBcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjA6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.AdGroupCriterionErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.AdGroupCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.AdGroupCriterionErrorEnum.Types.AdGroupCriterionError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group criterion errors.
  /// </summary>
  public sealed partial class AdGroupCriterionErrorEnum : pb::IMessage<AdGroupCriterionErrorEnum> {
    private static readonly pb::MessageParser<AdGroupCriterionErrorEnum> _parser = new pb::MessageParser<AdGroupCriterionErrorEnum>(() => new AdGroupCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.AdGroupCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionErrorEnum(AdGroupCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionErrorEnum Clone() {
      return new AdGroupCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupCriterionErrorEnum other) {
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
    public void MergeFrom(AdGroupCriterionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group criterion errors.
      /// </summary>
      public enum AdGroupCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No link found between the AdGroupCriterion and the label.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION_LABEL_DOES_NOT_EXIST")] AdGroupCriterionLabelDoesNotExist = 2,
        /// <summary>
        /// The label has already been attached to the AdGroupCriterion.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION_LABEL_ALREADY_EXISTS")] AdGroupCriterionLabelAlreadyExists = 3,
        /// <summary>
        /// Negative AdGroupCriterion cannot have labels.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_LABEL_TO_NEGATIVE_CRITERION")] CannotAddLabelToNegativeCriterion = 4,
        /// <summary>
        /// Too many operations for a single call.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 5,
        /// <summary>
        /// Negative ad group criteria are not updateable.
        /// </summary>
        [pbr::OriginalName("CANT_UPDATE_NEGATIVE")] CantUpdateNegative = 6,
        /// <summary>
        /// Concrete type of criterion (keyword v.s. placement) is required for ADD
        /// and SET operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 7,
        /// <summary>
        /// Bid is incompatible with ad group's bidding settings.
        /// </summary>
        [pbr::OriginalName("BID_INCOMPATIBLE_WITH_ADGROUP")] BidIncompatibleWithAdgroup = 8,
        /// <summary>
        /// Cannot target and exclude the same criterion at once.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_AND_EXCLUDE")] CannotTargetAndExclude = 9,
        /// <summary>
        /// The URL of a placement is invalid.
        /// </summary>
        [pbr::OriginalName("ILLEGAL_URL")] IllegalUrl = 10,
        /// <summary>
        /// Keyword text was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_TEXT")] InvalidKeywordText = 11,
        /// <summary>
        /// Destination URL was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_DESTINATION_URL")] InvalidDestinationUrl = 12,
        /// <summary>
        /// The destination url must contain at least one tag (e.g. {lpurl})
        /// </summary>
        [pbr::OriginalName("MISSING_DESTINATION_URL_TAG")] MissingDestinationUrlTag = 13,
        /// <summary>
        /// Keyword-level cpm bid is not supported
        /// </summary>
        [pbr::OriginalName("KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM")] KeywordLevelBidNotSupportedForManualcpm = 14,
        /// <summary>
        /// For example, cannot add a biddable ad group criterion that had been
        /// removed.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_STATUS")] InvalidUserStatus = 15,
        /// <summary>
        /// Criteria type cannot be targeted for the ad group. Either the account is
        /// restricted to keywords only, the criteria type is incompatible with the
        /// campaign's bidding strategy, or the criteria type can only be applied to
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_CRITERIA_TYPE")] CannotAddCriteriaType = 16,
        /// <summary>
        /// Criteria type cannot be excluded for the ad group. Refer to the
        /// documentation for a specific criterion to check if it is excludable.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 17,
        /// <summary>
        /// Partial failure is not supported for shopping campaign mutate operations.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_TYPE_NOT_COMPATIBLE_WITH_PARTIAL_FAILURE")] CampaignTypeNotCompatibleWithPartialFailure = 27,
        /// <summary>
        /// Operations in the mutate request changes too many shopping ad groups.
        /// Please split requests for multiple shopping ad groups across multiple
        /// requests.
        /// </summary>
        [pbr::OriginalName("OPERATIONS_FOR_TOO_MANY_SHOPPING_ADGROUPS")] OperationsForTooManyShoppingAdgroups = 28,
        /// <summary>
        /// Not allowed to modify url fields of an ad group criterion if there are
        /// duplicate elements for that ad group criterion in the request.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_URL_FIELDS_WITH_DUPLICATE_ELEMENTS")] CannotModifyUrlFieldsWithDuplicateElements = 29,
        /// <summary>
        /// Cannot set url fields without also setting final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITHOUT_FINAL_URLS")] CannotSetWithoutFinalUrls = 30,
        /// <summary>
        /// Cannot clear final urls if final mobile urls exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_FINAL_MOBILE_URLS_EXIST")] CannotClearFinalUrlsIfFinalMobileUrlsExist = 31,
        /// <summary>
        /// Cannot clear final urls if final app urls exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_FINAL_APP_URLS_EXIST")] CannotClearFinalUrlsIfFinalAppUrlsExist = 32,
        /// <summary>
        /// Cannot clear final urls if tracking url template exists.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_TRACKING_URL_TEMPLATE_EXISTS")] CannotClearFinalUrlsIfTrackingUrlTemplateExists = 33,
        /// <summary>
        /// Cannot clear final urls if url custom parameters exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_URL_CUSTOM_PARAMETERS_EXIST")] CannotClearFinalUrlsIfUrlCustomParametersExist = 34,
        /// <summary>
        /// Cannot set both destination url and final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_DESTINATION_URL_AND_FINAL_URLS")] CannotSetBothDestinationUrlAndFinalUrls = 35,
        /// <summary>
        /// Cannot set both destination url and tracking url template.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE")] CannotSetBothDestinationUrlAndTrackingUrlTemplate = 36,
        /// <summary>
        /// Final urls are not supported for this criterion type.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE")] FinalUrlsNotSupportedForCriterionType = 37,
        /// <summary>
        /// Final mobile urls are not supported for this criterion type.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE")] FinalMobileUrlsNotSupportedForCriterionType = 38,
        /// <summary>
        /// Ad group is invalid due to the listing groups it contains.
        /// </summary>
        [pbr::OriginalName("INVALID_LISTING_GROUP_HIERARCHY")] InvalidListingGroupHierarchy = 39,
        /// <summary>
        /// Listing group unit cannot have children.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_UNIT_CANNOT_HAVE_CHILDREN")] ListingGroupUnitCannotHaveChildren = 40,
        /// <summary>
        /// Subdivided listing groups must have an "others" case.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_SUBDIVISION_REQUIRES_OTHERS_CASE")] ListingGroupSubdivisionRequiresOthersCase = 41,
        /// <summary>
        /// Dimension type of listing group must be the same as that of its siblings.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_REQUIRES_SAME_DIMENSION_TYPE_AS_SIBLINGS")] ListingGroupRequiresSameDimensionTypeAsSiblings = 42,
        /// <summary>
        /// Listing group cannot be added to the ad group because it already exists.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_ALREADY_EXISTS")] ListingGroupAlreadyExists = 43,
        /// <summary>
        /// Listing group referenced in the operation was not found in the ad group.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_DOES_NOT_EXIST")] ListingGroupDoesNotExist = 44,
        /// <summary>
        /// Recursive removal failed because listing group subdivision is being
        /// created or modified in this request.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_CANNOT_BE_REMOVED")] ListingGroupCannotBeRemoved = 45,
        /// <summary>
        /// Listing group type is not allowed for specified ad group criterion type.
        /// </summary>
        [pbr::OriginalName("INVALID_LISTING_GROUP_TYPE")] InvalidListingGroupType = 46,
        /// <summary>
        /// Listing group in an ADD operation specifies a non temporary criterion id.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP_ADD_MAY_ONLY_USE_TEMP_ID")] ListingGroupAddMayOnlyUseTempId = 47,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
