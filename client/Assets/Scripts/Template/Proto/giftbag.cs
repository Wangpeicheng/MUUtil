//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: giftbag.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGiftBagExchangeReq")]
  public partial class CmdGiftBagExchangeReq : global::ProtoBuf.IExtensible
  {
    public CmdGiftBagExchangeReq() {}
    
    private byte[] _code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] code
    {
      get { return _code?? null; }
      set { _code = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool codeSpecified
    {
      get { return this._code != null; }
      set { if (value == (this._code== null)) this._code = value ? this.code : (byte[])null; }
    }
    private bool ShouldSerializecode() { return codeSpecified; }
    private void Resetcode() { codeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GiftBagItem")]
  public partial class GiftBagItem : global::ProtoBuf.IExtensible
  {
    public GiftBagItem() {}
    
    private int? _itemInfoId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"itemInfoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemInfoId
    {
      get { return _itemInfoId?? default(int); }
      set { _itemInfoId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool itemInfoIdSpecified
    {
      get { return this._itemInfoId != null; }
      set { if (value == (this._itemInfoId== null)) this._itemInfoId = value ? this.itemInfoId : (int?)null; }
    }
    private bool ShouldSerializeitemInfoId() { return itemInfoIdSpecified; }
    private void ResetitemInfoId() { itemInfoIdSpecified = false; }
    
    private int? _itemNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemNum
    {
      get { return _itemNum?? default(int); }
      set { _itemNum = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool itemNumSpecified
    {
      get { return this._itemNum != null; }
      set { if (value == (this._itemNum== null)) this._itemNum = value ? this.itemNum : (int?)null; }
    }
    private bool ShouldSerializeitemNum() { return itemNumSpecified; }
    private void ResetitemNum() { itemNumSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGiftBagExchangeRes")]
  public partial class CmdGiftBagExchangeRes : global::ProtoBuf.IExtensible
  {
    public CmdGiftBagExchangeRes() {}
    
    private readonly global::System.Collections.Generic.List<Proto.GiftBagItem> _item = new global::System.Collections.Generic.List<Proto.GiftBagItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.GiftBagItem> item
    {
      get { return _item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdGiftBag")]
    public enum CmdGiftBag
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGiftBag_ExchangeReq", Value=4001)]
      CmdGiftBag_ExchangeReq = 4001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGiftBag_ExchangeRes", Value=4002)]
      CmdGiftBag_ExchangeRes = 4002
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorGiftBag")]
    public enum ErrorGiftBag
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_NotSupported", Value=4001)]
      ErrorGiftBag_NotSupported = 4001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_JsonParseFail", Value=4002)]
      ErrorGiftBag_JsonParseFail = 4002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_BagNotEnough", Value=4003)]
      ErrorGiftBag_BagNotEnough = 4003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_JsonFormatFail", Value=4004)]
      ErrorGiftBag_JsonFormatFail = 4004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_PlatformFail", Value=4005)]
      ErrorGiftBag_PlatformFail = 4005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeNotExist", Value=4006)]
      ErrorGiftBag_CodeNotExist = 4006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeHasUsed", Value=4007)]
      ErrorGiftBag_CodeHasUsed = 4007,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeNotEffect", Value=4008)]
      ErrorGiftBag_CodeNotEffect = 4008,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeHasExpired", Value=4009)]
      ErrorGiftBag_CodeHasExpired = 4009,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeClassFail", Value=4010)]
      ErrorGiftBag_CodeClassFail = 4010,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeChannelFail", Value=4011)]
      ErrorGiftBag_CodeChannelFail = 4011,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeLevelFail", Value=4012)]
      ErrorGiftBag_CodeLevelFail = 4012,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeVipFail", Value=4013)]
      ErrorGiftBag_CodeVipFail = 4013,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGiftBag_CodeZoneFail", Value=4014)]
      ErrorGiftBag_CodeZoneFail = 4014
    }
  
}