// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/experiment_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/experiment_error.proto</summary>
  public static partial class ExperimentErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/experiment_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExperimentErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2V4cGVyaW1lbnRf",
            "ZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5lcnJvcnMi",
            "xAcKE0V4cGVyaW1lbnRFcnJvckVudW0irAcKD0V4cGVyaW1lbnRFcnJvchIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIhCh1DQU5OT1RfU0VUX1NU",
            "QVJUX0RBVEVfSU5fUEFTVBACEh4KGkVORF9EQVRFX0JFRk9SRV9TVEFSVF9E",
            "QVRFEAMSIAocU1RBUlRfREFURV9UT09fRkFSX0lOX0ZVVFVSRRAEEh0KGURV",
            "UExJQ0FURV9FWFBFUklNRU5UX05BTUUQBRIkCiBDQU5OT1RfTU9ESUZZX1JF",
            "TU9WRURfRVhQRVJJTUVOVBAGEh0KGVNUQVJUX0RBVEVfQUxSRUFEWV9QQVNT",
            "RUQQBxIfChtDQU5OT1RfU0VUX0VORF9EQVRFX0lOX1BBU1QQCBIgChxDQU5O",
            "T1RfU0VUX1NUQVRVU19UT19SRU1PVkVEEAkSHwobQ0FOTk9UX01PRElGWV9Q",
            "QVNUX0VORF9EQVRFEAoSEgoOSU5WQUxJRF9TVEFUVVMQCxIhCh1JTlZBTElE",
            "X0NBTVBBSUdOX0NIQU5ORUxfVFlQRRAMEiYKIk9WRVJMQVBQSU5HX01FTUJF",
            "UlNfQU5EX0RBVEVfUkFOR0UQDRIjCh9JTlZBTElEX1RSSUFMX0FSTV9UUkFG",
            "RklDX1NQTElUEA4SHQoZVFJBRkZJQ19TUExJVF9PVkVSTEFQUElORxAPEkUK",
            "QVNVTV9UUklBTF9BUk1fVFJBRkZJQ19VTkVRVUFMU19UT19UUklBTF9UUkFG",
            "RklDX1NQTElUX0RFTk9NSU5BVE9SEBASKwonQ0FOTk9UX01PRElGWV9UUkFG",
            "RklDX1NQTElUX0FGVEVSX1NUQVJUEBESGAoURVhQRVJJTUVOVF9OT1RfRk9V",
            "TkQQEhIeChpFWFBFUklNRU5UX05PVF9ZRVRfU1RBUlRFRBATEiUKIUNBTk5P",
            "VF9IQVZFX01VTFRJUExFX0NPTlRST0xfQVJNUxAUEh8KG0lOX0RFU0lHTl9D",
            "QU1QQUlHTlNfTk9UX1NFVBAVEiIKHkNBTk5PVF9TRVRfU1RBVFVTX1RPX0dS",
            "QURVQVRFRBAWEjgKNENBTk5PVF9DUkVBVEVfRVhQRVJJTUVOVF9DQU1QQUlH",
            "Tl9XSVRIX1NIQVJFRF9CVURHRVQQFxI4CjRDQU5OT1RfQ1JFQVRFX0VYUEVS",
            "SU1FTlRfQ0FNUEFJR05fV0lUSF9DVVNUT01fQlVER0VUEBgSHQoZU1RBVFVT",
            "X1RSQU5TSVRJT05fSU5WQUxJRBAZQvQBCiNjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjExLmVycm9yc0IURXhwZXJpbWVudEVycm9yUHJvdG9QAVpFZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YxMS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjExLkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMVxF",
            "cnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTE6OkVycm9yc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.ExperimentErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.ExperimentErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.ExperimentErrorEnum.Types.ExperimentError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible experiment error.
  /// </summary>
  public sealed partial class ExperimentErrorEnum : pb::IMessage<ExperimentErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExperimentErrorEnum> _parser = new pb::MessageParser<ExperimentErrorEnum>(() => new ExperimentErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExperimentErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.ExperimentErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentErrorEnum(ExperimentErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentErrorEnum Clone() {
      return new ExperimentErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExperimentErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExperimentErrorEnum other) {
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
    public void MergeFrom(ExperimentErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ExperimentErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible experiment errors.
      /// </summary>
      public enum ExperimentError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The start date of an experiment cannot be set in the past.
        /// Please use a start date in the future.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_START_DATE_IN_PAST")] CannotSetStartDateInPast = 2,
        /// <summary>
        /// The end date of an experiment is before its start date.
        /// Please use an end date after the start date.
        /// </summary>
        [pbr::OriginalName("END_DATE_BEFORE_START_DATE")] EndDateBeforeStartDate = 3,
        /// <summary>
        /// The start date of an experiment is too far in the future.
        /// Please use a start date no more than 1 year in the future.
        /// </summary>
        [pbr::OriginalName("START_DATE_TOO_FAR_IN_FUTURE")] StartDateTooFarInFuture = 4,
        /// <summary>
        /// The experiment has the same name as an existing active experiment.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_EXPERIMENT_NAME")] DuplicateExperimentName = 5,
        /// <summary>
        /// Experiments can only be modified when they are ENABLED.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_REMOVED_EXPERIMENT")] CannotModifyRemovedExperiment = 6,
        /// <summary>
        /// The start date of an experiment cannot be modified if the existing start
        /// date has already passed.
        /// </summary>
        [pbr::OriginalName("START_DATE_ALREADY_PASSED")] StartDateAlreadyPassed = 7,
        /// <summary>
        /// The end date of an experiment cannot be set in the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_END_DATE_IN_PAST")] CannotSetEndDateInPast = 8,
        /// <summary>
        /// The status of an experiment cannot be set to REMOVED.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_TO_REMOVED")] CannotSetStatusToRemoved = 9,
        /// <summary>
        /// The end date of an expired experiment cannot be modified.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_PAST_END_DATE")] CannotModifyPastEndDate = 10,
        /// <summary>
        /// The status is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS")] InvalidStatus = 11,
        /// <summary>
        /// Experiment arm contains campaigns with invalid advertising channel type.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN_CHANNEL_TYPE")] InvalidCampaignChannelType = 12,
        /// <summary>
        /// A pair of trials share members and have overlapping date ranges.
        /// </summary>
        [pbr::OriginalName("OVERLAPPING_MEMBERS_AND_DATE_RANGE")] OverlappingMembersAndDateRange = 13,
        /// <summary>
        /// Experiment arm contains invalid traffic split.
        /// </summary>
        [pbr::OriginalName("INVALID_TRIAL_ARM_TRAFFIC_SPLIT")] InvalidTrialArmTrafficSplit = 14,
        /// <summary>
        /// Experiment contains trial arms with overlapping traffic split.
        /// </summary>
        [pbr::OriginalName("TRAFFIC_SPLIT_OVERLAPPING")] TrafficSplitOverlapping = 15,
        /// <summary>
        /// The total traffic split of trial arms is not equal to 100.
        /// </summary>
        [pbr::OriginalName("SUM_TRIAL_ARM_TRAFFIC_UNEQUALS_TO_TRIAL_TRAFFIC_SPLIT_DENOMINATOR")] SumTrialArmTrafficUnequalsToTrialTrafficSplitDenominator = 16,
        /// <summary>
        /// Traffic split related settings (like traffic share bounds) can't be
        /// modified after the experiment has started.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_TRAFFIC_SPLIT_AFTER_START")] CannotModifyTrafficSplitAfterStart = 17,
        /// <summary>
        /// The experiment could not be found.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_NOT_FOUND")] ExperimentNotFound = 18,
        /// <summary>
        /// Experiment has not begun.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_NOT_YET_STARTED")] ExperimentNotYetStarted = 19,
        /// <summary>
        /// The experiment cannot have more than one control arm.
        /// </summary>
        [pbr::OriginalName("CANNOT_HAVE_MULTIPLE_CONTROL_ARMS")] CannotHaveMultipleControlArms = 20,
        /// <summary>
        /// The experiment doesn't set in-design campaigns.
        /// </summary>
        [pbr::OriginalName("IN_DESIGN_CAMPAIGNS_NOT_SET")] InDesignCampaignsNotSet = 21,
        /// <summary>
        /// Clients must use the graduate action to graduate experiments and cannot
        /// set the status to GRADUATED directly.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_TO_GRADUATED")] CannotSetStatusToGraduated = 22,
        /// <summary>
        /// Cannot use shared budget on base campaign when scheduling an experiment.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_CAMPAIGN_WITH_SHARED_BUDGET")] CannotCreateExperimentCampaignWithSharedBudget = 23,
        /// <summary>
        /// Cannot use custom budget on base campaign when scheduling an experiment.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_CAMPAIGN_WITH_CUSTOM_BUDGET")] CannotCreateExperimentCampaignWithCustomBudget = 24,
        /// <summary>
        /// Invalid status transition.
        /// </summary>
        [pbr::OriginalName("STATUS_TRANSITION_INVALID")] StatusTransitionInvalid = 25,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
