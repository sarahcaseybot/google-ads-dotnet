// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/feed_item_set_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/feed_item_set_error.proto</summary>
  public static partial class FeedItemSetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/feed_item_set_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemSetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvZmVlZF9pdGVtX3Nl",
            "dF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqACChRGZWVkSXRlbVNl",
            "dEVycm9yRW51bSKHAgoQRmVlZEl0ZW1TZXRFcnJvchIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIZChVGRUVEX0lURU1fU0VUX1JFTU9WRUQQAhIf",
            "ChtDQU5OT1RfQ0xFQVJfRFlOQU1JQ19GSUxURVIQAxIgChxDQU5OT1RfQ1JF",
            "QVRFX0RZTkFNSUNfRklMVEVSEAQSFQoRSU5WQUxJRF9GRUVEX1RZUEUQBRIS",
            "Cg5EVVBMSUNBVEVfTkFNRRAGEiYKIldST05HX0RZTkFNSUNfRklMVEVSX0ZP",
            "Ul9GRUVEX1RZUEUQBxIkCiBEWU5BTUlDX0ZJTFRFUl9JTlZBTElEX0NIQUlO",
            "X0lEUxAIQvABCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3Jz",
            "QhVGZWVkSXRlbVNldEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L2Vycm9ycztl",
            "cnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5FcnJvcnPK",
            "Ah5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxFcnJvcnPqAiJHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWOTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.FeedItemSetErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.FeedItemSetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.FeedItemSetErrorEnum.Types.FeedItemSetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item set errors.
  /// </summary>
  public sealed partial class FeedItemSetErrorEnum : pb::IMessage<FeedItemSetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemSetErrorEnum> _parser = new pb::MessageParser<FeedItemSetErrorEnum>(() => new FeedItemSetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedItemSetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.FeedItemSetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetErrorEnum(FeedItemSetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetErrorEnum Clone() {
      return new FeedItemSetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedItemSetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedItemSetErrorEnum other) {
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
    public void MergeFrom(FeedItemSetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemSetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed item set errors.
      /// </summary>
      public enum FeedItemSetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The given ID refers to a removed FeedItemSet.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_SET_REMOVED")] FeedItemSetRemoved = 2,
        /// <summary>
        /// The dynamic filter of a feed item set cannot be cleared on UPDATE if it
        /// exists. A set is either static or dynamic once added, and that cannot
        /// change.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_DYNAMIC_FILTER")] CannotClearDynamicFilter = 3,
        /// <summary>
        /// The dynamic filter of a feed item set cannot be created on UPDATE if it
        /// does not exist. A set is either static or dynamic once added, and that
        /// cannot change.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_DYNAMIC_FILTER")] CannotCreateDynamicFilter = 4,
        /// <summary>
        /// FeedItemSets can only be made for location or affiliate location feeds.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE")] InvalidFeedType = 5,
        /// <summary>
        /// FeedItemSets duplicate name. Name should be unique within an account.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 6,
        /// <summary>
        /// The feed type of the parent Feed is not compatible with the type of
        /// dynamic filter being set. For example, you can only set
        /// dynamic_location_set_filter for LOCATION feed item sets.
        /// </summary>
        [pbr::OriginalName("WRONG_DYNAMIC_FILTER_FOR_FEED_TYPE")] WrongDynamicFilterForFeedType = 7,
        /// <summary>
        /// Chain ID specified for AffiliateLocationFeedData is invalid.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_FILTER_INVALID_CHAIN_IDS")] DynamicFilterInvalidChainIds = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
