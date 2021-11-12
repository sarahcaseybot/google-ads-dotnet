// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/customer_feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/customer_feed_error.proto</summary>
  public static partial class CustomerFeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/customer_feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerFeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvY3VzdG9tZXJfZmVl",
            "ZF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvcCChVDdXN0b21lckZl",
            "ZWRFcnJvckVudW0i3QIKEUN1c3RvbWVyRmVlZEVycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEiwKKEZFRURfQUxSRUFEWV9FWElTVFNfRk9S",
            "X1BMQUNFSE9MREVSX1RZUEUQAhIiCh5DQU5OT1RfQ1JFQVRFX0ZPUl9SRU1P",
            "VkVEX0ZFRUQQAxIwCixDQU5OT1RfQ1JFQVRFX0FMUkVBRFlfRVhJU1RJTkdf",
            "Q1VTVE9NRVJfRkVFRBAEEicKI0NBTk5PVF9NT0RJRllfUkVNT1ZFRF9DVVNU",
            "T01FUl9GRUVEEAUSHAoYSU5WQUxJRF9QTEFDRUhPTERFUl9UWVBFEAYSLAoo",
            "TUlTU0lOR19GRUVETUFQUElOR19GT1JfUExBQ0VIT0xERVJfVFlQRRAHEjEK",
            "LVBMQUNFSE9MREVSX1RZUEVfTk9UX0FMTE9XRURfT05fQ1VTVE9NRVJfRkVF",
            "RBAIQvEBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3JzQhZD",
            "dXN0b21lckZlZWRFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnM7ZXJy",
            "b3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjkuRXJyb3JzygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6Vjk6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.CustomerFeedErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.CustomerFeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.CustomerFeedErrorEnum.Types.CustomerFeedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible customer feed errors.
  /// </summary>
  public sealed partial class CustomerFeedErrorEnum : pb::IMessage<CustomerFeedErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerFeedErrorEnum> _parser = new pb::MessageParser<CustomerFeedErrorEnum>(() => new CustomerFeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerFeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.CustomerFeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeedErrorEnum(CustomerFeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerFeedErrorEnum Clone() {
      return new CustomerFeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerFeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerFeedErrorEnum other) {
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
    public void MergeFrom(CustomerFeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CustomerFeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible customer feed errors.
      /// </summary>
      public enum CustomerFeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active feed already exists for this customer and place holder type.
        /// </summary>
        [pbr::OriginalName("FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] FeedAlreadyExistsForPlaceholderType = 2,
        /// <summary>
        /// The specified feed is removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_FOR_REMOVED_FEED")] CannotCreateForRemovedFeed = 3,
        /// <summary>
        /// The CustomerFeed already exists. Update should be used to modify the
        /// existing CustomerFeed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_ALREADY_EXISTING_CUSTOMER_FEED")] CannotCreateAlreadyExistingCustomerFeed = 4,
        /// <summary>
        /// Cannot update removed customer feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_REMOVED_CUSTOMER_FEED")] CannotModifyRemovedCustomerFeed = 5,
        /// <summary>
        /// Invalid placeholder type.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE")] InvalidPlaceholderType = 6,
        /// <summary>
        /// Feed mapping for this placeholder type does not exist.
        /// </summary>
        [pbr::OriginalName("MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE")] MissingFeedmappingForPlaceholderType = 7,
        /// <summary>
        /// Placeholder not allowed at the account level.
        /// </summary>
        [pbr::OriginalName("PLACEHOLDER_TYPE_NOT_ALLOWED_ON_CUSTOMER_FEED")] PlaceholderTypeNotAllowedOnCustomerFeed = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
