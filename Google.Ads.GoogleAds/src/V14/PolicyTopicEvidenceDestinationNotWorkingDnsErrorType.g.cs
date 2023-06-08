// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/policy_topic_evidence_destination_not_working_dns_error_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/policy_topic_evidence_destination_not_working_dns_error_type.proto</summary>
  public static partial class PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/policy_topic_evidence_destination_not_working_dns_error_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CmFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvcG9saWN5X3RvcGlj",
            "X2V2aWRlbmNlX2Rlc3RpbmF0aW9uX25vdF93b3JraW5nX2Ruc19lcnJvcl90",
            "eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQuZW51bXMixwEK",
            "OFBvbGljeVRvcGljRXZpZGVuY2VEZXN0aW5hdGlvbk5vdFdvcmtpbmdEbnNF",
            "cnJvclR5cGVFbnVtIooBCjRQb2xpY3lUb3BpY0V2aWRlbmNlRGVzdGluYXRp",
            "b25Ob3RXb3JraW5nRG5zRXJyb3JUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEhYKEkhPU1ROQU1FX05PVF9GT1VORBACEhwKGEdPT0dMRV9D",
            "UkFXTEVSX0ROU19JU1NVRRADQpMCCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjE0LmVudW1zQjlQb2xpY3lUb3BpY0V2aWRlbmNlRGVzdGluYXRpb25O",
            "b3RXb3JraW5nRG5zRXJyb3JUeXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNC9lbnVt",
            "cztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNC5FbnVt",
            "c8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNFxFbnVtc+oCIkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYxNDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum), global::Google.Ads.GoogleAds.V14.Enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.Types.PolicyTopicEvidenceDestinationNotWorkingDnsErrorType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic evidence destination not
  /// working DNS error types.
  /// </summary>
  public sealed partial class PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum : pb::IMessage<PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum> _parser = new pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum>(() => new PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum(PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum Clone() {
      return new PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum other) {
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
    public void MergeFrom(PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic evidence destination not working DNS error types.
      /// </summary>
      public enum PolicyTopicEvidenceDestinationNotWorkingDnsErrorType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Host name not found in DNS when fetching landing page.
        /// </summary>
        [pbr::OriginalName("HOSTNAME_NOT_FOUND")] HostnameNotFound = 2,
        /// <summary>
        /// Google internal crawler issue when communicating with DNS. This error
        /// doesn't mean the landing page doesn't work. Google will recrawl the
        /// landing page.
        /// </summary>
        [pbr::OriginalName("GOOGLE_CRAWLER_DNS_ISSUE")] GoogleCrawlerDnsIssue = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
