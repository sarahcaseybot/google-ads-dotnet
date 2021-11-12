// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/common/value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/common/value.proto</summary>
  public static partial class ValueReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/common/value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vdmFsdWUucHJvdG8S",
            "Hmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbhocZ29vZ2xlL2FwaS9h",
            "bm5vdGF0aW9ucy5wcm90byKHAQoFVmFsdWUSFwoNYm9vbGVhbl92YWx1ZRgB",
            "IAEoCEgAEhUKC2ludDY0X3ZhbHVlGAIgASgDSAASFQoLZmxvYXRfdmFsdWUY",
            "AyABKAJIABIWCgxkb3VibGVfdmFsdWUYBCABKAFIABIWCgxzdHJpbmdfdmFs",
            "dWUYBSABKAlIAEIHCgV2YWx1ZULlAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LmNvbW1vbkIKVmFsdWVQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvY29tbW9u",
            "O2NvbW1vbqICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LkNvbW1v",
            "bsoCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XENvbW1vbuoCIkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlY5OjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.Value), global::Google.Ads.GoogleAds.V9.Common.Value.Parser, new[]{ "BooleanValue", "Int64Value", "FloatValue", "DoubleValue", "StringValue" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A generic data container.
  /// </summary>
  public sealed partial class Value : pb::IMessage<Value>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Value> _parser = new pb::MessageParser<Value>(() => new Value());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.ValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Value(Value other) : this() {
      switch (other.ValueCase) {
        case ValueOneofCase.BooleanValue:
          BooleanValue = other.BooleanValue;
          break;
        case ValueOneofCase.Int64Value:
          Int64Value = other.Int64Value;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Value Clone() {
      return new Value(this);
    }

    /// <summary>Field number for the "boolean_value" field.</summary>
    public const int BooleanValueFieldNumber = 1;
    /// <summary>
    /// A boolean.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BooleanValue {
      get { return valueCase_ == ValueOneofCase.BooleanValue ? (bool) value_ : false; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.BooleanValue;
      }
    }

    /// <summary>Field number for the "int64_value" field.</summary>
    public const int Int64ValueFieldNumber = 2;
    /// <summary>
    /// An int64.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Int64Value {
      get { return valueCase_ == ValueOneofCase.Int64Value ? (long) value_ : 0L; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Int64Value;
      }
    }

    /// <summary>Field number for the "float_value" field.</summary>
    public const int FloatValueFieldNumber = 3;
    /// <summary>
    /// A float.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FloatValue {
      get { return valueCase_ == ValueOneofCase.FloatValue ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.FloatValue;
      }
    }

    /// <summary>Field number for the "double_value" field.</summary>
    public const int DoubleValueFieldNumber = 4;
    /// <summary>
    /// A double.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double DoubleValue {
      get { return valueCase_ == ValueOneofCase.DoubleValue ? (double) value_ : 0D; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.DoubleValue;
      }
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 5;
    /// <summary>
    /// A string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return valueCase_ == ValueOneofCase.StringValue ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.StringValue;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      BooleanValue = 1,
      Int64Value = 2,
      FloatValue = 3,
      DoubleValue = 4,
      StringValue = 5,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BooleanValue != other.BooleanValue) return false;
      if (Int64Value != other.Int64Value) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue)) return false;
      if (StringValue != other.StringValue) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (valueCase_ == ValueOneofCase.BooleanValue) hash ^= BooleanValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.Int64Value) hash ^= Int64Value.GetHashCode();
      if (valueCase_ == ValueOneofCase.FloatValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
      if (valueCase_ == ValueOneofCase.DoubleValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
      if (valueCase_ == ValueOneofCase.StringValue) hash ^= StringValue.GetHashCode();
      hash ^= (int) valueCase_;
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
      if (valueCase_ == ValueOneofCase.BooleanValue) {
        output.WriteRawTag(8);
        output.WriteBool(BooleanValue);
      }
      if (valueCase_ == ValueOneofCase.Int64Value) {
        output.WriteRawTag(16);
        output.WriteInt64(Int64Value);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        output.WriteRawTag(33);
        output.WriteDouble(DoubleValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(42);
        output.WriteString(StringValue);
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
      if (valueCase_ == ValueOneofCase.BooleanValue) {
        output.WriteRawTag(8);
        output.WriteBool(BooleanValue);
      }
      if (valueCase_ == ValueOneofCase.Int64Value) {
        output.WriteRawTag(16);
        output.WriteInt64(Int64Value);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        output.WriteRawTag(33);
        output.WriteDouble(DoubleValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(42);
        output.WriteString(StringValue);
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
      if (valueCase_ == ValueOneofCase.BooleanValue) {
        size += 1 + 1;
      }
      if (valueCase_ == ValueOneofCase.Int64Value) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Int64Value);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        size += 1 + 4;
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        size += 1 + 8;
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Value other) {
      if (other == null) {
        return;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.BooleanValue:
          BooleanValue = other.BooleanValue;
          break;
        case ValueOneofCase.Int64Value:
          Int64Value = other.Int64Value;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
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
          case 8: {
            BooleanValue = input.ReadBool();
            break;
          }
          case 16: {
            Int64Value = input.ReadInt64();
            break;
          }
          case 29: {
            FloatValue = input.ReadFloat();
            break;
          }
          case 33: {
            DoubleValue = input.ReadDouble();
            break;
          }
          case 42: {
            StringValue = input.ReadString();
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
          case 8: {
            BooleanValue = input.ReadBool();
            break;
          }
          case 16: {
            Int64Value = input.ReadInt64();
            break;
          }
          case 29: {
            FloatValue = input.ReadFloat();
            break;
          }
          case 33: {
            DoubleValue = input.ReadDouble();
            break;
          }
          case 42: {
            StringValue = input.ReadString();
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
