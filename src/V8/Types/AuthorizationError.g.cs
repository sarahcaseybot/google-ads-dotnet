// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/errors/authorization_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/errors/authorization_error.proto</summary>
  public static partial class AuthorizationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/errors/authorization_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthorizationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lcnJvcnMvYXV0aG9yaXphdGlv",
            "bl9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjguZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItoDChZBdXRob3JpemF0",
            "aW9uRXJyb3JFbnVtIr8DChJBdXRob3JpemF0aW9uRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESGgoWVVNFUl9QRVJNSVNTSU9OX0RFTklF",
            "RBACEiQKIERFVkVMT1BFUl9UT0tFTl9OT1RfT05fQUxMT1dMSVNUEA0SHgoa",
            "REVWRUxPUEVSX1RPS0VOX1BST0hJQklURUQQBBIUChBQUk9KRUNUX0RJU0FC",
            "TEVEEAUSFwoTQVVUSE9SSVpBVElPTl9FUlJPUhAGEhgKFEFDVElPTl9OT1Rf",
            "UEVSTUlUVEVEEAcSFQoRSU5DT01QTEVURV9TSUdOVVAQCBIYChRDVVNUT01F",
            "Ul9OT1RfRU5BQkxFRBAYEg8KC01JU1NJTkdfVE9TEAkSIAocREVWRUxPUEVS",
            "X1RPS0VOX05PVF9BUFBST1ZFRBAKEj0KOUlOVkFMSURfTE9HSU5fQ1VTVE9N",
            "RVJfSURfU0VSVklOR19DVVNUT01FUl9JRF9DT01CSU5BVElPThALEhkKFVNF",
            "UlZJQ0VfQUNDRVNTX0RFTklFRBAMEiIKHkFDQ0VTU19ERU5JRURfRk9SX0FD",
            "Q09VTlRfVFlQRRAZQvIBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjgu",
            "ZXJyb3JzQhdBdXRob3JpemF0aW9uRXJyb3JQcm90b1ABWkRnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjgv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY4",
            "LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY4XEVycm9yc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlY4OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Errors.AuthorizationErrorEnum), global::Google.Ads.GoogleAds.V8.Errors.AuthorizationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Errors.AuthorizationErrorEnum.Types.AuthorizationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible authorization errors.
  /// </summary>
  public sealed partial class AuthorizationErrorEnum : pb::IMessage<AuthorizationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthorizationErrorEnum> _parser = new pb::MessageParser<AuthorizationErrorEnum>(() => new AuthorizationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AuthorizationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Errors.AuthorizationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorizationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorizationErrorEnum(AuthorizationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorizationErrorEnum Clone() {
      return new AuthorizationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AuthorizationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AuthorizationErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AuthorizationErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AuthorizationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible authorization errors.
      /// </summary>
      public enum AuthorizationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// User doesn't have permission to access customer. Note: If you're
        /// accessing a client customer, the manager's customer ID must be set in the
        /// `login-customer-id` header. Learn more at
        /// https://developers.google.com/google-ads/api/docs/concepts/call-structure#cid
        /// </summary>
        [pbr::OriginalName("USER_PERMISSION_DENIED")] UserPermissionDenied = 2,
        /// <summary>
        /// The developer token is not on the allow-list.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_NOT_ON_ALLOWLIST")] DeveloperTokenNotOnAllowlist = 13,
        /// <summary>
        /// The developer token is not allowed with the project sent in the request.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_PROHIBITED")] DeveloperTokenProhibited = 4,
        /// <summary>
        /// The Google Cloud project sent in the request does not have permission to
        /// access the api.
        /// </summary>
        [pbr::OriginalName("PROJECT_DISABLED")] ProjectDisabled = 5,
        /// <summary>
        /// Authorization of the client failed.
        /// </summary>
        [pbr::OriginalName("AUTHORIZATION_ERROR")] AuthorizationError = 6,
        /// <summary>
        /// The user does not have permission to perform this action
        /// (e.g., ADD, UPDATE, REMOVE) on the resource or call a method.
        /// </summary>
        [pbr::OriginalName("ACTION_NOT_PERMITTED")] ActionNotPermitted = 7,
        /// <summary>
        /// Signup not complete.
        /// </summary>
        [pbr::OriginalName("INCOMPLETE_SIGNUP")] IncompleteSignup = 8,
        /// <summary>
        /// The customer can't be used because it isn't enabled.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ENABLED")] CustomerNotEnabled = 24,
        /// <summary>
        /// The developer must sign the terms of service. They can be found here:
        /// ads.google.com/aw/apicenter
        /// </summary>
        [pbr::OriginalName("MISSING_TOS")] MissingTos = 9,
        /// <summary>
        /// The developer token is not approved. Non-approved developer tokens can
        /// only be used with test accounts.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_NOT_APPROVED")] DeveloperTokenNotApproved = 10,
        /// <summary>
        /// The login customer specified does not have access to the account
        /// specified, so the request is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_LOGIN_CUSTOMER_ID_SERVING_CUSTOMER_ID_COMBINATION")] InvalidLoginCustomerIdServingCustomerIdCombination = 11,
        /// <summary>
        /// The developer specified does not have access to the service.
        /// </summary>
        [pbr::OriginalName("SERVICE_ACCESS_DENIED")] ServiceAccessDenied = 12,
        /// <summary>
        /// The customer (or login customer) isn't in Google Ads. It belongs to
        /// another ads system.
        /// </summary>
        [pbr::OriginalName("ACCESS_DENIED_FOR_ACCOUNT_TYPE")] AccessDeniedForAccountType = 25,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
