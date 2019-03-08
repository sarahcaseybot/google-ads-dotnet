// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/price_extension_price_qualifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/price_extension_price_qualifier.proto</summary>
  public static partial class PriceExtensionPriceQualifierReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/price_extension_price_qualifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceExtensionPriceQualifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9wcmljZV9leHRlbnNp",
            "b25fcHJpY2VfcXVhbGlmaWVyLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MS5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKCAQog",
            "UHJpY2VFeHRlbnNpb25QcmljZVF1YWxpZmllckVudW0iXgocUHJpY2VFeHRl",
            "bnNpb25QcmljZVF1YWxpZmllchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIICgRGUk9NEAISCQoFVVBfVE8QAxILCgdBVkVSQUdFEARC9gEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtc0IhUHJpY2VFeHRlbnNp",
            "b25QcmljZVF1YWxpZmllclByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkVudW1zygIdR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjFcRW51bXPqAiFHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.PriceExtensionPriceQualifierEnum), global::Google.Ads.GoogleAds.V1.Enums.PriceExtensionPriceQualifierEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.PriceExtensionPriceQualifierEnum.Types.PriceExtensionPriceQualifier) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing a price extension price qualifier.
  /// </summary>
  public sealed partial class PriceExtensionPriceQualifierEnum : pb::IMessage<PriceExtensionPriceQualifierEnum> {
    private static readonly pb::MessageParser<PriceExtensionPriceQualifierEnum> _parser = new pb::MessageParser<PriceExtensionPriceQualifierEnum>(() => new PriceExtensionPriceQualifierEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceExtensionPriceQualifierEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.PriceExtensionPriceQualifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceQualifierEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceQualifierEnum(PriceExtensionPriceQualifierEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceQualifierEnum Clone() {
      return new PriceExtensionPriceQualifierEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceExtensionPriceQualifierEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceExtensionPriceQualifierEnum other) {
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
    public void MergeFrom(PriceExtensionPriceQualifierEnum other) {
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
    /// <summary>Container for nested types declared in the PriceExtensionPriceQualifierEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enums of price extension price qualifier.
      /// </summary>
      public enum PriceExtensionPriceQualifier {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// 'From' qualifier for the price.
        /// </summary>
        [pbr::OriginalName("FROM")] From = 2,
        /// <summary>
        /// 'Up to' qualifier for the price.
        /// </summary>
        [pbr::OriginalName("UP_TO")] UpTo = 3,
        /// <summary>
        /// 'Average' qualifier for the price.
        /// </summary>
        [pbr::OriginalName("AVERAGE")] Average = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
