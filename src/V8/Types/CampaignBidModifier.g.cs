// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/campaign_bid_modifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/campaign_bid_modifier.proto</summary>
  public static partial class CampaignBidModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/campaign_bid_modifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignBidModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "YmlkX21vZGlmaWVyLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52OC5y",
            "ZXNvdXJjZXMaLWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y4L2NvbW1vbi9jcml0",
            "ZXJpYS5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZ",
            "Z29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90byLvAwoTQ2FtcGFpZ25CaWRNb2RpZmllchJLCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjTgQQX6QS4KLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DYW1wYWlnbkJpZE1vZGlmaWVyEkAKCGNhbXBhaWduGAYgASgJQingQQP6",
            "QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkgBiAEBEh4K",
            "DGNyaXRlcmlvbl9pZBgHIAEoA0ID4EEDSAKIAQESGQoMYmlkX21vZGlmaWVy",
            "GAggASgBSAOIAQESVAoQaW50ZXJhY3Rpb25fdHlwZRgFIAEoCzIzLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY4LmNvbW1vbi5JbnRlcmFjdGlvblR5cGVJbmZv",
            "QgPgQQVIADp86kF5Cixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFp",
            "Z25CaWRNb2RpZmllchJJY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vY2FtcGFp",
            "Z25CaWRNb2RpZmllcnMve2NhbXBhaWduX2lkfX57Y3JpdGVyaW9uX2lkfUIL",
            "Cgljcml0ZXJpb25CCwoJX2NhbXBhaWduQg8KDV9jcml0ZXJpb25faWRCDwoN",
            "X2JpZF9tb2RpZmllckKFAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4",
            "LnJlc291cmNlc0IYQ2FtcGFpZ25CaWRNb2RpZmllclByb3RvUAFaSmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92OC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjguUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjhcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Common.CriteriaReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.CampaignBidModifier), global::Google.Ads.GoogleAds.V8.Resources.CampaignBidModifier.Parser, new[]{ "ResourceName", "Campaign", "CriterionId", "BidModifier", "InteractionType" }, new[]{ "Criterion", "Campaign", "CriterionId", "BidModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a bid-modifiable only criterion at the campaign level.
  /// </summary>
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
      get { return global::Google.Ads.GoogleAds.V8.Resources.CampaignBidModifierReflection.Descriptor.MessageTypes[0]; }
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
    private string campaign_;
    /// <summary>
    /// Output only. The campaign to which this criterion belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? ""; }
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
    private long criterionId_;
    /// <summary>
    /// Output only. The ID of the criterion to bid modify.
    ///
    /// This field is ignored for mutates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CriterionId {
      get { if ((_hasBits0 & 1) != 0) { return criterionId_; } else { return 0L; } }
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
    private double bidModifier_;
    /// <summary>
    /// The modifier for the bid when the criterion matches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double BidModifier {
      get { if ((_hasBits0 & 2) != 0) { return bidModifier_; } else { return 0D; } }
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
    /// Immutable. Criterion for interaction type. Only supported for search campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo InteractionType {
      get { return criterionCase_ == CriterionOneofCase.InteractionType ? (global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo) criterion_ : null; }
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
            InteractionType = new global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo();
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
            global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo subBuilder = new global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo();
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
            global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo subBuilder = new global::Google.Ads.GoogleAds.V8.Common.InteractionTypeInfo();
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
