// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/shared_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/shared_set.proto</summary>
  public static partial class SharedSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/shared_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvc2hhcmVkX3Nl",
            "dC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjgucmVzb3VyY2VzGjVn",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9zaGFyZWRfc2V0X3N0YXR1",
            "cy5wcm90bxozZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjgvZW51bXMvc2hhcmVk",
            "X3NldF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnBy",
            "b3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIvgDCglTaGFyZWRTZXQSQQoNcmVzb3VyY2VfbmFt",
            "ZRgBIAEoCUIq4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU2hh",
            "cmVkU2V0EhQKAmlkGAggASgDQgPgQQNIAIgBARJRCgR0eXBlGAMgASgOMj4u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjguZW51bXMuU2hhcmVkU2V0VHlwZUVu",
            "dW0uU2hhcmVkU2V0VHlwZUID4EEFEhEKBG5hbWUYCSABKAlIAYgBARJXCgZz",
            "dGF0dXMYBSABKA4yQi5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtcy5T",
            "aGFyZWRTZXRTdGF0dXNFbnVtLlNoYXJlZFNldFN0YXR1c0ID4EEDEh4KDG1l",
            "bWJlcl9jb3VudBgKIAEoA0ID4EEDSAKIAQESIQoPcmVmZXJlbmNlX2NvdW50",
            "GAsgASgDQgPgQQNIA4gBATpb6kFYCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5j",
            "b20vU2hhcmVkU2V0EjJjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9zaGFyZWRT",
            "ZXRzL3tzaGFyZWRfc2V0X2lkfUIFCgNfaWRCBwoFX25hbWVCDwoNX21lbWJl",
            "cl9jb3VudEISChBfcmVmZXJlbmNlX2NvdW50QvsBCiVjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjgucmVzb3VyY2VzQg5TaGFyZWRTZXRQcm90b1ABWkpn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjgvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlY4LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFY4XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY4",
            "OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.SharedSet), global::Google.Ads.GoogleAds.V8.Resources.SharedSet.Parser, new[]{ "ResourceName", "Id", "Type", "Name", "Status", "MemberCount", "ReferenceCount" }, new[]{ "Id", "Name", "MemberCount", "ReferenceCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// SharedSets are used for sharing criterion exclusions across multiple
  /// campaigns.
  /// </summary>
  public sealed partial class SharedSet : pb::IMessage<SharedSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SharedSet> _parser = new pb::MessageParser<SharedSet>(() => new SharedSet());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SharedSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.SharedSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedSet(SharedSet other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      type_ = other.type_;
      name_ = other.name_;
      status_ = other.status_;
      memberCount_ = other.memberCount_;
      referenceCount_ = other.referenceCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharedSet Clone() {
      return new SharedSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the shared set.
    /// Shared set resource names have the form:
    ///
    /// `customers/{customer_id}/sharedSets/{shared_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 8;
    private long id_;
    /// <summary>
    /// Output only. The ID of this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType type_ = global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified;
    /// <summary>
    /// Immutable. The type of this shared set: each shared set holds only a single kind
    /// of resource. Required. Immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 9;
    private string name_;
    /// <summary>
    /// The name of this shared set. Required.
    /// Shared Sets must have names that are unique among active shared sets of
    /// the same type.
    /// The length of this string should be between 1 and 255 UTF-8 bytes,
    /// inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus status_ = global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "member_count" field.</summary>
    public const int MemberCountFieldNumber = 10;
    private long memberCount_;
    /// <summary>
    /// Output only. The number of shared criteria within this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MemberCount {
      get { if ((_hasBits0 & 2) != 0) { return memberCount_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        memberCount_ = value;
      }
    }
    /// <summary>Gets whether the "member_count" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMemberCount {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "member_count" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMemberCount() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "reference_count" field.</summary>
    public const int ReferenceCountFieldNumber = 11;
    private long referenceCount_;
    /// <summary>
    /// Output only. The number of campaigns associated with this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ReferenceCount {
      get { if ((_hasBits0 & 4) != 0) { return referenceCount_; } else { return 0L; } }
      set {
        _hasBits0 |= 4;
        referenceCount_ = value;
      }
    }
    /// <summary>Gets whether the "reference_count" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasReferenceCount {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "reference_count" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearReferenceCount() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SharedSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SharedSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (Name != other.Name) return false;
      if (Status != other.Status) return false;
      if (MemberCount != other.MemberCount) return false;
      if (ReferenceCount != other.ReferenceCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) hash ^= Type.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasMemberCount) hash ^= MemberCount.GetHashCode();
      if (HasReferenceCount) hash ^= ReferenceCount.GetHashCode();
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
      if (Type != global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(64);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(74);
        output.WriteString(Name);
      }
      if (HasMemberCount) {
        output.WriteRawTag(80);
        output.WriteInt64(MemberCount);
      }
      if (HasReferenceCount) {
        output.WriteRawTag(88);
        output.WriteInt64(ReferenceCount);
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
      if (Type != global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(64);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(74);
        output.WriteString(Name);
      }
      if (HasMemberCount) {
        output.WriteRawTag(80);
        output.WriteInt64(MemberCount);
      }
      if (HasReferenceCount) {
        output.WriteRawTag(88);
        output.WriteInt64(ReferenceCount);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Type != global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Status != global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasMemberCount) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MemberCount);
      }
      if (HasReferenceCount) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ReferenceCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SharedSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        Type = other.Type;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasMemberCount) {
        MemberCount = other.MemberCount;
      }
      if (other.HasReferenceCount) {
        ReferenceCount = other.ReferenceCount;
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus) input.ReadEnum();
            break;
          }
          case 64: {
            Id = input.ReadInt64();
            break;
          }
          case 74: {
            Name = input.ReadString();
            break;
          }
          case 80: {
            MemberCount = input.ReadInt64();
            break;
          }
          case 88: {
            ReferenceCount = input.ReadInt64();
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V8.Enums.SharedSetTypeEnum.Types.SharedSetType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V8.Enums.SharedSetStatusEnum.Types.SharedSetStatus) input.ReadEnum();
            break;
          }
          case 64: {
            Id = input.ReadInt64();
            break;
          }
          case 74: {
            Name = input.ReadString();
            break;
          }
          case 80: {
            MemberCount = input.ReadInt64();
            break;
          }
          case 88: {
            ReferenceCount = input.ReadInt64();
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
