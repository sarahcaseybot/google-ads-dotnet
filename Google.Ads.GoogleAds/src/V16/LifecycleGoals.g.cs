// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/common/lifecycle_goals.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/common/lifecycle_goals.proto</summary>
  public static partial class LifecycleGoalsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/common/lifecycle_goals.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LifecycleGoalsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvY29tbW9uL2xpZmVjeWNsZV9n",
            "b2Fscy5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2LmNvbW1vbiJ0",
            "ChpMaWZlY3ljbGVHb2FsVmFsdWVTZXR0aW5ncxISCgV2YWx1ZRgBIAEoAUgA",
            "iAEBEiAKE2hpZ2hfbGlmZXRpbWVfdmFsdWUYAiABKAFIAYgBAUIICgZfdmFs",
            "dWVCFgoUX2hpZ2hfbGlmZXRpbWVfdmFsdWVC8wEKI2NvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTYuY29tbW9uQhNMaWZlY3ljbGVHb2Fsc1Byb3RvUAFa",
            "RWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MTYvY29tbW9uO2NvbW1vbqICA0dBQaoCH0dvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxNi5Db21tb27KAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MTZcQ29tbW9u6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE2OjpDb21t",
            "b25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Common.LifecycleGoalValueSettings), global::Google.Ads.GoogleAds.V16.Common.LifecycleGoalValueSettings.Parser, new[]{ "Value", "HighLifetimeValue" }, new[]{ "Value", "HighLifetimeValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Lifecycle goal value settings.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LifecycleGoalValueSettings : pb::IMessage<LifecycleGoalValueSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LifecycleGoalValueSettings> _parser = new pb::MessageParser<LifecycleGoalValueSettings>(() => new LifecycleGoalValueSettings());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LifecycleGoalValueSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Common.LifecycleGoalsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifecycleGoalValueSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifecycleGoalValueSettings(LifecycleGoalValueSettings other) : this() {
      _hasBits0 = other._hasBits0;
      value_ = other.value_;
      highLifetimeValue_ = other.highLifetimeValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifecycleGoalValueSettings Clone() {
      return new LifecycleGoalValueSettings(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private readonly static double ValueDefaultValue = 0D;

    private double value_;
    /// <summary>
    /// Value of the lifecycle goal. For example, for customer acquisition goal,
    /// value is the incremental conversion value for new customers who are not of
    /// high value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Value {
      get { if ((_hasBits0 & 1) != 0) { return value_; } else { return ValueDefaultValue; } }
      set {
        _hasBits0 |= 1;
        value_ = value;
      }
    }
    /// <summary>Gets whether the "value" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasValue {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "value" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "high_lifetime_value" field.</summary>
    public const int HighLifetimeValueFieldNumber = 2;
    private readonly static double HighLifetimeValueDefaultValue = 0D;

    private double highLifetimeValue_;
    /// <summary>
    /// High lifetime value of the lifecycle goal. For example, for customer
    /// acquisition goal, high lifetime value is the incremental conversion value
    /// for new customers who are of high value. High lifetime value should be
    /// greater than value, if set.
    /// In current stage, high lifetime value feature is in beta and this field
    /// is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double HighLifetimeValue {
      get { if ((_hasBits0 & 2) != 0) { return highLifetimeValue_; } else { return HighLifetimeValueDefaultValue; } }
      set {
        _hasBits0 |= 2;
        highLifetimeValue_ = value;
      }
    }
    /// <summary>Gets whether the "high_lifetime_value" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHighLifetimeValue {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "high_lifetime_value" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHighLifetimeValue() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LifecycleGoalValueSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LifecycleGoalValueSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HighLifetimeValue, other.HighLifetimeValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
      if (HasHighLifetimeValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HighLifetimeValue);
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
      if (HasValue) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
      }
      if (HasHighLifetimeValue) {
        output.WriteRawTag(17);
        output.WriteDouble(HighLifetimeValue);
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
      if (HasValue) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
      }
      if (HasHighLifetimeValue) {
        output.WriteRawTag(17);
        output.WriteDouble(HighLifetimeValue);
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
      if (HasValue) {
        size += 1 + 8;
      }
      if (HasHighLifetimeValue) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LifecycleGoalValueSettings other) {
      if (other == null) {
        return;
      }
      if (other.HasValue) {
        Value = other.Value;
      }
      if (other.HasHighLifetimeValue) {
        HighLifetimeValue = other.HighLifetimeValue;
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
          case 9: {
            Value = input.ReadDouble();
            break;
          }
          case 17: {
            HighLifetimeValue = input.ReadDouble();
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
          case 9: {
            Value = input.ReadDouble();
            break;
          }
          case 17: {
            HighLifetimeValue = input.ReadDouble();
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
