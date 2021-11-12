// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/listing_group_filter_product_type_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/listing_group_filter_product_type_level.proto</summary>
  public static partial class ListingGroupFilterProductTypeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/listing_group_filter_product_type_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingGroupFilterProductTypeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9saXN0aW5nX2dyb3Vw",
            "X2ZpbHRlcl9wcm9kdWN0X3R5cGVfbGV2ZWwucHJvdG8SHWdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY5LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvIqgBCiZMaXN0aW5nR3JvdXBGaWx0ZXJQcm9kdWN0VHlwZUxldmVsRW51",
            "bSJ+CiJMaXN0aW5nR3JvdXBGaWx0ZXJQcm9kdWN0VHlwZUxldmVsEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgoKBkxFVkVMMRACEgoKBkxFVkVM",
            "MhADEgoKBkxFVkVMMxAEEgoKBkxFVkVMNBAFEgoKBkxFVkVMNRAGQvwBCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXNCJ0xpc3RpbmdHcm91",
            "cEZpbHRlclByb2R1Y3RUeXBlTGV2ZWxQcm90b1ABWkJnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvZW51",
            "bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5FbnVt",
            "c8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XEVudW1z6gIhR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6Vjk6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterProductTypeLevelEnum), global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterProductTypeLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterProductTypeLevelEnum.Types.ListingGroupFilterProductTypeLevel) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Level of the type of a product offer.
  /// </summary>
  public sealed partial class ListingGroupFilterProductTypeLevelEnum : pb::IMessage<ListingGroupFilterProductTypeLevelEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListingGroupFilterProductTypeLevelEnum> _parser = new pb::MessageParser<ListingGroupFilterProductTypeLevelEnum>(() => new ListingGroupFilterProductTypeLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListingGroupFilterProductTypeLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.ListingGroupFilterProductTypeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductTypeLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductTypeLevelEnum(ListingGroupFilterProductTypeLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductTypeLevelEnum Clone() {
      return new ListingGroupFilterProductTypeLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListingGroupFilterProductTypeLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListingGroupFilterProductTypeLevelEnum other) {
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
    public void MergeFrom(ListingGroupFilterProductTypeLevelEnum other) {
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
    /// <summary>Container for nested types declared in the ListingGroupFilterProductTypeLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the level of the type of a product offer.
      /// </summary>
      public enum ListingGroupFilterProductTypeLevel {
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
