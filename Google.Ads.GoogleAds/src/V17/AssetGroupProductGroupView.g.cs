// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/resources/asset_group_product_group_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/resources/asset_group_product_group_view.proto</summary>
  public static partial class AssetGroupProductGroupViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/resources/asset_group_product_group_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupProductGroupViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwX3Byb2R1Y3RfZ3JvdXBfdmlldy5wcm90bxIiZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjE3LnJlc291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byK3AwoaQXNzZXRH",
            "cm91cFByb2R1Y3RHcm91cFZpZXcSUgoNcmVzb3VyY2VfbmFtZRgBIAEoCUI7",
            "4EED+kE1CjNnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRHcm91cFBy",
            "b2R1Y3RHcm91cFZpZXcSQAoLYXNzZXRfZ3JvdXAYAiABKAlCK+BBA/pBJQoj",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Fzc2V0R3JvdXASZwogYXNzZXRf",
            "Z3JvdXBfbGlzdGluZ19ncm91cF9maWx0ZXIYBCABKAlCPeBBA/pBNwo1Z29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0Fzc2V0R3JvdXBMaXN0aW5nR3JvdXBG",
            "aWx0ZXI6mQHqQZUBCjNnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRH",
            "cm91cFByb2R1Y3RHcm91cFZpZXcSXmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9",
            "L2Fzc2V0R3JvdXBQcm9kdWN0R3JvdXBWaWV3cy97YXNzZXRfZ3JvdXBfaWR9",
            "fntsaXN0aW5nX2dyb3VwX2ZpbHRlcl9pZH1CkQIKJmNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTcucmVzb3VyY2VzQh9Bc3NldEdyb3VwUHJvZHVjdEdy",
            "b3VwVmlld1Byb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTcvcmVzb3VyY2VzO3Jlc291cmNl",
            "c6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNy5SZXNvdXJjZXPK",
            "AiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTdcUmVzb3VyY2Vz6gImR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjE3OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Resources.AssetGroupProductGroupView), global::Google.Ads.GoogleAds.V17.Resources.AssetGroupProductGroupView.Parser, new[]{ "ResourceName", "AssetGroup", "AssetGroupListingGroupFilter" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An asset group product group view.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetGroupProductGroupView : pb::IMessage<AssetGroupProductGroupView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupProductGroupView> _parser = new pb::MessageParser<AssetGroupProductGroupView>(() => new AssetGroupProductGroupView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupProductGroupView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Resources.AssetGroupProductGroupViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupProductGroupView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupProductGroupView(AssetGroupProductGroupView other) : this() {
      resourceName_ = other.resourceName_;
      assetGroup_ = other.assetGroup_;
      assetGroupListingGroupFilter_ = other.assetGroupListingGroupFilter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupProductGroupView Clone() {
      return new AssetGroupProductGroupView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the asset group product group view.
    /// Asset group product group view resource names have the form:
    ///
    /// `customers/{customer_id}/assetGroupProductGroupViews/{asset_group_id}~{listing_group_filter_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_group" field.</summary>
    public const int AssetGroupFieldNumber = 2;
    private string assetGroup_ = "";
    /// <summary>
    /// Output only. The asset group associated with the listing group filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetGroup {
      get { return assetGroup_; }
      set {
        assetGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_group_listing_group_filter" field.</summary>
    public const int AssetGroupListingGroupFilterFieldNumber = 4;
    private string assetGroupListingGroupFilter_ = "";
    /// <summary>
    /// Output only. The resource name of the asset group listing group filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetGroupListingGroupFilter {
      get { return assetGroupListingGroupFilter_; }
      set {
        assetGroupListingGroupFilter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupProductGroupView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupProductGroupView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AssetGroup != other.AssetGroup) return false;
      if (AssetGroupListingGroupFilter != other.AssetGroupListingGroupFilter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AssetGroup.Length != 0) hash ^= AssetGroup.GetHashCode();
      if (AssetGroupListingGroupFilter.Length != 0) hash ^= AssetGroupListingGroupFilter.GetHashCode();
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
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (AssetGroupListingGroupFilter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AssetGroupListingGroupFilter);
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
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (AssetGroupListingGroupFilter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AssetGroupListingGroupFilter);
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
      if (AssetGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetGroup);
      }
      if (AssetGroupListingGroupFilter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetGroupListingGroupFilter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroupProductGroupView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AssetGroup.Length != 0) {
        AssetGroup = other.AssetGroup;
      }
      if (other.AssetGroupListingGroupFilter.Length != 0) {
        AssetGroupListingGroupFilter = other.AssetGroupListingGroupFilter;
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
            AssetGroup = input.ReadString();
            break;
          }
          case 34: {
            AssetGroupListingGroupFilter = input.ReadString();
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
            AssetGroup = input.ReadString();
            break;
          }
          case 34: {
            AssetGroupListingGroupFilter = input.ReadString();
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
