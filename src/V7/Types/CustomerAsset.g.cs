// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/customer_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/customer_asset.proto</summary>
  public static partial class CustomerAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/customer_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "YXNzZXQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291cmNl",
            "cxo0Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvYXNzZXRfZmllbGRf",
            "dHlwZS5wcm90bxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvYXNz",
            "ZXRfbGlua19zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8irwMKDUN1c3RvbWVyQXNzZXQSRQoNcmVz",
            "b3VyY2VfbmFtZRgBIAEoCUIu4EEF+kEoCiZnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb20vQ3VzdG9tZXJBc3NldBI4CgVhc3NldBgCIAEoCUIp4EEC4EEF+kEg",
            "Ch5nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXQSXAoKZmllbGRfdHlw",
            "ZRgDIAEoDjJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1zLkFzc2V0",
            "RmllbGRUeXBlRW51bS5Bc3NldEZpZWxkVHlwZUIG4EEC4EEFElIKBnN0YXR1",
            "cxgEIAEoDjJCLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1zLkFzc2V0",
            "TGlua1N0YXR1c0VudW0uQXNzZXRMaW5rU3RhdHVzOmvqQWgKJmdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9DdXN0b21lckFzc2V0Ej5jdXN0b21lcnMve2N1",
            "c3RvbWVyX2lkfS9jdXN0b21lckFzc2V0cy97YXNzZXRfaWR9fntmaWVsZF90",
            "eXBlfUL/AQolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291cmNl",
            "c0ISQ3VzdG9tZXJBc3NldFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXM7",
            "cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjcuUmVz",
            "b3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdcUmVzb3VyY2Vz6gIl",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.CustomerAsset), global::Google.Ads.GoogleAds.V7.Resources.CustomerAsset.Parser, new[]{ "ResourceName", "Asset", "FieldType", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between a customer and an asset.
  /// </summary>
  public sealed partial class CustomerAsset : pb::IMessage<CustomerAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerAsset> _parser = new pb::MessageParser<CustomerAsset>(() => new CustomerAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.CustomerAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset(CustomerAsset other) : this() {
      resourceName_ = other.resourceName_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset Clone() {
      return new CustomerAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer asset.
    /// CustomerAsset resource names have the form:
    ///
    /// `customers/{customer_id}/customerAssets/{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 2;
    private string asset_ = "";
    /// <summary>
    /// Required. Immutable. The asset which is linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Required. Immutable. Role that the asset takes for the customer link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// Status of the customer asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (Asset.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (Asset.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
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
          case 18: {
            Asset = input.ReadString();
            break;
          }
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V7.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
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
