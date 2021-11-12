// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/ad_group_ad_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/ad_group_ad_error.proto</summary>
  public static partial class AdGroupAdErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/ad_group_ad_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvYWRfZ3JvdXBfYWRf",
            "ZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVycm9ycxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKrAwoSQWRHcm91cEFkRXJy",
            "b3JFbnVtIpQDCg5BZEdyb3VwQWRFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIkCiBBRF9HUk9VUF9BRF9MQUJFTF9ET0VTX05PVF9FWElT",
            "VBACEiQKIEFEX0dST1VQX0FEX0xBQkVMX0FMUkVBRFlfRVhJU1RTEAMSGAoU",
            "QURfTk9UX1VOREVSX0FER1JPVVAQBBInCiNDQU5OT1RfT1BFUkFURV9PTl9S",
            "RU1PVkVEX0FER1JPVVBBRBAFEiAKHENBTk5PVF9DUkVBVEVfREVQUkVDQVRF",
            "RF9BRFMQBhIaChZDQU5OT1RfQ1JFQVRFX1RFWFRfQURTEAcSDwoLRU1QVFlf",
            "RklFTEQQCBInCiNSRVNPVVJDRV9SRUZFUkVOQ0VEX0lOX01VTFRJUExFX09Q",
            "UxAJEhwKGEFEX1RZUEVfQ0FOTk9UX0JFX1BBVVNFRBAKEh0KGUFEX1RZUEVf",
            "Q0FOTk9UX0JFX1JFTU9WRUQQCxIgChxDQU5OT1RfVVBEQVRFX0RFUFJFQ0FU",
            "RURfQURTEAxC7gEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5lcnJv",
            "cnNCE0FkR3JvdXBBZEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L2Vycm9ycztl",
            "cnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5FcnJvcnPK",
            "Ah5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxFcnJvcnPqAiJHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWOTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.AdGroupAdErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.AdGroupAdErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.AdGroupAdErrorEnum.Types.AdGroupAdError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group ad errors.
  /// </summary>
  public sealed partial class AdGroupAdErrorEnum : pb::IMessage<AdGroupAdErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdErrorEnum> _parser = new pb::MessageParser<AdGroupAdErrorEnum>(() => new AdGroupAdErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAdErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.AdGroupAdErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum(AdGroupAdErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdErrorEnum Clone() {
      return new AdGroupAdErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAdErrorEnum other) {
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
    public void MergeFrom(AdGroupAdErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupAdErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group ad errors.
      /// </summary>
      public enum AdGroupAdError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No link found between the adgroup ad and the label.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD_LABEL_DOES_NOT_EXIST")] AdGroupAdLabelDoesNotExist = 2,
        /// <summary>
        /// The label has already been attached to the adgroup ad.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD_LABEL_ALREADY_EXISTS")] AdGroupAdLabelAlreadyExists = 3,
        /// <summary>
        /// The specified ad was not found in the adgroup
        /// </summary>
        [pbr::OriginalName("AD_NOT_UNDER_ADGROUP")] AdNotUnderAdgroup = 4,
        /// <summary>
        /// Removed ads may not be modified
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_ADGROUPAD")] CannotOperateOnRemovedAdgroupad = 5,
        /// <summary>
        /// An ad of this type is deprecated and cannot be created. Only deletions
        /// are permitted.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_DEPRECATED_ADS")] CannotCreateDeprecatedAds = 6,
        /// <summary>
        /// Text ads are deprecated and cannot be created. Use expanded text ads
        /// instead.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_TEXT_ADS")] CannotCreateTextAds = 7,
        /// <summary>
        /// A required field was not specified or is an empty string.
        /// </summary>
        [pbr::OriginalName("EMPTY_FIELD")] EmptyField = 8,
        /// <summary>
        /// An ad may only be modified once per call
        /// </summary>
        [pbr::OriginalName("RESOURCE_REFERENCED_IN_MULTIPLE_OPS")] ResourceReferencedInMultipleOps = 9,
        /// <summary>
        /// AdGroupAds with the given ad type cannot be paused.
        /// </summary>
        [pbr::OriginalName("AD_TYPE_CANNOT_BE_PAUSED")] AdTypeCannotBePaused = 10,
        /// <summary>
        /// AdGroupAds with the given ad type cannot be removed.
        /// </summary>
        [pbr::OriginalName("AD_TYPE_CANNOT_BE_REMOVED")] AdTypeCannotBeRemoved = 11,
        /// <summary>
        /// An ad of this type is deprecated and cannot be updated. Only removals
        /// are permitted.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_DEPRECATED_ADS")] CannotUpdateDeprecatedAds = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
