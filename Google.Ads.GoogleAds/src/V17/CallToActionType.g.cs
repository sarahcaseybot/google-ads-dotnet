// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v17/enums/call_to_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V17.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v17/enums/call_to_action_type.proto</summary>
  public static partial class CallToActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v17/enums/call_to_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CallToActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTcvZW51bXMvY2FsbF90b19hY3Rp",
            "b25fdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE3LmVudW1z",
            "IsMCChRDYWxsVG9BY3Rpb25UeXBlRW51bSKqAgoQQ2FsbFRvQWN0aW9uVHlw",
            "ZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIOCgpMRUFSTl9NT1JF",
            "EAISDQoJR0VUX1FVT1RFEAMSDQoJQVBQTFlfTk9XEAQSCwoHU0lHTl9VUBAF",
            "Eg4KCkNPTlRBQ1RfVVMQBhINCglTVUJTQ1JJQkUQBxIMCghET1dOTE9BRBAI",
            "EgwKCEJPT0tfTk9XEAkSDAoIU0hPUF9OT1cQChILCgdCVVlfTk9XEAsSDgoK",
            "RE9OQVRFX05PVxAMEg0KCU9SREVSX05PVxANEgwKCFBMQVlfTk9XEA4SDAoI",
            "U0VFX01PUkUQDxINCglTVEFSVF9OT1cQEBIOCgpWSVNJVF9TSVRFEBESDQoJ",
            "V0FUQ0hfTk9XEBJC7wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTcu",
            "ZW51bXNCFUNhbGxUb0FjdGlvblR5cGVQcm90b1ABWkNnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE3L2Vu",
            "dW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE3LkVu",
            "dW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE3XEVudW1z6gIiR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjE3OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V17.Enums.CallToActionTypeEnum), global::Google.Ads.GoogleAds.V17.Enums.CallToActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V17.Enums.CallToActionTypeEnum.Types.CallToActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the call to action types.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CallToActionTypeEnum : pb::IMessage<CallToActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CallToActionTypeEnum> _parser = new pb::MessageParser<CallToActionTypeEnum>(() => new CallToActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CallToActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V17.Enums.CallToActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallToActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallToActionTypeEnum(CallToActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CallToActionTypeEnum Clone() {
      return new CallToActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CallToActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CallToActionTypeEnum other) {
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
    public void MergeFrom(CallToActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CallToActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible types of call to action.
      /// </summary>
      public enum CallToActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The call to action type is learn more.
        /// </summary>
        [pbr::OriginalName("LEARN_MORE")] LearnMore = 2,
        /// <summary>
        /// The call to action type is get quote.
        /// </summary>
        [pbr::OriginalName("GET_QUOTE")] GetQuote = 3,
        /// <summary>
        /// The call to action type is apply now.
        /// </summary>
        [pbr::OriginalName("APPLY_NOW")] ApplyNow = 4,
        /// <summary>
        /// The call to action type is sign up.
        /// </summary>
        [pbr::OriginalName("SIGN_UP")] SignUp = 5,
        /// <summary>
        /// The call to action type is contact us.
        /// </summary>
        [pbr::OriginalName("CONTACT_US")] ContactUs = 6,
        /// <summary>
        /// The call to action type is subscribe.
        /// </summary>
        [pbr::OriginalName("SUBSCRIBE")] Subscribe = 7,
        /// <summary>
        /// The call to action type is download.
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 8,
        /// <summary>
        /// The call to action type is book now.
        /// </summary>
        [pbr::OriginalName("BOOK_NOW")] BookNow = 9,
        /// <summary>
        /// The call to action type is shop now.
        /// </summary>
        [pbr::OriginalName("SHOP_NOW")] ShopNow = 10,
        /// <summary>
        /// The call to action type is buy now.
        /// </summary>
        [pbr::OriginalName("BUY_NOW")] BuyNow = 11,
        /// <summary>
        /// The call to action type is donate now.
        /// </summary>
        [pbr::OriginalName("DONATE_NOW")] DonateNow = 12,
        /// <summary>
        /// The call to action type is order now.
        /// </summary>
        [pbr::OriginalName("ORDER_NOW")] OrderNow = 13,
        /// <summary>
        /// The call to action type is play now.
        /// </summary>
        [pbr::OriginalName("PLAY_NOW")] PlayNow = 14,
        /// <summary>
        /// The call to action type is see more.
        /// </summary>
        [pbr::OriginalName("SEE_MORE")] SeeMore = 15,
        /// <summary>
        /// The call to action type is start now.
        /// </summary>
        [pbr::OriginalName("START_NOW")] StartNow = 16,
        /// <summary>
        /// The call to action type is visit site.
        /// </summary>
        [pbr::OriginalName("VISIT_SITE")] VisitSite = 17,
        /// <summary>
        /// The call to action type is watch now.
        /// </summary>
        [pbr::OriginalName("WATCH_NOW")] WatchNow = 18,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
