// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/feed_item_set_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/feed_item_set_link.proto</summary>
  public static partial class FeedItemSetLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/feed_item_set_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemSetLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvZmVlZF9pdGVt",
            "X3NldF9saW5rLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNv",
            "dXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8i5AIKD0ZlZWRJdGVtU2V0TGluaxJHCg1yZXNvdXJjZV9uYW1lGAEg",
            "ASgJQjDgQQX6QSoKKGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkSXRl",
            "bVNldExpbmsSPAoJZmVlZF9pdGVtGAIgASgJQingQQX6QSMKIWdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9GZWVkSXRlbRJDCg1mZWVkX2l0ZW1fc2V0GAMg",
            "ASgJQizgQQX6QSYKJGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkSXRl",
            "bVNldDqEAepBgAEKKGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkSXRl",
            "bVNldExpbmsSVGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2ZlZWRJdGVtU2V0",
            "TGlua3Mve2ZlZWRfaWR9fntmZWVkX2l0ZW1fc2V0X2lkfX57ZmVlZF9pdGVt",
            "X2lkfUKBAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNl",
            "c0IURmVlZEl0ZW1TZXRMaW5rUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5L3Jlc291cmNl",
            "cztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5S",
            "ZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxSZXNvdXJjZXPq",
            "AiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6UmVzb3VyY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.FeedItemSetLink), global::Google.Ads.GoogleAds.V9.Resources.FeedItemSetLink.Parser, new[]{ "ResourceName", "FeedItem", "FeedItemSet" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a link between a FeedItem and a FeedItemSet.
  /// </summary>
  public sealed partial class FeedItemSetLink : pb::IMessage<FeedItemSetLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemSetLink> _parser = new pb::MessageParser<FeedItemSetLink>(() => new FeedItemSetLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedItemSetLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.FeedItemSetLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetLink(FeedItemSetLink other) : this() {
      resourceName_ = other.resourceName_;
      feedItem_ = other.feedItem_;
      feedItemSet_ = other.feedItemSet_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSetLink Clone() {
      return new FeedItemSetLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the feed item set link.
    /// Feed item set link resource names have the form:
    /// `customers/{customer_id}/feedItemSetLinks/{feed_id}~{feed_item_set_id}~{feed_item_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed_item" field.</summary>
    public const int FeedItemFieldNumber = 2;
    private string feedItem_ = "";
    /// <summary>
    /// Immutable. The linked FeedItem.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FeedItem {
      get { return feedItem_; }
      set {
        feedItem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed_item_set" field.</summary>
    public const int FeedItemSetFieldNumber = 3;
    private string feedItemSet_ = "";
    /// <summary>
    /// Immutable. The linked FeedItemSet.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FeedItemSet {
      get { return feedItemSet_; }
      set {
        feedItemSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedItemSetLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedItemSetLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (FeedItem != other.FeedItem) return false;
      if (FeedItemSet != other.FeedItemSet) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (FeedItem.Length != 0) hash ^= FeedItem.GetHashCode();
      if (FeedItemSet.Length != 0) hash ^= FeedItemSet.GetHashCode();
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
      if (FeedItem.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FeedItem);
      }
      if (FeedItemSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FeedItemSet);
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
      if (FeedItem.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FeedItem);
      }
      if (FeedItemSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FeedItemSet);
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
      if (FeedItem.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FeedItem);
      }
      if (FeedItemSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FeedItemSet);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedItemSetLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.FeedItem.Length != 0) {
        FeedItem = other.FeedItem;
      }
      if (other.FeedItemSet.Length != 0) {
        FeedItemSet = other.FeedItemSet;
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
          case 18: {
            FeedItem = input.ReadString();
            break;
          }
          case 26: {
            FeedItemSet = input.ReadString();
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
          case 18: {
            FeedItem = input.ReadString();
            break;
          }
          case 26: {
            FeedItemSet = input.ReadString();
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
