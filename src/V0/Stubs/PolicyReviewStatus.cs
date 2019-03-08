// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/policy_review_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/policy_review_status.proto</summary>
  public static partial class PolicyReviewStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/policy_review_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyReviewStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wb2xpY3lfcmV2aWV3",
            "X3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ihAEKFlBvbGljeVJldmll",
            "d1N0YXR1c0VudW0iagoSUG9saWN5UmV2aWV3U3RhdHVzEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhYKElJFVklFV19JTl9QUk9HUkVTUxACEgwK",
            "CFJFVklFV0VEEAMSEAoMVU5ERVJfQVBQRUFMEARC7AEKIWNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MC5lbnVtc0IXUG9saWN5UmV2aWV3U3RhdHVzUHJv",
            "dG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYwOjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.PolicyReviewStatusEnum), global::Google.Ads.GoogleAds.V0.Enums.PolicyReviewStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy review statuses.
  /// </summary>
  public sealed partial class PolicyReviewStatusEnum : pb::IMessage<PolicyReviewStatusEnum> {
    private static readonly pb::MessageParser<PolicyReviewStatusEnum> _parser = new pb::MessageParser<PolicyReviewStatusEnum>(() => new PolicyReviewStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyReviewStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.PolicyReviewStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum(PolicyReviewStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum Clone() {
      return new PolicyReviewStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyReviewStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyReviewStatusEnum other) {
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
    public void MergeFrom(PolicyReviewStatusEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyReviewStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible policy review statuses.
      /// </summary>
      public enum PolicyReviewStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Currently under review.
        /// </summary>
        [pbr::OriginalName("REVIEW_IN_PROGRESS")] ReviewInProgress = 2,
        /// <summary>
        /// Primary review complete. Other reviews may be continuing.
        /// </summary>
        [pbr::OriginalName("REVIEWED")] Reviewed = 3,
        /// <summary>
        /// The resource has been resubmitted for approval or its policy decision has
        /// been appealed.
        /// </summary>
        [pbr::OriginalName("UNDER_APPEAL")] UnderAppeal = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
