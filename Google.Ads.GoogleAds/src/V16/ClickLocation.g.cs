// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/common/click_location.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/common/click_location.proto</summary>
  public static partial class ClickLocationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/common/click_location.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickLocationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvY29tbW9uL2NsaWNrX2xvY2F0",
            "aW9uLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTYuY29tbW9uIrkB",
            "Cg1DbGlja0xvY2F0aW9uEhEKBGNpdHkYBiABKAlIAIgBARIUCgdjb3VudHJ5",
            "GAcgASgJSAGIAQESEgoFbWV0cm8YCCABKAlIAogBARIaCg1tb3N0X3NwZWNp",
            "ZmljGAkgASgJSAOIAQESEwoGcmVnaW9uGAogASgJSASIAQFCBwoFX2NpdHlC",
            "CgoIX2NvdW50cnlCCAoGX21ldHJvQhAKDl9tb3N0X3NwZWNpZmljQgkKB19y",
            "ZWdpb25C8gEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTYuY29tbW9u",
            "QhJDbGlja0xvY2F0aW9uUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNi9jb21tb247Y29t",
            "bW9uogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE2LkNvbW1vbsoC",
            "H0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNlxDb21tb27qAiNHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTY6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Common.ClickLocation), global::Google.Ads.GoogleAds.V16.Common.ClickLocation.Parser, new[]{ "City", "Country", "Metro", "MostSpecific", "Region" }, new[]{ "City", "Country", "Metro", "MostSpecific", "Region" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Location criteria associated with a click.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClickLocation : pb::IMessage<ClickLocation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClickLocation> _parser = new pb::MessageParser<ClickLocation>(() => new ClickLocation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClickLocation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Common.ClickLocationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickLocation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickLocation(ClickLocation other) : this() {
      city_ = other.city_;
      country_ = other.country_;
      metro_ = other.metro_;
      mostSpecific_ = other.mostSpecific_;
      region_ = other.region_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickLocation Clone() {
      return new ClickLocation(this);
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 6;
    private readonly static string CityDefaultValue = "";

    private string city_;
    /// <summary>
    /// The city location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_ ?? CityDefaultValue; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "city" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCity {
      get { return city_ != null; }
    }
    /// <summary>Clears the value of the "city" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCity() {
      city_ = null;
    }

    /// <summary>Field number for the "country" field.</summary>
    public const int CountryFieldNumber = 7;
    private readonly static string CountryDefaultValue = "";

    private string country_;
    /// <summary>
    /// The country location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Country {
      get { return country_ ?? CountryDefaultValue; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "country" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCountry {
      get { return country_ != null; }
    }
    /// <summary>Clears the value of the "country" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCountry() {
      country_ = null;
    }

    /// <summary>Field number for the "metro" field.</summary>
    public const int MetroFieldNumber = 8;
    private readonly static string MetroDefaultValue = "";

    private string metro_;
    /// <summary>
    /// The metro location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Metro {
      get { return metro_ ?? MetroDefaultValue; }
      set {
        metro_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "metro" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMetro {
      get { return metro_ != null; }
    }
    /// <summary>Clears the value of the "metro" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMetro() {
      metro_ = null;
    }

    /// <summary>Field number for the "most_specific" field.</summary>
    public const int MostSpecificFieldNumber = 9;
    private readonly static string MostSpecificDefaultValue = "";

    private string mostSpecific_;
    /// <summary>
    /// The most specific location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MostSpecific {
      get { return mostSpecific_ ?? MostSpecificDefaultValue; }
      set {
        mostSpecific_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "most_specific" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMostSpecific {
      get { return mostSpecific_ != null; }
    }
    /// <summary>Clears the value of the "most_specific" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMostSpecific() {
      mostSpecific_ = null;
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 10;
    private readonly static string RegionDefaultValue = "";

    private string region_;
    /// <summary>
    /// The region location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_ ?? RegionDefaultValue; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "region" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRegion {
      get { return region_ != null; }
    }
    /// <summary>Clears the value of the "region" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRegion() {
      region_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClickLocation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClickLocation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (Country != other.Country) return false;
      if (Metro != other.Metro) return false;
      if (MostSpecific != other.MostSpecific) return false;
      if (Region != other.Region) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasCity) hash ^= City.GetHashCode();
      if (HasCountry) hash ^= Country.GetHashCode();
      if (HasMetro) hash ^= Metro.GetHashCode();
      if (HasMostSpecific) hash ^= MostSpecific.GetHashCode();
      if (HasRegion) hash ^= Region.GetHashCode();
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
      if (HasCity) {
        output.WriteRawTag(50);
        output.WriteString(City);
      }
      if (HasCountry) {
        output.WriteRawTag(58);
        output.WriteString(Country);
      }
      if (HasMetro) {
        output.WriteRawTag(66);
        output.WriteString(Metro);
      }
      if (HasMostSpecific) {
        output.WriteRawTag(74);
        output.WriteString(MostSpecific);
      }
      if (HasRegion) {
        output.WriteRawTag(82);
        output.WriteString(Region);
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
      if (HasCity) {
        output.WriteRawTag(50);
        output.WriteString(City);
      }
      if (HasCountry) {
        output.WriteRawTag(58);
        output.WriteString(Country);
      }
      if (HasMetro) {
        output.WriteRawTag(66);
        output.WriteString(Metro);
      }
      if (HasMostSpecific) {
        output.WriteRawTag(74);
        output.WriteString(MostSpecific);
      }
      if (HasRegion) {
        output.WriteRawTag(82);
        output.WriteString(Region);
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
      if (HasCity) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (HasCountry) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (HasMetro) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Metro);
      }
      if (HasMostSpecific) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MostSpecific);
      }
      if (HasRegion) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClickLocation other) {
      if (other == null) {
        return;
      }
      if (other.HasCity) {
        City = other.City;
      }
      if (other.HasCountry) {
        Country = other.Country;
      }
      if (other.HasMetro) {
        Metro = other.Metro;
      }
      if (other.HasMostSpecific) {
        MostSpecific = other.MostSpecific;
      }
      if (other.HasRegion) {
        Region = other.Region;
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
          case 50: {
            City = input.ReadString();
            break;
          }
          case 58: {
            Country = input.ReadString();
            break;
          }
          case 66: {
            Metro = input.ReadString();
            break;
          }
          case 74: {
            MostSpecific = input.ReadString();
            break;
          }
          case 82: {
            Region = input.ReadString();
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
          case 50: {
            City = input.ReadString();
            break;
          }
          case 58: {
            Country = input.ReadString();
            break;
          }
          case 66: {
            Metro = input.ReadString();
            break;
          }
          case 74: {
            MostSpecific = input.ReadString();
            break;
          }
          case 82: {
            Region = input.ReadString();
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
