// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/services/hotel_performance_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/services/hotel_performance_view_service.proto</summary>
  public static partial class HotelPerformanceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/services/hotel_performance_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelPerformanceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9zZXJ2aWNlcy9ob3RlbF9wZXJm",
            "b3JtYW5jZV92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY2LnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9yZXNv",
            "dXJjZXMvaG90ZWxfcGVyZm9ybWFuY2Vfdmlldy5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8ibgoeR2V0SG90ZWxQZXJmb3JtYW5jZVZpZXdSZXF1",
            "ZXN0EkwKDXJlc291cmNlX25hbWUYASABKAlCNeBBAvpBLwotZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0hvdGVsUGVyZm9ybWFuY2VWaWV3MskCChtIb3Rl",
            "bFBlcmZvcm1hbmNlVmlld1NlcnZpY2US4gEKF0dldEhvdGVsUGVyZm9ybWFu",
            "Y2VWaWV3EkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjYuc2VydmljZXMuR2V0",
            "SG90ZWxQZXJmb3JtYW5jZVZpZXdSZXF1ZXN0GjcuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjYucmVzb3VyY2VzLkhvdGVsUGVyZm9ybWFuY2VWaWV3IkyC0+ST",
            "AjYSNC92Ni97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKi9ob3RlbFBlcmZv",
            "cm1hbmNlVmlld33aQQ1yZXNvdXJjZV9uYW1lGkXKQRhnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb23SQSdodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRo",
            "L2Fkd29yZHNChwIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5zZXJ2",
            "aWNlc0IgSG90ZWxQZXJmb3JtYW5jZVZpZXdTZXJ2aWNlUHJvdG9QAVpIZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3Y2L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjYuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "NlxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY2OjpTZXJ2",
            "aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Resources.HotelPerformanceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Services.GetHotelPerformanceViewRequest), global::Google.Ads.GoogleAds.V6.Services.GetHotelPerformanceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [HotelPerformanceViewService.GetHotelPerformanceView][google.ads.googleads.v6.services.HotelPerformanceViewService.GetHotelPerformanceView].
  /// </summary>
  public sealed partial class GetHotelPerformanceViewRequest : pb::IMessage<GetHotelPerformanceViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetHotelPerformanceViewRequest> _parser = new pb::MessageParser<GetHotelPerformanceViewRequest>(() => new GetHotelPerformanceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHotelPerformanceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Services.HotelPerformanceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest(GetHotelPerformanceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest Clone() {
      return new GetHotelPerformanceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the Hotel Performance View to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetHotelPerformanceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHotelPerformanceViewRequest other) {
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
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(GetHotelPerformanceViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
