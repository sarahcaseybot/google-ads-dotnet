// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/remarketing_action_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// Service to manage remarketing actions.
  /// </summary>
  public static partial class RemarketingActionService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.RemarketingActionService";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest> __Marshaller_google_ads_googleads_v4_services_GetRemarketingActionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction> __Marshaller_google_ads_googleads_v4_resources_RemarketingAction = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest> __Marshaller_google_ads_googleads_v4_services_MutateRemarketingActionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse> __Marshaller_google_ads_googleads_v4_services_MutateRemarketingActionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest, global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction> __Method_GetRemarketingAction = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest, global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRemarketingAction",
        __Marshaller_google_ads_googleads_v4_services_GetRemarketingActionRequest,
        __Marshaller_google_ads_googleads_v4_resources_RemarketingAction);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse> __Method_MutateRemarketingActions = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateRemarketingActions",
        __Marshaller_google_ads_googleads_v4_services_MutateRemarketingActionsRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateRemarketingActionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.RemarketingActionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemarketingActionService</summary>
    [grpc::BindServiceMethod(typeof(RemarketingActionService), "BindService")]
    public abstract partial class RemarketingActionServiceBase
    {
      /// <summary>
      /// Returns the requested remarketing action in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction> GetRemarketingAction(global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or updates remarketing actions. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse> MutateRemarketingActions(global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemarketingActionService</summary>
    public partial class RemarketingActionServiceClient : grpc::ClientBase<RemarketingActionServiceClient>
    {
      /// <summary>Creates a new client for RemarketingActionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemarketingActionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemarketingActionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemarketingActionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemarketingActionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemarketingActionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested remarketing action in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction GetRemarketingAction(global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRemarketingAction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested remarketing action in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction GetRemarketingAction(global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRemarketingAction, null, options, request);
      }
      /// <summary>
      /// Returns the requested remarketing action in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction> GetRemarketingActionAsync(global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRemarketingActionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested remarketing action in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction> GetRemarketingActionAsync(global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRemarketingAction, null, options, request);
      }
      /// <summary>
      /// Creates or updates remarketing actions. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse MutateRemarketingActions(global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRemarketingActions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates remarketing actions. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse MutateRemarketingActions(global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateRemarketingActions, null, options, request);
      }
      /// <summary>
      /// Creates or updates remarketing actions. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRemarketingActionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates remarketing actions. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateRemarketingActions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RemarketingActionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemarketingActionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemarketingActionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetRemarketingAction, serviceImpl.GetRemarketingAction)
          .AddMethod(__Method_MutateRemarketingActions, serviceImpl.MutateRemarketingActions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RemarketingActionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetRemarketingAction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetRemarketingActionRequest, global::Google.Ads.GoogleAds.V4.Resources.RemarketingAction>(serviceImpl.GetRemarketingAction));
      serviceBinder.AddMethod(__Method_MutateRemarketingActions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateRemarketingActionsResponse>(serviceImpl.MutateRemarketingActions));
    }

  }
}
#endregion
