// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/keyword_plan_keyword_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
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
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V1.Services {
  /// <summary>
  /// Service to manage Keyword Plan ad group keywords.
  /// </summary>
  public static partial class KeywordPlanKeywordService
  {
    static readonly string __ServiceName = "google.ads.googleads.v1.services.KeywordPlanKeywordService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest> __Marshaller_google_ads_googleads_v1_services_GetKeywordPlanKeywordRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword> __Marshaller_google_ads_googleads_v1_resources_KeywordPlanKeyword = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest> __Marshaller_google_ads_googleads_v1_services_MutateKeywordPlanKeywordsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse> __Marshaller_google_ads_googleads_v1_services_MutateKeywordPlanKeywordsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest, global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword> __Method_GetKeywordPlanKeyword = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest, global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlanKeyword",
        __Marshaller_google_ads_googleads_v1_services_GetKeywordPlanKeywordRequest,
        __Marshaller_google_ads_googleads_v1_resources_KeywordPlanKeyword);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest, global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse> __Method_MutateKeywordPlanKeywords = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest, global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanKeywords",
        __Marshaller_google_ads_googleads_v1_services_MutateKeywordPlanKeywordsRequest,
        __Marshaller_google_ads_googleads_v1_services_MutateKeywordPlanKeywordsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V1.Services.KeywordPlanKeywordServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanKeywordService</summary>
    public abstract partial class KeywordPlanKeywordServiceBase
    {
      /// <summary>
      /// Returns the requested Keyword Plan keyword in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword> GetKeywordPlanKeyword(global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywords(global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanKeywordService</summary>
    public partial class KeywordPlanKeywordServiceClient : grpc::ClientBase<KeywordPlanKeywordServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanKeywordService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public KeywordPlanKeywordServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanKeywordService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public KeywordPlanKeywordServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected KeywordPlanKeywordServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected KeywordPlanKeywordServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested Keyword Plan keyword in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword GetKeywordPlanKeyword(global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanKeyword(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan keyword in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword GetKeywordPlanKeyword(global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlanKeyword, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan keyword in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword> GetKeywordPlanKeywordAsync(global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanKeywordAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan keyword in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanKeyword> GetKeywordPlanKeywordAsync(global::Google.Ads.GoogleAds.V1.Services.GetKeywordPlanKeywordRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlanKeyword, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanKeywords(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanKeywords, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanKeywordsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(global::Google.Ads.GoogleAds.V1.Services.MutateKeywordPlanKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanKeywords, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override KeywordPlanKeywordServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanKeywordServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KeywordPlanKeywordServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlanKeyword, serviceImpl.GetKeywordPlanKeyword)
          .AddMethod(__Method_MutateKeywordPlanKeywords, serviceImpl.MutateKeywordPlanKeywords).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanKeywordServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetKeywordPlanKeyword, serviceImpl.GetKeywordPlanKeyword);
      serviceBinder.AddMethod(__Method_MutateKeywordPlanKeywords, serviceImpl.MutateKeywordPlanKeywords);
    }

  }
}
#endregion
