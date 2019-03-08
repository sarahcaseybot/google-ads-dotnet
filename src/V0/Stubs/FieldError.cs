// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/field_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/field_error.proto</summary>
  public static partial class FieldErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/field_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvZmllbGRfZXJyb3Iu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9ycxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byLFAQoORmllbGRFcnJvckVudW0isgEK",
            "CkZpZWxkRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoI",
            "UkVRVUlSRUQQAhITCg9JTU1VVEFCTEVfRklFTEQQAxIRCg1JTlZBTElEX1ZB",
            "TFVFEAQSFwoTVkFMVUVfTVVTVF9CRV9VTlNFVBAFEhoKFlJFUVVJUkVEX05P",
            "TkVNUFRZX0xJU1QQBhIbChdGSUVMRF9DQU5OT1RfQkVfQ0xFQVJFRBAHQuoB",
            "CiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJyb3JzQg9GaWVsZEVy",
            "cm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5H",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMFxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.FieldErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.FieldErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.FieldErrorEnum.Types.FieldError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible field errors.
  /// </summary>
  public sealed partial class FieldErrorEnum : pb::IMessage<FieldErrorEnum> {
    private static readonly pb::MessageParser<FieldErrorEnum> _parser = new pb::MessageParser<FieldErrorEnum>(() => new FieldErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FieldErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.FieldErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FieldErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FieldErrorEnum(FieldErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FieldErrorEnum Clone() {
      return new FieldErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FieldErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FieldErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FieldErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        /// The required field was not present in the resource.
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
