// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/services/keyword_plan_campaign_keyword_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V7.Services {
  /// <summary>
  /// Service to manage Keyword Plan campaign keywords. KeywordPlanCampaign is
  /// required to add the campaign keywords. Only negative keywords are supported.
  /// A maximum of 1000 negative keywords are allowed per plan. This includes both
  /// campaign negative keywords and ad group negative keywords.
  /// </summary>
  public static partial class KeywordPlanCampaignKeywordService
  {
    static readonly string __ServiceName = "google.ads.googleads.v7.services.KeywordPlanCampaignKeywordService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest> __Marshaller_google_ads_googleads_v7_services_GetKeywordPlanCampaignKeywordRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword> __Marshaller_google_ads_googleads_v7_resources_KeywordPlanCampaignKeyword = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest> __Marshaller_google_ads_googleads_v7_services_MutateKeywordPlanCampaignKeywordsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse> __Marshaller_google_ads_googleads_v7_services_MutateKeywordPlanCampaignKeywordsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest, global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword> __Method_GetKeywordPlanCampaignKeyword = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest, global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlanCampaignKeyword",
        __Marshaller_google_ads_googleads_v7_services_GetKeywordPlanCampaignKeywordRequest,
        __Marshaller_google_ads_googleads_v7_resources_KeywordPlanCampaignKeyword);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest, global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse> __Method_MutateKeywordPlanCampaignKeywords = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest, global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanCampaignKeywords",
        __Marshaller_google_ads_googleads_v7_services_MutateKeywordPlanCampaignKeywordsRequest,
        __Marshaller_google_ads_googleads_v7_services_MutateKeywordPlanCampaignKeywordsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V7.Services.KeywordPlanCampaignKeywordServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanCampaignKeywordService</summary>
    [grpc::BindServiceMethod(typeof(KeywordPlanCampaignKeywordService), "BindService")]
    public abstract partial class KeywordPlanCampaignKeywordServiceBase
    {
      /// <summary>
      /// Returns the requested plan in full detail.
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
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeyword(global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanCampaignKeywordError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywords(global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanCampaignKeywordService</summary>
    public partial class KeywordPlanCampaignKeywordServiceClient : grpc::ClientBase<KeywordPlanCampaignKeywordServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanCampaignKeywordService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanCampaignKeywordServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanCampaignKeywordService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanCampaignKeywordServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanCampaignKeywordServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanCampaignKeywordServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested plan in full detail.
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
      public virtual global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanCampaignKeyword(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
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
      public virtual global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlanCampaignKeyword, null, options, request);
      }
      /// <summary>
      /// Returns the requested plan in full detail.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanCampaignKeywordAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlanCampaignKeyword, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanCampaignKeywordError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse MutateKeywordPlanCampaignKeywords(global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanCampaignKeywords(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanCampaignKeywordError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse MutateKeywordPlanCampaignKeywords(global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanCampaignKeywords, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanCampaignKeywordError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanCampaignKeywordsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanCampaignKeywordError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanCampaignKeywords, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override KeywordPlanCampaignKeywordServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanCampaignKeywordServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(KeywordPlanCampaignKeywordServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlanCampaignKeyword, serviceImpl.GetKeywordPlanCampaignKeyword)
          .AddMethod(__Method_MutateKeywordPlanCampaignKeywords, serviceImpl.MutateKeywordPlanCampaignKeywords).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanCampaignKeywordServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetKeywordPlanCampaignKeyword, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.GetKeywordPlanCampaignKeywordRequest, global::Google.Ads.GoogleAds.V7.Resources.KeywordPlanCampaignKeyword>(serviceImpl.GetKeywordPlanCampaignKeyword));
      serviceBinder.AddMethod(__Method_MutateKeywordPlanCampaignKeywords, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsRequest, global::Google.Ads.GoogleAds.V7.Services.MutateKeywordPlanCampaignKeywordsResponse>(serviceImpl.MutateKeywordPlanCampaignKeywords));
    }

  }
}
#endregion
