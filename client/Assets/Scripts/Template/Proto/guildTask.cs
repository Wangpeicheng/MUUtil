//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: guildTask.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildTask")]
  public partial class GuildTask : global::ProtoBuf.IExtensible
  {
    public GuildTask() {}
    
    private int? _taskId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"taskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int taskId
    {
      get { return _taskId?? default(int); }
      set { _taskId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool taskIdSpecified
    {
      get { return this._taskId != null; }
      set { if (value == (this._taskId== null)) this._taskId = value ? this.taskId : (int?)null; }
    }
    private bool ShouldSerializetaskId() { return taskIdSpecified; }
    private void ResettaskId() { taskIdSpecified = false; }
    
    private int? _curProcess;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"curProcess", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int curProcess
    {
      get { return _curProcess?? default(int); }
      set { _curProcess = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool curProcessSpecified
    {
      get { return this._curProcess != null; }
      set { if (value == (this._curProcess== null)) this._curProcess = value ? this.curProcess : (int?)null; }
    }
    private bool ShouldSerializecurProcess() { return curProcessSpecified; }
    private void ResetcurProcess() { curProcessSpecified = false; }
    
    private int? _totalProcess;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"totalProcess", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int totalProcess
    {
      get { return _totalProcess?? default(int); }
      set { _totalProcess = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalProcessSpecified
    {
      get { return this._totalProcess != null; }
      set { if (value == (this._totalProcess== null)) this._totalProcess = value ? this.totalProcess : (int?)null; }
    }
    private bool ShouldSerializetotalProcess() { return totalProcessSpecified; }
    private void ResettotalProcess() { totalProcessSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildBuildTask")]
  public partial class GuildBuildTask : global::ProtoBuf.IExtensible
  {
    public GuildBuildTask() {}
    
    private Proto.GuildTask _task = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"task", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildTask task
    {
      get { return _task; }
      set { _task = value; }
    }
    private int? _ring;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ring", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ring
    {
      get { return _ring?? default(int); }
      set { _ring = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ringSpecified
    {
      get { return this._ring != null; }
      set { if (value == (this._ring== null)) this._ring = value ? this.ring : (int?)null; }
    }
    private bool ShouldSerializering() { return ringSpecified; }
    private void Resetring() { ringSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildTaskDataNtf")]
  public partial class CmdGuildTaskDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildTaskDataNtf() {}
    
    private Proto.GuildBuildTask _buildTask = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"buildTask", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildBuildTask buildTask
    {
      get { return _buildTask; }
      set { _buildTask = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildTaskBuildTaskNtf")]
  public partial class CmdGuildTaskBuildTaskNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildTaskBuildTaskNtf() {}
    
    private Proto.GuildBuildTask _buildTask = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"buildTask", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildBuildTask buildTask
    {
      get { return _buildTask; }
      set { _buildTask = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildTaskTalkReq")]
  public partial class CmdGuildTaskTalkReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildTaskTalkReq() {}
    
    private int? _taskId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"taskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int taskId
    {
      get { return _taskId?? default(int); }
      set { _taskId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool taskIdSpecified
    {
      get { return this._taskId != null; }
      set { if (value == (this._taskId== null)) this._taskId = value ? this.taskId : (int?)null; }
    }
    private bool ShouldSerializetaskId() { return taskIdSpecified; }
    private void ResettaskId() { taskIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildTaskTalkRes")]
  public partial class CmdGuildTaskTalkRes : global::ProtoBuf.IExtensible
  {
    public CmdGuildTaskTalkRes() {}
    
    private int? _taskId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"taskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int taskId
    {
      get { return _taskId?? default(int); }
      set { _taskId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool taskIdSpecified
    {
      get { return this._taskId != null; }
      set { if (value == (this._taskId== null)) this._taskId = value ? this.taskId : (int?)null; }
    }
    private bool ShouldSerializetaskId() { return taskIdSpecified; }
    private void ResettaskId() { taskIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildTaskRewardNtf")]
  public partial class CmdGuildTaskRewardNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildTaskRewardNtf() {}
    
    private int? _taskId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"taskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int taskId
    {
      get { return _taskId?? default(int); }
      set { _taskId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool taskIdSpecified
    {
      get { return this._taskId != null; }
      set { if (value == (this._taskId== null)) this._taskId = value ? this.taskId : (int?)null; }
    }
    private bool ShouldSerializetaskId() { return taskIdSpecified; }
    private void ResettaskId() { taskIdSpecified = false; }
    
    private uint? _exp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint exp
    {
      get { return _exp?? default(uint); }
      set { _exp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool expSpecified
    {
      get { return this._exp != null; }
      set { if (value == (this._exp== null)) this._exp = value ? this.exp : (uint?)null; }
    }
    private bool ShouldSerializeexp() { return expSpecified; }
    private void Resetexp() { expSpecified = false; }
    
    private uint? _contri;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"contri", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint contri
    {
      get { return _contri?? default(uint); }
      set { _contri = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool contriSpecified
    {
      get { return this._contri != null; }
      set { if (value == (this._contri== null)) this._contri = value ? this.contri : (uint?)null; }
    }
    private bool ShouldSerializecontri() { return contriSpecified; }
    private void Resetcontri() { contriSpecified = false; }
    
    private uint? _money;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint money
    {
      get { return _money?? default(uint); }
      set { _money = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool moneySpecified
    {
      get { return this._money != null; }
      set { if (value == (this._money== null)) this._money = value ? this.money : (uint?)null; }
    }
    private bool ShouldSerializemoney() { return moneySpecified; }
    private void Resetmoney() { moneySpecified = false; }
    
    private uint? _bonus;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"bonus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint bonus
    {
      get { return _bonus?? default(uint); }
      set { _bonus = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool bonusSpecified
    {
      get { return this._bonus != null; }
      set { if (value == (this._bonus== null)) this._bonus = value ? this.bonus : (uint?)null; }
    }
    private bool ShouldSerializebonus() { return bonusSpecified; }
    private void Resetbonus() { bonusSpecified = false; }
    
    private uint? _coin;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"coin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint coin
    {
      get { return _coin?? default(uint); }
      set { _coin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool coinSpecified
    {
      get { return this._coin != null; }
      set { if (value == (this._coin== null)) this._coin = value ? this.coin : (uint?)null; }
    }
    private bool ShouldSerializecoin() { return coinSpecified; }
    private void Resetcoin() { coinSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdGuildTask")]
    public enum CmdGuildTask
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildTask_DataNtf", Value=4701)]
      CmdGuildTask_DataNtf = 4701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildTask_BuildTaskNtf", Value=4702)]
      CmdGuildTask_BuildTaskNtf = 4702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildTask_TalkReq", Value=4703)]
      CmdGuildTask_TalkReq = 4703,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildTask_TalkRes", Value=4704)]
      CmdGuildTask_TalkRes = 4704,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildTask_RewardNtf", Value=4705)]
      CmdGuildTask_RewardNtf = 4705
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorGuildTask")]
    public enum ErrorGuildTask
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildTask_BuildTaskInfoNotFound", Value=4701)]
      ErrorGuildTask_BuildTaskInfoNotFound = 4701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildTask_LevelInfoNotFound", Value=4702)]
      ErrorGuildTask_LevelInfoNotFound = 4702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildTask_GuildNotExist", Value=4703)]
      ErrorGuildTask_GuildNotExist = 4703
    }
  
}