//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: guildGuardHome.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildGuardHomeData")]
  public partial class GuildGuardHomeData : global::ProtoBuf.IExtensible
  {
    public GuildGuardHomeData() {}
    
    private int? _targetId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"targetId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int targetId
    {
      get { return _targetId?? default(int); }
      set { _targetId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool targetIdSpecified
    {
      get { return this._targetId != null; }
      set { if (value == (this._targetId== null)) this._targetId = value ? this.targetId : (int?)null; }
    }
    private bool ShouldSerializetargetId() { return targetIdSpecified; }
    private void ResettargetId() { targetIdSpecified = false; }
    
    private int? _totalStar;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"totalStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int totalStar
    {
      get { return _totalStar?? default(int); }
      set { _totalStar = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalStarSpecified
    {
      get { return this._totalStar != null; }
      set { if (value == (this._totalStar== null)) this._totalStar = value ? this.totalStar : (int?)null; }
    }
    private bool ShouldSerializetotalStar() { return totalStarSpecified; }
    private void ResettotalStar() { totalStarSpecified = false; }
    
    private int? _curStar;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"curStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int curStar
    {
      get { return _curStar?? default(int); }
      set { _curStar = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool curStarSpecified
    {
      get { return this._curStar != null; }
      set { if (value == (this._curStar== null)) this._curStar = value ? this.curStar : (int?)null; }
    }
    private bool ShouldSerializecurStar() { return curStarSpecified; }
    private void ResetcurStar() { curStarSpecified = false; }
    
    private int? _totalProcess;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"totalProcess", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private int? _curProcess;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"curProcess", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private uint? _lastStartTime;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"lastStartTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lastStartTime
    {
      get { return _lastStartTime?? default(uint); }
      set { _lastStartTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool lastStartTimeSpecified
    {
      get { return this._lastStartTime != null; }
      set { if (value == (this._lastStartTime== null)) this._lastStartTime = value ? this.lastStartTime : (uint?)null; }
    }
    private bool ShouldSerializelastStartTime() { return lastStartTimeSpecified; }
    private void ResetlastStartTime() { lastStartTimeSpecified = false; }
    
    private uint? _lastRefreshTime;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"lastRefreshTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lastRefreshTime
    {
      get { return _lastRefreshTime?? default(uint); }
      set { _lastRefreshTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool lastRefreshTimeSpecified
    {
      get { return this._lastRefreshTime != null; }
      set { if (value == (this._lastRefreshTime== null)) this._lastRefreshTime = value ? this.lastRefreshTime : (uint?)null; }
    }
    private bool ShouldSerializelastRefreshTime() { return lastRefreshTimeSpecified; }
    private void ResetlastRefreshTime() { lastRefreshTimeSpecified = false; }
    
    private int? _refreshTimes;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"refreshTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int refreshTimes
    {
      get { return _refreshTimes?? default(int); }
      set { _refreshTimes = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool refreshTimesSpecified
    {
      get { return this._refreshTimes != null; }
      set { if (value == (this._refreshTimes== null)) this._refreshTimes = value ? this.refreshTimes : (int?)null; }
    }
    private bool ShouldSerializerefreshTimes() { return refreshTimesSpecified; }
    private void ResetrefreshTimes() { refreshTimesSpecified = false; }
    
    private int? _joinTimes;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"joinTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int joinTimes
    {
      get { return _joinTimes?? default(int); }
      set { _joinTimes = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool joinTimesSpecified
    {
      get { return this._joinTimes != null; }
      set { if (value == (this._joinTimes== null)) this._joinTimes = value ? this.joinTimes : (int?)null; }
    }
    private bool ShouldSerializejoinTimes() { return joinTimesSpecified; }
    private void ResetjoinTimes() { joinTimesSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeDataReq")]
  public partial class CmdGuildGuardHomeDataReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeDataReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeDataRes")]
  public partial class CmdGuildGuardHomeDataRes : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeDataRes() {}
    
    private Proto.GuildGuardHomeData _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildGuardHomeData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeStartReq")]
  public partial class CmdGuildGuardHomeStartReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeStartReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeStartRes")]
  public partial class CmdGuildGuardHomeStartRes : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeStartRes() {}
    
    private Proto.GuildGuardHomeData _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildGuardHomeData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeRefreshReq")]
  public partial class CmdGuildGuardHomeRefreshReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeRefreshReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeRefreshRes")]
  public partial class CmdGuildGuardHomeRefreshRes : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeRefreshRes() {}
    
    private Proto.GuildGuardHomeData _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildGuardHomeData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeSetDefiniteTimeReq")]
  public partial class CmdGuildGuardHomeSetDefiniteTimeReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeSetDefiniteTimeReq() {}
    
    private uint? _definiteTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"definiteTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint definiteTime
    {
      get { return _definiteTime?? default(uint); }
      set { _definiteTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool definiteTimeSpecified
    {
      get { return this._definiteTime != null; }
      set { if (value == (this._definiteTime== null)) this._definiteTime = value ? this.definiteTime : (uint?)null; }
    }
    private bool ShouldSerializedefiniteTime() { return definiteTimeSpecified; }
    private void ResetdefiniteTime() { definiteTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHomeDefiniteTimeNtf")]
  public partial class CmdGuildGuardHomeDefiniteTimeNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildGuardHomeDefiniteTimeNtf() {}
    
    private uint? _definiteTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"definiteTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint definiteTime
    {
      get { return _definiteTime?? default(uint); }
      set { _definiteTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool definiteTimeSpecified
    {
      get { return this._definiteTime != null; }
      set { if (value == (this._definiteTime== null)) this._definiteTime = value ? this.definiteTime : (uint?)null; }
    }
    private bool ShouldSerializedefiniteTime() { return definiteTimeSpecified; }
    private void ResetdefiniteTime() { definiteTimeSpecified = false; }
    
    private uint? _lastDefRefreshTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lastDefRefreshTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lastDefRefreshTime
    {
      get { return _lastDefRefreshTime?? default(uint); }
      set { _lastDefRefreshTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool lastDefRefreshTimeSpecified
    {
      get { return this._lastDefRefreshTime != null; }
      set { if (value == (this._lastDefRefreshTime== null)) this._lastDefRefreshTime = value ? this.lastDefRefreshTime : (uint?)null; }
    }
    private bool ShouldSerializelastDefRefreshTime() { return lastDefRefreshTimeSpecified; }
    private void ResetlastDefRefreshTime() { lastDefRefreshTimeSpecified = false; }
    
    private uint? _curDefiniteTime;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"curDefiniteTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint curDefiniteTime
    {
      get { return _curDefiniteTime?? default(uint); }
      set { _curDefiniteTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool curDefiniteTimeSpecified
    {
      get { return this._curDefiniteTime != null; }
      set { if (value == (this._curDefiniteTime== null)) this._curDefiniteTime = value ? this.curDefiniteTime : (uint?)null; }
    }
    private bool ShouldSerializecurDefiniteTime() { return curDefiniteTimeSpecified; }
    private void ResetcurDefiniteTime() { curDefiniteTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdGuildGuardHome")]
    public enum CmdGuildGuardHome
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_DataReq", Value=5401)]
      CmdGuildGuardHome_DataReq = 5401,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_DataRes", Value=5402)]
      CmdGuildGuardHome_DataRes = 5402,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_StartReq", Value=5403)]
      CmdGuildGuardHome_StartReq = 5403,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_StartRes", Value=5404)]
      CmdGuildGuardHome_StartRes = 5404,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_RefreshReq", Value=5405)]
      CmdGuildGuardHome_RefreshReq = 5405,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_RefreshRes", Value=5406)]
      CmdGuildGuardHome_RefreshRes = 5406,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_SetDefiniteTimeReq", Value=5407)]
      CmdGuildGuardHome_SetDefiniteTimeReq = 5407,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildGuardHome_DefiniteTimeNtf", Value=5408)]
      CmdGuildGuardHome_DefiniteTimeNtf = 5408
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorGuildGuardHome")]
    public enum ErrorGuildGuardHome
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_InfoNotFound", Value=5401)]
      ErrorGuildGuardHome_InfoNotFound = 5401,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_NoGuild", Value=5402)]
      ErrorGuildGuardHome_NoGuild = 5402,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_OpenNotAllowed", Value=5403)]
      ErrorGuildGuardHome_OpenNotAllowed = 5403,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_TodayHasOpened", Value=5404)]
      ErrorGuildGuardHome_TodayHasOpened = 5404,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_DataError", Value=5405)]
      ErrorGuildGuardHome_DataError = 5405,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_RefreshFailOnOpening", Value=5406)]
      ErrorGuildGuardHome_RefreshFailOnOpening = 5406,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_RefreshFailTimes", Value=5407)]
      ErrorGuildGuardHome_RefreshFailTimes = 5407,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_RefreshNotAllowed", Value=5408)]
      ErrorGuildGuardHome_RefreshNotAllowed = 5408,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_RefreshFailMoney", Value=5409)]
      ErrorGuildGuardHome_RefreshFailMoney = 5409,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_StartFailOnOpening", Value=5410)]
      ErrorGuildGuardHome_StartFailOnOpening = 5410,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildGuardHome_DefTimeOutOfRange", Value=5411)]
      ErrorGuildGuardHome_DefTimeOutOfRange = 5411
    }
  
}