// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/asset_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/asset_service.proto</summary>
  public static partial class AssetServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/asset_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9hc3NldF9zZXJ2",
            "aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2aWNlcxot",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3VyY2VzL2Fzc2V0LnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIigKD0dldEFzc2V0UmVx",
            "dWVzdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJInAKE011dGF0ZUFzc2V0c1Jl",
            "cXVlc3QSEwoLY3VzdG9tZXJfaWQYASABKAkSRAoKb3BlcmF0aW9ucxgCIAMo",
            "CzIwLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZpY2VzLkFzc2V0T3Bl",
            "cmF0aW9uIlkKDkFzc2V0T3BlcmF0aW9uEjoKBmNyZWF0ZRgBIAEoCzIoLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNlcy5Bc3NldEgAQgsKCW9w",
            "ZXJhdGlvbiJcChRNdXRhdGVBc3NldHNSZXNwb25zZRJECgdyZXN1bHRzGAIg",
            "AygLMjMuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuc2VydmljZXMuTXV0YXRl",
            "QXNzZXRSZXN1bHQiKgoRTXV0YXRlQXNzZXRSZXN1bHQSFQoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCTLiAgoMQXNzZXRTZXJ2aWNlEpkBCghHZXRBc3NldBIxLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZpY2VzLkdldEFzc2V0UmVxdWVz",
            "dBooLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNlcy5Bc3NldCIw",
            "gtPkkwIqEigvdjEve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovYXNzZXRz",
            "Lyp9ErUBCgxNdXRhdGVBc3NldHMSNS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MS5zZXJ2aWNlcy5NdXRhdGVBc3NldHNSZXF1ZXN0GjYuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEuc2VydmljZXMuTXV0YXRlQXNzZXRzUmVzcG9uc2UiNoLT",
            "5JMCMCIrL3YxL2N1c3RvbWVycy97Y3VzdG9tZXJfaWQ9Kn0vYXNzZXRzOm11",
            "dGF0ZToBKkL4AQokY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZp",
            "Y2VzQhFBc3NldFNlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEvc2VydmljZXM7",
            "c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WMS5TZXJ2",
            "aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXFNlcnZpY2Vz6gIkR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.AssetReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetAssetRequest), global::Google.Ads.GoogleAds.V1.Services.GetAssetRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateAssetsRequest), global::Google.Ads.GoogleAds.V1.Services.MutateAssetsRequest.Parser, new[]{ "CustomerId", "Operations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.AssetOperation), global::Google.Ads.GoogleAds.V1.Services.AssetOperation.Parser, new[]{ "Create" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateAssetsResponse), global::Google.Ads.GoogleAds.V1.Services.MutateAssetsResponse.Parser, new[]{ "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult), global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [AssetService.GetAsset][google.ads.googleads.v1.services.AssetService.GetAsset]
  /// </summary>
  public sealed partial class GetAssetRequest : pb::IMessage<GetAssetRequest> {
    private static readonly pb::MessageParser<GetAssetRequest> _parser = new pb::MessageParser<GetAssetRequest>(() => new GetAssetRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAssetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.AssetServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetRequest(GetAssetRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetRequest Clone() {
      return new GetAssetRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the asset to fetch.
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
      return Equals(other as GetAssetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAssetRequest other) {
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
    public void MergeFrom(GetAssetRequest other) {
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

  /// <summary>
  /// Request message for [AssetService.MutateAssets][google.ads.googleads.v1.services.AssetService.MutateAssets]
  /// </summary>
  public sealed partial class MutateAssetsRequest : pb::IMessage<MutateAssetsRequest> {
    private static readonly pb::MessageParser<MutateAssetsRequest> _parser = new pb::MessageParser<MutateAssetsRequest>(() => new MutateAssetsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAssetsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.AssetServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsRequest(MutateAssetsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsRequest Clone() {
      return new MutateAssetsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose assets are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Services.AssetOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V1.Services.AssetOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.AssetOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.AssetOperation>();
    /// <summary>
    /// The list of operations to perform on individual assets.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.AssetOperation> Operations {
      get { return operations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAssetsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAssetsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAssetsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation to create an asset.
  /// </summary>
  public sealed partial class AssetOperation : pb::IMessage<AssetOperation> {
    private static readonly pb::MessageParser<AssetOperation> _parser = new pb::MessageParser<AssetOperation>(() => new AssetOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssetOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.AssetServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetOperation(AssetOperation other) : this() {
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetOperation Clone() {
      return new AssetOperation(this);
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Resources.Asset Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V1.Resources.Asset) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssetOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssetOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Create, other.Create)) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      hash ^= (int) operationCase_;
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
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssetOperation other) {
      if (other == null) {
        return;
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V1.Resources.Asset();
          }
          Create.MergeFrom(other.Create);
          break;
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
            global::Google.Ads.GoogleAds.V1.Resources.Asset subBuilder = new global::Google.Ads.GoogleAds.V1.Resources.Asset();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for an asset mutate.
  /// </summary>
  public sealed partial class MutateAssetsResponse : pb::IMessage<MutateAssetsResponse> {
    private static readonly pb::MessageParser<MutateAssetsResponse> _parser = new pb::MessageParser<MutateAssetsResponse>(() => new MutateAssetsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAssetsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.AssetServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsResponse(MutateAssetsResponse other) : this() {
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetsResponse Clone() {
      return new MutateAssetsResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Services.MutateAssetResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAssetsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAssetsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAssetsResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
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
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the asset mutate.
  /// </summary>
  public sealed partial class MutateAssetResult : pb::IMessage<MutateAssetResult> {
    private static readonly pb::MessageParser<MutateAssetResult> _parser = new pb::MessageParser<MutateAssetResult>(() => new MutateAssetResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAssetResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.AssetServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetResult(MutateAssetResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAssetResult Clone() {
      return new MutateAssetResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name returned for successful operations.
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
      return Equals(other as MutateAssetResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAssetResult other) {
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
    public void MergeFrom(MutateAssetResult other) {
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
