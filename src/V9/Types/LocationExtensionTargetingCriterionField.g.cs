// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/location_extension_targeting_criterion_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/location_extension_targeting_criterion_field.proto</summary>
  public static partial class LocationExtensionTargetingCriterionFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/location_extension_targeting_criterion_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationExtensionTargetingCriterionFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9sb2NhdGlvbl9leHRl",
            "bnNpb25fdGFyZ2V0aW5nX2NyaXRlcmlvbl9maWVsZC5wcm90bxIdZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjkuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlv",
            "bnMucHJvdG8i3AEKLExvY2F0aW9uRXh0ZW5zaW9uVGFyZ2V0aW5nQ3JpdGVy",
            "aW9uRmllbGRFbnVtIqsBCihMb2NhdGlvbkV4dGVuc2lvblRhcmdldGluZ0Ny",
            "aXRlcmlvbkZpZWxkEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhIK",
            "DkFERFJFU1NfTElORV8xEAISEgoOQUREUkVTU19MSU5FXzIQAxIICgRDSVRZ",
            "EAQSDAoIUFJPVklOQ0UQBRIPCgtQT1NUQUxfQ09ERRAGEhAKDENPVU5UUllf",
            "Q09ERRAHQoICCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXNC",
            "LUxvY2F0aW9uRXh0ZW5zaW9uVGFyZ2V0aW5nQ3JpdGVyaW9uRmllbGRQcm90",
            "b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjkvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WOS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5",
            "XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjk6OkVudW1zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.LocationExtensionTargetingCriterionFieldEnum), global::Google.Ads.GoogleAds.V9.Enums.LocationExtensionTargetingCriterionFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.LocationExtensionTargetingCriterionFieldEnum.Types.LocationExtensionTargetingCriterionField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Location Extension Targeting criterion fields.
  /// </summary>
  public sealed partial class LocationExtensionTargetingCriterionFieldEnum : pb::IMessage<LocationExtensionTargetingCriterionFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocationExtensionTargetingCriterionFieldEnum> _parser = new pb::MessageParser<LocationExtensionTargetingCriterionFieldEnum>(() => new LocationExtensionTargetingCriterionFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocationExtensionTargetingCriterionFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.LocationExtensionTargetingCriterionFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationExtensionTargetingCriterionFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationExtensionTargetingCriterionFieldEnum(LocationExtensionTargetingCriterionFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationExtensionTargetingCriterionFieldEnum Clone() {
      return new LocationExtensionTargetingCriterionFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocationExtensionTargetingCriterionFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocationExtensionTargetingCriterionFieldEnum other) {
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
    public void MergeFrom(LocationExtensionTargetingCriterionFieldEnum other) {
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
    /// <summary>Container for nested types declared in the LocationExtensionTargetingCriterionFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Location Extension Targeting criterion fields.
      /// </summary>
      public enum LocationExtensionTargetingCriterionField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Line 1 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_1")] AddressLine1 = 2,
        /// <summary>
        /// Data Type: STRING. Line 2 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_2")] AddressLine2 = 3,
        /// <summary>
        /// Data Type: STRING. City of the business address.
        /// </summary>
        [pbr::OriginalName("CITY")] City = 4,
        /// <summary>
        /// Data Type: STRING. Province of the business address.
        /// </summary>
        [pbr::OriginalName("PROVINCE")] Province = 5,
        /// <summary>
        /// Data Type: STRING. Postal code of the business address.
        /// </summary>
        [pbr::OriginalName("POSTAL_CODE")] PostalCode = 6,
        /// <summary>
        /// Data Type: STRING. Country code of the business address.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
