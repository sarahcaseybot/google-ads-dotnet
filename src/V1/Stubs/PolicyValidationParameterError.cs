// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/policy_validation_parameter_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/policy_validation_parameter_error.proto</summary>
  public static partial class PolicyValidationParameterErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/policy_validation_parameter_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyValidationParameterErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvcG9saWN5X3ZhbGlk",
            "YXRpb25fcGFyYW1ldGVyX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MS5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "mQEKIlBvbGljeVZhbGlkYXRpb25QYXJhbWV0ZXJFcnJvckVudW0icwoeUG9s",
            "aWN5VmFsaWRhdGlvblBhcmFtZXRlckVycm9yEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEjMKL1VOU1VQUE9SVEVEX0FEX1RZUEVfRk9SX0lHTk9S",
            "QUJMRV9QT0xJQ1lfVE9QSUNTEAJC/gEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MS5lcnJvcnNCI1BvbGljeVZhbGlkYXRpb25QYXJhbWV0ZXJFcnJv",
            "clByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjFcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6",
            "OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.PolicyValidationParameterErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.PolicyValidationParameterErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.PolicyValidationParameterErrorEnum.Types.PolicyValidationParameterError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy validation parameter errors.
  /// </summary>
  public sealed partial class PolicyValidationParameterErrorEnum : pb::IMessage<PolicyValidationParameterErrorEnum> {
    private static readonly pb::MessageParser<PolicyValidationParameterErrorEnum> _parser = new pb::MessageParser<PolicyValidationParameterErrorEnum>(() => new PolicyValidationParameterErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyValidationParameterErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.PolicyValidationParameterErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyValidationParameterErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyValidationParameterErrorEnum(PolicyValidationParameterErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyValidationParameterErrorEnum Clone() {
      return new PolicyValidationParameterErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyValidationParameterErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyValidationParameterErrorEnum other) {
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
    public void MergeFrom(PolicyValidationParameterErrorEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyValidationParameterErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible policy validation parameter errors.
      /// </summary>
      public enum PolicyValidationParameterError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Ignorable policy topics are not supported for the ad type.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_AD_TYPE_FOR_IGNORABLE_POLICY_TOPICS")] UnsupportedAdTypeForIgnorablePolicyTopics = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
