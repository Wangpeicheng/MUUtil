//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: battleInstance.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdBattleInstanceEnterReq")]
  public partial class CmdBattleInstanceEnterReq : global::ProtoBuf.IExtensible
  {
    public CmdBattleInstanceEnterReq() {}
    
    private int? _infoId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"infoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int infoId
    {
      get { return _infoId?? default(int); }
      set { _infoId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool infoIdSpecified
    {
      get { return this._infoId != null; }
      set { if (value == (this._infoId== null)) this._infoId = value ? this.infoId : (int?)null; }
    }
    private bool ShouldSerializeinfoId() { return infoIdSpecified; }
    private void ResetinfoId() { infoIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdBattleInstanceEnterRes")]
  public partial class CmdBattleInstanceEnterRes : global::ProtoBuf.IExtensible
  {
    public CmdBattleInstanceEnterRes() {}
    
    private int? _infoId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"infoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int infoId
    {
      get { return _infoId?? default(int); }
      set { _infoId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool infoIdSpecified
    {
      get { return this._infoId != null; }
      set { if (value == (this._infoId== null)) this._infoId = value ? this.infoId : (int?)null; }
    }
    private bool ShouldSerializeinfoId() { return infoIdSpecified; }
    private void ResetinfoId() { infoIdSpecified = false; }
    
    private uint? _insLeftTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"insLeftTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint insLeftTime
    {
      get { return _insLeftTime?? default(uint); }
      set { _insLeftTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool insLeftTimeSpecified
    {
      get { return this._insLeftTime != null; }
      set { if (value == (this._insLeftTime== null)) this._insLeftTime = value ? this.insLeftTime : (uint?)null; }
    }
    private bool ShouldSerializeinsLeftTime() { return insLeftTimeSpecified; }
    private void ResetinsLeftTime() { insLeftTimeSpecified = false; }
    
    private uint? _roleLeftTime;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"roleLeftTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint roleLeftTime
    {
      get { return _roleLeftTime?? default(uint); }
      set { _roleLeftTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool roleLeftTimeSpecified
    {
      get { return this._roleLeftTime != null; }
      set { if (value == (this._roleLeftTime== null)) this._roleLeftTime = value ? this.roleLeftTime : (uint?)null; }
    }
    private bool ShouldSerializeroleLeftTime() { return roleLeftTimeSpecified; }
    private void ResetroleLeftTime() { roleLeftTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdBattleInstanceDataNtf")]
  public partial class CmdBattleInstanceDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdBattleInstanceDataNtf() {}
    
    private uint? _time;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint time
    {
      get { return _time?? default(uint); }
      set { _time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timeSpecified
    {
      get { return this._time != null; }
      set { if (value == (this._time== null)) this._time = value ? this.time : (uint?)null; }
    }
    private bool ShouldSerializetime() { return timeSpecified; }
    private void Resettime() { timeSpecified = false; }
    
    private uint? _leftTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"leftTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint leftTime
    {
      get { return _leftTime?? default(uint); }
      set { _leftTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool leftTimeSpecified
    {
      get { return this._leftTime != null; }
      set { if (value == (this._leftTime== null)) this._leftTime = value ? this.leftTime : (uint?)null; }
    }
    private bool ShouldSerializeleftTime() { return leftTimeSpecified; }
    private void ResetleftTime() { leftTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdBattleInstance")]
    public enum CmdBattleInstance
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdBattleInstance_EnterReq", Value=5701)]
      CmdBattleInstance_EnterReq = 5701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdBattleInstance_EnterRes", Value=5702)]
      CmdBattleInstance_EnterRes = 5702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdBattleInstance_DataNtf", Value=5703)]
      CmdBattleInstance_DataNtf = 5703
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorBattleInstance")]
    public enum ErrorBattleInstance
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_HasTeamFail", Value=5701)]
      ErrorBattleInstance_HasTeamFail = 5701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_LevelFail", Value=5702)]
      ErrorBattleInstance_LevelFail = 5702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_NotInActiveTime", Value=5703)]
      ErrorBattleInstance_NotInActiveTime = 5703,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_InfoNotFound", Value=5704)]
      ErrorBattleInstance_InfoNotFound = 5704,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_DayTimeOut", Value=5705)]
      ErrorBattleInstance_DayTimeOut = 5705,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_RoleNumOut", Value=5706)]
      ErrorBattleInstance_RoleNumOut = 5706,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorBattleInstance_InsAllocFail", Value=5707)]
      ErrorBattleInstance_InsAllocFail = 5707
    }
  
}