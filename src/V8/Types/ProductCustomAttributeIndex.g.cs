// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/product_custom_attribute_index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/product_custom_attribute_index.proto</summary>
  public static partial class ProductCustomAttributeIndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/product_custom_attribute_index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductCustomAttributeIndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9wcm9kdWN0X2N1c3Rv",
            "bV9hdHRyaWJ1dGVfaW5kZXgucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY4LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpoBCh9Q",
            "cm9kdWN0Q3VzdG9tQXR0cmlidXRlSW5kZXhFbnVtIncKG1Byb2R1Y3RDdXN0",
            "b21BdHRyaWJ1dGVJbmRleBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIKCgZJTkRFWDAQBxIKCgZJTkRFWDEQCBIKCgZJTkRFWDIQCRIKCgZJTkRF",
            "WDMQChIKCgZJTkRFWDQQC0L1AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY4LmVudW1zQiBQcm9kdWN0Q3VzdG9tQXR0cmlidXRlSW5kZXhQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjgvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WOC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY4XEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.ProductCustomAttributeIndexEnum), global::Google.Ads.GoogleAds.V8.Enums.ProductCustomAttributeIndexEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.ProductCustomAttributeIndexEnum.Types.ProductCustomAttributeIndex) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the index of the product custom attribute.
  /// </summary>
  public sealed partial class ProductCustomAttributeIndexEnum : pb::IMessage<ProductCustomAttributeIndexEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductCustomAttributeIndexEnum> _parser = new pb::MessageParser<ProductCustomAttributeIndexEnum>(() => new ProductCustomAttributeIndexEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProductCustomAttributeIndexEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.ProductCustomAttributeIndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductCustomAttributeIndexEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductCustomAttributeIndexEnum(ProductCustomAttributeIndexEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductCustomAttributeIndexEnum Clone() {
      return new ProductCustomAttributeIndexEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProductCustomAttributeIndexEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProductCustomAttributeIndexEnum other) {
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
    public void MergeFrom(ProductCustomAttributeIndexEnum other) {
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
    /// <summary>Container for nested types declared in the ProductCustomAttributeIndexEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The index of the product custom attribute.
      /// </summary>
      public enum ProductCustomAttributeIndex {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// First product custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX0")] Index0 = 7,
        /// <summary>
        /// Second product custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX1")] Index1 = 8,
        /// <summary>
        /// Third product custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX2")] Index2 = 9,
        /// <summary>
        /// Fourth product custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX3")] Index3 = 10,
        /// <summary>
        /// Fifth product custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX4")] Index4 = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
