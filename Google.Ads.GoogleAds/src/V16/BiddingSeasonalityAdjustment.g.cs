// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/bidding_seasonality_adjustment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/bidding_seasonality_adjustment.proto</summary>
  public static partial class BiddingSeasonalityAdjustmentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/bidding_seasonality_adjustment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingSeasonalityAdjustmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2JpZGRpbmdf",
            "c2Vhc29uYWxpdHlfYWRqdXN0bWVudC5wcm90bxIiZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjE2LnJlc291cmNlcxo9Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE2",
            "L2VudW1zL2FkdmVydGlzaW5nX2NoYW5uZWxfdHlwZS5wcm90bxorZ29vZ2xl",
            "L2Fkcy9nb29nbGVhZHMvdjE2L2VudW1zL2RldmljZS5wcm90bxo8Z29vZ2xl",
            "L2Fkcy9nb29nbGVhZHMvdjE2L2VudW1zL3NlYXNvbmFsaXR5X2V2ZW50X3Nj",
            "b3BlLnByb3RvGj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZW51bXMvc2Vh",
            "c29uYWxpdHlfZXZlbnRfc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIuQG",
            "ChxCaWRkaW5nU2Vhc29uYWxpdHlBZGp1c3RtZW50ElQKDXJlc291cmNlX25h",
            "bWUYASABKAlCPeBBBfpBNwo1Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Jp",
            "ZGRpbmdTZWFzb25hbGl0eUFkanVzdG1lbnQSJgoZc2Vhc29uYWxpdHlfYWRq",
            "dXN0bWVudF9pZBgCIAEoA0ID4EEDEl4KBXNjb3BlGAMgASgOMk8uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE2LmVudW1zLlNlYXNvbmFsaXR5RXZlbnRTY29w",
            "ZUVudW0uU2Vhc29uYWxpdHlFdmVudFNjb3BlEmYKBnN0YXR1cxgEIAEoDjJR",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5lbnVtcy5TZWFzb25hbGl0eUV2",
            "ZW50U3RhdHVzRW51bS5TZWFzb25hbGl0eUV2ZW50U3RhdHVzQgPgQQMSHAoP",
            "c3RhcnRfZGF0ZV90aW1lGAUgASgJQgPgQQISGgoNZW5kX2RhdGVfdGltZRgG",
            "IAEoCUID4EECEgwKBG5hbWUYByABKAkSEwoLZGVzY3JpcHRpb24YCCABKAkS",
            "QgoHZGV2aWNlcxgJIAMoDjIxLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5l",
            "bnVtcy5EZXZpY2VFbnVtLkRldmljZRIgChhjb252ZXJzaW9uX3JhdGVfbW9k",
            "aWZpZXIYCiABKAESOQoJY2FtcGFpZ25zGAsgAygJQib6QSMKIWdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbhJ0ChlhZHZlcnRpc2luZ19jaGFu",
            "bmVsX3R5cGVzGAwgAygOMlEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2LmVu",
            "dW1zLkFkdmVydGlzaW5nQ2hhbm5lbFR5cGVFbnVtLkFkdmVydGlzaW5nQ2hh",
            "bm5lbFR5cGU6iQHqQYUBCjVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQmlk",
            "ZGluZ1NlYXNvbmFsaXR5QWRqdXN0bWVudBJMY3VzdG9tZXJzL3tjdXN0b21l",
            "cl9pZH0vYmlkZGluZ1NlYXNvbmFsaXR5QWRqdXN0bWVudHMve3NlYXNvbmFs",
            "aXR5X2V2ZW50X2lkfUKTAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "Ni5yZXNvdXJjZXNCIUJpZGRpbmdTZWFzb25hbGl0eUFkanVzdG1lbnRQcm90",
            "b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjE2L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMTYuUmVzb3VyY2VzygIiR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjE2XFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxNjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V16.Enums.DeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeReflection.Descriptor, global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.BiddingSeasonalityAdjustment), global::Google.Ads.GoogleAds.V16.Resources.BiddingSeasonalityAdjustment.Parser, new[]{ "ResourceName", "SeasonalityAdjustmentId", "Scope", "Status", "StartDateTime", "EndDateTime", "Name", "Description", "Devices", "ConversionRateModifier", "Campaigns", "AdvertisingChannelTypes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a bidding seasonality adjustment.
  ///
  /// See "About seasonality adjustments" at
  /// https://support.google.com/google-ads/answer/10369906.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BiddingSeasonalityAdjustment : pb::IMessage<BiddingSeasonalityAdjustment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingSeasonalityAdjustment> _parser = new pb::MessageParser<BiddingSeasonalityAdjustment>(() => new BiddingSeasonalityAdjustment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BiddingSeasonalityAdjustment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.BiddingSeasonalityAdjustmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingSeasonalityAdjustment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingSeasonalityAdjustment(BiddingSeasonalityAdjustment other) : this() {
      resourceName_ = other.resourceName_;
      seasonalityAdjustmentId_ = other.seasonalityAdjustmentId_;
      scope_ = other.scope_;
      status_ = other.status_;
      startDateTime_ = other.startDateTime_;
      endDateTime_ = other.endDateTime_;
      name_ = other.name_;
      description_ = other.description_;
      devices_ = other.devices_.Clone();
      conversionRateModifier_ = other.conversionRateModifier_;
      campaigns_ = other.campaigns_.Clone();
      advertisingChannelTypes_ = other.advertisingChannelTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingSeasonalityAdjustment Clone() {
      return new BiddingSeasonalityAdjustment(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the seasonality adjustment.
    /// Seasonality adjustment resource names have the form:
    ///
    /// `customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_adjustment_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "seasonality_adjustment_id" field.</summary>
    public const int SeasonalityAdjustmentIdFieldNumber = 2;
    private long seasonalityAdjustmentId_;
    /// <summary>
    /// Output only. The ID of the seasonality adjustment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SeasonalityAdjustmentId {
      get { return seasonalityAdjustmentId_; }
      set {
        seasonalityAdjustmentId_ = value;
      }
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope scope_ = global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified;
    /// <summary>
    /// The scope of the seasonality adjustment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus status_ = global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the seasonality adjustment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "start_date_time" field.</summary>
    public const int StartDateTimeFieldNumber = 5;
    private string startDateTime_ = "";
    /// <summary>
    /// Required. The inclusive start time of the seasonality adjustment in
    /// yyyy-MM-dd HH:mm:ss format.
    ///
    /// A seasonality adjustment is forward looking and should be used for events
    /// that start and end in the future.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDateTime {
      get { return startDateTime_; }
      set {
        startDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_date_time" field.</summary>
    public const int EndDateTimeFieldNumber = 6;
    private string endDateTime_ = "";
    /// <summary>
    /// Required. The exclusive end time of the seasonality adjustment in
    /// yyyy-MM-dd HH:mm:ss format.
    ///
    /// The length of [start_date_time, end_date_time) interval must be
    /// within (0, 14 days].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDateTime {
      get { return endDateTime_; }
      set {
        endDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 7;
    private string name_ = "";
    /// <summary>
    /// The name of the seasonality adjustment. The name can be at most 255
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 8;
    private string description_ = "";
    /// <summary>
    /// The description of the seasonality adjustment. The description can be at
    /// most 2048 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "devices" field.</summary>
    public const int DevicesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V16.Enums.DeviceEnum.Types.Device> _repeated_devices_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Google.Ads.GoogleAds.V16.Enums.DeviceEnum.Types.Device) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.DeviceEnum.Types.Device> devices_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.DeviceEnum.Types.Device>();
    /// <summary>
    /// If not specified, all devices will be included in this adjustment.
    /// Otherwise, only the specified targeted devices will be included in this
    /// adjustment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.DeviceEnum.Types.Device> Devices {
      get { return devices_; }
    }

    /// <summary>Field number for the "conversion_rate_modifier" field.</summary>
    public const int ConversionRateModifierFieldNumber = 10;
    private double conversionRateModifier_;
    /// <summary>
    /// Conversion rate modifier estimated based on expected conversion rate
    /// changes. When this field is unset or set to 1.0 no adjustment will be
    /// applied to traffic. The allowed range is 0.1 to 10.0.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double ConversionRateModifier {
      get { return conversionRateModifier_; }
      set {
        conversionRateModifier_ = value;
      }
    }

    /// <summary>Field number for the "campaigns" field.</summary>
    public const int CampaignsFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _repeated_campaigns_codec
        = pb::FieldCodec.ForString(90);
    private readonly pbc::RepeatedField<string> campaigns_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The seasonality adjustment will apply to the campaigns listed when the
    /// scope of this adjustment is CAMPAIGN. The maximum number of campaigns per
    /// event is 2000.
    /// Note: a seasonality adjustment with both advertising_channel_types and
    /// campaign_ids is not supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Campaigns {
      get { return campaigns_; }
    }

    /// <summary>Field number for the "advertising_channel_types" field.</summary>
    public const int AdvertisingChannelTypesFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> _repeated_advertisingChannelTypes_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> advertisingChannelTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType>();
    /// <summary>
    /// The seasonality adjustment will apply to all the campaigns under the listed
    /// channels retroactively as well as going forward when the scope of this
    /// adjustment is CHANNEL.
    /// The supported advertising channel types are DISPLAY, SEARCH and SHOPPING.
    /// Note: a seasonality adjustment with both advertising_channel_types and
    /// campaign_ids is not supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V16.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> AdvertisingChannelTypes {
      get { return advertisingChannelTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BiddingSeasonalityAdjustment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BiddingSeasonalityAdjustment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SeasonalityAdjustmentId != other.SeasonalityAdjustmentId) return false;
      if (Scope != other.Scope) return false;
      if (Status != other.Status) return false;
      if (StartDateTime != other.StartDateTime) return false;
      if (EndDateTime != other.EndDateTime) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if(!devices_.Equals(other.devices_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConversionRateModifier, other.ConversionRateModifier)) return false;
      if(!campaigns_.Equals(other.campaigns_)) return false;
      if(!advertisingChannelTypes_.Equals(other.advertisingChannelTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (SeasonalityAdjustmentId != 0L) hash ^= SeasonalityAdjustmentId.GetHashCode();
      if (Scope != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) hash ^= Scope.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) hash ^= Status.GetHashCode();
      if (StartDateTime.Length != 0) hash ^= StartDateTime.GetHashCode();
      if (EndDateTime.Length != 0) hash ^= EndDateTime.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= devices_.GetHashCode();
      if (ConversionRateModifier != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConversionRateModifier);
      hash ^= campaigns_.GetHashCode();
      hash ^= advertisingChannelTypes_.GetHashCode();
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
      if (SeasonalityAdjustmentId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SeasonalityAdjustmentId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (StartDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDateTime);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      devices_.WriteTo(output, _repeated_devices_codec);
      if (ConversionRateModifier != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(ConversionRateModifier);
      }
      campaigns_.WriteTo(output, _repeated_campaigns_codec);
      advertisingChannelTypes_.WriteTo(output, _repeated_advertisingChannelTypes_codec);
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
      if (SeasonalityAdjustmentId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SeasonalityAdjustmentId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (StartDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDateTime);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      devices_.WriteTo(ref output, _repeated_devices_codec);
      if (ConversionRateModifier != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(ConversionRateModifier);
      }
      campaigns_.WriteTo(ref output, _repeated_campaigns_codec);
      advertisingChannelTypes_.WriteTo(ref output, _repeated_advertisingChannelTypes_codec);
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
      if (SeasonalityAdjustmentId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SeasonalityAdjustmentId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (StartDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDateTime);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += devices_.CalculateSize(_repeated_devices_codec);
      if (ConversionRateModifier != 0D) {
        size += 1 + 8;
      }
      size += campaigns_.CalculateSize(_repeated_campaigns_codec);
      size += advertisingChannelTypes_.CalculateSize(_repeated_advertisingChannelTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BiddingSeasonalityAdjustment other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.SeasonalityAdjustmentId != 0L) {
        SeasonalityAdjustmentId = other.SeasonalityAdjustmentId;
      }
      if (other.Scope != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        Scope = other.Scope;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.StartDateTime.Length != 0) {
        StartDateTime = other.StartDateTime;
      }
      if (other.EndDateTime.Length != 0) {
        EndDateTime = other.EndDateTime;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      devices_.Add(other.devices_);
      if (other.ConversionRateModifier != 0D) {
        ConversionRateModifier = other.ConversionRateModifier;
      }
      campaigns_.Add(other.campaigns_);
      advertisingChannelTypes_.Add(other.advertisingChannelTypes_);
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
          case 16: {
            SeasonalityAdjustmentId = input.ReadInt64();
            break;
          }
          case 24: {
            Scope = (global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus) input.ReadEnum();
            break;
          }
          case 42: {
            StartDateTime = input.ReadString();
            break;
          }
          case 50: {
            EndDateTime = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74:
          case 72: {
            devices_.AddEntriesFrom(input, _repeated_devices_codec);
            break;
          }
          case 81: {
            ConversionRateModifier = input.ReadDouble();
            break;
          }
          case 90: {
            campaigns_.AddEntriesFrom(input, _repeated_campaigns_codec);
            break;
          }
          case 98:
          case 96: {
            advertisingChannelTypes_.AddEntriesFrom(input, _repeated_advertisingChannelTypes_codec);
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
          case 16: {
            SeasonalityAdjustmentId = input.ReadInt64();
            break;
          }
          case 24: {
            Scope = (global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V16.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus) input.ReadEnum();
            break;
          }
          case 42: {
            StartDateTime = input.ReadString();
            break;
          }
          case 50: {
            EndDateTime = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74:
          case 72: {
            devices_.AddEntriesFrom(ref input, _repeated_devices_codec);
            break;
          }
          case 81: {
            ConversionRateModifier = input.ReadDouble();
            break;
          }
          case 90: {
            campaigns_.AddEntriesFrom(ref input, _repeated_campaigns_codec);
            break;
          }
          case 98:
          case 96: {
            advertisingChannelTypes_.AddEntriesFrom(ref input, _repeated_advertisingChannelTypes_codec);
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
