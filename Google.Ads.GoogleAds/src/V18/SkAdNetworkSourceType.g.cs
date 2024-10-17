// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/sk_ad_network_source_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/sk_ad_network_source_type.proto</summary>
  public static partial class SkAdNetworkSourceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/sk_ad_network_source_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkAdNetworkSourceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvc2tfYWRfbmV0d29y",
            "a19zb3VyY2VfdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4",
            "LmVudW1zIogBChlTa0FkTmV0d29ya1NvdXJjZVR5cGVFbnVtImsKFVNrQWRO",
            "ZXR3b3JrU291cmNlVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIPCgtVTkFWQUlMQUJMRRACEgsKB1dFQlNJVEUQAxIWChJNT0JJTEVfQVBQ",
            "TElDQVRJT04QBEL0AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5l",
            "bnVtc0IaU2tBZE5ldHdvcmtTb3VyY2VUeXBlUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "OC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "OC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxOFxFbnVtc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxODo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkSourceTypeEnum), global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkSourceTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkSourceTypeEnum.Types.SkAdNetworkSourceType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of SkAdNetwork source types.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SkAdNetworkSourceTypeEnum : pb::IMessage<SkAdNetworkSourceTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkAdNetworkSourceTypeEnum> _parser = new pb::MessageParser<SkAdNetworkSourceTypeEnum>(() => new SkAdNetworkSourceTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkAdNetworkSourceTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkSourceTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkSourceTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkSourceTypeEnum(SkAdNetworkSourceTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkSourceTypeEnum Clone() {
      return new SkAdNetworkSourceTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkAdNetworkSourceTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkAdNetworkSourceTypeEnum other) {
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
    public void MergeFrom(SkAdNetworkSourceTypeEnum other) {
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
    /// <summary>Container for nested types declared in the SkAdNetworkSourceTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates SkAdNetwork source types
      /// </summary>
      public enum SkAdNetworkSourceType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The source app ID or source domain was not present in the postback or we
        /// do not have this data for other reasons.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 2,
        /// <summary>
        /// The ad was shown on a webpage.
        /// </summary>
        [pbr::OriginalName("WEBSITE")] Website = 3,
        /// <summary>
        /// The ad was shown on an app.
        /// </summary>
        [pbr::OriginalName("MOBILE_APPLICATION")] MobileApplication = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
