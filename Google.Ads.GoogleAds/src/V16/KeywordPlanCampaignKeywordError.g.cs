// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/errors/keyword_plan_campaign_keyword_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/errors/keyword_plan_campaign_keyword_error.proto</summary>
  public static partial class KeywordPlanCampaignKeywordErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/errors/keyword_plan_campaign_keyword_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCampaignKeywordErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZXJyb3JzL2tleXdvcmRfcGxh",
            "bl9jYW1wYWlnbl9rZXl3b3JkX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTYuZXJyb3JzIogBCiNLZXl3b3JkUGxhbkNhbXBhaWduS2V5",
            "d29yZEVycm9yRW51bSJhCh9LZXl3b3JkUGxhbkNhbXBhaWduS2V5d29yZEVy",
            "cm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiAKHENBTVBBSUdO",
            "X0tFWVdPUkRfSVNfUE9TSVRJVkUQCEKEAgojY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNi5lcnJvcnNCJEtleXdvcmRQbGFuQ2FtcGFpZ25LZXl3b3Jk",
            "RXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE2L2Vycm9ycztlcnJvcnOiAgNHQUGq",
            "Ah9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTYuRXJyb3JzygIfR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjE2XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxNjo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanCampaignKeywordErrorEnum), global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanCampaignKeywordErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanCampaignKeywordErrorEnum.Types.KeywordPlanCampaignKeywordError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a keyword plan
  /// campaign keyword.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KeywordPlanCampaignKeywordErrorEnum : pb::IMessage<KeywordPlanCampaignKeywordErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanCampaignKeywordErrorEnum> _parser = new pb::MessageParser<KeywordPlanCampaignKeywordErrorEnum>(() => new KeywordPlanCampaignKeywordErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanCampaignKeywordErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanCampaignKeywordErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanCampaignKeywordErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanCampaignKeywordErrorEnum(KeywordPlanCampaignKeywordErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanCampaignKeywordErrorEnum Clone() {
      return new KeywordPlanCampaignKeywordErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanCampaignKeywordErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanCampaignKeywordErrorEnum other) {
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
    public void MergeFrom(KeywordPlanCampaignKeywordErrorEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanCampaignKeywordErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a keyword plan campaign
      /// keyword.
      /// </summary>
      public enum KeywordPlanCampaignKeywordError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword plan campaign keyword is positive.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_KEYWORD_IS_POSITIVE")] CampaignKeywordIsPositive = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
