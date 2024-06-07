// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/errors/mutate_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/errors/mutate_error.proto</summary>
  public static partial class MutateErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/errors/mutate_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MutateErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZXJyb3JzL211dGF0ZV9lcnJv",
            "ci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LmVycm9ycyLjAgoP",
            "TXV0YXRlRXJyb3JFbnVtIs8CCgtNdXRhdGVFcnJvchIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIWChJSRVNPVVJDRV9OT1RfRk9VTkQQAxIhCh1J",
            "RF9FWElTVFNfSU5fTVVMVElQTEVfTVVUQVRFUxAHEh0KGUlOQ09OU0lTVEVO",
            "VF9GSUVMRF9WQUxVRVMQCBIWChJNVVRBVEVfTk9UX0FMTE9XRUQQCRIeChpS",
            "RVNPVVJDRV9OT1RfSU5fR09PR0xFX0FEUxAKEhsKF1JFU09VUkNFX0FMUkVB",
            "RFlfRVhJU1RTEAsSKwonUkVTT1VSQ0VfRE9FU19OT1RfU1VQUE9SVF9WQUxJ",
            "REFURV9PTkxZEAwSLgoqT1BFUkFUSU9OX0RPRVNfTk9UX1NVUFBPUlRfUEFS",
            "VElBTF9GQUlMVVJFEBASFgoSUkVTT1VSQ0VfUkVBRF9PTkxZEA1C8AEKI2Nv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcuZXJyb3JzQhBNdXRhdGVFcnJv",
            "clByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTcvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxNy5FcnJvcnPKAh9Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMTdcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjE3OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Errors.MutateErrorEnum), global::Google.Ads.GoogleAds.V17.Errors.MutateErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Errors.MutateErrorEnum.Types.MutateError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible mutate errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MutateErrorEnum : pb::IMessage<MutateErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MutateErrorEnum> _parser = new pb::MessageParser<MutateErrorEnum>(() => new MutateErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MutateErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Errors.MutateErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MutateErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MutateErrorEnum(MutateErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MutateErrorEnum Clone() {
      return new MutateErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MutateErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MutateErrorEnum other) {
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
    public void MergeFrom(MutateErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MutateErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible mutate errors.
      /// </summary>
      public enum MutateError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Requested resource was not found.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_FOUND")] ResourceNotFound = 3,
        /// <summary>
        /// Cannot mutate the same resource twice in one request.
        /// </summary>
        [pbr::OriginalName("ID_EXISTS_IN_MULTIPLE_MUTATES")] IdExistsInMultipleMutates = 7,
        /// <summary>
        /// The field's contents don't match another field that represents the same
        /// data.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_FIELD_VALUES")] InconsistentFieldValues = 8,
        /// <summary>
        /// Mutates are not allowed for the requested resource.
        /// </summary>
        [pbr::OriginalName("MUTATE_NOT_ALLOWED")] MutateNotAllowed = 9,
        /// <summary>
        /// The resource isn't in Google Ads. It belongs to another ads system.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_IN_GOOGLE_ADS")] ResourceNotInGoogleAds = 10,
        /// <summary>
        /// The resource being created already exists.
        /// </summary>
        [pbr::OriginalName("RESOURCE_ALREADY_EXISTS")] ResourceAlreadyExists = 11,
        /// <summary>
        /// This resource cannot be used with "validate_only".
        /// </summary>
        [pbr::OriginalName("RESOURCE_DOES_NOT_SUPPORT_VALIDATE_ONLY")] ResourceDoesNotSupportValidateOnly = 12,
        /// <summary>
        /// This operation cannot be used with "partial_failure".
        /// </summary>
        [pbr::OriginalName("OPERATION_DOES_NOT_SUPPORT_PARTIAL_FAILURE")] OperationDoesNotSupportPartialFailure = 16,
        /// <summary>
        /// Attempt to write to read-only fields.
        /// </summary>
        [pbr::OriginalName("RESOURCE_READ_ONLY")] ResourceReadOnly = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
