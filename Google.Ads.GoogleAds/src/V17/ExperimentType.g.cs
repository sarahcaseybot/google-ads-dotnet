// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/experiment_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/experiment_type.proto</summary>
  public static partial class ExperimentTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/experiment_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExperimentTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvZXhwZXJpbWVudF90",
            "eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcuZW51bXMiywIK",
            "EkV4cGVyaW1lbnRUeXBlRW51bSK0AgoORXhwZXJpbWVudFR5cGUSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESGQoVRElTUExBWV9BTkRfVklERU9f",
            "MzYwEAISEAoMQURfVkFSSUFUSU9OEAMSEgoOWU9VVFVCRV9DVVNUT00QBRIS",
            "Cg5ESVNQTEFZX0NVU1RPTRAGEhEKDVNFQVJDSF9DVVNUT00QBxImCiJESVNQ",
            "TEFZX0FVVE9NQVRFRF9CSURESU5HX1NUUkFURUdZEAgSJQohU0VBUkNIX0FV",
            "VE9NQVRFRF9CSURESU5HX1NUUkFURUdZEAkSJwojU0hPUFBJTkdfQVVUT01B",
            "VEVEX0JJRERJTkdfU1RSQVRFR1kQChISCg5TTUFSVF9NQVRDSElORxALEhAK",
            "DEhPVEVMX0NVU1RPTRAMQu0BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djE3LmVudW1zQhNFeHBlcmltZW50VHlwZVByb3RvUAFaQ2dvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTcv",
            "ZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTcu",
            "RW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTdcRW51bXPqAiJHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTc6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.ExperimentTypeEnum), global::Google.Ads.GoogleAds.V17.Enums.ExperimentTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.ExperimentTypeEnum.Types.ExperimentType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of experiment.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExperimentTypeEnum : pb::IMessage<ExperimentTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExperimentTypeEnum> _parser = new pb::MessageParser<ExperimentTypeEnum>(() => new ExperimentTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExperimentTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.ExperimentTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentTypeEnum(ExperimentTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentTypeEnum Clone() {
      return new ExperimentTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExperimentTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExperimentTypeEnum other) {
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
    public void MergeFrom(ExperimentTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ExperimentTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The type of the experiment.
      /// </summary>
      public enum ExperimentType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// This is a DISPLAY_AND_VIDEO_360 experiment.
        /// </summary>
        [pbr::OriginalName("DISPLAY_AND_VIDEO_360")] DisplayAndVideo360 = 2,
        /// <summary>
        /// This is an ad variation experiment.
        /// </summary>
        [pbr::OriginalName("AD_VARIATION")] AdVariation = 3,
        /// <summary>
        /// A custom experiment consisting of Video campaigns.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_CUSTOM")] YoutubeCustom = 5,
        /// <summary>
        /// A custom experiment consisting of display campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_CUSTOM")] DisplayCustom = 6,
        /// <summary>
        /// A custom experiment consisting of search campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH_CUSTOM")] SearchCustom = 7,
        /// <summary>
        /// An experiment that compares bidding strategies for display campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_AUTOMATED_BIDDING_STRATEGY")] DisplayAutomatedBiddingStrategy = 8,
        /// <summary>
        /// An experiment that compares bidding strategies for search campaigns."
        /// </summary>
        [pbr::OriginalName("SEARCH_AUTOMATED_BIDDING_STRATEGY")] SearchAutomatedBiddingStrategy = 9,
        /// <summary>
        /// An experiment that compares bidding strategies for shopping campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_AUTOMATED_BIDDING_STRATEGY")] ShoppingAutomatedBiddingStrategy = 10,
        /// <summary>
        /// DEPRECATED. A smart matching experiment with search campaigns.
        /// </summary>
        [pbr::OriginalName("SMART_MATCHING")] SmartMatching = 11,
        /// <summary>
        /// A custom experiment consisting of hotel campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL_CUSTOM")] HotelCustom = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
