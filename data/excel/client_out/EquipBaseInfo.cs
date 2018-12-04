

// 武器模型真实位置
public enum WeaponPos
{
    pos_right = 0, //右手
    pos_left = 1, //左手
};

// 装备类型
public enum EquipType
{
    EquipType_BigSword = 1, //重剑
    EquipType_SmallSword = 2, //单手剑
    EquipType_Hotsue = 3, //法杖
    EquipType_Mace = 4, //权杖
    EquipType_Bow = 5, //弓箭
    EquipType_CrossBow = 6, //弩
    EquipType_Shield = 7, //盾牌
    EquipType_CrossBowTube = 8, //弩筒
    EquipType_Hat = 9, //帽子
    EquipType_Armor = 10, //衣服
    EquipType_Leg = 11, //护腿
    EquipType_Gauntlets = 12, //护腕
    EquipType_Boot = 13, //靴子
    EquipType_Neck = 14, //项链
    EquipType_Ring = 15, //戒指
};

// 装备部位
public enum EquipPos
{
    EquipPos_HandLeft = 1, //左手
    EquipPos_HandRight = 2, //右手
    EquipPos_HandDouble = 3, //双手(右手)
    EquipPos_Head = 4, //头
    EquipPos_Armor = 5, //衣服
    EquipPos_Leg = 6, //护腿
    EquipPos_Gauntlets = 7, //护腕
    EquipPos_Shoot = 8, //鞋子
    EquipPos_Neck = 9, //项链
    EquipPos_Ring = 10, //戒指
    EquipPos_HandAll = 11, //左右手
    EquipPos_HandLeftToRight = 12, //左手到右手（理论左手位置，表现放在右手位置）
    EquipPos_HandRightToLeft = 13, //右手到左手（理论右手位置，表现放在左手位置）
};

// 装备类型
public enum EquipDataValue
{
    EquipDataValue_LeftBaseModel = 1, //左武器模型(基础)
    EquipDataValue_LeftCreateModel = 2, //左武器模型(创角)
    EquipDataValue_LeftBonePos = 3, //左手武器骨骼节点(背部基础)
    EquipDataValue_RightBaseModel = 4, //右武器模型(基础)
    EquipDataValue_RightCreateModel = 5, //右武器模型(创角)
    EquipDataValue_RightBonePos = 6, //右手武器骨骼节点(背部基础)
    EquipDataValue_WingModel = 7, //翅膀模型(创角)
    EquipDataValue_WingBonePos = 8, //翅膀骨骼节点
    EquipDataValue_LeftWeaponBonePos = 9, //攻击左手武器骨骼节点(左手基础)
    EquipDataValue_RightWeaponBonePos = 10, //攻击右手武器骨骼节点(左手基础)
};


