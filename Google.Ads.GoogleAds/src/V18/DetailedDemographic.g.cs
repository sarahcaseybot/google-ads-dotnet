// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/resources/detailed_demographic.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/resources/detailed_demographic.proto</summary>
  public static partial class DetailedDemographicReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/resources/detailed_demographic.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DetailedDemographicReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzL2RldGFpbGVk",
            "X2RlbW9ncmFwaGljLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTgu",
            "cmVzb3VyY2VzGkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvY29tbW9uL2Ny",
            "aXRlcmlvbl9jYXRlZ29yeV9hdmFpbGFiaWxpdHkucHJvdG8aH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2Uu",
            "cHJvdG8iwgMKE0RldGFpbGVkRGVtb2dyYXBoaWMSSwoNcmVzb3VyY2VfbmFt",
            "ZRgBIAEoCUI04EED+kEuCixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRGV0",
            "YWlsZWREZW1vZ3JhcGhpYxIPCgJpZBgCIAEoA0ID4EEDEhEKBG5hbWUYAyAB",
            "KAlCA+BBAxJECgZwYXJlbnQYBCABKAlCNOBBA/pBLgosZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0RldGFpbGVkRGVtb2dyYXBoaWMSHAoPbGF1bmNoZWRf",
            "dG9fYWxsGAUgASgIQgPgQQMSWwoOYXZhaWxhYmlsaXRpZXMYBiADKAsyPi5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTguY29tbW9uLkNyaXRlcmlvbkNhdGVn",
            "b3J5QXZhaWxhYmlsaXR5QgPgQQM6eepBdgosZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0RldGFpbGVkRGVtb2dyYXBoaWMSRmN1c3RvbWVycy97Y3VzdG9t",
            "ZXJfaWR9L2RldGFpbGVkRGVtb2dyYXBoaWNzL3tkZXRhaWxlZF9kZW1vZ3Jh",
            "cGhpY19pZH1CigIKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTgucmVz",
            "b3VyY2VzQhhEZXRhaWxlZERlbW9ncmFwaGljUHJvdG9QAVpLZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "OC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjE4LlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "OFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTg6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailabilityReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.DetailedDemographic), global::Google.Ads.GoogleAds.V18.Resources.DetailedDemographic.Parser, new[]{ "ResourceName", "Id", "Name", "Parent", "LaunchedToAll", "Availabilities" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A detailed demographic: a particular interest-based vertical to be targeted
  /// to reach users based on long-term life facts.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DetailedDemographic : pb::IMessage<DetailedDemographic>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DetailedDemographic> _parser = new pb::MessageParser<DetailedDemographic>(() => new DetailedDemographic());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DetailedDemographic> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.DetailedDemographicReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailedDemographic() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailedDemographic(DetailedDemographic other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      parent_ = other.parent_;
      launchedToAll_ = other.launchedToAll_;
      availabilities_ = other.availabilities_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailedDemographic Clone() {
      return new DetailedDemographic(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the detailed demographic.
    /// Detailed demographic resource names have the form:
    ///
    /// `customers/{customer_id}/detailedDemographics/{detailed_demographic_id}`
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
    public const int IdFieldNumber = 2;
    private long id_;
    /// <summary>
    /// Output only. The ID of the detailed demographic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Output only. The name of the detailed demographic. For example,"Highest
    /// Level of Educational Attainment"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 4;
    private string parent_ = "";
    /// <summary>
    /// Output only. The parent of the detailed_demographic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "launched_to_all" field.</summary>
    public const int LaunchedToAllFieldNumber = 5;
    private bool launchedToAll_;
    /// <summary>
    /// Output only. True if the detailed demographic is launched to all channels
    /// and locales.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LaunchedToAll {
      get { return launchedToAll_; }
      set {
        launchedToAll_ = value;
      }
    }

    /// <summary>Field number for the "availabilities" field.</summary>
    public const int AvailabilitiesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailability> _repeated_availabilities_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailability.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailability> availabilities_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailability>();
    /// <summary>
    /// Output only. Availability information of the detailed demographic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.CriterionCategoryAvailability> Availabilities {
      get { return availabilities_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DetailedDemographic);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DetailedDemographic other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Parent != other.Parent) return false;
      if (LaunchedToAll != other.LaunchedToAll) return false;
      if(!availabilities_.Equals(other.availabilities_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (LaunchedToAll != false) hash ^= LaunchedToAll.GetHashCode();
      hash ^= availabilities_.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (LaunchedToAll != false) {
        output.WriteRawTag(40);
        output.WriteBool(LaunchedToAll);
      }
      availabilities_.WriteTo(output, _repeated_availabilities_codec);
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (LaunchedToAll != false) {
        output.WriteRawTag(40);
        output.WriteBool(LaunchedToAll);
      }
      availabilities_.WriteTo(ref output, _repeated_availabilities_codec);
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
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (LaunchedToAll != false) {
        size += 1 + 1;
      }
      size += availabilities_.CalculateSize(_repeated_availabilities_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DetailedDemographic other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.LaunchedToAll != false) {
        LaunchedToAll = other.LaunchedToAll;
      }
      availabilities_.Add(other.availabilities_);
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
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 40: {
            LaunchedToAll = input.ReadBool();
            break;
          }
          case 50: {
            availabilities_.AddEntriesFrom(input, _repeated_availabilities_codec);
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
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 40: {
            LaunchedToAll = input.ReadBool();
            break;
          }
          case 50: {
            availabilities_.AddEntriesFrom(ref input, _repeated_availabilities_codec);
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
