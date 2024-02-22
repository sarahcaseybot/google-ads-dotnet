// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/ad_group_ad_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/ad_group_ad_label.proto</summary>
  public static partial class AdGroupAdLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/ad_group_ad_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2FkX2xhYmVsLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTYucmVz",
            "b3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29n",
            "bGUvYXBpL3Jlc291cmNlLnByb3RvIuwCCg5BZEdyb3VwQWRMYWJlbBJGCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQi/gQQX6QSkKJ2dvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9BZEdyb3VwQWRMYWJlbBJECgthZF9ncm91cF9hZBgEIAEoCUIq",
            "4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFkSACI",
            "AQESOgoFbGFiZWwYBSABKAlCJuBBBfpBIAoeZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0xhYmVsSAGIAQE6dupBcwonZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0FkR3JvdXBBZExhYmVsEkhjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9h",
            "ZEdyb3VwQWRMYWJlbHMve2FkX2dyb3VwX2lkfX57YWRfaWR9fntsYWJlbF9p",
            "ZH1CDgoMX2FkX2dyb3VwX2FkQggKBl9sYWJlbEKFAgomY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxNi5yZXNvdXJjZXNCE0FkR3JvdXBBZExhYmVsUHJv",
            "dG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YxNi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIi",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE2LlJlc291cmNlc8oCIkdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYxNlxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTY6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.AdGroupAdLabel), global::Google.Ads.GoogleAds.V16.Resources.AdGroupAdLabel.Parser, new[]{ "ResourceName", "AdGroupAd", "Label" }, new[]{ "AdGroupAd", "Label" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A relationship between an ad group ad and a label.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdGroupAdLabel : pb::IMessage<AdGroupAdLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdLabel> _parser = new pb::MessageParser<AdGroupAdLabel>(() => new AdGroupAdLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAdLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.AdGroupAdLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdLabel(AdGroupAdLabel other) : this() {
      resourceName_ = other.resourceName_;
      adGroupAd_ = other.adGroupAd_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAdLabel Clone() {
      return new AdGroupAdLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group ad label.
    /// Ad group ad label resource names have the form:
    /// `customers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 4;
    private readonly static string AdGroupAdDefaultValue = "";

    private string adGroupAd_;
    /// <summary>
    /// Immutable. The ad group ad to which the label is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroupAd {
      get { return adGroupAd_ ?? AdGroupAdDefaultValue; }
      set {
        adGroupAd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_ad" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroupAd {
      get { return adGroupAd_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_ad" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroupAd() {
      adGroupAd_ = null;
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private readonly static string LabelDefaultValue = "";

    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Label {
      get { return label_ ?? LabelDefaultValue; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "label" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLabel {
      get { return label_ != null; }
    }
    /// <summary>Clears the value of the "label" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLabel() {
      label_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAdLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasAdGroupAd) hash ^= AdGroupAd.GetHashCode();
      if (HasLabel) hash ^= Label.GetHashCode();
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
      if (HasAdGroupAd) {
        output.WriteRawTag(34);
        output.WriteString(AdGroupAd);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasAdGroupAd) {
        output.WriteRawTag(34);
        output.WriteString(AdGroupAd);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasAdGroupAd) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroupAd);
      }
      if (HasLabel) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAdLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasAdGroupAd) {
        AdGroupAd = other.AdGroupAd;
      }
      if (other.HasLabel) {
        Label = other.Label;
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
          case 34: {
            AdGroupAd = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
          case 34: {
            AdGroupAd = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
