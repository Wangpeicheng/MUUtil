//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: sevenReward.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSevenRewardDataNtf")]
  public partial class CmdSevenRewardDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdSevenRewardDataNtf() {}
    
    private uint? _receivedTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"receivedTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint receivedTime
    {
      get { return _receivedTime?? default(uint); }
      set { _receivedTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool receivedTimeSpecified
    {
      get { return this._receivedTime != null; }
      set { if (value == (this._receivedTime== null)) this._receivedTime = value ? this.receivedTime : (uint?)null; }
    }
    private bool ShouldSerializereceivedTime() { return receivedTimeSpecified; }
    private void ResetreceivedTime() { receivedTimeSpecified = false; }
    
    private uint? _receivedTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"receivedTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint receivedTimes
    {
      get { return _receivedTimes?? default(uint); }
      set { _receivedTimes = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool receivedTimesSpecified
    {
      get { return this._receivedTimes != null; }
      set { if (value == (this._receivedTimes== null)) this._receivedTimes = value ? this.receivedTimes : (uint?)null; }
    }
    private bool ShouldSerializereceivedTimes() { return receivedTimesSpecified; }
    private void ResetreceivedTimes() { receivedTimesSpecified = false; }
    
    private uint? _openTime;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"openTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint openTime
    {
      get { return _openTime?? default(uint); }
      set { _openTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool openTimeSpecified
    {
      get { return this._openTime != null; }
      set { if (value == (this._openTime== null)) this._openTime = value ? this.openTime : (uint?)null; }
    }
    private bool ShouldSerializeopenTime() { return openTimeSpecified; }
    private void ResetopenTime() { openTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSevenRewardGetReq")]
  public partial class CmdSevenRewardGetReq : global::ProtoBuf.IExtensible
  {
    public CmdSevenRewardGetReq() {}
    
    private uint? _infoId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"infoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint infoId
    {
      get { return _infoId?? default(uint); }
      set { _infoId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool infoIdSpecified
    {
      get { return this._infoId != null; }
      set { if (value == (this._infoId== null)) this._infoId = value ? this.infoId : (uint?)null; }
    }
    private bool ShouldSerializeinfoId() { return infoIdSpecified; }
    private void ResetinfoId() { infoIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdSevenRewardGetRes")]
  public partial class CmdSevenRewardGetRes : global::ProtoBuf.IExtensible
  {
    public CmdSevenRewardGetRes() {}
    
    private uint? _infoId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"infoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint infoId
    {
      get { return _infoId?? default(uint); }
      set { _infoId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool infoIdSpecified
    {
      get { return this._infoId != null; }
      set { if (value == (this._infoId== null)) this._infoId = value ? this.infoId : (uint?)null; }
    }
    private bool ShouldSerializeinfoId() { return infoIdSpecified; }
    private void ResetinfoId() { infoIdSpecified = false; }
    
    private uint? _receivedTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"receivedTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint receivedTime
    {
      get { return _receivedTime?? default(uint); }
      set { _receivedTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool receivedTimeSpecified
    {
      get { return this._receivedTime != null; }
      set { if (value == (this._receivedTime== null)) this._receivedTime = value ? this.receivedTime : (uint?)null; }
    }
    private bool ShouldSerializereceivedTime() { return receivedTimeSpecified; }
    private void ResetreceivedTime() { receivedTimeSpecified = false; }
    
    private uint? _receivedTimes;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"receivedTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint receivedTimes
    {
      get { return _receivedTimes?? default(uint); }
      set { _receivedTimes = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool receivedTimesSpecified
    {
      get { return this._receivedTimes != null; }
      set { if (value == (this._receivedTimes== null)) this._receivedTimes = value ? this.receivedTimes : (uint?)null; }
    }
    private bool ShouldSerializereceivedTimes() { return receivedTimesSpecified; }
    private void ResetreceivedTimes() { receivedTimesSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdSevenReward")]
    public enum CmdSevenReward
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSevenReward_DataNtf", Value=3001)]
      CmdSevenReward_DataNtf = 3001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSevenReward_GetReq", Value=3002)]
      CmdSevenReward_GetReq = 3002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdSevenReward_GetRes", Value=3003)]
      CmdSevenReward_GetRes = 3003
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorSevenReward")]
    public enum ErrorSevenReward
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_BagFull", Value=3001)]
      Error_SevenReward_BagFull = 3001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_ReceivedToday", Value=3002)]
      Error_SevenReward_ReceivedToday = 3002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_OverLimit", Value=3003)]
      Error_SevenReward_OverLimit = 3003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_BadId", Value=3004)]
      Error_SevenReward_BadId = 3004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_ActivityEnd", Value=3005)]
      Error_SevenReward_ActivityEnd = 3005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_SevenReward_NotOpen", Value=3006)]
      Error_SevenReward_NotOpen = 3006
    }
  
}