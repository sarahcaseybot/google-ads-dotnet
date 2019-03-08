// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/data_driven_model_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/data_driven_model_status.proto</summary>
  public static partial class DataDrivenModelStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/data_driven_model_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataDrivenModelStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9kYXRhX2RyaXZlbl9t",
            "b2RlbF9zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIo4BChlEYXRhRHJp",
            "dmVuTW9kZWxTdGF0dXNFbnVtInEKFURhdGFEcml2ZW5Nb2RlbFN0YXR1cxIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARINCglBVkFJTEFCTEUQAhIJ",
            "CgVTVEFMRRADEgsKB0VYUElSRUQQBBITCg9ORVZFUl9HRU5FUkFURUQQBULv",
            "AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQhpEYXRhRHJp",
            "dmVuTW9kZWxTdGF0dXNQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVtc8oCHUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.DataDrivenModelStatusEnum), global::Google.Ads.GoogleAds.V0.Enums.DataDrivenModelStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.DataDrivenModelStatusEnum.Types.DataDrivenModelStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum indicating data driven model status.
  /// </summary>
  public sealed partial class DataDrivenModelStatusEnum : pb::IMessage<DataDrivenModelStatusEnum> {
    private static readonly pb::MessageParser<DataDrivenModelStatusEnum> _parser = new pb::MessageParser<DataDrivenModelStatusEnum>(() => new DataDrivenModelStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataDrivenModelStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.DataDrivenModelStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataDrivenModelStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataDrivenModelStatusEnum(DataDrivenModelStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataDrivenModelStatusEnum Clone() {
      return new DataDrivenModelStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataDrivenModelStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataDrivenModelStatusEnum other) {
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
    public void MergeFrom(DataDrivenModelStatusEnum other) {
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
    /// <summary>Container for nested types declared in the DataDrivenModelStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates data driven model statuses.
      /// </summary>
      public enum DataDrivenModelStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The data driven model is available.
        /// </summary>
        [pbr::OriginalName("AVAILABLE")] Available = 2,
        /// <summary>
        /// The data driven model is stale. It hasn't been updated for at least 7
        /// days. It is still being used, but will become expired if it does not get
        /// updated for 30 days.
        /// </summary>
        [pbr::OriginalName("STALE")] Stale = 3,
        /// <summary>
        /// The data driven model expired. It hasn't been updated for at least 30
        /// days and cannot be used. Most commonly this is because there hasn't been
        /// the required number of events in a recent 30-day period.
        /// </summary>
        [pbr::OriginalName("EXPIRED")] Expired = 4,
        /// <summary>
        /// The data driven model has never been generated. Most commonly this is
        /// because there has never been the required number of events in any 30-day
        /// period.
        /// </summary>
        [pbr::OriginalName("NEVER_GENERATED")] NeverGenerated = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
