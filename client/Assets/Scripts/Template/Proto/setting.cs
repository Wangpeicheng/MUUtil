//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: setting.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SettingSkill")]
  public partial class SettingSkill : global::ProtoBuf.IExtensible
  {
    public SettingSkill() {}
    
    private int? _skill;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skill
    {
      get { return _skill?? default(int); }
      set { _skill = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool skillSpecified
    {
      get { return this._skill != null; }
      set { if (value == (this._skill== null)) this._skill = value ? this.skill : (int?)null; }
    }
    private bool ShouldSerializeskill() { return skillSpecified; }
    private void Resetskill() { skillSpecified = false; }
    
    private int? _occupation;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"occupation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int occupation
    {
      get { return _occupation?? default(int); }
      set { _occupation = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool occupationSpecified
    {
      get { return this._occupation != null; }
      set { if (value == (this._occupation== null)) this._occupation = value ? this.occupation : (int?)null; }
    }
    private bool ShouldSerializeoccupation() { return occupationSpecified; }
    private void Resetoccupation() { occupationSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SettingActivity")]
  public partial class SettingActivity : global::ProtoBuf.IExtensible
  {
    public SettingActivity() {}
    
    private int? _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id?? default(int); }
      set { _id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool idSpecified
    {
      get { return this._id != null; }
      set { if (value == (this._id== null)) this._id = value ? this.id : (int?)null; }
    }
    private bool ShouldSerializeid() { return idSpecified; }
    private void Resetid() { idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SettingMsgPush")]
  public partial class SettingMsgPush : global::ProtoBuf.IExtensible
  {
    public SettingMsgPush() {}
    
    private int? _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id?? default(int); }
      set { _id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool idSpecified
    {
      get { return this._id != null; }
      set { if (value == (this._id== null)) this._id = value ? this.id : (int?)null; }
    }
    private bool ShouldSerializeid() { return idSpecified; }
    private void Resetid() { idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SettingOffExp")]
  public partial class SettingOffExp : global::ProtoBuf.IExtensible
  {
    public SettingOffExp() {}
    
    private bool? _recvMsgFlag;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"recvMsgFlag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool recvMsgFlag
    {
      get { return _recvMsgFlag?? default(bool); }
      set { _recvMsgFlag = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool recvMsgFlagSpecified
    {
      get { return this._recvMsgFlag != null; }
      set { if (value == (this._recvMsgFlag== null)) this._recvMsgFlag = value ? this.recvMsgFlag : (bool?)null; }
    }
    private bool ShouldSerializerecvMsgFlag() { return recvMsgFlagSpecified; }
    private void ResetrecvMsgFlag() { recvMsgFlagSpecified = false; }
    
    private bool? _noDisturbFlag;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"noDisturbFlag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool noDisturbFlag
    {
      get { return _noDisturbFlag?? default(bool); }
      set { _noDisturbFlag = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool noDisturbFlagSpecified
    {
      get { return this._noDisturbFlag != null; }
      set { if (value == (this._noDisturbFlag== null)) this._noDisturbFlag = value ? this.noDisturbFlag : (bool?)null; }
    }
    private bool ShouldSerializenoDisturbFlag() { return noDisturbFlagSpecified; }
    private void ResetnoDisturbFlag() { noDisturbFlagSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingDataNtf")]
  public partial class CmdSettingDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdSettingDataNtf() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingSkill> _skill = new global::System.Collections.Generic.List<Proto.SettingSkill>();
    [global::ProtoBuf.ProtoMember(2, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingSkill> skill
    {
      get { return _skill; }
    }
  
    private readonly global::System.Collections.Generic.List<Proto.SettingActivity> _activity = new global::System.Collections.Generic.List<Proto.SettingActivity>();
    [global::ProtoBuf.ProtoMember(3, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingActivity> activity
    {
      get { return _activity; }
    }
  
    private readonly global::System.Collections.Generic.List<Proto.SettingMsgPush> _msgPush = new global::System.Collections.Generic.List<Proto.SettingMsgPush>();
    [global::ProtoBuf.ProtoMember(4, Name=@"msgPush", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingMsgPush> msgPush
    {
      get { return _msgPush; }
    }
  
    private Proto.SettingOffExp _offExp = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"offExp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.SettingOffExp offExp
    {
      get { return _offExp; }
      set { _offExp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingSkillSaveReq")]
  public partial class CmdSettingSkillSaveReq : global::ProtoBuf.IExtensible
  {
    public CmdSettingSkillSaveReq() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingSkill> _skill = new global::System.Collections.Generic.List<Proto.SettingSkill>();
    [global::ProtoBuf.ProtoMember(2, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingSkill> skill
    {
      get { return _skill; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingSkillSaveRes")]
  public partial class CmdSettingSkillSaveRes : global::ProtoBuf.IExtensible
  {
    public CmdSettingSkillSaveRes() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingSkill> _skill = new global::System.Collections.Generic.List<Proto.SettingSkill>();
    [global::ProtoBuf.ProtoMember(2, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingSkill> skill
    {
      get { return _skill; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingActivitySaveReq")]
  public partial class CmdSettingActivitySaveReq : global::ProtoBuf.IExtensible
  {
    public CmdSettingActivitySaveReq() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingActivity> _activity = new global::System.Collections.Generic.List<Proto.SettingActivity>();
    [global::ProtoBuf.ProtoMember(1, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingActivity> activity
    {
      get { return _activity; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingActivitySaveRes")]
  public partial class CmdSettingActivitySaveRes : global::ProtoBuf.IExtensible
  {
    public CmdSettingActivitySaveRes() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingActivity> _activity = new global::System.Collections.Generic.List<Proto.SettingActivity>();
    [global::ProtoBuf.ProtoMember(1, Name=@"activity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingActivity> activity
    {
      get { return _activity; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingMsgPushSaveReq")]
  public partial class CmdSettingMsgPushSaveReq : global::ProtoBuf.IExtensible
  {
    public CmdSettingMsgPushSaveReq() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingMsgPush> _msgPush = new global::System.Collections.Generic.List<Proto.SettingMsgPush>();
    [global::ProtoBuf.ProtoMember(1, Name=@"msgPush", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingMsgPush> msgPush
    {
      get { return _msgPush; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingMsgPushSaveRes")]
  public partial class CmdSettingMsgPushSaveRes : global::ProtoBuf.IExtensible
  {
    public CmdSettingMsgPushSaveRes() {}
    
    private readonly global::System.Collections.Generic.List<Proto.SettingMsgPush> _msgPush = new global::System.Collections.Generic.List<Proto.SettingMsgPush>();
    [global::ProtoBuf.ProtoMember(1, Name=@"msgPush", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.SettingMsgPush> msgPush
    {
      get { return _msgPush; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingOffExpSaveReq")]
  public partial class CmdSettingOffExpSaveReq : global::ProtoBuf.IExtensible
  {
    public CmdSettingOffExpSaveReq() {}
    
    private Proto.SettingOffExp _offExp = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"offExp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.SettingOffExp offExp
    {
      get { return _offExp; }
      set { _offExp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSettingOffExpSaveRes")]
  public partial class CmdSettingOffExpSaveRes : global::ProtoBuf.IExtensible
  {
    public CmdSettingOffExpSaveRes() {}
    
    private Proto.SettingOffExp _offExp = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"offExp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.SettingOffExp offExp
    {
      get { return _offExp; }
      set { _offExp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdSetting")]
    public enum CmdSetting
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_DataNtf", Value=5601)]
      CmdSetting_DataNtf = 5601,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_SkillSaveReq", Value=5602)]
      CmdSetting_SkillSaveReq = 5602,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_SkillSaveRes", Value=5603)]
      CmdSetting_SkillSaveRes = 5603,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_ActivitySaveReq", Value=5604)]
      CmdSetting_ActivitySaveReq = 5604,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_ActivitySaveRes", Value=5605)]
      CmdSetting_ActivitySaveRes = 5605,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_MsgPushSaveReq", Value=5606)]
      CmdSetting_MsgPushSaveReq = 5606,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_MsgPushSaveRes", Value=5607)]
      CmdSetting_MsgPushSaveRes = 5607,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_OffExpSaveReq", Value=5608)]
      CmdSetting_OffExpSaveReq = 5608,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSetting_OffExpSaveRes", Value=5609)]
      CmdSetting_OffExpSaveRes = 5609
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorSetting")]
    public enum ErrorSetting
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorSetting_ActivitySpaceFull", Value=5601)]
      ErrorSetting_ActivitySpaceFull = 5601,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorSetting_PushMsgNotOpen", Value=5602)]
      ErrorSetting_PushMsgNotOpen = 5602
    }
  
}