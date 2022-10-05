// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/authorizer/v2/authorizer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Aserto.Authorizer.V2 {
  public static partial class Authorizer
  {
    static readonly string __ServiceName = "aserto.authorizer.v2.Authorizer";

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
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.DecisionTreeRequest> __Marshaller_aserto_authorizer_v2_DecisionTreeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.DecisionTreeRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.DecisionTreeResponse> __Marshaller_aserto_authorizer_v2_DecisionTreeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.DecisionTreeResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.IsRequest> __Marshaller_aserto_authorizer_v2_IsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.IsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.IsResponse> __Marshaller_aserto_authorizer_v2_IsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.IsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.QueryRequest> __Marshaller_aserto_authorizer_v2_QueryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.QueryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.QueryResponse> __Marshaller_aserto_authorizer_v2_QueryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.QueryResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.CompileRequest> __Marshaller_aserto_authorizer_v2_CompileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.CompileRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.CompileResponse> __Marshaller_aserto_authorizer_v2_CompileResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.CompileResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.ListPoliciesRequest> __Marshaller_aserto_authorizer_v2_ListPoliciesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.ListPoliciesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.ListPoliciesResponse> __Marshaller_aserto_authorizer_v2_ListPoliciesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.ListPoliciesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.GetPolicyRequest> __Marshaller_aserto_authorizer_v2_GetPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.GetPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Authorizer.V2.GetPolicyResponse> __Marshaller_aserto_authorizer_v2_GetPolicyResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Authorizer.V2.GetPolicyResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.DecisionTreeRequest, global::Aserto.Authorizer.V2.DecisionTreeResponse> __Method_DecisionTree = new grpc::Method<global::Aserto.Authorizer.V2.DecisionTreeRequest, global::Aserto.Authorizer.V2.DecisionTreeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DecisionTree",
        __Marshaller_aserto_authorizer_v2_DecisionTreeRequest,
        __Marshaller_aserto_authorizer_v2_DecisionTreeResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.IsRequest, global::Aserto.Authorizer.V2.IsResponse> __Method_Is = new grpc::Method<global::Aserto.Authorizer.V2.IsRequest, global::Aserto.Authorizer.V2.IsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Is",
        __Marshaller_aserto_authorizer_v2_IsRequest,
        __Marshaller_aserto_authorizer_v2_IsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.QueryRequest, global::Aserto.Authorizer.V2.QueryResponse> __Method_Query = new grpc::Method<global::Aserto.Authorizer.V2.QueryRequest, global::Aserto.Authorizer.V2.QueryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Query",
        __Marshaller_aserto_authorizer_v2_QueryRequest,
        __Marshaller_aserto_authorizer_v2_QueryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.CompileRequest, global::Aserto.Authorizer.V2.CompileResponse> __Method_Compile = new grpc::Method<global::Aserto.Authorizer.V2.CompileRequest, global::Aserto.Authorizer.V2.CompileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Compile",
        __Marshaller_aserto_authorizer_v2_CompileRequest,
        __Marshaller_aserto_authorizer_v2_CompileResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.ListPoliciesRequest, global::Aserto.Authorizer.V2.ListPoliciesResponse> __Method_ListPolicies = new grpc::Method<global::Aserto.Authorizer.V2.ListPoliciesRequest, global::Aserto.Authorizer.V2.ListPoliciesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPolicies",
        __Marshaller_aserto_authorizer_v2_ListPoliciesRequest,
        __Marshaller_aserto_authorizer_v2_ListPoliciesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Authorizer.V2.GetPolicyRequest, global::Aserto.Authorizer.V2.GetPolicyResponse> __Method_GetPolicy = new grpc::Method<global::Aserto.Authorizer.V2.GetPolicyRequest, global::Aserto.Authorizer.V2.GetPolicyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPolicy",
        __Marshaller_aserto_authorizer_v2_GetPolicyRequest,
        __Marshaller_aserto_authorizer_v2_GetPolicyResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Aserto.Authorizer.V2.AuthorizerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Authorizer</summary>
    public partial class AuthorizerClient : grpc::ClientBase<AuthorizerClient>
    {
      /// <summary>Creates a new client for Authorizer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AuthorizerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Authorizer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AuthorizerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AuthorizerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AuthorizerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.DecisionTreeResponse DecisionTree(global::Aserto.Authorizer.V2.DecisionTreeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DecisionTree(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.DecisionTreeResponse DecisionTree(global::Aserto.Authorizer.V2.DecisionTreeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DecisionTree, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.DecisionTreeResponse> DecisionTreeAsync(global::Aserto.Authorizer.V2.DecisionTreeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DecisionTreeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.DecisionTreeResponse> DecisionTreeAsync(global::Aserto.Authorizer.V2.DecisionTreeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DecisionTree, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.IsResponse Is(global::Aserto.Authorizer.V2.IsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Is(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.IsResponse Is(global::Aserto.Authorizer.V2.IsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Is, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.IsResponse> IsAsync(global::Aserto.Authorizer.V2.IsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.IsResponse> IsAsync(global::Aserto.Authorizer.V2.IsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Is, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.QueryResponse Query(global::Aserto.Authorizer.V2.QueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Query(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.QueryResponse Query(global::Aserto.Authorizer.V2.QueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Query, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.QueryResponse> QueryAsync(global::Aserto.Authorizer.V2.QueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.QueryResponse> QueryAsync(global::Aserto.Authorizer.V2.QueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Query, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.CompileResponse Compile(global::Aserto.Authorizer.V2.CompileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Compile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.CompileResponse Compile(global::Aserto.Authorizer.V2.CompileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Compile, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.CompileResponse> CompileAsync(global::Aserto.Authorizer.V2.CompileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CompileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.CompileResponse> CompileAsync(global::Aserto.Authorizer.V2.CompileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Compile, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.ListPoliciesResponse ListPolicies(global::Aserto.Authorizer.V2.ListPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPolicies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.ListPoliciesResponse ListPolicies(global::Aserto.Authorizer.V2.ListPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPolicies, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.ListPoliciesResponse> ListPoliciesAsync(global::Aserto.Authorizer.V2.ListPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPoliciesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.ListPoliciesResponse> ListPoliciesAsync(global::Aserto.Authorizer.V2.ListPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPolicies, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.GetPolicyResponse GetPolicy(global::Aserto.Authorizer.V2.GetPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Authorizer.V2.GetPolicyResponse GetPolicy(global::Aserto.Authorizer.V2.GetPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPolicy, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.GetPolicyResponse> GetPolicyAsync(global::Aserto.Authorizer.V2.GetPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Authorizer.V2.GetPolicyResponse> GetPolicyAsync(global::Aserto.Authorizer.V2.GetPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPolicy, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AuthorizerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AuthorizerClient(configuration);
      }
    }

  }
}
#endregion
