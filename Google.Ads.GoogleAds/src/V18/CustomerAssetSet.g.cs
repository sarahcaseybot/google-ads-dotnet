// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/resources/customer_asset_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/resources/customer_asset_set.proto</summary>
  public static partial class CustomerAssetSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/resources/customer_asset_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerAssetSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2Fzc2V0X3NldC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4LnJl",
            "c291cmNlcxo6Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE4L2VudW1zL2Fzc2V0",
            "X3NldF9saW5rX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhh",
            "dmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKhAwoQQ3Vz",
            "dG9tZXJBc3NldFNldBJICg1yZXNvdXJjZV9uYW1lGAEgASgJQjHgQQX6QSsK",
            "KWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lckFzc2V0U2V0EjwK",
            "CWFzc2V0X3NldBgCIAEoCUIp4EEF+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb20vQXNzZXRTZXQSOwoIY3VzdG9tZXIYAyABKAlCKeBBBfpBIwohZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyEl4KBnN0YXR1cxgEIAEo",
            "DjJJLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lbnVtcy5Bc3NldFNldExp",
            "bmtTdGF0dXNFbnVtLkFzc2V0U2V0TGlua1N0YXR1c0ID4EEDOmjqQWUKKWdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lckFzc2V0U2V0EjhjdXN0",
            "b21lcnMve2N1c3RvbWVyX2lkfS9jdXN0b21lckFzc2V0U2V0cy97YXNzZXRf",
            "c2V0X2lkfUKHAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5yZXNv",
            "dXJjZXNCFUN1c3RvbWVyQXNzZXRTZXRQcm90b1ABWktnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE4L3Jl",
            "c291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMTguUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE4XFJl",
            "c291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxODo6UmVzb3Vy",
            "Y2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.CustomerAssetSet), global::Google.Ads.GoogleAds.V18.Resources.CustomerAssetSet.Parser, new[]{ "ResourceName", "AssetSet", "Customer", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CustomerAssetSet is the linkage between a customer and an asset set.
  /// Adding a CustomerAssetSet links an asset set with a customer.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CustomerAssetSet : pb::IMessage<CustomerAssetSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerAssetSet> _parser = new pb::MessageParser<CustomerAssetSet>(() => new CustomerAssetSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerAssetSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.CustomerAssetSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAssetSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAssetSet(CustomerAssetSet other) : this() {
      resourceName_ = other.resourceName_;
      assetSet_ = other.assetSet_;
      customer_ = other.customer_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAssetSet Clone() {
      return new CustomerAssetSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer asset set.
    /// Asset set asset resource names have the form:
    ///
    /// `customers/{customer_id}/customerAssetSets/{asset_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_set" field.</summary>
    public const int AssetSetFieldNumber = 2;
    private string assetSet_ = "";
    /// <summary>
    /// Immutable. The asset set which is linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetSet {
      get { return assetSet_; }
      set {
        assetSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer" field.</summary>
    public const int CustomerFieldNumber = 3;
    private string customer_ = "";
    /// <summary>
    /// Immutable. The customer to which this asset set is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Customer {
      get { return customer_; }
      set {
        customer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus status_ = global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the customer asset set asset. Read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerAssetSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerAssetSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AssetSet != other.AssetSet) return false;
      if (Customer != other.Customer) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AssetSet.Length != 0) hash ^= AssetSet.GetHashCode();
      if (Customer.Length != 0) hash ^= Customer.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (AssetSet.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetSet);
      }
      if (Customer.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Customer);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
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
      if (AssetSet.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetSet);
      }
      if (Customer.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Customer);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
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
      if (AssetSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetSet);
      }
      if (Customer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Customer);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerAssetSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AssetSet.Length != 0) {
        AssetSet = other.AssetSet;
      }
      if (other.Customer.Length != 0) {
        Customer = other.Customer;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
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
            AssetSet = input.ReadString();
            break;
          }
          case 26: {
            Customer = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
            AssetSet = input.ReadString();
            break;
          }
          case 26: {
            Customer = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
