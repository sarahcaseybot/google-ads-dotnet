// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/campaign_search_term_insight.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/campaign_search_term_insight.proto</summary>
  public static partial class CampaignSearchTermInsightReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/campaign_search_term_insight.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSearchTermInsightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X3NlYXJjaF90ZXJtX2luc2lnaHQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNi5yZXNvdXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8i+QIKGUNhbXBhaWdu",
            "U2VhcmNoVGVybUluc2lnaHQSUQoNcmVzb3VyY2VfbmFtZRgBIAEoCUI64EED",
            "+kE0CjJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25TZWFyY2hU",
            "ZXJtSW5zaWdodBIgCg5jYXRlZ29yeV9sYWJlbBgCIAEoCUID4EEDSACIAQES",
            "FAoCaWQYAyABKANCA+BBA0gBiAEBEh0KC2NhbXBhaWduX2lkGAQgASgDQgPg",
            "QQNIAogBATqHAepBgwEKMmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1w",
            "YWlnblNlYXJjaFRlcm1JbnNpZ2h0Ek1jdXN0b21lcnMve2N1c3RvbWVyX2lk",
            "fS9jYW1wYWlnblNlYXJjaFRlcm1JbnNpZ2h0cy97Y2FtcGFpZ25faWR9fntj",
            "bHVzdGVyX2lkfUIRCg9fY2F0ZWdvcnlfbGFiZWxCBQoDX2lkQg4KDF9jYW1w",
            "YWlnbl9pZEKQAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5yZXNv",
            "dXJjZXNCHkNhbXBhaWduU2VhcmNoVGVybUluc2lnaHRQcm90b1ABWktnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjE2L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMTYuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjE2XFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "Njo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.CampaignSearchTermInsight), global::Google.Ads.GoogleAds.V16.Resources.CampaignSearchTermInsight.Parser, new[]{ "ResourceName", "CategoryLabel", "Id", "CampaignId" }, new[]{ "CategoryLabel", "Id", "CampaignId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Campaign search term view.
  /// Historical data is available starting March 2023.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignSearchTermInsight : pb::IMessage<CampaignSearchTermInsight>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignSearchTermInsight> _parser = new pb::MessageParser<CampaignSearchTermInsight>(() => new CampaignSearchTermInsight());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignSearchTermInsight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.CampaignSearchTermInsightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSearchTermInsight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSearchTermInsight(CampaignSearchTermInsight other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      categoryLabel_ = other.categoryLabel_;
      id_ = other.id_;
      campaignId_ = other.campaignId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSearchTermInsight Clone() {
      return new CampaignSearchTermInsight(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the campaign level search term insight.
    /// Campaign level search term insight resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSearchTermInsights/{campaign_id}~{category_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category_label" field.</summary>
    public const int CategoryLabelFieldNumber = 2;
    private readonly static string CategoryLabelDefaultValue = "";

    private string categoryLabel_;
    /// <summary>
    /// Output only. The label for the search category. An empty string denotes the
    /// catch-all category for search terms that didn't fit into another category.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CategoryLabel {
      get { return categoryLabel_ ?? CategoryLabelDefaultValue; }
      set {
        categoryLabel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "category_label" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCategoryLabel {
      get { return categoryLabel_ != null; }
    }
    /// <summary>Clears the value of the "category_label" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCategoryLabel() {
      categoryLabel_ = null;
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private readonly static long IdDefaultValue = 0L;

    private long id_;
    /// <summary>
    /// Output only. The ID of the insight.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 4;
    private readonly static long CampaignIdDefaultValue = 0L;

    private long campaignId_;
    /// <summary>
    /// Output only. The ID of the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CampaignId {
      get { if ((_hasBits0 & 2) != 0) { return campaignId_; } else { return CampaignIdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        campaignId_ = value;
      }
    }
    /// <summary>Gets whether the "campaign_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaignId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "campaign_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaignId() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignSearchTermInsight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignSearchTermInsight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CategoryLabel != other.CategoryLabel) return false;
      if (Id != other.Id) return false;
      if (CampaignId != other.CampaignId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCategoryLabel) hash ^= CategoryLabel.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasCampaignId) hash ^= CampaignId.GetHashCode();
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
      if (HasCategoryLabel) {
        output.WriteRawTag(18);
        output.WriteString(CategoryLabel);
      }
      if (HasId) {
        output.WriteRawTag(24);
        output.WriteInt64(Id);
      }
      if (HasCampaignId) {
        output.WriteRawTag(32);
        output.WriteInt64(CampaignId);
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
      if (HasCategoryLabel) {
        output.WriteRawTag(18);
        output.WriteString(CategoryLabel);
      }
      if (HasId) {
        output.WriteRawTag(24);
        output.WriteInt64(Id);
      }
      if (HasCampaignId) {
        output.WriteRawTag(32);
        output.WriteInt64(CampaignId);
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
      if (HasCategoryLabel) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CategoryLabel);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasCampaignId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CampaignId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignSearchTermInsight other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCategoryLabel) {
        CategoryLabel = other.CategoryLabel;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasCampaignId) {
        CampaignId = other.CampaignId;
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
            CategoryLabel = input.ReadString();
            break;
          }
          case 24: {
            Id = input.ReadInt64();
            break;
          }
          case 32: {
            CampaignId = input.ReadInt64();
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
            CategoryLabel = input.ReadString();
            break;
          }
          case 24: {
            Id = input.ReadInt64();
            break;
          }
          case 32: {
            CampaignId = input.ReadInt64();
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
