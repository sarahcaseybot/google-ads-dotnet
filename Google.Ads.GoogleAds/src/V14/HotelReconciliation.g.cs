// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/resources/hotel_reconciliation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/resources/hotel_reconciliation.proto</summary>
  public static partial class HotelReconciliationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/resources/hotel_reconciliation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelReconciliationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvcmVzb3VyY2VzL2hvdGVsX3Jl",
            "Y29uY2lsaWF0aW9uLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTQu",
            "cmVzb3VyY2VzGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvaG90",
            "ZWxfcmVjb25jaWxpYXRpb25fc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "IuMEChNIb3RlbFJlY29uY2lsaWF0aW9uEksKDXJlc291cmNlX25hbWUYASAB",
            "KAlCNOBBBfpBLgosZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0hvdGVsUmVj",
            "b25jaWxpYXRpb24SHQoNY29tbWlzc2lvbl9pZBgCIAEoCUIG4EEC4EEDEhUK",
            "CG9yZGVyX2lkGAMgASgJQgPgQQMSOwoIY2FtcGFpZ24YCyABKAlCKeBBA/pB",
            "IwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduEhwKD2hvdGVs",
            "X2NlbnRlcl9pZBgEIAEoA0ID4EEDEhUKCGhvdGVsX2lkGAUgASgJQgPgQQMS",
            "GgoNY2hlY2tfaW5fZGF0ZRgGIAEoCUID4EEDEhsKDmNoZWNrX291dF9kYXRl",
            "GAcgASgJQgPgQQMSJwoXcmVjb25jaWxlZF92YWx1ZV9taWNyb3MYCCABKANC",
            "BuBBAuBBAxITCgZiaWxsZWQYCSABKAhCA+BBAxJvCgZzdGF0dXMYCiABKA4y",
            "Vy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQuZW51bXMuSG90ZWxSZWNvbmNp",
            "bGlhdGlvblN0YXR1c0VudW0uSG90ZWxSZWNvbmNpbGlhdGlvblN0YXR1c0IG",
            "4EEC4EEDOm/qQWwKLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Ib3RlbFJl",
            "Y29uY2lsaWF0aW9uEjxjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9ob3RlbFJl",
            "Y29uY2lsaWF0aW9ucy97Y29tbWlzc2lvbl9pZH1CigIKJmNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MTQucmVzb3VyY2VzQhhIb3RlbFJlY29uY2lsaWF0",
            "aW9uUHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxNC9yZXNvdXJjZXM7cmVzb3VyY2VzogID",
            "R0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE0LlJlc291cmNlc8oCIkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYxNFxSZXNvdXJjZXPqAiZHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTQ6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Resources.HotelReconciliation), global::Google.Ads.GoogleAds.V14.Resources.HotelReconciliation.Parser, new[]{ "ResourceName", "CommissionId", "OrderId", "Campaign", "HotelCenterId", "HotelId", "CheckInDate", "CheckOutDate", "ReconciledValueMicros", "Billed", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A hotel reconciliation. It contains conversion information from Hotel
  /// bookings to reconcile with advertiser records. These rows may be updated
  /// or canceled before billing through Bulk Uploads.
  /// </summary>
  public sealed partial class HotelReconciliation : pb::IMessage<HotelReconciliation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotelReconciliation> _parser = new pb::MessageParser<HotelReconciliation>(() => new HotelReconciliation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HotelReconciliation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Resources.HotelReconciliationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliation(HotelReconciliation other) : this() {
      resourceName_ = other.resourceName_;
      commissionId_ = other.commissionId_;
      orderId_ = other.orderId_;
      campaign_ = other.campaign_;
      hotelCenterId_ = other.hotelCenterId_;
      hotelId_ = other.hotelId_;
      checkInDate_ = other.checkInDate_;
      checkOutDate_ = other.checkOutDate_;
      reconciledValueMicros_ = other.reconciledValueMicros_;
      billed_ = other.billed_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliation Clone() {
      return new HotelReconciliation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the hotel reconciliation.
    /// Hotel reconciliation resource names have the form:
    ///
    /// `customers/{customer_id}/hotelReconciliations/{commission_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "commission_id" field.</summary>
    public const int CommissionIdFieldNumber = 2;
    private string commissionId_ = "";
    /// <summary>
    /// Required. Output only. The commission ID is Google's ID for this booking.
    /// Every booking event is assigned a Commission ID to help you match it to a
    /// guest stay.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CommissionId {
      get { return commissionId_; }
      set {
        commissionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "order_id" field.</summary>
    public const int OrderIdFieldNumber = 3;
    private string orderId_ = "";
    /// <summary>
    /// Output only. The order ID is the identifier for this booking as provided in
    /// the 'transaction_id' parameter of the conversion tracking tag.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OrderId {
      get { return orderId_; }
      set {
        orderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 11;
    private string campaign_ = "";
    /// <summary>
    /// Output only. The resource name for the Campaign associated with the
    /// conversion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hotel_center_id" field.</summary>
    public const int HotelCenterIdFieldNumber = 4;
    private long hotelCenterId_;
    /// <summary>
    /// Output only. Identifier for the Hotel Center account which provides the
    /// rates for the Hotel campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HotelCenterId {
      get { return hotelCenterId_; }
      set {
        hotelCenterId_ = value;
      }
    }

    /// <summary>Field number for the "hotel_id" field.</summary>
    public const int HotelIdFieldNumber = 5;
    private string hotelId_ = "";
    /// <summary>
    /// Output only. Unique identifier for the booked property, as provided in the
    /// Hotel Center feed. The hotel ID comes from the 'ID' parameter of the
    /// conversion tracking tag.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HotelId {
      get { return hotelId_; }
      set {
        hotelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "check_in_date" field.</summary>
    public const int CheckInDateFieldNumber = 6;
    private string checkInDate_ = "";
    /// <summary>
    /// Output only. Check-in date recorded when the booking is made. If the
    /// check-in date is modified at reconciliation, the revised date will then
    /// take the place of the original date in this column. Format is YYYY-MM-DD.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CheckInDate {
      get { return checkInDate_; }
      set {
        checkInDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "check_out_date" field.</summary>
    public const int CheckOutDateFieldNumber = 7;
    private string checkOutDate_ = "";
    /// <summary>
    /// Output only. Check-out date recorded when the booking is made. If the
    /// check-in date is modified at reconciliation, the revised date will then
    /// take the place of the original date in this column. Format is YYYY-MM-DD.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CheckOutDate {
      get { return checkOutDate_; }
      set {
        checkOutDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reconciled_value_micros" field.</summary>
    public const int ReconciledValueMicrosFieldNumber = 8;
    private long reconciledValueMicros_;
    /// <summary>
    /// Required. Output only. Reconciled value is the final value of a booking as
    /// paid by the guest. If original booking value changes for any reason, such
    /// as itinerary changes or room upsells, the reconciled value should be the
    /// full final amount collected. If a booking is canceled, the reconciled value
    /// should include the value of any cancellation fees or non-refundable nights
    /// charged. Value is in millionths of the base unit currency. For example,
    /// $12.35 would be represented as 12350000. Currency unit is in the default
    /// customer currency.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ReconciledValueMicros {
      get { return reconciledValueMicros_; }
      set {
        reconciledValueMicros_ = value;
      }
    }

    /// <summary>Field number for the "billed" field.</summary>
    public const int BilledFieldNumber = 9;
    private bool billed_;
    /// <summary>
    /// Output only. Whether a given booking has been billed. Once billed, a
    /// booking can't be modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Billed {
      get { return billed_; }
      set {
        billed_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 10;
    private global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus status_ = global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified;
    /// <summary>
    /// Required. Output only. Current status of a booking with regards to
    /// reconciliation and billing. Bookings should be reconciled within 45 days
    /// after the check-out date. Any booking not reconciled within 45 days will be
    /// billed at its original value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HotelReconciliation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HotelReconciliation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CommissionId != other.CommissionId) return false;
      if (OrderId != other.OrderId) return false;
      if (Campaign != other.Campaign) return false;
      if (HotelCenterId != other.HotelCenterId) return false;
      if (HotelId != other.HotelId) return false;
      if (CheckInDate != other.CheckInDate) return false;
      if (CheckOutDate != other.CheckOutDate) return false;
      if (ReconciledValueMicros != other.ReconciledValueMicros) return false;
      if (Billed != other.Billed) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CommissionId.Length != 0) hash ^= CommissionId.GetHashCode();
      if (OrderId.Length != 0) hash ^= OrderId.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (HotelCenterId != 0L) hash ^= HotelCenterId.GetHashCode();
      if (HotelId.Length != 0) hash ^= HotelId.GetHashCode();
      if (CheckInDate.Length != 0) hash ^= CheckInDate.GetHashCode();
      if (CheckOutDate.Length != 0) hash ^= CheckOutDate.GetHashCode();
      if (ReconciledValueMicros != 0L) hash ^= ReconciledValueMicros.GetHashCode();
      if (Billed != false) hash ^= Billed.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (CommissionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CommissionId);
      }
      if (OrderId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OrderId);
      }
      if (HotelCenterId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HotelCenterId);
      }
      if (HotelId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(HotelId);
      }
      if (CheckInDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CheckInDate);
      }
      if (CheckOutDate.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CheckOutDate);
      }
      if (ReconciledValueMicros != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(ReconciledValueMicros);
      }
      if (Billed != false) {
        output.WriteRawTag(72);
        output.WriteBool(Billed);
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Status);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Campaign);
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
      if (CommissionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CommissionId);
      }
      if (OrderId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OrderId);
      }
      if (HotelCenterId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HotelCenterId);
      }
      if (HotelId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(HotelId);
      }
      if (CheckInDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CheckInDate);
      }
      if (CheckOutDate.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CheckOutDate);
      }
      if (ReconciledValueMicros != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(ReconciledValueMicros);
      }
      if (Billed != false) {
        output.WriteRawTag(72);
        output.WriteBool(Billed);
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Status);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Campaign);
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
      if (CommissionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CommissionId);
      }
      if (OrderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderId);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HotelCenterId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HotelCenterId);
      }
      if (HotelId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HotelId);
      }
      if (CheckInDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CheckInDate);
      }
      if (CheckOutDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CheckOutDate);
      }
      if (ReconciledValueMicros != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ReconciledValueMicros);
      }
      if (Billed != false) {
        size += 1 + 1;
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HotelReconciliation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CommissionId.Length != 0) {
        CommissionId = other.CommissionId;
      }
      if (other.OrderId.Length != 0) {
        OrderId = other.OrderId;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.HotelCenterId != 0L) {
        HotelCenterId = other.HotelCenterId;
      }
      if (other.HotelId.Length != 0) {
        HotelId = other.HotelId;
      }
      if (other.CheckInDate.Length != 0) {
        CheckInDate = other.CheckInDate;
      }
      if (other.CheckOutDate.Length != 0) {
        CheckOutDate = other.CheckOutDate;
      }
      if (other.ReconciledValueMicros != 0L) {
        ReconciledValueMicros = other.ReconciledValueMicros;
      }
      if (other.Billed != false) {
        Billed = other.Billed;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus.Unspecified) {
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
            CommissionId = input.ReadString();
            break;
          }
          case 26: {
            OrderId = input.ReadString();
            break;
          }
          case 32: {
            HotelCenterId = input.ReadInt64();
            break;
          }
          case 42: {
            HotelId = input.ReadString();
            break;
          }
          case 50: {
            CheckInDate = input.ReadString();
            break;
          }
          case 58: {
            CheckOutDate = input.ReadString();
            break;
          }
          case 64: {
            ReconciledValueMicros = input.ReadInt64();
            break;
          }
          case 72: {
            Billed = input.ReadBool();
            break;
          }
          case 80: {
            Status = (global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus) input.ReadEnum();
            break;
          }
          case 90: {
            Campaign = input.ReadString();
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
            CommissionId = input.ReadString();
            break;
          }
          case 26: {
            OrderId = input.ReadString();
            break;
          }
          case 32: {
            HotelCenterId = input.ReadInt64();
            break;
          }
          case 42: {
            HotelId = input.ReadString();
            break;
          }
          case 50: {
            CheckInDate = input.ReadString();
            break;
          }
          case 58: {
            CheckOutDate = input.ReadString();
            break;
          }
          case 64: {
            ReconciledValueMicros = input.ReadInt64();
            break;
          }
          case 72: {
            Billed = input.ReadBool();
            break;
          }
          case 80: {
            Status = (global::Google.Ads.GoogleAds.V14.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus) input.ReadEnum();
            break;
          }
          case 90: {
            Campaign = input.ReadString();
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
