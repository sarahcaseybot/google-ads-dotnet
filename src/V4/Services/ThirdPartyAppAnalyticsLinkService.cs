// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/third_party_app_analytics_link_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/third_party_app_analytics_link_service.proto</summary>
  public static partial class ThirdPartyAppAnalyticsLinkServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/third_party_app_analytics_link_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ThirdPartyAppAnalyticsLinkServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy90aGlyZF9wYXJ0",
            "eV9hcHBfYW5hbHl0aWNzX2xpbmtfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjQuc2VydmljZXMaRmdvb2dsZS9hZHMvZ29vZ2xlYWRz",
            "L3Y0L3Jlc291cmNlcy90aGlyZF9wYXJ0eV9hcHBfYW5hbHl0aWNzX2xpbmsu",
            "cHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvIncK",
            "JEdldFRoaXJkUGFydHlBcHBBbmFseXRpY3NMaW5rUmVxdWVzdBJPCg1yZXNv",
            "dXJjZV9uYW1lGAEgASgJQjj6QTUKM2dvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9UaGlyZFBhcnR5QXBwQW5hbHl0aWNzTGluazLaAgohVGhpcmRQYXJ0eUFw",
            "cEFuYWx5dGljc0xpbmtTZXJ2aWNlEu0BCh1HZXRUaGlyZFBhcnR5QXBwQW5h",
            "bHl0aWNzTGluaxJGLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNlcnZpY2Vz",
            "LkdldFRoaXJkUGFydHlBcHBBbmFseXRpY3NMaW5rUmVxdWVzdBo9Lmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY0LnJlc291cmNlcy5UaGlyZFBhcnR5QXBwQW5h",
            "bHl0aWNzTGluayJFgtPkkwI/Ej0vdjQve3Jlc291cmNlX25hbWU9Y3VzdG9t",
            "ZXJzLyovdGhpcmRQYXJ0eUFwcEFuYWx5dGljc0xpbmtzLyp9GkXKQRhnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdodHRwczovL3d3dy5nb29nbGVhcGlz",
            "LmNvbS9hdXRoL2Fkd29yZHNCjQIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52NC5zZXJ2aWNlc0ImVGhpcmRQYXJ0eUFwcEFuYWx5dGljc0xpbmtTZXJ2",
            "aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FB",
            "qgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuU2VydmljZXPKAiBHb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWNFxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlY0OjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.ThirdPartyAppAnalyticsLinkReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetThirdPartyAppAnalyticsLinkRequest), global::Google.Ads.GoogleAds.V4.Services.GetThirdPartyAppAnalyticsLinkRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ThirdPartyAppAnalyticsLinkService.GetThirdPartyAppAnalyticsLink][google.ads.googleads.v4.services.ThirdPartyAppAnalyticsLinkService.GetThirdPartyAppAnalyticsLink].
  /// </summary>
  public sealed partial class GetThirdPartyAppAnalyticsLinkRequest : pb::IMessage<GetThirdPartyAppAnalyticsLinkRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetThirdPartyAppAnalyticsLinkRequest> _parser = new pb::MessageParser<GetThirdPartyAppAnalyticsLinkRequest>(() => new GetThirdPartyAppAnalyticsLinkRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetThirdPartyAppAnalyticsLinkRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.ThirdPartyAppAnalyticsLinkServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetThirdPartyAppAnalyticsLinkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetThirdPartyAppAnalyticsLinkRequest(GetThirdPartyAppAnalyticsLinkRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetThirdPartyAppAnalyticsLinkRequest Clone() {
      return new GetThirdPartyAppAnalyticsLinkRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Resource name of the third party app analytics link.
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
      return Equals(other as GetThirdPartyAppAnalyticsLinkRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetThirdPartyAppAnalyticsLinkRequest other) {
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
    public void MergeFrom(GetThirdPartyAppAnalyticsLinkRequest other) {
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
