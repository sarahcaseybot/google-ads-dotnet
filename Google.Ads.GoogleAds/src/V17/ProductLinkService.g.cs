// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/services/product_link_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/services/product_link_service.proto</summary>
  public static partial class ProductLinkServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/services/product_link_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductLinkServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvc2VydmljZXMvcHJvZHVjdF9s",
            "aW5rX3NlcnZpY2UucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5z",
            "ZXJ2aWNlcxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE3L3Jlc291cmNlcy9w",
            "cm9kdWN0X2xpbmsucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIoAB",
            "ChhDcmVhdGVQcm9kdWN0TGlua1JlcXVlc3QSGAoLY3VzdG9tZXJfaWQYASAB",
            "KAlCA+BBAhJKCgxwcm9kdWN0X2xpbmsYAiABKAsyLy5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTcucmVzb3VyY2VzLlByb2R1Y3RMaW5rQgPgQQIiXQoZQ3Jl",
            "YXRlUHJvZHVjdExpbmtSZXNwb25zZRJACg1yZXNvdXJjZV9uYW1lGAEgASgJ",
            "Qin6QSYKJGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Qcm9kdWN0TGluayKQ",
            "AQoYUmVtb3ZlUHJvZHVjdExpbmtSZXF1ZXN0EhgKC2N1c3RvbWVyX2lkGAEg",
            "ASgJQgPgQQISQwoNcmVzb3VyY2VfbmFtZRgCIAEoCUIs4EEC+kEmCiRnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vUHJvZHVjdExpbmsSFQoNdmFsaWRhdGVf",
            "b25seRgDIAEoCCJdChlSZW1vdmVQcm9kdWN0TGlua1Jlc3BvbnNlEkAKDXJl",
            "c291cmNlX25hbWUYASABKAlCKfpBJgokZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL1Byb2R1Y3RMaW5rMrIEChJQcm9kdWN0TGlua1NlcnZpY2US6AEKEUNy",
            "ZWF0ZVByb2R1Y3RMaW5rEjsuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LnNl",
            "cnZpY2VzLkNyZWF0ZVByb2R1Y3RMaW5rUmVxdWVzdBo8Lmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNy5zZXJ2aWNlcy5DcmVhdGVQcm9kdWN0TGlua1Jlc3Bv",
            "bnNlIljaQRhjdXN0b21lcl9pZCxwcm9kdWN0X2xpbmuC0+STAjciMi92MTcv",
            "Y3VzdG9tZXJzL3tjdXN0b21lcl9pZD0qfS9wcm9kdWN0TGlua3M6Y3JlYXRl",
            "OgEqEukBChFSZW1vdmVQcm9kdWN0TGluaxI7Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNy5zZXJ2aWNlcy5SZW1vdmVQcm9kdWN0TGlua1JlcXVlc3QaPC5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTcuc2VydmljZXMuUmVtb3ZlUHJvZHVj",
            "dExpbmtSZXNwb25zZSJZ2kEZY3VzdG9tZXJfaWQscmVzb3VyY2VfbmFtZYLT",
            "5JMCNyIyL3YxNy9jdXN0b21lcnMve2N1c3RvbWVyX2lkPSp9L3Byb2R1Y3RM",
            "aW5rczpyZW1vdmU6ASoaRcpBGGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbdJB",
            "J2h0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvYWR3b3Jkc0KDAgol",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5zZXJ2aWNlc0IXUHJvZHVj",
            "dExpbmtTZXJ2aWNlUHJvdG9QAVpJZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNy9zZXJ2aWNlcztzZXJ2",
            "aWNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNy5TZXJ2aWNl",
            "c8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxN1xTZXJ2aWNlc+oCJUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxNzo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V17.Resources.ProductLinkReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Services.CreateProductLinkRequest), global::Google.Ads.GoogleAds.V17.Services.CreateProductLinkRequest.Parser, new[]{ "CustomerId", "ProductLink" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Services.CreateProductLinkResponse), global::Google.Ads.GoogleAds.V17.Services.CreateProductLinkResponse.Parser, new[]{ "ResourceName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Services.RemoveProductLinkRequest), global::Google.Ads.GoogleAds.V17.Services.RemoveProductLinkRequest.Parser, new[]{ "CustomerId", "ResourceName", "ValidateOnly" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Services.RemoveProductLinkResponse), global::Google.Ads.GoogleAds.V17.Services.RemoveProductLinkResponse.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ProductLinkService.CreateProductLink][google.ads.googleads.v17.services.ProductLinkService.CreateProductLink].
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CreateProductLinkRequest : pb::IMessage<CreateProductLinkRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateProductLinkRequest> _parser = new pb::MessageParser<CreateProductLinkRequest>(() => new CreateProductLinkRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateProductLinkRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Services.ProductLinkServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkRequest(CreateProductLinkRequest other) : this() {
      customerId_ = other.customerId_;
      productLink_ = other.productLink_ != null ? other.productLink_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkRequest Clone() {
      return new CreateProductLinkRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer for which the product link is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_link" field.</summary>
    public const int ProductLinkFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V17.Resources.ProductLink productLink_;
    /// <summary>
    /// Required. The product link to be created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V17.Resources.ProductLink ProductLink {
      get { return productLink_; }
      set {
        productLink_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateProductLinkRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateProductLinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (!object.Equals(ProductLink, other.ProductLink)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (productLink_ != null) hash ^= ProductLink.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (productLink_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ProductLink);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (productLink_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ProductLink);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (productLink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProductLink);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateProductLinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.productLink_ != null) {
        if (productLink_ == null) {
          ProductLink = new global::Google.Ads.GoogleAds.V17.Resources.ProductLink();
        }
        ProductLink.MergeFrom(other.ProductLink);
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            if (productLink_ == null) {
              ProductLink = new global::Google.Ads.GoogleAds.V17.Resources.ProductLink();
            }
            input.ReadMessage(ProductLink);
            break;
          }
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            if (productLink_ == null) {
              ProductLink = new global::Google.Ads.GoogleAds.V17.Resources.ProductLink();
            }
            input.ReadMessage(ProductLink);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for
  /// [ProductLinkService.CreateProductLink][google.ads.googleads.v17.services.ProductLinkService.CreateProductLink].
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CreateProductLinkResponse : pb::IMessage<CreateProductLinkResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateProductLinkResponse> _parser = new pb::MessageParser<CreateProductLinkResponse>(() => new CreateProductLinkResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateProductLinkResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Services.ProductLinkServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkResponse(CreateProductLinkResponse other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateProductLinkResponse Clone() {
      return new CreateProductLinkResponse(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations. Resource name of the product link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateProductLinkResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateProductLinkResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateProductLinkResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request message for
  /// [ProductLinkService.RemoveProductLink][google.ads.googleads.v17.services.ProductLinkService.RemoveProductLink].
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RemoveProductLinkRequest : pb::IMessage<RemoveProductLinkRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RemoveProductLinkRequest> _parser = new pb::MessageParser<RemoveProductLinkRequest>(() => new RemoveProductLinkRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RemoveProductLinkRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Services.ProductLinkServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkRequest(RemoveProductLinkRequest other) : this() {
      customerId_ = other.customerId_;
      resourceName_ = other.resourceName_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkRequest Clone() {
      return new RemoveProductLinkRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 2;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Remove operation: A resource name for the product link to remove
    /// is expected, in this format:
    ///
    /// `customers/{customer_id}/productLinks/{product_link_id} `
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "validate_only" field.</summary>
    public const int ValidateOnlyFieldNumber = 3;
    private bool validateOnly_;
    /// <summary>
    /// If true, the request is validated but not executed. Only errors are
    /// returned, not results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ValidateOnly {
      get { return validateOnly_; }
      set {
        validateOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RemoveProductLinkRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RemoveProductLinkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (ResourceName != other.ResourceName) return false;
      if (ValidateOnly != other.ValidateOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (ValidateOnly != false) hash ^= ValidateOnly.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (ResourceName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResourceName);
      }
      if (ValidateOnly != false) {
        output.WriteRawTag(24);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (ResourceName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResourceName);
      }
      if (ValidateOnly != false) {
        output.WriteRawTag(24);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (ValidateOnly != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RemoveProductLinkRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.ValidateOnly != false) {
        ValidateOnly = other.ValidateOnly;
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            ValidateOnly = input.ReadBool();
            break;
          }
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
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            ValidateOnly = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for product link removal.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RemoveProductLinkResponse : pb::IMessage<RemoveProductLinkResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RemoveProductLinkResponse> _parser = new pb::MessageParser<RemoveProductLinkResponse>(() => new RemoveProductLinkResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RemoveProductLinkResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Services.ProductLinkServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkResponse(RemoveProductLinkResponse other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoveProductLinkResponse Clone() {
      return new RemoveProductLinkResponse(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Result for the remove request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RemoveProductLinkResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RemoveProductLinkResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RemoveProductLinkResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
