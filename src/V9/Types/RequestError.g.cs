// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/request_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/request_error.proto</summary>
  public static partial class RequestErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/request_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMvcmVxdWVzdF9lcnJv",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZXJyb3JzGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIrsGChBSZXF1ZXN0RXJyb3JFbnVt",
            "IqYGCgxSZXF1ZXN0RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESGQoVUkVTT1VSQ0VfTkFNRV9NSVNTSU5HEAMSGwoXUkVTT1VSQ0VfTkFN",
            "RV9NQUxGT1JNRUQQBBITCg9CQURfUkVTT1VSQ0VfSUQQERIXChNJTlZBTElE",
            "X0NVU1RPTUVSX0lEEBASFgoST1BFUkFUSU9OX1JFUVVJUkVEEAUSFgoSUkVT",
            "T1VSQ0VfTk9UX0ZPVU5EEAYSFgoSSU5WQUxJRF9QQUdFX1RPS0VOEAcSFgoS",
            "RVhQSVJFRF9QQUdFX1RPS0VOEAgSFQoRSU5WQUxJRF9QQUdFX1NJWkUQFhIa",
            "ChZSRVFVSVJFRF9GSUVMRF9NSVNTSU5HEAkSEwoPSU1NVVRBQkxFX0ZJRUxE",
            "EAsSHgoaVE9PX01BTllfTVVUQVRFX09QRVJBVElPTlMQDRIpCiVDQU5OT1Rf",
            "QkVfRVhFQ1VURURfQllfTUFOQUdFUl9BQ0NPVU5UEA4SHwobQ0FOTk9UX01P",
            "RElGWV9GT1JFSUdOX0ZJRUxEEA8SFgoSSU5WQUxJRF9FTlVNX1ZBTFVFEBIS",
            "JQohREVWRUxPUEVSX1RPS0VOX1BBUkFNRVRFUl9NSVNTSU5HEBMSJwojTE9H",
            "SU5fQ1VTVE9NRVJfSURfUEFSQU1FVEVSX01JU1NJTkcQFBIoCiRWQUxJREFU",
            "RV9PTkxZX1JFUVVFU1RfSEFTX1BBR0VfVE9LRU4QFRI5CjVDQU5OT1RfUkVU",
            "VVJOX1NVTU1BUllfUk9XX0ZPUl9SRVFVRVNUX1dJVEhPVVRfTUVUUklDUxAd",
            "EjgKNENBTk5PVF9SRVRVUk5fU1VNTUFSWV9ST1dfRk9SX1ZBTElEQVRFX09O",
            "TFlfUkVRVUVTVFMQHhIpCiVJTkNPTlNJU1RFTlRfUkVUVVJOX1NVTU1BUllf",
            "Uk9XX1ZBTFVFEB8SMAosVE9UQUxfUkVTVUxUU19DT1VOVF9OT1RfT1JJR0lO",
            "QUxMWV9SRVFVRVNURUQQIBIaChZSUENfREVBRExJTkVfVE9PX1NIT1JUECFC",
            "7AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5lcnJvcnNCEVJlcXVl",
            "c3RFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnM7ZXJyb3JzogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjkuRXJyb3JzygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjlcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6Vjk6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.RequestErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.RequestErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.RequestErrorEnum.Types.RequestError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible request errors.
  /// </summary>
  public sealed partial class RequestErrorEnum : pb::IMessage<RequestErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RequestErrorEnum> _parser = new pb::MessageParser<RequestErrorEnum>(() => new RequestErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RequestErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.RequestErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestErrorEnum(RequestErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestErrorEnum Clone() {
      return new RequestErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RequestErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RequestErrorEnum other) {
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
    public void MergeFrom(RequestErrorEnum other) {
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
    /// <summary>Container for nested types declared in the RequestErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible request errors.
      /// </summary>
      public enum RequestError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Resource name is required for this request.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NAME_MISSING")] ResourceNameMissing = 3,
        /// <summary>
        /// Resource name provided is malformed.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NAME_MALFORMED")] ResourceNameMalformed = 4,
        /// <summary>
        /// Resource name provided is malformed.
        /// </summary>
        [pbr::OriginalName("BAD_RESOURCE_ID")] BadResourceId = 17,
        /// <summary>
        /// Customer ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOMER_ID")] InvalidCustomerId = 16,
        /// <summary>
        /// Mutate operation should have either create, update, or remove specified.
        /// </summary>
        [pbr::OriginalName("OPERATION_REQUIRED")] OperationRequired = 5,
        /// <summary>
        /// Requested resource not found.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_FOUND")] ResourceNotFound = 6,
        /// <summary>
        /// Next page token specified in user request is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PAGE_TOKEN")] InvalidPageToken = 7,
        /// <summary>
        /// Next page token specified in user request has expired.
        /// </summary>
        [pbr::OriginalName("EXPIRED_PAGE_TOKEN")] ExpiredPageToken = 8,
        /// <summary>
        /// Page size specified in user request is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PAGE_SIZE")] InvalidPageSize = 22,
        /// <summary>
        /// Required field is missing.
        /// </summary>
        [pbr::OriginalName("REQUIRED_FIELD_MISSING")] RequiredFieldMissing = 9,
        /// <summary>
        /// The field cannot be modified because it's immutable. It's also possible
        /// that the field can be modified using 'create' operation but not 'update'.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 11,
        /// <summary>
        /// Received too many entries in request.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_MUTATE_OPERATIONS")] TooManyMutateOperations = 13,
        /// <summary>
        /// Request cannot be executed by a manager account.
        /// </summary>
        [pbr::OriginalName("CANNOT_BE_EXECUTED_BY_MANAGER_ACCOUNT")] CannotBeExecutedByManagerAccount = 14,
        /// <summary>
        /// Mutate request was attempting to modify a readonly field.
        /// For instance, Budget fields can be requested for Ad Group,
        /// but are read-only for adGroups:mutate.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FOREIGN_FIELD")] CannotModifyForeignField = 15,
        /// <summary>
        /// Enum value is not permitted.
        /// </summary>
        [pbr::OriginalName("INVALID_ENUM_VALUE")] InvalidEnumValue = 18,
        /// <summary>
        /// The developer-token parameter is required for all requests.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_PARAMETER_MISSING")] DeveloperTokenParameterMissing = 19,
        /// <summary>
        /// The login-customer-id parameter is required for this request.
        /// </summary>
        [pbr::OriginalName("LOGIN_CUSTOMER_ID_PARAMETER_MISSING")] LoginCustomerIdParameterMissing = 20,
        /// <summary>
        /// page_token is set in the validate only request
        /// </summary>
        [pbr::OriginalName("VALIDATE_ONLY_REQUEST_HAS_PAGE_TOKEN")] ValidateOnlyRequestHasPageToken = 21,
        /// <summary>
        /// return_summary_row cannot be enabled if request did not select any
        /// metrics field.
        /// </summary>
        [pbr::OriginalName("CANNOT_RETURN_SUMMARY_ROW_FOR_REQUEST_WITHOUT_METRICS")] CannotReturnSummaryRowForRequestWithoutMetrics = 29,
        /// <summary>
        /// return_summary_row should not be enabled for validate only requests.
        /// </summary>
        [pbr::OriginalName("CANNOT_RETURN_SUMMARY_ROW_FOR_VALIDATE_ONLY_REQUESTS")] CannotReturnSummaryRowForValidateOnlyRequests = 30,
        /// <summary>
        /// return_summary_row parameter value should be the same between requests
        /// with page_token field set and their original request.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_RETURN_SUMMARY_ROW_VALUE")] InconsistentReturnSummaryRowValue = 31,
        /// <summary>
        /// The total results count cannot be returned if it was not requested in the
        /// original request.
        /// </summary>
        [pbr::OriginalName("TOTAL_RESULTS_COUNT_NOT_ORIGINALLY_REQUESTED")] TotalResultsCountNotOriginallyRequested = 32,
        /// <summary>
        /// Deadline specified by the client was too short.
        /// </summary>
        [pbr::OriginalName("RPC_DEADLINE_TOO_SHORT")] RpcDeadlineTooShort = 33,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
