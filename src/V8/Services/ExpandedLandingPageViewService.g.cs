// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/services/expanded_landing_page_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/services/expanded_landing_page_view_service.proto</summary>
  public static partial class ExpandedLandingPageViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/services/expanded_landing_page_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpandedLandingPageViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9zZXJ2aWNlcy9leHBhbmRlZF9s",
            "YW5kaW5nX3BhZ2Vfdmlld19zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52OC5zZXJ2aWNlcxpCZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjgv",
            "cmVzb3VyY2VzL2V4cGFuZGVkX2xhbmRpbmdfcGFnZV92aWV3LnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVu",
            "dC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29v",
            "Z2xlL2FwaS9yZXNvdXJjZS5wcm90byJ0CiFHZXRFeHBhbmRlZExhbmRpbmdQ",
            "YWdlVmlld1JlcXVlc3QSTwoNcmVzb3VyY2VfbmFtZRgBIAEoCUI44EEC+kEy",
            "CjBnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRXhwYW5kZWRMYW5kaW5nUGFn",
            "ZVZpZXcy2wIKHkV4cGFuZGVkTGFuZGluZ1BhZ2VWaWV3U2VydmljZRLxAQoa",
            "R2V0RXhwYW5kZWRMYW5kaW5nUGFnZVZpZXcSQy5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52OC5zZXJ2aWNlcy5HZXRFeHBhbmRlZExhbmRpbmdQYWdlVmlld1Jl",
            "cXVlc3QaOi5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5yZXNvdXJjZXMuRXhw",
            "YW5kZWRMYW5kaW5nUGFnZVZpZXciUoLT5JMCPBI6L3Y4L3tyZXNvdXJjZV9u",
            "YW1lPWN1c3RvbWVycy8qL2V4cGFuZGVkTGFuZGluZ1BhZ2VWaWV3cy8qfdpB",
            "DXJlc291cmNlX25hbWUaRcpBGGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbdJB",
            "J2h0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvYWR3b3Jkc0KKAgok",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LnNlcnZpY2VzQiNFeHBhbmRl",
            "ZExhbmRpbmdQYWdlVmlld1NlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjgvc2Vy",
            "dmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "OC5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFY4XFNlcnZpY2Vz",
            "6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OlNlcnZpY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Resources.ExpandedLandingPageViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Services.GetExpandedLandingPageViewRequest), global::Google.Ads.GoogleAds.V8.Services.GetExpandedLandingPageViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ExpandedLandingPageViewService.GetExpandedLandingPageView][google.ads.googleads.v8.services.ExpandedLandingPageViewService.GetExpandedLandingPageView].
  /// </summary>
  public sealed partial class GetExpandedLandingPageViewRequest : pb::IMessage<GetExpandedLandingPageViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetExpandedLandingPageViewRequest> _parser = new pb::MessageParser<GetExpandedLandingPageViewRequest>(() => new GetExpandedLandingPageViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetExpandedLandingPageViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Services.ExpandedLandingPageViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetExpandedLandingPageViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetExpandedLandingPageViewRequest(GetExpandedLandingPageViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetExpandedLandingPageViewRequest Clone() {
      return new GetExpandedLandingPageViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the expanded landing page view to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetExpandedLandingPageViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetExpandedLandingPageViewRequest other) {
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetExpandedLandingPageViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
