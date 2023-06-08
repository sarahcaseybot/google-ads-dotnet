// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/errors/field_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/errors/field_error.proto</summary>
  public static partial class FieldErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/errors/field_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZXJyb3JzL2ZpZWxkX2Vycm9y",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQuZXJyb3JzIvcBCg5G",
            "aWVsZEVycm9yRW51bSLkAQoKRmllbGRFcnJvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIMCghSRVFVSVJFRBACEhMKD0lNTVVUQUJMRV9GSUVM",
            "RBADEhEKDUlOVkFMSURfVkFMVUUQBBIXChNWQUxVRV9NVVNUX0JFX1VOU0VU",
            "EAUSGgoWUkVRVUlSRURfTk9ORU1QVFlfTElTVBAGEhsKF0ZJRUxEX0NBTk5P",
            "VF9CRV9DTEVBUkVEEAcSEQoNQkxPQ0tFRF9WQUxVRRAJEh0KGUZJRUxEX0NB",
            "Tl9PTkxZX0JFX0NMRUFSRUQQCkLvAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNC5lcnJvcnNCD0ZpZWxkRXJyb3JQcm90b1ABWkVnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE0",
            "L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTQuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0XEVycm9yc+oC",
            "I0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Errors.FieldErrorEnum), global::Google.Ads.GoogleAds.V14.Errors.FieldErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Errors.FieldErrorEnum.Types.FieldError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible field errors.
  /// </summary>
  public sealed partial class FieldErrorEnum : pb::IMessage<FieldErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FieldErrorEnum> _parser = new pb::MessageParser<FieldErrorEnum>(() => new FieldErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FieldErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Errors.FieldErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum(FieldErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum Clone() {
      return new FieldErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FieldErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FieldErrorEnum other) {
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
    public void MergeFrom(FieldErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FieldErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible field errors.
      /// </summary>
      public enum FieldError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The required field was not present.
        /// </summary>
        [pbr::OriginalName("REQUIRED")] Required = 2,
        /// <summary>
        /// The field attempted to be mutated is immutable.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 3,
        /// <summary>
        /// The field's value is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE")] InvalidValue = 4,
        /// <summary>
        /// The field cannot be set.
        /// </summary>
        [pbr::OriginalName("VALUE_MUST_BE_UNSET")] ValueMustBeUnset = 5,
        /// <summary>
        /// The required repeated field was empty.
        /// </summary>
        [pbr::OriginalName("REQUIRED_NONEMPTY_LIST")] RequiredNonemptyList = 6,
        /// <summary>
        /// The field cannot be cleared.
        /// </summary>
        [pbr::OriginalName("FIELD_CANNOT_BE_CLEARED")] FieldCannotBeCleared = 7,
        /// <summary>
        /// The field's value is on a deny-list for this field.
        /// </summary>
        [pbr::OriginalName("BLOCKED_VALUE")] BlockedValue = 9,
        /// <summary>
        /// The field's value cannot be modified, except for clearing.
        /// </summary>
        [pbr::OriginalName("FIELD_CAN_ONLY_BE_CLEARED")] FieldCanOnlyBeCleared = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
