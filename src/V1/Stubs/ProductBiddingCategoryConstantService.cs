// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/product_bidding_category_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/product_bidding_category_constant_service.proto</summary>
  public static partial class ProductBiddingCategoryConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/product_bidding_category_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductBiddingCategoryConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9wcm9kdWN0X2Jp",
            "ZGRpbmdfY2F0ZWdvcnlfY29uc3RhbnRfc2VydmljZS5wcm90bxIgZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEuc2VydmljZXMaSWdvb2dsZS9hZHMvZ29vZ2xl",
            "YWRzL3YxL3Jlc291cmNlcy9wcm9kdWN0X2JpZGRpbmdfY2F0ZWdvcnlfY29u",
            "c3RhbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iQQoo",
            "R2V0UHJvZHVjdEJpZGRpbmdDYXRlZ29yeUNvbnN0YW50UmVxdWVzdBIVCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJMpsCCiVQcm9kdWN0QmlkZGluZ0NhdGVnb3J5",
            "Q29uc3RhbnRTZXJ2aWNlEvEBCiFHZXRQcm9kdWN0QmlkZGluZ0NhdGVnb3J5",
            "Q29uc3RhbnQSSi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2aWNlcy5H",
            "ZXRQcm9kdWN0QmlkZGluZ0NhdGVnb3J5Q29uc3RhbnRSZXF1ZXN0GkEuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjEucmVzb3VyY2VzLlByb2R1Y3RCaWRkaW5n",
            "Q2F0ZWdvcnlDb25zdGFudCI9gtPkkwI3EjUvdjEve3Jlc291cmNlX25hbWU9",
            "cHJvZHVjdEJpZGRpbmdDYXRlZ29yeUNvbnN0YW50cy8qfUKOAgokY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZpY2VzQipQcm9kdWN0QmlkZGlu",
            "Z0NhdGVnb3J5Q29uc3RhbnRTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL3Nl",
            "cnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxTZXJ2aWNl",
            "c+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.ProductBiddingCategoryConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetProductBiddingCategoryConstantRequest), global::Google.Ads.GoogleAds.V1.Services.GetProductBiddingCategoryConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ProductBiddingCategoryService.GetProductBiddingCategory][].
  /// </summary>
  public sealed partial class GetProductBiddingCategoryConstantRequest : pb::IMessage<GetProductBiddingCategoryConstantRequest> {
    private static readonly pb::MessageParser<GetProductBiddingCategoryConstantRequest> _parser = new pb::MessageParser<GetProductBiddingCategoryConstantRequest>(() => new GetProductBiddingCategoryConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetProductBiddingCategoryConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.ProductBiddingCategoryConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetProductBiddingCategoryConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetProductBiddingCategoryConstantRequest(GetProductBiddingCategoryConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetProductBiddingCategoryConstantRequest Clone() {
      return new GetProductBiddingCategoryConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Resource name of the Product Bidding Category to fetch.
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
      return Equals(other as GetProductBiddingCategoryConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetProductBiddingCategoryConstantRequest other) {
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

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
    public void MergeFrom(GetProductBiddingCategoryConstantRequest other) {
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
    }

  }

  #endregion

}

#endregion Designer generated code
