// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/reach_plan_age_range.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/reach_plan_age_range.proto</summary>
  public static partial class ReachPlanAgeRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/reach_plan_age_range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReachPlanAgeRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvcmVhY2hfcGxhbl9h",
            "Z2VfcmFuZ2UucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNy5lbnVt",
            "cyKLBQoVUmVhY2hQbGFuQWdlUmFuZ2VFbnVtIvEEChFSZWFjaFBsYW5BZ2VS",
            "YW5nZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIVCg9BR0VfUkFO",
            "R0VfMThfMjQQ2dkeEhMKD0FHRV9SQU5HRV8xOF8zNBACEhMKD0FHRV9SQU5H",
            "RV8xOF80NBADEhMKD0FHRV9SQU5HRV8xOF80ORAEEhMKD0FHRV9SQU5HRV8x",
            "OF81NBAFEhMKD0FHRV9SQU5HRV8xOF82NBAGEhYKEkFHRV9SQU5HRV8xOF82",
            "NV9VUBAHEhMKD0FHRV9SQU5HRV8yMV8zNBAIEhUKD0FHRV9SQU5HRV8yNV8z",
            "NBDa2R4SEwoPQUdFX1JBTkdFXzI1XzQ0EAkSEwoPQUdFX1JBTkdFXzI1XzQ5",
            "EAoSEwoPQUdFX1JBTkdFXzI1XzU0EAsSEwoPQUdFX1JBTkdFXzI1XzY0EAwS",
            "FgoSQUdFX1JBTkdFXzI1XzY1X1VQEA0SFQoPQUdFX1JBTkdFXzM1XzQ0ENvZ",
            "HhITCg9BR0VfUkFOR0VfMzVfNDkQDhITCg9BR0VfUkFOR0VfMzVfNTQQDxIT",
            "Cg9BR0VfUkFOR0VfMzVfNjQQEBIWChJBR0VfUkFOR0VfMzVfNjVfVVAQERIV",
            "Cg9BR0VfUkFOR0VfNDVfNTQQ3NkeEhMKD0FHRV9SQU5HRV80NV82NBASEhYK",
            "EkFHRV9SQU5HRV80NV82NV9VUBATEhYKEkFHRV9SQU5HRV81MF82NV9VUBAU",
            "EhUKD0FHRV9SQU5HRV81NV82NBDd2R4SFgoSQUdFX1JBTkdFXzU1XzY1X1VQ",
            "EBUSFQoPQUdFX1JBTkdFXzY1X1VQEN7ZHkLwAQoiY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNy5lbnVtc0IWUmVhY2hQbGFuQWdlUmFuZ2VQcm90b1AB",
            "WkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjE3L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjE3LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE3",
            "XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE3OjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.ReachPlanAgeRangeEnum), global::Google.Ads.GoogleAds.V17.Enums.ReachPlanAgeRangeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.ReachPlanAgeRangeEnum.Types.ReachPlanAgeRange) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing plannable age ranges.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ReachPlanAgeRangeEnum : pb::IMessage<ReachPlanAgeRangeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReachPlanAgeRangeEnum> _parser = new pb::MessageParser<ReachPlanAgeRangeEnum>(() => new ReachPlanAgeRangeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReachPlanAgeRangeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.ReachPlanAgeRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum(ReachPlanAgeRangeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReachPlanAgeRangeEnum Clone() {
      return new ReachPlanAgeRangeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReachPlanAgeRangeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReachPlanAgeRangeEnum other) {
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
    public void MergeFrom(ReachPlanAgeRangeEnum other) {
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
    /// <summary>Container for nested types declared in the ReachPlanAgeRangeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible plannable age range values.
      /// </summary>
      public enum ReachPlanAgeRange {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Between 18 and 24 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_24")] AgeRange1824 = 503001,
        /// <summary>
        /// Between 18 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_34")] AgeRange1834 = 2,
        /// <summary>
        /// Between 18 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_44")] AgeRange1844 = 3,
        /// <summary>
        /// Between 18 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_49")] AgeRange1849 = 4,
        /// <summary>
        /// Between 18 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_54")] AgeRange1854 = 5,
        /// <summary>
        /// Between 18 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_64")] AgeRange1864 = 6,
        /// <summary>
        /// Between 18 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_65_UP")] AgeRange1865Up = 7,
        /// <summary>
        /// Between 21 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_21_34")] AgeRange2134 = 8,
        /// <summary>
        /// Between 25 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_34")] AgeRange2534 = 503002,
        /// <summary>
        /// Between 25 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_44")] AgeRange2544 = 9,
        /// <summary>
        /// Between 25 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_49")] AgeRange2549 = 10,
        /// <summary>
        /// Between 25 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_54")] AgeRange2554 = 11,
        /// <summary>
        /// Between 25 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_64")] AgeRange2564 = 12,
        /// <summary>
        /// Between 25 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_65_UP")] AgeRange2565Up = 13,
        /// <summary>
        /// Between 35 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_44")] AgeRange3544 = 503003,
        /// <summary>
        /// Between 35 and 49 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_49")] AgeRange3549 = 14,
        /// <summary>
        /// Between 35 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_54")] AgeRange3554 = 15,
        /// <summary>
        /// Between 35 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_64")] AgeRange3564 = 16,
        /// <summary>
        /// Between 35 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_65_UP")] AgeRange3565Up = 17,
        /// <summary>
        /// Between 45 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_54")] AgeRange4554 = 503004,
        /// <summary>
        /// Between 45 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_64")] AgeRange4564 = 18,
        /// <summary>
        /// Between 45 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_65_UP")] AgeRange4565Up = 19,
        /// <summary>
        /// Between 50 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_50_65_UP")] AgeRange5065Up = 20,
        /// <summary>
        /// Between 55 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_64")] AgeRange5564 = 503005,
        /// <summary>
        /// Between 55 and 65+ years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_65_UP")] AgeRange5565Up = 21,
        /// <summary>
        /// 65 years old and beyond.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_65_UP")] AgeRange65Up = 503006,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
