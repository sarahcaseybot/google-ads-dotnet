// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/listing_group_filter_bidding_category_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/listing_group_filter_bidding_category_level.proto</summary>
  public static partial class ListingGroupFilterBiddingCategoryLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/listing_group_filter_bidding_category_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingGroupFilterBiddingCategoryLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck9nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9saXN0aW5nX2dyb3Vw",
            "X2ZpbHRlcl9iaWRkaW5nX2NhdGVnb3J5X2xldmVsLnByb3RvEh1nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52OS5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byKxAQoqTGlzdGluZ0dyb3VwRmlsdGVyQmlkZGluZ0NhdGVnb3J5",
            "TGV2ZWxFbnVtIoIBCiZMaXN0aW5nR3JvdXBGaWx0ZXJCaWRkaW5nQ2F0ZWdv",
            "cnlMZXZlbBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZMRVZF",
            "TDEQAhIKCgZMRVZFTDIQAxIKCgZMRVZFTDMQBBIKCgZMRVZFTDQQBRIKCgZM",
            "RVZFTDUQBkKAAgohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVudW1z",
            "QitMaXN0aW5nR3JvdXBGaWx0ZXJCaWRkaW5nQ2F0ZWdvcnlMZXZlbFByb3Rv",
            "UAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92OS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlY5LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlc",
            "RW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6RW51bXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterBiddingCategoryLevelEnum), global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterBiddingCategoryLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterBiddingCategoryLevelEnum.Types.ListingGroupFilterBiddingCategoryLevel) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the levels of bidding category used in
  /// ListingGroupFilterDimension.
  /// </summary>
  public sealed partial class ListingGroupFilterBiddingCategoryLevelEnum : pb::IMessage<ListingGroupFilterBiddingCategoryLevelEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListingGroupFilterBiddingCategoryLevelEnum> _parser = new pb::MessageParser<ListingGroupFilterBiddingCategoryLevelEnum>(() => new ListingGroupFilterBiddingCategoryLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListingGroupFilterBiddingCategoryLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterBiddingCategoryLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterBiddingCategoryLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterBiddingCategoryLevelEnum(ListingGroupFilterBiddingCategoryLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterBiddingCategoryLevelEnum Clone() {
      return new ListingGroupFilterBiddingCategoryLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListingGroupFilterBiddingCategoryLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListingGroupFilterBiddingCategoryLevelEnum other) {
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
    public void MergeFrom(ListingGroupFilterBiddingCategoryLevelEnum other) {
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
    /// <summary>Container for nested types declared in the ListingGroupFilterBiddingCategoryLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The level of the listing group filter bidding category.
      /// </summary>
      public enum ListingGroupFilterBiddingCategoryLevel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Level 1.
        /// </summary>
        [pbr::OriginalName("LEVEL1")] Level1 = 2,
        /// <summary>
        /// Level 2.
        /// </summary>
        [pbr::OriginalName("LEVEL2")] Level2 = 3,
        /// <summary>
        /// Level 3.
        /// </summary>
        [pbr::OriginalName("LEVEL3")] Level3 = 4,
        /// <summary>
        /// Level 4.
        /// </summary>
        [pbr::OriginalName("LEVEL4")] Level4 = 5,
        /// <summary>
        /// Level 5.
        /// </summary>
        [pbr::OriginalName("LEVEL5")] Level5 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
