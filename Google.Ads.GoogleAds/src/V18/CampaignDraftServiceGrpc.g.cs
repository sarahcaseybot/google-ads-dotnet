// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/services/campaign_draft_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V18.Services {
  /// <summary>
  /// Service to manage campaign drafts.
  /// </summary>
  public static partial class CampaignDraftService
  {
    static readonly string __ServiceName = "google.ads.googleads.v18.services.CampaignDraftService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest> __Marshaller_google_ads_googleads_v18_services_MutateCampaignDraftsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse> __Marshaller_google_ads_googleads_v18_services_MutateCampaignDraftsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest> __Marshaller_google_ads_googleads_v18_services_PromoteCampaignDraftRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest> __Marshaller_google_ads_googleads_v18_services_ListCampaignDraftAsyncErrorsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse> __Marshaller_google_ads_googleads_v18_services_ListCampaignDraftAsyncErrorsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest, global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse> __Method_MutateCampaignDrafts = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest, global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignDrafts",
        __Marshaller_google_ads_googleads_v18_services_MutateCampaignDraftsRequest,
        __Marshaller_google_ads_googleads_v18_services_MutateCampaignDraftsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest, global::Google.LongRunning.Operation> __Method_PromoteCampaignDraft = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PromoteCampaignDraft",
        __Marshaller_google_ads_googleads_v18_services_PromoteCampaignDraftRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest, global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse> __Method_ListCampaignDraftAsyncErrors = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest, global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListCampaignDraftAsyncErrors",
        __Marshaller_google_ads_googleads_v18_services_ListCampaignDraftAsyncErrorsRequest,
        __Marshaller_google_ads_googleads_v18_services_ListCampaignDraftAsyncErrorsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V18.Services.CampaignDraftServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CampaignDraftService</summary>
    [grpc::BindServiceMethod(typeof(CampaignDraftService), "BindService")]
    public abstract partial class CampaignDraftServiceBase
    {
      /// <summary>
      /// Creates, updates, or removes campaign drafts. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse> MutateCampaignDrafts(global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Promotes the changes in a draft back to the base campaign.
      ///
      /// This method returns a Long Running Operation (LRO) indicating if the
      /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
      /// is done. Only a done status is returned in the response. See the status
      /// in the Campaign Draft resource to determine if the promotion was
      /// successful. If the LRO failed, use
      /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v18.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
      /// to view the list of error reasons.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> PromoteCampaignDraft(global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns all errors that occurred during CampaignDraft promote. Throws an
      /// error if called before campaign draft is promoted.
      /// Supports standard list paging.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse> ListCampaignDraftAsyncErrors(global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CampaignDraftService</summary>
    public partial class CampaignDraftServiceClient : grpc::ClientBase<CampaignDraftServiceClient>
    {
      /// <summary>Creates a new client for CampaignDraftService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CampaignDraftServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CampaignDraftService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CampaignDraftServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CampaignDraftServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CampaignDraftServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates, updates, or removes campaign drafts. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse MutateCampaignDrafts(global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignDrafts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes campaign drafts. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse MutateCampaignDrafts(global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignDrafts, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes campaign drafts. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignDraftsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes campaign drafts. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignDrafts, null, options, request);
      }
      /// <summary>
      /// Promotes the changes in a draft back to the base campaign.
      ///
      /// This method returns a Long Running Operation (LRO) indicating if the
      /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
      /// is done. Only a done status is returned in the response. See the status
      /// in the Campaign Draft resource to determine if the promotion was
      /// successful. If the LRO failed, use
      /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v18.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
      /// to view the list of error reasons.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation PromoteCampaignDraft(global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PromoteCampaignDraft(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Promotes the changes in a draft back to the base campaign.
      ///
      /// This method returns a Long Running Operation (LRO) indicating if the
      /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
      /// is done. Only a done status is returned in the response. See the status
      /// in the Campaign Draft resource to determine if the promotion was
      /// successful. If the LRO failed, use
      /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v18.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
      /// to view the list of error reasons.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation PromoteCampaignDraft(global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PromoteCampaignDraft, null, options, request);
      }
      /// <summary>
      /// Promotes the changes in a draft back to the base campaign.
      ///
      /// This method returns a Long Running Operation (LRO) indicating if the
      /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
      /// is done. Only a done status is returned in the response. See the status
      /// in the Campaign Draft resource to determine if the promotion was
      /// successful. If the LRO failed, use
      /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v18.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
      /// to view the list of error reasons.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> PromoteCampaignDraftAsync(global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PromoteCampaignDraftAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Promotes the changes in a draft back to the base campaign.
      ///
      /// This method returns a Long Running Operation (LRO) indicating if the
      /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
      /// is done. Only a done status is returned in the response. See the status
      /// in the Campaign Draft resource to determine if the promotion was
      /// successful. If the LRO failed, use
      /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v18.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
      /// to view the list of error reasons.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CampaignDraftError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> PromoteCampaignDraftAsync(global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PromoteCampaignDraft, null, options, request);
      }
      /// <summary>
      /// Returns all errors that occurred during CampaignDraft promote. Throws an
      /// error if called before campaign draft is promoted.
      /// Supports standard list paging.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse ListCampaignDraftAsyncErrors(global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCampaignDraftAsyncErrors(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all errors that occurred during CampaignDraft promote. Throws an
      /// error if called before campaign draft is promoted.
      /// Supports standard list paging.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse ListCampaignDraftAsyncErrors(global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListCampaignDraftAsyncErrors, null, options, request);
      }
      /// <summary>
      /// Returns all errors that occurred during CampaignDraft promote. Throws an
      /// error if called before campaign draft is promoted.
      /// Supports standard list paging.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse> ListCampaignDraftAsyncErrorsAsync(global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCampaignDraftAsyncErrorsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all errors that occurred during CampaignDraft promote. Throws an
      /// error if called before campaign draft is promoted.
      /// Supports standard list paging.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse> ListCampaignDraftAsyncErrorsAsync(global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListCampaignDraftAsyncErrors, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CampaignDraftServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CampaignDraftServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CampaignDraftServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateCampaignDrafts, serviceImpl.MutateCampaignDrafts)
          .AddMethod(__Method_PromoteCampaignDraft, serviceImpl.PromoteCampaignDraft)
          .AddMethod(__Method_ListCampaignDraftAsyncErrors, serviceImpl.ListCampaignDraftAsyncErrors).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CampaignDraftServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateCampaignDrafts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsRequest, global::Google.Ads.GoogleAds.V18.Services.MutateCampaignDraftsResponse>(serviceImpl.MutateCampaignDrafts));
      serviceBinder.AddMethod(__Method_PromoteCampaignDraft, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.PromoteCampaignDraftRequest, global::Google.LongRunning.Operation>(serviceImpl.PromoteCampaignDraft));
      serviceBinder.AddMethod(__Method_ListCampaignDraftAsyncErrors, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsRequest, global::Google.Ads.GoogleAds.V18.Services.ListCampaignDraftAsyncErrorsResponse>(serviceImpl.ListCampaignDraftAsyncErrors));
    }

  }
}
#endregion
