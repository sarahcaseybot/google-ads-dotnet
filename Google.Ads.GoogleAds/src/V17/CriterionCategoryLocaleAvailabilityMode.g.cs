// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/criterion_category_locale_availability_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/criterion_category_locale_availability_mode.proto</summary>
  public static partial class CriterionCategoryLocaleAvailabilityModeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/criterion_category_locale_availability_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionCategoryLocaleAvailabilityModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvY3JpdGVyaW9uX2Nh",
            "dGVnb3J5X2xvY2FsZV9hdmFpbGFiaWxpdHlfbW9kZS5wcm90bxIeZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE3LmVudW1zIuEBCitDcml0ZXJpb25DYXRlZ29y",
            "eUxvY2FsZUF2YWlsYWJpbGl0eU1vZGVFbnVtIrEBCidDcml0ZXJpb25DYXRl",
            "Z29yeUxvY2FsZUF2YWlsYWJpbGl0eU1vZGUSDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESDwoLQUxMX0xPQ0FMRVMQAhIdChlDT1VOVFJZX0FORF9B",
            "TExfTEFOR1VBR0VTEAMSHgoaTEFOR1VBR0VfQU5EX0FMTF9DT1VOVFJJRVMQ",
            "BBIYChRDT1VOVFJZX0FORF9MQU5HVUFHRRAFQoYCCiJjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjE3LmVudW1zQixDcml0ZXJpb25DYXRlZ29yeUxvY2Fs",
            "ZUF2YWlsYWJpbGl0eU1vZGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE3L2VudW1zO2Vu",
            "dW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE3LkVudW1zygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjE3XEVudW1z6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjE3OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.CriterionCategoryLocaleAvailabilityModeEnum), global::Google.Ads.GoogleAds.V17.Enums.CriterionCategoryLocaleAvailabilityModeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.CriterionCategoryLocaleAvailabilityModeEnum.Types.CriterionCategoryLocaleAvailabilityMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes locale availability mode for a criterion availability - whether
  /// it's available globally, or a particular country with all languages, or a
  /// particular language with all countries, or a country-language pair.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CriterionCategoryLocaleAvailabilityModeEnum : pb::IMessage<CriterionCategoryLocaleAvailabilityModeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CriterionCategoryLocaleAvailabilityModeEnum> _parser = new pb::MessageParser<CriterionCategoryLocaleAvailabilityModeEnum>(() => new CriterionCategoryLocaleAvailabilityModeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CriterionCategoryLocaleAvailabilityModeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.CriterionCategoryLocaleAvailabilityModeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryLocaleAvailabilityModeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryLocaleAvailabilityModeEnum(CriterionCategoryLocaleAvailabilityModeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryLocaleAvailabilityModeEnum Clone() {
      return new CriterionCategoryLocaleAvailabilityModeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CriterionCategoryLocaleAvailabilityModeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CriterionCategoryLocaleAvailabilityModeEnum other) {
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
    public void MergeFrom(CriterionCategoryLocaleAvailabilityModeEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionCategoryLocaleAvailabilityModeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum containing the possible CriterionCategoryLocaleAvailabilityMode.
      /// </summary>
      public enum CriterionCategoryLocaleAvailabilityMode {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The category is available to campaigns of all locales.
        /// </summary>
        [pbr::OriginalName("ALL_LOCALES")] AllLocales = 2,
        /// <summary>
        /// The category is available to campaigns within a list of countries,
        /// regardless of language.
        /// </summary>
        [pbr::OriginalName("COUNTRY_AND_ALL_LANGUAGES")] CountryAndAllLanguages = 3,
        /// <summary>
        /// The category is available to campaigns within a list of languages,
        /// regardless of country.
        /// </summary>
        [pbr::OriginalName("LANGUAGE_AND_ALL_COUNTRIES")] LanguageAndAllCountries = 4,
        /// <summary>
        /// The category is available to campaigns within a list of country, language
        /// pairs.
        /// </summary>
        [pbr::OriginalName("COUNTRY_AND_LANGUAGE")] CountryAndLanguage = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
