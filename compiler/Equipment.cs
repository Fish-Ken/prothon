// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Equipment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Equipment.proto</summary>
public static partial class EquipmentReflection {

  #region Descriptor
  /// <summary>File descriptor for Equipment.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EquipmentReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9FcXVpcG1lbnQucHJvdG8aCkVudW0ucHJvdG8ihgEKCUVxdWlwbWVudBIK",
          "CgJJZBgBIAIoCRIVCgVTdGF0ZRgCIAIoDjIGLkdyYWRlEgwKBE5hbWUYAyAC",
          "KAkSFQoFR3JhZGUYBCACKA4yBi5HcmFkZRIbCgtEZXNjcmlwdGlvbhgFIAIo",
          "DjIGLkdyYWRlEhQKBFBhcnQYBiACKA4yBi5HcmFkZQ=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::EnumReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Equipment), global::Equipment.Parser, new[]{ "Id", "State", "Name", "Grade", "Description", "Part" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Equipment : pb::IMessage<Equipment>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Equipment> _parser = new pb::MessageParser<Equipment>(() => new Equipment());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Equipment> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EquipmentReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Equipment() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Equipment(Equipment other) : this() {
    _hasBits0 = other._hasBits0;
    id_ = other.id_;
    state_ = other.state_;
    name_ = other.name_;
    grade_ = other.grade_;
    description_ = other.description_;
    part_ = other.part_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Equipment Clone() {
    return new Equipment(this);
  }

  /// <summary>Field number for the "Id" field.</summary>
  public const int IdFieldNumber = 1;
  private readonly static string IdDefaultValue = "";

  private string id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Id {
    get { return id_ ?? IdDefaultValue; }
    set {
      id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  /// <summary>Gets whether the "Id" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasId {
    get { return id_ != null; }
  }
  /// <summary>Clears the value of the "Id" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearId() {
    id_ = null;
  }

  /// <summary>Field number for the "State" field.</summary>
  public const int StateFieldNumber = 2;
  private readonly static global::Grade StateDefaultValue = global::Grade.Normal;

  private global::Grade state_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Grade State {
    get { if ((_hasBits0 & 1) != 0) { return state_; } else { return StateDefaultValue; } }
    set {
      _hasBits0 |= 1;
      state_ = value;
    }
  }
  /// <summary>Gets whether the "State" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasState {
    get { return (_hasBits0 & 1) != 0; }
  }
  /// <summary>Clears the value of the "State" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearState() {
    _hasBits0 &= ~1;
  }

  /// <summary>Field number for the "Name" field.</summary>
  public const int NameFieldNumber = 3;
  private readonly static string NameDefaultValue = "";

  private string name_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_ ?? NameDefaultValue; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  /// <summary>Gets whether the "Name" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasName {
    get { return name_ != null; }
  }
  /// <summary>Clears the value of the "Name" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearName() {
    name_ = null;
  }

  /// <summary>Field number for the "Grade" field.</summary>
  public const int GradeFieldNumber = 4;
  private readonly static global::Grade GradeDefaultValue = global::Grade.Normal;

  private global::Grade grade_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Grade Grade {
    get { if ((_hasBits0 & 2) != 0) { return grade_; } else { return GradeDefaultValue; } }
    set {
      _hasBits0 |= 2;
      grade_ = value;
    }
  }
  /// <summary>Gets whether the "Grade" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasGrade {
    get { return (_hasBits0 & 2) != 0; }
  }
  /// <summary>Clears the value of the "Grade" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearGrade() {
    _hasBits0 &= ~2;
  }

  /// <summary>Field number for the "Description" field.</summary>
  public const int DescriptionFieldNumber = 5;
  private readonly static global::Grade DescriptionDefaultValue = global::Grade.Normal;

  private global::Grade description_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Grade Description {
    get { if ((_hasBits0 & 4) != 0) { return description_; } else { return DescriptionDefaultValue; } }
    set {
      _hasBits0 |= 4;
      description_ = value;
    }
  }
  /// <summary>Gets whether the "Description" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasDescription {
    get { return (_hasBits0 & 4) != 0; }
  }
  /// <summary>Clears the value of the "Description" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearDescription() {
    _hasBits0 &= ~4;
  }

  /// <summary>Field number for the "Part" field.</summary>
  public const int PartFieldNumber = 6;
  private readonly static global::Grade PartDefaultValue = global::Grade.Normal;

  private global::Grade part_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Grade Part {
    get { if ((_hasBits0 & 8) != 0) { return part_; } else { return PartDefaultValue; } }
    set {
      _hasBits0 |= 8;
      part_ = value;
    }
  }
  /// <summary>Gets whether the "Part" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasPart {
    get { return (_hasBits0 & 8) != 0; }
  }
  /// <summary>Clears the value of the "Part" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearPart() {
    _hasBits0 &= ~8;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Equipment);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Equipment other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (State != other.State) return false;
    if (Name != other.Name) return false;
    if (Grade != other.Grade) return false;
    if (Description != other.Description) return false;
    if (Part != other.Part) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (HasId) hash ^= Id.GetHashCode();
    if (HasState) hash ^= State.GetHashCode();
    if (HasName) hash ^= Name.GetHashCode();
    if (HasGrade) hash ^= Grade.GetHashCode();
    if (HasDescription) hash ^= Description.GetHashCode();
    if (HasPart) hash ^= Part.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasId) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (HasState) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (HasName) {
      output.WriteRawTag(26);
      output.WriteString(Name);
    }
    if (HasGrade) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Grade);
    }
    if (HasDescription) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Description);
    }
    if (HasPart) {
      output.WriteRawTag(48);
      output.WriteEnum((int) Part);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasId) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (HasState) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (HasName) {
      output.WriteRawTag(26);
      output.WriteString(Name);
    }
    if (HasGrade) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Grade);
    }
    if (HasDescription) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Description);
    }
    if (HasPart) {
      output.WriteRawTag(48);
      output.WriteEnum((int) Part);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (HasId) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
    }
    if (HasState) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (HasName) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (HasGrade) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Grade);
    }
    if (HasDescription) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Description);
    }
    if (HasPart) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Part);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Equipment other) {
    if (other == null) {
      return;
    }
    if (other.HasId) {
      Id = other.Id;
    }
    if (other.HasState) {
      State = other.State;
    }
    if (other.HasName) {
      Name = other.Name;
    }
    if (other.HasGrade) {
      Grade = other.Grade;
    }
    if (other.HasDescription) {
      Description = other.Description;
    }
    if (other.HasPart) {
      Part = other.Part;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          Id = input.ReadString();
          break;
        }
        case 16: {
          State = (global::Grade) input.ReadEnum();
          break;
        }
        case 26: {
          Name = input.ReadString();
          break;
        }
        case 32: {
          Grade = (global::Grade) input.ReadEnum();
          break;
        }
        case 40: {
          Description = (global::Grade) input.ReadEnum();
          break;
        }
        case 48: {
          Part = (global::Grade) input.ReadEnum();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Id = input.ReadString();
          break;
        }
        case 16: {
          State = (global::Grade) input.ReadEnum();
          break;
        }
        case 26: {
          Name = input.ReadString();
          break;
        }
        case 32: {
          Grade = (global::Grade) input.ReadEnum();
          break;
        }
        case 40: {
          Description = (global::Grade) input.ReadEnum();
          break;
        }
        case 48: {
          Part = (global::Grade) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
