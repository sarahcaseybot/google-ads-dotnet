// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/day_of_week.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/day_of_week.proto</summary>
  public static partial class DayOfWeekReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/day_of_week.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DayOfWeekReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9kYXlfb2Zfd2Vlay5w",
            "cm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXMaHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8ilwEKDURheU9mV2Vla0VudW0ihQEKCURh",
            "eU9mV2VlaxIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZNT05E",
            "QVkQAhILCgdUVUVTREFZEAMSDQoJV0VETkVTREFZEAQSDAoIVEhVUlNEQVkQ",
            "BRIKCgZGUklEQVkQBhIMCghTQVRVUkRBWRAHEgoKBlNVTkRBWRAIQuMBCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCDkRheU9mV2Vla1By",
            "b3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92Mi9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYyLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjJcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6RW51bXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.DayOfWeekEnum), global::Google.Ads.GoogleAds.V2.Enums.DayOfWeekEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.DayOfWeekEnum.Types.DayOfWeek) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of days of the week, e.g., "Monday".
  /// </summary>
  public sealed partial class DayOfWeekEnum : pb::IMessage<DayOfWeekEnum> {
    private static readonly pb::MessageParser<DayOfWeekEnum> _parser = new pb::MessageParser<DayOfWeekEnum>(() => new DayOfWeekEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DayOfWeekEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.DayOfWeekReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DayOfWeekEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DayOfWeekEnum(DayOfWeekEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DayOfWeekEnum Clone() {
      return new DayOfWeekEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DayOfWeekEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DayOfWeekEnum other) {
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
    public void MergeFrom(DayOfWeekEnum other) {
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
    /// <summary>Container for nested types declared in the DayOfWeekEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates days of the week, e.g., "Monday".
      /// </summary>
      public enum DayOfWeek {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Monday.
        /// </summary>
        [pbr::OriginalName("MONDAY")] Monday = 2,
        /// <summary>
        /// Tuesday.
        /// </summary>
        [pbr::OriginalName("TUESDAY")] Tuesday = 3,
        /// <summary>
        /// Wednesday.
        /// </summary>
        [pbr::OriginalName("WEDNESDAY")] Wednesday = 4,
        /// <summary>
        /// Thursday.
        /// </summary>
        [pbr::OriginalName("THURSDAY")] Thursday = 5,
        /// <summary>
        /// Friday.
        /// </summary>
        [pbr::OriginalName("FRIDAY")] Friday = 6,
        /// <summary>
        /// Saturday.
        /// </summary>
        [pbr::OriginalName("SATURDAY")] Saturday = 7,
        /// <summary>
        /// Sunday.
        /// </summary>
        [pbr::OriginalName("SUNDAY")] Sunday = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
