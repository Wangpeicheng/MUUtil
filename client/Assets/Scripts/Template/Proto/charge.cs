//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: charge.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeGrowDataNtf")]
  public partial class CmdChargeGrowDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdChargeGrowDataNtf() {}
    
    private uint? _growBuyTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"growBuyTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint growBuyTime
    {
      get { return _growBuyTime?? default(uint); }
      set { _growBuyTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool growBuyTimeSpecified
    {
      get { return this._growBuyTime != null; }
      set { if (value == (this._growBuyTime== null)) this._growBuyTime = value ? this.growBuyTime : (uint?)null; }
    }
    private bool ShouldSerializegrowBuyTime() { return growBuyTimeSpecified; }
    private void ResetgrowBuyTime() { growBuyTimeSpecified = false; }
    
    private uint? _takeInfo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"takeInfo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint takeInfo
    {
      get { return _takeInfo?? default(uint); }
      set { _takeInfo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool takeInfoSpecified
    {
      get { return this._takeInfo != null; }
      set { if (value == (this._takeInfo== null)) this._takeInfo = value ? this.takeInfo : (uint?)null; }
    }
    private bool ShouldSerializetakeInfo() { return takeInfoSpecified; }
    private void ResettakeInfo() { takeInfoSpecified = false; }
    
    private uint? _growBuyTime2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"growBuyTime2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint growBuyTime2
    {
      get { return _growBuyTime2?? default(uint); }
      set { _growBuyTime2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool growBuyTime2Specified
    {
      get { return this._growBuyTime2 != null; }
      set { if (value == (this._growBuyTime2== null)) this._growBuyTime2 = value ? this.growBuyTime2 : (uint?)null; }
    }
    private bool ShouldSerializegrowBuyTime2() { return growBuyTime2Specified; }
    private void ResetgrowBuyTime2() { growBuyTime2Specified = false; }
    
    private uint? _takeInfo2;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"takeInfo2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint takeInfo2
    {
      get { return _takeInfo2?? default(uint); }
      set { _takeInfo2 = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool takeInfo2Specified
    {
      get { return this._takeInfo2 != null; }
      set { if (value == (this._takeInfo2== null)) this._takeInfo2 = value ? this.takeInfo2 : (uint?)null; }
    }
    private bool ShouldSerializetakeInfo2() { return takeInfo2Specified; }
    private void ResettakeInfo2() { takeInfo2Specified = false; }
    
    private readonly global::System.Collections.Generic.List<uint> _growBuyTime3n = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"growBuyTime3n", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> growBuyTime3n
    {
      get { return _growBuyTime3n; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _takeInfo3n = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"takeInfo3n", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> takeInfo3n
    {
      get { return _takeInfo3n; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeTakeGrowAwardReq")]
  public partial class CmdChargeTakeGrowAwardReq : global::ProtoBuf.IExtensible
  {
    public CmdChargeTakeGrowAwardReq() {}
    
    private uint? _takeId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"takeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint takeId
    {
      get { return _takeId?? default(uint); }
      set { _takeId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool takeIdSpecified
    {
      get { return this._takeId != null; }
      set { if (value == (this._takeId== null)) this._takeId = value ? this.takeId : (uint?)null; }
    }
    private bool ShouldSerializetakeId() { return takeIdSpecified; }
    private void ResettakeId() { takeIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeCardDataNtf")]
  public partial class CmdChargeCardDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdChargeCardDataNtf() {}
    
    private uint? _zhoukaTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"zhoukaTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zhoukaTime
    {
      get { return _zhoukaTime?? default(uint); }
      set { _zhoukaTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool zhoukaTimeSpecified
    {
      get { return this._zhoukaTime != null; }
      set { if (value == (this._zhoukaTime== null)) this._zhoukaTime = value ? this.zhoukaTime : (uint?)null; }
    }
    private bool ShouldSerializezhoukaTime() { return zhoukaTimeSpecified; }
    private void ResetzhoukaTime() { zhoukaTimeSpecified = false; }
    
    private uint? _yuekaTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"yuekaTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint yuekaTime
    {
      get { return _yuekaTime?? default(uint); }
      set { _yuekaTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool yuekaTimeSpecified
    {
      get { return this._yuekaTime != null; }
      set { if (value == (this._yuekaTime== null)) this._yuekaTime = value ? this.yuekaTime : (uint?)null; }
    }
    private bool ShouldSerializeyuekaTime() { return yuekaTimeSpecified; }
    private void ResetyuekaTime() { yuekaTimeSpecified = false; }
    
    private uint? _wTakeInfo;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"wTakeInfo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint wTakeInfo
    {
      get { return _wTakeInfo?? default(uint); }
      set { _wTakeInfo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool wTakeInfoSpecified
    {
      get { return this._wTakeInfo != null; }
      set { if (value == (this._wTakeInfo== null)) this._wTakeInfo = value ? this.wTakeInfo : (uint?)null; }
    }
    private bool ShouldSerializewTakeInfo() { return wTakeInfoSpecified; }
    private void ResetwTakeInfo() { wTakeInfoSpecified = false; }
    
    private uint? _mTakeInfo;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"mTakeInfo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint mTakeInfo
    {
      get { return _mTakeInfo?? default(uint); }
      set { _mTakeInfo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool mTakeInfoSpecified
    {
      get { return this._mTakeInfo != null; }
      set { if (value == (this._mTakeInfo== null)) this._mTakeInfo = value ? this.mTakeInfo : (uint?)null; }
    }
    private bool ShouldSerializemTakeInfo() { return mTakeInfoSpecified; }
    private void ResetmTakeInfo() { mTakeInfoSpecified = false; }
    
    private uint? _foreverCardBuyTime;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"foreverCardBuyTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint foreverCardBuyTime
    {
      get { return _foreverCardBuyTime?? default(uint); }
      set { _foreverCardBuyTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool foreverCardBuyTimeSpecified
    {
      get { return this._foreverCardBuyTime != null; }
      set { if (value == (this._foreverCardBuyTime== null)) this._foreverCardBuyTime = value ? this.foreverCardBuyTime : (uint?)null; }
    }
    private bool ShouldSerializeforeverCardBuyTime() { return foreverCardBuyTimeSpecified; }
    private void ResetforeverCardBuyTime() { foreverCardBuyTimeSpecified = false; }
    
    private uint? _lastTakeTime;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"lastTakeTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lastTakeTime
    {
      get { return _lastTakeTime?? default(uint); }
      set { _lastTakeTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool lastTakeTimeSpecified
    {
      get { return this._lastTakeTime != null; }
      set { if (value == (this._lastTakeTime== null)) this._lastTakeTime = value ? this.lastTakeTime : (uint?)null; }
    }
    private bool ShouldSerializelastTakeTime() { return lastTakeTimeSpecified; }
    private void ResetlastTakeTime() { lastTakeTimeSpecified = false; }
    
    private uint? _privilegeCardBuyTime;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"privilegeCardBuyTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint privilegeCardBuyTime
    {
      get { return _privilegeCardBuyTime?? default(uint); }
      set { _privilegeCardBuyTime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool privilegeCardBuyTimeSpecified
    {
      get { return this._privilegeCardBuyTime != null; }
      set { if (value == (this._privilegeCardBuyTime== null)) this._privilegeCardBuyTime = value ? this.privilegeCardBuyTime : (uint?)null; }
    }
    private bool ShouldSerializeprivilegeCardBuyTime() { return privilegeCardBuyTimeSpecified; }
    private void ResetprivilegeCardBuyTime() { privilegeCardBuyTimeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeTakeCardAwardReq")]
  public partial class CmdChargeTakeCardAwardReq : global::ProtoBuf.IExtensible
  {
    public CmdChargeTakeCardAwardReq() {}
    
    private uint? _cardType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint cardType
    {
      get { return _cardType?? default(uint); }
      set { _cardType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool cardTypeSpecified
    {
      get { return this._cardType != null; }
      set { if (value == (this._cardType== null)) this._cardType = value ? this.cardType : (uint?)null; }
    }
    private bool ShouldSerializecardType() { return cardTypeSpecified; }
    private void ResetcardType() { cardTypeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeDataNtf")]
  public partial class CmdChargeDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdChargeDataNtf() {}
    
    private readonly global::System.Collections.Generic.List<uint> _saleId = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"saleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> saleId
    {
      get { return _saleId; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _saleNum = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"saleNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> saleNum
    {
      get { return _saleNum; }
    }
  
    private uint? _totalCharge;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"totalCharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint totalCharge
    {
      get { return _totalCharge?? default(uint); }
      set { _totalCharge = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalChargeSpecified
    {
      get { return this._totalCharge != null; }
      set { if (value == (this._totalCharge== null)) this._totalCharge = value ? this.totalCharge : (uint?)null; }
    }
    private bool ShouldSerializetotalCharge() { return totalChargeSpecified; }
    private void ResettotalCharge() { totalChargeSpecified = false; }
    
    private bool? _fcRewardReceived;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fcRewardReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool fcRewardReceived
    {
      get { return _fcRewardReceived?? default(bool); }
      set { _fcRewardReceived = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool fcRewardReceivedSpecified
    {
      get { return this._fcRewardReceived != null; }
      set { if (value == (this._fcRewardReceived== null)) this._fcRewardReceived = value ? this.fcRewardReceived : (bool?)null; }
    }
    private bool ShouldSerializefcRewardReceived() { return fcRewardReceivedSpecified; }
    private void ResetfcRewardReceived() { fcRewardReceivedSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeChargeReq")]
  public partial class CmdChargeChargeReq : global::ProtoBuf.IExtensible
  {
    public CmdChargeChargeReq() {}
    
    private uint? _saleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"saleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint saleId
    {
      get { return _saleId?? default(uint); }
      set { _saleId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool saleIdSpecified
    {
      get { return this._saleId != null; }
      set { if (value == (this._saleId== null)) this._saleId = value ? this.saleId : (uint?)null; }
    }
    private bool ShouldSerializesaleId() { return saleIdSpecified; }
    private void ResetsaleId() { saleIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeChargeNtf")]
  public partial class CmdChargeChargeNtf : global::ProtoBuf.IExtensible
  {
    public CmdChargeChargeNtf() {}
    
    private uint? _saleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"saleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint saleId
    {
      get { return _saleId?? default(uint); }
      set { _saleId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool saleIdSpecified
    {
      get { return this._saleId != null; }
      set { if (value == (this._saleId== null)) this._saleId = value ? this.saleId : (uint?)null; }
    }
    private bool ShouldSerializesaleId() { return saleIdSpecified; }
    private void ResetsaleId() { saleIdSpecified = false; }
    
    private uint? _saleNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"saleNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint saleNum
    {
      get { return _saleNum?? default(uint); }
      set { _saleNum = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool saleNumSpecified
    {
      get { return this._saleNum != null; }
      set { if (value == (this._saleNum== null)) this._saleNum = value ? this.saleNum : (uint?)null; }
    }
    private bool ShouldSerializesaleNum() { return saleNumSpecified; }
    private void ResetsaleNum() { saleNumSpecified = false; }
    
    private uint? _totalCharge;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"totalCharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint totalCharge
    {
      get { return _totalCharge?? default(uint); }
      set { _totalCharge = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalChargeSpecified
    {
      get { return this._totalCharge != null; }
      set { if (value == (this._totalCharge== null)) this._totalCharge = value ? this.totalCharge : (uint?)null; }
    }
    private bool ShouldSerializetotalCharge() { return totalChargeSpecified; }
    private void ResettotalCharge() { totalChargeSpecified = false; }
    
    private bool? _fcRewardReceived;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fcRewardReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool fcRewardReceived
    {
      get { return _fcRewardReceived?? default(bool); }
      set { _fcRewardReceived = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool fcRewardReceivedSpecified
    {
      get { return this._fcRewardReceived != null; }
      set { if (value == (this._fcRewardReceived== null)) this._fcRewardReceived = value ? this.fcRewardReceived : (bool?)null; }
    }
    private bool ShouldSerializefcRewardReceived() { return fcRewardReceivedSpecified; }
    private void ResetfcRewardReceived() { fcRewardReceivedSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdFCRewardGetReq")]
  public partial class CmdFCRewardGetReq : global::ProtoBuf.IExtensible
  {
    public CmdFCRewardGetReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdFCRewardGetRes")]
  public partial class CmdFCRewardGetRes : global::ProtoBuf.IExtensible
  {
    public CmdFCRewardGetRes() {}
    
    private bool? _fcRewardReceived;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"fcRewardReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool fcRewardReceived
    {
      get { return _fcRewardReceived?? default(bool); }
      set { _fcRewardReceived = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool fcRewardReceivedSpecified
    {
      get { return this._fcRewardReceived != null; }
      set { if (value == (this._fcRewardReceived== null)) this._fcRewardReceived = value ? this.fcRewardReceived : (bool?)null; }
    }
    private bool ShouldSerializefcRewardReceived() { return fcRewardReceivedSpecified; }
    private void ResetfcRewardReceived() { fcRewardReceivedSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeTRChargeReq")]
  public partial class CmdChargeTRChargeReq : global::ProtoBuf.IExtensible
  {
    public CmdChargeTRChargeReq() {}
    
    private uint? _productId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"productId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint productId
    {
      get { return _productId?? default(uint); }
      set { _productId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool productIdSpecified
    {
      get { return this._productId != null; }
      set { if (value == (this._productId== null)) this._productId = value ? this.productId : (uint?)null; }
    }
    private bool ShouldSerializeproductId() { return productIdSpecified; }
    private void ResetproductId() { productIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeTRChargeRes")]
  public partial class CmdChargeTRChargeRes : global::ProtoBuf.IExtensible
  {
    public CmdChargeTRChargeRes() {}
    
    private byte[] _ext_data;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ext_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] ext_data
    {
      get { return _ext_data?? null; }
      set { _ext_data = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ext_dataSpecified
    {
      get { return this._ext_data != null; }
      set { if (value == (this._ext_data== null)) this._ext_data = value ? this.ext_data : (byte[])null; }
    }
    private bool ShouldSerializeext_data() { return ext_dataSpecified; }
    private void Resetext_data() { ext_dataSpecified = false; }
    
    private byte[] _sign;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sign", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] sign
    {
      get { return _sign?? null; }
      set { _sign = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool signSpecified
    {
      get { return this._sign != null; }
      set { if (value == (this._sign== null)) this._sign = value ? this.sign : (byte[])null; }
    }
    private bool ShouldSerializesign() { return signSpecified; }
    private void Resetsign() { signSpecified = false; }
    
    private byte[] _amount;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] amount
    {
      get { return _amount?? null; }
      set { _amount = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool amountSpecified
    {
      get { return this._amount != null; }
      set { if (value == (this._amount== null)) this._amount = value ? this.amount : (byte[])null; }
    }
    private bool ShouldSerializeamount() { return amountSpecified; }
    private void Resetamount() { amountSpecified = false; }
    
    private uint? _productId;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"productId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint productId
    {
      get { return _productId?? default(uint); }
      set { _productId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool productIdSpecified
    {
      get { return this._productId != null; }
      set { if (value == (this._productId== null)) this._productId = value ? this.productId : (uint?)null; }
    }
    private bool ShouldSerializeproductId() { return productIdSpecified; }
    private void ResetproductId() { productIdSpecified = false; }
    
    private byte[] _productName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"productName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] productName
    {
      get { return _productName?? null; }
      set { _productName = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool productNameSpecified
    {
      get { return this._productName != null; }
      set { if (value == (this._productName== null)) this._productName = value ? this.productName : (byte[])null; }
    }
    private bool ShouldSerializeproductName() { return productNameSpecified; }
    private void ResetproductName() { productNameSpecified = false; }
    
    private byte[] _serverName;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"serverName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] serverName
    {
      get { return _serverName?? null; }
      set { _serverName = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool serverNameSpecified
    {
      get { return this._serverName != null; }
      set { if (value == (this._serverName== null)) this._serverName = value ? this.serverName : (byte[])null; }
    }
    private bool ShouldSerializeserverName() { return serverNameSpecified; }
    private void ResetserverName() { serverNameSpecified = false; }
    
    private ulong? _gameOrderId;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"gameOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong gameOrderId
    {
      get { return _gameOrderId?? default(ulong); }
      set { _gameOrderId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool gameOrderIdSpecified
    {
      get { return this._gameOrderId != null; }
      set { if (value == (this._gameOrderId== null)) this._gameOrderId = value ? this.gameOrderId : (ulong?)null; }
    }
    private bool ShouldSerializegameOrderId() { return gameOrderIdSpecified; }
    private void ResetgameOrderId() { gameOrderIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeVNTransIdReq")]
  public partial class CmdChargeVNTransIdReq : global::ProtoBuf.IExtensible
  {
    public CmdChargeVNTransIdReq() {}
    
    private byte[] _productId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"productId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] productId
    {
      get { return _productId?? null; }
      set { _productId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool productIdSpecified
    {
      get { return this._productId != null; }
      set { if (value == (this._productId== null)) this._productId = value ? this.productId : (byte[])null; }
    }
    private bool ShouldSerializeproductId() { return productIdSpecified; }
    private void ResetproductId() { productIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdChargeVNTransIdRes")]
  public partial class CmdChargeVNTransIdRes : global::ProtoBuf.IExtensible
  {
    public CmdChargeVNTransIdRes() {}
    
    private byte[] _transId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"transId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] transId
    {
      get { return _transId?? null; }
      set { _transId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool transIdSpecified
    {
      get { return this._transId != null; }
      set { if (value == (this._transId== null)) this._transId = value ? this.transId : (byte[])null; }
    }
    private bool ShouldSerializetransId() { return transIdSpecified; }
    private void ResettransId() { transIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdCharge")]
    public enum CmdCharge
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_DataNtf", Value=2100)]
      CmdCharge_DataNtf = 2100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_ChargeReq", Value=2101)]
      CmdCharge_ChargeReq = 2101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_ChargeNtf", Value=2102)]
      CmdCharge_ChargeNtf = 2102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdFCReward_GetReq", Value=2103)]
      CmdFCReward_GetReq = 2103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdFCReward_GetRes", Value=2104)]
      CmdFCReward_GetRes = 2104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_BuyCardReq", Value=2110)]
      CmdCharge_BuyCardReq = 2110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_TakeCardAwardReq", Value=2112)]
      CmdCharge_TakeCardAwardReq = 2112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_CardDataNtf", Value=2114)]
      CmdCharge_CardDataNtf = 2114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_GrowDataNtf", Value=2115)]
      CmdCharge_GrowDataNtf = 2115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_TakeGrowAwardReq", Value=2116)]
      CmdCharge_TakeGrowAwardReq = 2116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_TRChargeReq", Value=2117)]
      CmdCharge_TRChargeReq = 2117,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_TRChargeRes", Value=2118)]
      CmdCharge_TRChargeRes = 2118,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_VNTransIdReq", Value=2119)]
      CmdCharge_VNTransIdReq = 2119,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdCharge_VNTransIdRes", Value=2120)]
      CmdCharge_VNTransIdRes = 2120
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorCharge")]
    public enum ErrorCharge
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_SoldOut", Value=2100)]
      ErrorCharge_SoldOut = 2100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_InfoNotFound", Value=2101)]
      ErrorCharge_InfoNotFound = 2101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_FCReward_NotCharged", Value=2102)]
      Error_FCReward_NotCharged = 2102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_FCReward_HaveReceived", Value=2103)]
      Error_FCReward_HaveReceived = 2103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_FCReward_BagPosFull", Value=2104)]
      Error_FCReward_BagPosFull = 2104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_ToMuchBill", Value=2110)]
      ErrorCharge_ToMuchBill = 2110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_HttpReqFail", Value=2111)]
      ErrorCharge_HttpReqFail = 2111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_NotHaveRole", Value=2112)]
      ErrorCharge_NotHaveRole = 2112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_MoneyIsWrong", Value=2113)]
      ErrorCharge_MoneyIsWrong = 2113,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_HaveTaken", Value=2114)]
      ErrorCharge_HaveTaken = 2114,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_NotBuy", Value=2115)]
      ErrorCharge_NotBuy = 2115,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_HaveBuy", Value=2116)]
      ErrorCharge_HaveBuy = 2116,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorCharge_LevelLimit", Value=2117)]
      ErrorCharge_LevelLimit = 2117
    }
  
}