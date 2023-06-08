// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/offline_user_data_job_match_rate_range.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/offline_user_data_job_match_rate_range.proto</summary>
  public static partial class OfflineUserDataJobMatchRateRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/offline_user_data_job_match_rate_range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobMatchRateRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvb2ZmbGluZV91c2Vy",
            "X2RhdGFfam9iX21hdGNoX3JhdGVfcmFuZ2UucHJvdG8SHmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNC5lbnVtcyLYAgokT2ZmbGluZVVzZXJEYXRhSm9iTWF0",
            "Y2hSYXRlUmFuZ2VFbnVtIq8CCiBPZmZsaW5lVXNlckRhdGFKb2JNYXRjaFJh",
            "dGVSYW5nZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIcChhNQVRD",
            "SF9SQU5HRV9MRVNTX1RIQU5fMjAQAhIYChRNQVRDSF9SQU5HRV8yMF9UT18z",
            "MBADEhgKFE1BVENIX1JBTkdFXzMxX1RPXzQwEAQSGAoUTUFUQ0hfUkFOR0Vf",
            "NDFfVE9fNTAQBRIYChRNQVRDSF9SQU5HRV81MV9UT182MBAGEhgKFE1BVENI",
            "X1JBTkdFXzYxX1RPXzcwEAcSGAoUTUFUQ0hfUkFOR0VfNzFfVE9fODAQCBIY",
            "ChRNQVRDSF9SQU5HRV84MV9UT185MBAJEhkKFU1BVENIX1JBTkdFXzkxX1RP",
            "XzEwMBAKQv8BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1z",
            "QiVPZmZsaW5lVXNlckRhdGFKb2JNYXRjaFJhdGVSYW5nZVByb3RvUAFaQ2dv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTQvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMTQuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTRcRW51",
            "bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTQ6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobMatchRateRangeEnum), global::Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobMatchRateRangeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobMatchRateRangeEnum.Types.OfflineUserDataJobMatchRateRange) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing reasons match rate ranges for a customer match
  /// list upload.
  /// </summary>
  public sealed partial class OfflineUserDataJobMatchRateRangeEnum : pb::IMessage<OfflineUserDataJobMatchRateRangeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobMatchRateRangeEnum> _parser = new pb::MessageParser<OfflineUserDataJobMatchRateRangeEnum>(() => new OfflineUserDataJobMatchRateRangeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineUserDataJobMatchRateRangeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobMatchRateRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobMatchRateRangeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobMatchRateRangeEnum(OfflineUserDataJobMatchRateRangeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobMatchRateRangeEnum Clone() {
      return new OfflineUserDataJobMatchRateRangeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobMatchRateRangeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineUserDataJobMatchRateRangeEnum other) {
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
    public void MergeFrom(OfflineUserDataJobMatchRateRangeEnum other) {
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
    /// <summary>Container for nested types declared in the OfflineUserDataJobMatchRateRangeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The match rate range of an offline user data job.
      /// </summary>
      public enum OfflineUserDataJobMatchRateRange {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Default value for match rate range.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Match rate range for offline data upload entity is between 0% and 19%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_LESS_THAN_20")] MatchRangeLessThan20 = 2,
        /// <summary>
        /// Match rate range for offline data upload entity is between 20% and 30%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_20_TO_30")] MatchRange20To30 = 3,
        /// <summary>
        /// Match rate range for offline data upload entity is between 31% and 40%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_31_TO_40")] MatchRange31To40 = 4,
        /// <summary>
        /// Match rate range for offline data upload entity is between 41% and 50%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_41_TO_50")] MatchRange41To50 = 5,
        /// <summary>
        /// Match rate range for offline data upload entity is between 51% and 60%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_51_TO_60")] MatchRange51To60 = 6,
        /// <summary>
        /// Match rate range for offline data upload entity is between 61% and 70%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_61_TO_70")] MatchRange61To70 = 7,
        /// <summary>
        /// Match rate range for offline data upload entity is between 71% and 80%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_71_TO_80")] MatchRange71To80 = 8,
        /// <summary>
        /// Match rate range for offline data upload entity is between 81% and 90%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_81_TO_90")] MatchRange81To90 = 9,
        /// <summary>
        /// Match rate range for offline data upload entity is more than or equal to
        /// 91%.
        /// </summary>
        [pbr::OriginalName("MATCH_RANGE_91_TO_100")] MatchRange91To100 = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
