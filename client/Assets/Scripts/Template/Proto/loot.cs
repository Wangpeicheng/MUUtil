//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: loot.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdLootPickItemReq")]
  public partial class CmdLootPickItemReq : global::ProtoBuf.IExtensible
  {
    public CmdLootPickItemReq() {}
    
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdLootPickItemRes")]
  public partial class CmdLootPickItemRes : global::ProtoBuf.IExtensible
  {
    public CmdLootPickItemRes() {}
    
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _nullIDs = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"nullIDs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> nullIDs
    {
      get { return _nullIDs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdLootUpdateItemNtf")]
  public partial class CmdLootUpdateItemNtf : global::ProtoBuf.IExtensible
  {
    public CmdLootUpdateItemNtf() {}
    
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private readonly global::System.Collections.Generic.List<ulong> _ownerId = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(2, Name=@"ownerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> ownerId
    {
      get { return _ownerId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdLoot")]
    public enum CmdLoot
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdLoot_PickItemReq", Value=1101)]
      CmdLoot_PickItemReq = 1101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdLoot_PickItemRes", Value=1102)]
      CmdLoot_PickItemRes = 1102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdLoot_UpdateItemOwnerNtf", Value=1103)]
      CmdLoot_UpdateItemOwnerNtf = 1103
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorLoot")]
    public enum ErrorLoot
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_LootInfoNull", Value=1101)]
      Error_Loot_LootInfoNull = 1101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_LootPackageInfoNull", Value=1102)]
      Error_Loot_LootPackageInfoNull = 1102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_LootPackageNoItem", Value=1103)]
      Error_Loot_LootPackageNoItem = 1103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_ItemNotOwner", Value=1104)]
      Error_Loot_ItemNotOwner = 1104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_ItemNotFound", Value=1105)]
      Error_Loot_ItemNotFound = 1105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error_Loot_AllocItemError", Value=1106)]
      Error_Loot_AllocItemError = 1106
    }
  
}