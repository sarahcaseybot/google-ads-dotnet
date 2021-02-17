// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/video_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/video_service.proto</summary>
  public static partial class VideoServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/video_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy92aWRlb19zZXJ2",
            "aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52NC5zZXJ2aWNlcxot",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjQvcmVzb3VyY2VzL3ZpZGVvLnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2Ns",
            "aWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZ",
            "Z29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJQCg9HZXRWaWRlb1JlcXVlc3QS",
            "PQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIm4EEC+kEgCh5nb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vVmlkZW8ygQIKDFZpZGVvU2VydmljZRKpAQoIR2V0Vmlk",
            "ZW8SMS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5zZXJ2aWNlcy5HZXRWaWRl",
            "b1JlcXVlc3QaKC5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5yZXNvdXJjZXMu",
            "VmlkZW8iQILT5JMCKhIoL3Y0L3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8q",
            "L3ZpZGVvcy8qfdpBDXJlc291cmNlX25hbWUaRcpBGGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbdJBJ2h0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgv",
            "YWR3b3Jkc0L4AQokY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNlcnZp",
            "Y2VzQhFWaWRlb1NlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvc2VydmljZXM7",
            "c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5TZXJ2",
            "aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XFNlcnZpY2Vz6gIkR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjQ6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.VideoReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetVideoRequest), global::Google.Ads.GoogleAds.V4.Services.GetVideoRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [VideoService.GetVideo][google.ads.googleads.v4.services.VideoService.GetVideo].
  /// </summary>
  public sealed partial class GetVideoRequest : pb::IMessage<GetVideoRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetVideoRequest> _parser = new pb::MessageParser<GetVideoRequest>(() => new GetVideoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetVideoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.VideoServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVideoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVideoRequest(GetVideoRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVideoRequest Clone() {
      return new GetVideoRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the video to fetch.
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
      return Equals(other as GetVideoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetVideoRequest other) {
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
    public void MergeFrom(GetVideoRequest other) {
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
