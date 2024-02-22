// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/campaign_bid_modifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/campaign_bid_modifier.proto</summary>
  public static partial class CampaignBidModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/campaign_bid_modifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignBidModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X2JpZF9tb2RpZmllci5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2",
            "LnJlc291cmNlcxouZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE2L2NvbW1vbi9j",
            "cml0ZXJpYS5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLwAwoTQ2FtcGFpZ25CaWRN",
            "b2RpZmllchJLCg1yZXNvdXJjZV9uYW1lGAEgASgJQjTgQQX6QS4KLGdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkJpZE1vZGlmaWVyEkAKCGNh",
            "bXBhaWduGAYgASgJQingQQP6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DYW1wYWlnbkgBiAEBEh4KDGNyaXRlcmlvbl9pZBgHIAEoA0ID4EEDSAKI",
            "AQESGQoMYmlkX21vZGlmaWVyGAggASgBSAOIAQESVQoQaW50ZXJhY3Rpb25f",
            "dHlwZRgFIAEoCzI0Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5jb21tb24u",
            "SW50ZXJhY3Rpb25UeXBlSW5mb0ID4EEFSAA6fOpBeQosZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0NhbXBhaWduQmlkTW9kaWZpZXISSWN1c3RvbWVycy97",
            "Y3VzdG9tZXJfaWR9L2NhbXBhaWduQmlkTW9kaWZpZXJzL3tjYW1wYWlnbl9p",
            "ZH1+e2NyaXRlcmlvbl9pZH1CCwoJY3JpdGVyaW9uQgsKCV9jYW1wYWlnbkIP",
            "Cg1fY3JpdGVyaW9uX2lkQg8KDV9iaWRfbW9kaWZpZXJCigIKJmNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTYucmVzb3VyY2VzQhhDYW1wYWlnbkJpZE1v",
            "ZGlmaWVyUHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNi9yZXNvdXJjZXM7cmVzb3VyY2Vz",
            "ogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE2LlJlc291cmNlc8oC",
            "Ikdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNlxSZXNvdXJjZXPqAiZHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMTY6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V16.Common.CriteriaReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.CampaignBidModifier), global::Google.Ads.GoogleAds.V16.Resources.CampaignBidModifier.Parser, new[]{ "ResourceName", "Campaign", "CriterionId", "BidModifier", "InteractionType" }, new[]{ "Criterion", "Campaign", "CriterionId", "BidModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a bid-modifiable only criterion at the campaign level.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignBidModifier : pb::IMessage<CampaignBidModifier>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignBidModifier> _parser = new pb::MessageParser<CampaignBidModifier>(() => new CampaignBidModifier());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignBidModifier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.CampaignBidModifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBidModifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBidModifier(CampaignBidModifier other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      criterionId_ = other.criterionId_;
      bidModifier_ = other.bidModifier_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.InteractionType:
          InteractionType = other.InteractionType.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBidModifier Clone() {
      return new CampaignBidModifier(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign bid modifier.
    /// Campaign bid modifier resource names have the form:
    ///
    /// `customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 6;
    private readonly static string CampaignDefaultValue = "";

    private string campaign_;
    /// <summary>
    /// Output only. The campaign to which this criterion belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? CampaignDefaultValue; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 7;
    private readonly static long CriterionIdDefaultValue = 0L;

    private long criterionId_;
    /// <summary>
    /// Output only. The ID of the criterion to bid modify.
    ///
    /// This field is ignored for mutates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CriterionId {
      get { if ((_hasBits0 & 1) != 0) { return criterionId_; } else { return CriterionIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        criterionId_ = value;
      }
    }
    /// <summary>Gets whether the "criterion_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCriterionId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "criterion_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCriterionId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "bid_modifier" field.</summary>
    public const int BidModifierFieldNumber = 8;
    private readonly static double BidModifierDefaultValue = 0D;

    private double bidModifier_;
    /// <summary>
    /// The modifier for the bid when the criterion matches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double BidModifier {
      get { if ((_hasBits0 & 2) != 0) { return bidModifier_; } else { return BidModifierDefaultValue; } }
      set {
        _hasBits0 |= 2;
        bidModifier_ = value;
      }
    }
    /// <summary>Gets whether the "bid_modifier" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBidModifier {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "bid_modifier" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBidModifier() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "interaction_type" field.</summary>
    public const int InteractionTypeFieldNumber = 5;
    /// <summary>
    /// Immutable. Criterion for interaction type. Only supported for search
    /// campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo InteractionType {
      get { return criterionCase_ == CriterionOneofCase.InteractionType ? (global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.InteractionType;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      InteractionType = 5,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignBidModifier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignBidModifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (CriterionId != other.CriterionId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BidModifier, other.BidModifier)) return false;
      if (!object.Equals(InteractionType, other.InteractionType)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasCriterionId) hash ^= CriterionId.GetHashCode();
      if (HasBidModifier) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BidModifier);
      if (criterionCase_ == CriterionOneofCase.InteractionType) hash ^= InteractionType.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (criterionCase_ == CriterionOneofCase.InteractionType) {
        output.WriteRawTag(42);
        output.WriteMessage(InteractionType);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      if (HasCriterionId) {
        output.WriteRawTag(56);
        output.WriteInt64(CriterionId);
      }
      if (HasBidModifier) {
        output.WriteRawTag(65);
        output.WriteDouble(BidModifier);
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
      if (criterionCase_ == CriterionOneofCase.InteractionType) {
        output.WriteRawTag(42);
        output.WriteMessage(InteractionType);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      if (HasCriterionId) {
        output.WriteRawTag(56);
        output.WriteInt64(CriterionId);
      }
      if (HasBidModifier) {
        output.WriteRawTag(65);
        output.WriteDouble(BidModifier);
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
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasCriterionId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CriterionId);
      }
      if (HasBidModifier) {
        size += 1 + 8;
      }
      if (criterionCase_ == CriterionOneofCase.InteractionType) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InteractionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignBidModifier other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasCriterionId) {
        CriterionId = other.CriterionId;
      }
      if (other.HasBidModifier) {
        BidModifier = other.BidModifier;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.InteractionType:
          if (InteractionType == null) {
            InteractionType = new global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo();
          }
          InteractionType.MergeFrom(other.InteractionType);
          break;
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
          case 42: {
            global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo subBuilder = new global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo();
            if (criterionCase_ == CriterionOneofCase.InteractionType) {
              subBuilder.MergeFrom(InteractionType);
            }
            input.ReadMessage(subBuilder);
            InteractionType = subBuilder;
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 56: {
            CriterionId = input.ReadInt64();
            break;
          }
          case 65: {
            BidModifier = input.ReadDouble();
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
          case 42: {
            global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo subBuilder = new global::Google.Ads.GoogleAds.V16.Common.InteractionTypeInfo();
            if (criterionCase_ == CriterionOneofCase.InteractionType) {
              subBuilder.MergeFrom(InteractionType);
            }
            input.ReadMessage(subBuilder);
            InteractionType = subBuilder;
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 56: {
            CriterionId = input.ReadInt64();
            break;
          }
          case 65: {
            BidModifier = input.ReadDouble();
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
