// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/resources/search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/resources/search_term_view.proto</summary>
  public static partial class SearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/resources/search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzL3NlYXJjaF90",
            "ZXJtX3ZpZXcucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5yZXNv",
            "dXJjZXMaQWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxOC9lbnVtcy9zZWFyY2hf",
            "dGVybV90YXJnZXRpbmdfc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIr4D",
            "Cg5TZWFyY2hUZXJtVmlldxJGCg1yZXNvdXJjZV9uYW1lGAEgASgJQi/gQQP6",
            "QSkKJ2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9TZWFyY2hUZXJtVmlldxId",
            "CgtzZWFyY2hfdGVybRgFIAEoCUID4EEDSACIAQESPwoIYWRfZ3JvdXAYBiAB",
            "KAlCKOBBA/pBIgogZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBI",
            "AYgBARJsCgZzdGF0dXMYBCABKA4yVy5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTguZW51bXMuU2VhcmNoVGVybVRhcmdldGluZ1N0YXR1c0VudW0uU2VhcmNo",
            "VGVybVRhcmdldGluZ1N0YXR1c0ID4EEDOnnqQXYKJ2dvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9TZWFyY2hUZXJtVmlldxJLY3VzdG9tZXJzL3tjdXN0b21l",
            "cl9pZH0vc2VhcmNoVGVybVZpZXdzL3tjYW1wYWlnbl9pZH1+e2FkX2dyb3Vw",
            "X2lkfX57cXVlcnl9Qg4KDF9zZWFyY2hfdGVybUILCglfYWRfZ3JvdXBChQIK",
            "JmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTgucmVzb3VyY2VzQhNTZWFy",
            "Y2hUZXJtVmlld1Byb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzO3Jlc291",
            "cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOC5SZXNvdXJj",
            "ZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMThcUmVzb3VyY2Vz6gImR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjE4OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.SearchTermView), global::Google.Ads.GoogleAds.V18.Resources.SearchTermView.Parser, new[]{ "ResourceName", "SearchTerm", "AdGroup", "Status" }, new[]{ "SearchTerm", "AdGroup" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A search term view with metrics aggregated by search term at the ad group
  /// level.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SearchTermView : pb::IMessage<SearchTermView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SearchTermView> _parser = new pb::MessageParser<SearchTermView>(() => new SearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.SearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchTermView(SearchTermView other) : this() {
      resourceName_ = other.resourceName_;
      searchTerm_ = other.searchTerm_;
      adGroup_ = other.adGroup_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchTermView Clone() {
      return new SearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the search term view.
    /// Search term view resource names have the form:
    ///
    /// `customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{URL-base64_search_term}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 5;
    private readonly static string SearchTermDefaultValue = "";

    private string searchTerm_;
    /// <summary>
    /// Output only. The search term.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SearchTerm {
      get { return searchTerm_ ?? SearchTermDefaultValue; }
      set {
        searchTerm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "search_term" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSearchTerm {
      get { return searchTerm_ != null; }
    }
    /// <summary>Clears the value of the "search_term" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSearchTerm() {
      searchTerm_ = null;
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 6;
    private readonly static string AdGroupDefaultValue = "";

    private string adGroup_;
    /// <summary>
    /// Output only. The ad group the search term served in.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_ ?? AdGroupDefaultValue; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroup {
      get { return adGroup_ != null; }
    }
    /// <summary>Clears the value of the "ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroup() {
      adGroup_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus status_ = global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified;
    /// <summary>
    /// Output only. Indicates whether the search term is currently one of your
    /// targeted or excluded keywords.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      if (AdGroup != other.AdGroup) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasSearchTerm) hash ^= SearchTerm.GetHashCode();
      if (HasAdGroup) hash ^= AdGroup.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (HasSearchTerm) {
        output.WriteRawTag(42);
        output.WriteString(SearchTerm);
      }
      if (HasAdGroup) {
        output.WriteRawTag(50);
        output.WriteString(AdGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (HasSearchTerm) {
        output.WriteRawTag(42);
        output.WriteString(SearchTerm);
      }
      if (HasAdGroup) {
        output.WriteRawTag(50);
        output.WriteString(AdGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasSearchTerm) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchTerm);
      }
      if (HasAdGroup) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasSearchTerm) {
        SearchTerm = other.SearchTerm;
      }
      if (other.HasAdGroup) {
        AdGroup = other.AdGroup;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus) input.ReadEnum();
            break;
          }
          case 42: {
            SearchTerm = input.ReadString();
            break;
          }
          case 50: {
            AdGroup = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus) input.ReadEnum();
            break;
          }
          case 42: {
            SearchTerm = input.ReadString();
            break;
          }
          case 50: {
            AdGroup = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
