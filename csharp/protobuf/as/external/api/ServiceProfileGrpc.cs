// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: as/external/api/serviceProfile.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Chirpstack.ApplicationServer.External.Api {
  /// <summary>
  /// ServiceProfileService is the service managing service-profiles.
  /// </summary>
  public static partial class ServiceProfileService
  {
    static readonly string __ServiceName = "api.ServiceProfileService";

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
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest> __Marshaller_api_CreateServiceProfileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse> __Marshaller_api_CreateServiceProfileResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest> __Marshaller_api_GetServiceProfileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse> __Marshaller_api_GetServiceProfileResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest> __Marshaller_api_UpdateServiceProfileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest> __Marshaller_api_DeleteServiceProfileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest> __Marshaller_api_ListServiceProfileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse> __Marshaller_api_ListServiceProfileResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse> __Method_Create = new grpc::Method<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_api_CreateServiceProfileRequest,
        __Marshaller_api_CreateServiceProfileResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse> __Method_Get = new grpc::Method<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_api_GetServiceProfileRequest,
        __Marshaller_api_GetServiceProfileResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Update = new grpc::Method<global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_api_UpdateServiceProfileRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Delete = new grpc::Method<global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_api_DeleteServiceProfileRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse> __Method_List = new grpc::Method<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_api_ListServiceProfileRequest,
        __Marshaller_api_ListServiceProfileResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Chirpstack.ApplicationServer.External.Api.ServiceProfileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServiceProfileService</summary>
    [grpc::BindServiceMethod(typeof(ServiceProfileService), "BindService")]
    public abstract partial class ServiceProfileServiceBase
    {
      /// <summary>
      /// Create creates the given service-profile.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse> Create(global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get returns the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse> Get(global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update updates the given serviceprofile.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Update(global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete deletes the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Delete(global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// List lists the available service-profiles.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse> List(global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServiceProfileService</summary>
    public partial class ServiceProfileServiceClient : grpc::ClientBase<ServiceProfileServiceClient>
    {
      /// <summary>Creates a new client for ServiceProfileService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceProfileServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServiceProfileService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceProfileServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceProfileServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceProfileServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create creates the given service-profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse Create(global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create creates the given service-profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse Create(global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Create creates the given service-profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse> CreateAsync(global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create creates the given service-profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse> CreateAsync(global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Get returns the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse Get(global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get returns the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse Get(global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Get returns the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse> GetAsync(global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get returns the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse> GetAsync(global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Update updates the given serviceprofile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Update(global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update updates the given serviceprofile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Update(global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Update updates the given serviceprofile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateAsync(global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update updates the given serviceprofile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateAsync(global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Delete deletes the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Delete(global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete deletes the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Delete(global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Delete deletes the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAsync(global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete deletes the service-profile matching the given id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAsync(global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// List lists the available service-profiles.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse List(global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List lists the available service-profiles.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse List(global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// List lists the available service-profiles.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse> ListAsync(global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List lists the available service-profiles.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse> ListAsync(global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ServiceProfileServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceProfileServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServiceProfileServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_List, serviceImpl.List).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceProfileServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Create, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.CreateServiceProfileResponse>(serviceImpl.Create));
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.GetServiceProfileResponse>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Chirpstack.ApplicationServer.External.Api.UpdateServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Chirpstack.ApplicationServer.External.Api.DeleteServiceProfileRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_List, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileRequest, global::Chirpstack.ApplicationServer.External.Api.ListServiceProfileResponse>(serviceImpl.List));
    }

  }
}
#endregion
