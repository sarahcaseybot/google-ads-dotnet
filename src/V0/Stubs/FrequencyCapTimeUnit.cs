// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/frequency_cap_time_unit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/frequency_cap_time_unit.proto</summary>
  public static partial class FrequencyCapTimeUnitReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/frequency_cap_time_unit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrequencyCapTimeUnitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9mcmVxdWVuY3lfY2Fw",
            "X3RpbWVfdW5pdC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ibgoYRnJlcXVlbmN5",
            "Q2FwVGltZVVuaXRFbnVtIlIKFEZyZXF1ZW5jeUNhcFRpbWVVbml0Eg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgcKA0RBWRACEggKBFdFRUsQAxIJ",
            "CgVNT05USBAEQu4BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51",
            "bXNCGUZyZXF1ZW5jeUNhcFRpbWVVbml0UHJvdG9QAVpCZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2Vu",
            "dW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51",
            "bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxFbnVtc+oCIUdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.FrequencyCapTimeUnitEnum), global::Google.Ads.GoogleAds.V0.Enums.FrequencyCapTimeUnitEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the unit of time the cap is defined at.
  /// </summary>
  public sealed partial class FrequencyCapTimeUnitEnum : pb::IMessage<FrequencyCapTimeUnitEnum> {
    private static readonly pb::MessageParser<FrequencyCapTimeUnitEnum> _parser = new pb::MessageParser<FrequencyCapTimeUnitEnum>(() => new FrequencyCapTimeUnitEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrequencyCapTimeUnitEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.FrequencyCapTimeUnitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapTimeUnitEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapTimeUnitEnum(FrequencyCapTimeUnitEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapTimeUnitEnum Clone() {
      return new FrequencyCapTimeUnitEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrequencyCapTimeUnitEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrequencyCapTimeUnitEnum other) {
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
    public void MergeFrom(FrequencyCapTimeUnitEnum other) {
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
    /// <summary>Container for nested types declared in the FrequencyCapTimeUnitEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Unit of time the cap is defined at (e.g. day, week).
      /// </summary>
      public enum FrequencyCapTimeUnit {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The cap would define limit per one day.
        /// </summary>
        [pbr::OriginalName("DAY")] Day = 2,
        /// <summary>
        /// The cap would define limit per one week.
        /// </summary>
        [pbr::OriginalName("WEEK")] Week = 3,
        /// <summary>
        /// The cap would define limit per one month.
        /// </summary>
        [pbr::OriginalName("MONTH")] Month = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
