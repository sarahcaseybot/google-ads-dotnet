// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/lead_form_call_to_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/lead_form_call_to_action_type.proto</summary>
  public static partial class LeadFormCallToActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/lead_form_call_to_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LeadFormCallToActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9sZWFkX2Zvcm1fY2Fs",
            "bF90b19hY3Rpb25fdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djcuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iqwIKHExl",
            "YWRGb3JtQ2FsbFRvQWN0aW9uVHlwZUVudW0iigIKGExlYWRGb3JtQ2FsbFRv",
            "QWN0aW9uVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIOCgpM",
            "RUFSTl9NT1JFEAISDQoJR0VUX1FVT1RFEAMSDQoJQVBQTFlfTk9XEAQSCwoH",
            "U0lHTl9VUBAFEg4KCkNPTlRBQ1RfVVMQBhINCglTVUJTQ1JJQkUQBxIMCghE",
            "T1dOTE9BRBAIEgwKCEJPT0tfTk9XEAkSDQoJR0VUX09GRkVSEAoSDAoIUkVH",
            "SVNURVIQCxIMCghHRVRfSU5GTxAMEhAKDFJFUVVFU1RfREVNTxANEgwKCEpP",
            "SU5fTk9XEA4SDwoLR0VUX1NUQVJURUQQD0LyAQohY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY3LmVudW1zQh1MZWFkRm9ybUNhbGxUb0FjdGlvblR5cGVQ",
            "cm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjcvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WNy5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFY3XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OkVudW1z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.LeadFormCallToActionTypeEnum), global::Google.Ads.GoogleAds.V7.Enums.LeadFormCallToActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.LeadFormCallToActionTypeEnum.Types.LeadFormCallToActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the type of call-to-action phrases in a lead form.
  /// </summary>
  public sealed partial class LeadFormCallToActionTypeEnum : pb::IMessage<LeadFormCallToActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LeadFormCallToActionTypeEnum> _parser = new pb::MessageParser<LeadFormCallToActionTypeEnum>(() => new LeadFormCallToActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LeadFormCallToActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.LeadFormCallToActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum(LeadFormCallToActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum Clone() {
      return new LeadFormCallToActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LeadFormCallToActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LeadFormCallToActionTypeEnum other) {
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
    public void MergeFrom(LeadFormCallToActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the LeadFormCallToActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the type of call-to-action phrases in a lead form.
      /// </summary>
      public enum LeadFormCallToActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Learn more.
        /// </summary>
        [pbr::OriginalName("LEARN_MORE")] LearnMore = 2,
        /// <summary>
        /// Get quote.
        /// </summary>
        [pbr::OriginalName("GET_QUOTE")] GetQuote = 3,
        /// <summary>
        /// Apply now.
        /// </summary>
        [pbr::OriginalName("APPLY_NOW")] ApplyNow = 4,
        /// <summary>
        /// Sign Up.
        /// </summary>
        [pbr::OriginalName("SIGN_UP")] SignUp = 5,
        /// <summary>
        /// Contact us.
        /// </summary>
        [pbr::OriginalName("CONTACT_US")] ContactUs = 6,
        /// <summary>
        /// Subscribe.
        /// </summary>
        [pbr::OriginalName("SUBSCRIBE")] Subscribe = 7,
        /// <summary>
        /// Download.
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 8,
        /// <summary>
        /// Book now.
        /// </summary>
        [pbr::OriginalName("BOOK_NOW")] BookNow = 9,
        /// <summary>
        /// Get offer.
        /// </summary>
        [pbr::OriginalName("GET_OFFER")] GetOffer = 10,
        /// <summary>
        /// Register.
        /// </summary>
        [pbr::OriginalName("REGISTER")] Register = 11,
        /// <summary>
        /// Get info.
        /// </summary>
        [pbr::OriginalName("GET_INFO")] GetInfo = 12,
        /// <summary>
        /// Request a demo.
        /// </summary>
        [pbr::OriginalName("REQUEST_DEMO")] RequestDemo = 13,
        /// <summary>
        /// Join now.
        /// </summary>
        [pbr::OriginalName("JOIN_NOW")] JoinNow = 14,
        /// <summary>
        /// Get started.
        /// </summary>
        [pbr::OriginalName("GET_STARTED")] GetStarted = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
