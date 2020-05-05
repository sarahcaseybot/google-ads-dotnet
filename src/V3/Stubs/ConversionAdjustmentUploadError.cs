// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/conversion_adjustment_upload_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/conversion_adjustment_upload_error.proto</summary>
  public static partial class ConversionAdjustmentUploadErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/conversion_adjustment_upload_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionAdjustmentUploadErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvY29udmVyc2lvbl9h",
            "ZGp1c3RtZW50X3VwbG9hZF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMuZXJyb3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "Iu0DCiNDb252ZXJzaW9uQWRqdXN0bWVudFVwbG9hZEVycm9yRW51bSLFAwof",
            "Q29udmVyc2lvbkFkanVzdG1lbnRVcGxvYWRFcnJvchIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIgChxUT09fUkVDRU5UX0NPTlZFUlNJT05fQUNU",
            "SU9OEAISHQoZSU5WQUxJRF9DT05WRVJTSU9OX0FDVElPThADEiAKHENPTlZF",
            "UlNJT05fQUxSRUFEWV9SRVRSQUNURUQQBBIYChRDT05WRVJTSU9OX05PVF9G",
            "T1VORBAFEhYKEkNPTlZFUlNJT05fRVhQSVJFRBAGEiIKHkFESlVTVE1FTlRf",
            "UFJFQ0VERVNfQ09OVkVSU0lPThAHEiEKHU1PUkVfUkVDRU5UX1JFU1RBVEVN",
            "RU5UX0ZPVU5EEAgSGQoVVE9PX1JFQ0VOVF9DT05WRVJTSU9OEAkSTgpKQ0FO",
            "Tk9UX1JFU1RBVEVfQ09OVkVSU0lPTl9BQ1RJT05fVEhBVF9BTFdBWVNfVVNF",
            "U19ERUZBVUxUX0NPTlZFUlNJT05fVkFMVUUQChIjCh9UT09fTUFOWV9BREpV",
            "U1RNRU5UU19JTl9SRVFVRVNUEAsSGAoUVE9PX01BTllfQURKVVNUTUVOVFMQ",
            "DEL/AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVycm9yc0IkQ29u",
            "dmVyc2lvbkFkanVzdG1lbnRVcGxvYWRFcnJvclByb3RvUAFaRGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "My9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjMuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcRXJyb3Jz6gIi",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.ConversionAdjustmentUploadErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.ConversionAdjustmentUploadErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.ConversionAdjustmentUploadErrorEnum.Types.ConversionAdjustmentUploadError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion adjustment upload errors.
  /// </summary>
  public sealed partial class ConversionAdjustmentUploadErrorEnum : pb::IMessage<ConversionAdjustmentUploadErrorEnum> {
    private static readonly pb::MessageParser<ConversionAdjustmentUploadErrorEnum> _parser = new pb::MessageParser<ConversionAdjustmentUploadErrorEnum>(() => new ConversionAdjustmentUploadErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConversionAdjustmentUploadErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.ConversionAdjustmentUploadErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentUploadErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentUploadErrorEnum(ConversionAdjustmentUploadErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionAdjustmentUploadErrorEnum Clone() {
      return new ConversionAdjustmentUploadErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConversionAdjustmentUploadErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConversionAdjustmentUploadErrorEnum other) {
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
    public void MergeFrom(ConversionAdjustmentUploadErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionAdjustmentUploadErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion adjustment upload errors.
      /// </summary>
      public enum ConversionAdjustmentUploadError {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The specified conversion action was created too recently.
        /// Please try the upload again after 4-6 hours have passed since the
        /// conversion action was created.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CONVERSION_ACTION")] TooRecentConversionAction = 2,
        /// <summary>
        /// No conversion action of a supported ConversionActionType that matches the
        /// provided information can be found for the customer.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_ACTION")] InvalidConversionAction = 3,
        /// <summary>
        /// A retraction was already reported for this conversion.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ALREADY_RETRACTED")] ConversionAlreadyRetracted = 4,
        /// <summary>
        /// A conversion for the supplied combination of conversion
        /// action and conversion identifier could not be found.
        /// </summary>
        [pbr::OriginalName("CONVERSION_NOT_FOUND")] ConversionNotFound = 5,
        /// <summary>
        /// The specified conversion has already expired. Conversions expire after 55
        /// days, after which adjustments cannot be reported against them.
        /// </summary>
        [pbr::OriginalName("CONVERSION_EXPIRED")] ConversionExpired = 6,
        /// <summary>
        /// The supplied adjustment date time precedes that of the original
        /// conversion.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_PRECEDES_CONVERSION")] AdjustmentPrecedesConversion = 7,
        /// <summary>
        /// A restatement with a more recent adjustment date time was already
        /// reported for this conversion.
        /// </summary>
        [pbr::OriginalName("MORE_RECENT_RESTATEMENT_FOUND")] MoreRecentRestatementFound = 8,
        /// <summary>
        /// The conversion was created too recently.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CONVERSION")] TooRecentConversion = 9,
        /// <summary>
        /// Restatements cannot be reported for a conversion action that always uses
        /// the default value.
        /// </summary>
        [pbr::OriginalName("CANNOT_RESTATE_CONVERSION_ACTION_THAT_ALWAYS_USES_DEFAULT_CONVERSION_VALUE")] CannotRestateConversionActionThatAlwaysUsesDefaultConversionValue = 10,
        /// <summary>
        /// The request contained more than 2000 adjustments.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ADJUSTMENTS_IN_REQUEST")] TooManyAdjustmentsInRequest = 11,
        /// <summary>
        /// The conversion has been adjusted too many times.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ADJUSTMENTS")] TooManyAdjustments = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
