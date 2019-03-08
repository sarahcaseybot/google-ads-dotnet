// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/feed_item_quality_approval_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/feed_item_quality_approval_status.proto</summary>
  public static partial class FeedItemQualityApprovalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/feed_item_quality_approval_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemQualityApprovalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9mZWVkX2l0ZW1fcXVh",
            "bGl0eV9hcHByb3ZhbF9zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoEB",
            "CiFGZWVkSXRlbVF1YWxpdHlBcHByb3ZhbFN0YXR1c0VudW0iXAodRmVlZEl0",
            "ZW1RdWFsaXR5QXBwcm92YWxTdGF0dXMSDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESDAoIQVBQUk9WRUQQAhIPCgtESVNBUFBST1ZFRBADQvcBCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51bXNCIkZlZWRJdGVtUXVh",
            "bGl0eUFwcHJvdmFsU3RhdHVzUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2VudW1zO2Vu",
            "dW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRW51bXPKAh1H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFbnVtc+oCIUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.FeedItemQualityApprovalStatusEnum), global::Google.Ads.GoogleAds.V1.Enums.FeedItemQualityApprovalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.FeedItemQualityApprovalStatusEnum.Types.FeedItemQualityApprovalStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible quality evaluation approval statuses
  /// of a feed item.
  /// </summary>
  public sealed partial class FeedItemQualityApprovalStatusEnum : pb::IMessage<FeedItemQualityApprovalStatusEnum> {
    private static readonly pb::MessageParser<FeedItemQualityApprovalStatusEnum> _parser = new pb::MessageParser<FeedItemQualityApprovalStatusEnum>(() => new FeedItemQualityApprovalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemQualityApprovalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.FeedItemQualityApprovalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemQualityApprovalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemQualityApprovalStatusEnum(FeedItemQualityApprovalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemQualityApprovalStatusEnum Clone() {
      return new FeedItemQualityApprovalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemQualityApprovalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemQualityApprovalStatusEnum other) {
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
    public void MergeFrom(FeedItemQualityApprovalStatusEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemQualityApprovalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible quality evaluation approval statuses of a feed item.
      /// </summary>
      public enum FeedItemQualityApprovalStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Meets all quality expectations.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 2,
        /// <summary>
        /// Does not meet some quality expectations. The specific reason is found in
        /// the quality_disapproval_reasons field.
        /// </summary>
        [pbr::OriginalName("DISAPPROVED")] Disapproved = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
