

// 界面弹出类型类型
public enum ClickEvtType
{
    EvtType_None = 0, //
    EvtType_Buy = 1, //购买
    EvtType_Use = 2, //使用
    EvtType_Sell = 3, //出售
};

// 类型
public enum ItemType
{
    ItemType_None = 0, //默认值
    ItemType_Equip = 1, //装备
    ItemType_Material = 2, //材料
    ItemType_Consume = 3, //消耗品
    ItemType_Currency = 4, //货币
    ItemType_PetSkillBook = 5, //宠物技能书
    ItemType_Pandora = 6, //藏宝图
    ItemType_Gem = 8, //宝石
    ItemType_MagicBookChapter = 10, //魔法书章节
    ItemType_Rune = 11, //符文
    ItemType_SoulBall = 12, //魂珠
};

// 可否出售
public enum ItemSellType
{
    ItemSellType_None = 0, //不可出售
    ItemSellType_Cofc = 1, //商会或者系统
    ItemSellType_Market = 2, //市场
};

// 可否出售
public enum ItemCanUseType
{
    ItemCanUseType_None = 0, //不可使用
    ItemCanUseType_Use = 1, //使用
    ItemCanUseType_JumpToOtherUI = 2, //跳转界面
};

// 绑定类型
public enum BindType
{
    BindType_EquipBind = 0, //装备绑定
    BindType_GetBind = 1, //拾取绑定
    BindType_NeverBind = 2, //永不绑定
};

// 装备品质
public enum ItemColor
{
    ItemColor_None = 0, //默认值
    ItemColor_White = 1, //白色
    ItemColor_Green = 2, //绿色
    ItemColor_Blue = 3, //蓝色
    ItemColor_Purple = 4, //紫色
    ItemColor_Gold = 5, //金色
    ItemColor_Star_1 = 6, //一星
    ItemColor_Star_2 = 7, //二星
    ItemColor_Star_3 = 8, //三星
    ItemColor_Orange = 9, //橙色
    ItemColor_Red = 10, //红色
    ItemColor_Suit_1 = 11, //套装一
    ItemColor_Angel = 12, //大天使
    ItemColor_Max = 13, //最大值
};

// 使用效果
public enum ItemEffectType
{
    ItemEffectType_None = 0, //
    ItemEffectType_AddCoin = 1, //加金币
    ItemEffectType_AddExp = 2, //加经验
    ItemEffectType_AddBuff = 3, //加BUFF
    ItemEffectType_FillFirstAid = 4, //增加急救池
    ItemEffectType_AddCrystal = 5, //增加水晶
    ItemEffectType_AddHpPool = 6, //增加血池
    ItemEffectType_AddMpPool = 7, //增加蓝池
    ItemEffectType_OpenWing = 8, //开启翅膀
    ItemEffectType_AddStre = 9, //永久增加力量
    ItemEffectType_AddDext = 10, //永久增加敏捷
    ItemEffectType_AddCons = 11, //永久增加体力
    ItemEffectType_AddInte = 12, //永久增加智力
    ItemEffectType_AddItemByLoot = 13, //使用礼包
    ItemEffectType_AddPet = 14, //使用宠物蛋
    ItemEffectType_AddItem = 15, //使用礼包
    ItemEffectType_AddPetExp = 16, //增加宠物经验
    ItemEffectType_AddSpirit = 17, //增加小精灵时间
    ItemEffectType_PandoraHoe = 18, //潘多拉锄头
    ItemEffectType_PandoraBox = 19, //潘多拉魔盒
    ItemEffectType_HorseIdentify = 20, //坐骑鉴定
    ItemEffectType_HorseAddExp = 21, //坐骑加经验
    ItemEffectType_TreasureBox = 22, //奇迹宝箱
    ItemEffectType_AddHorse = 23, //使用获得坐骑
    ItemEffectType_SubPkValue = 24, //使用减少pk值
    ItemEffectType_AddSpecialHorse = 25, //获取特殊坐骑
    ItemEffectType_AddSpecialPet = 26, //获得特殊宠物
    ItemEffectType_ActivateTitle = 27, //激活称号
    ItemEffectType_AddHonorExp = 28, //增加头衔经验
    ItemEffectType_PVPInsAddJoinTimes = 29, //PVP副本增加参与次数
    ItemEffectType_AddOfflineTime = 30, //离线托管时间增加
    ItemEffectType_ArenaAddTimes = 31, //竞技场增加参与挑战次数
    ItemEffectType_AddBaseAttr = 33, //使用潘多拉果实
    ItemEffectType_ExchangeSoul = 34, //兑换灵魂
    ItemEffectType_PrivilegeCard = 35, //特权卡
    ItemEffectType_MonCard = 36, //月卡
    ItemEffectType_AddVipExp = 37, //增加角色vip经验
    ItemEffectType_AddJobItem = 38, //根据职业开东西
    ItemEffectType_AddJobLootItem = 39, //根据职业开东西loot
    ItemEffectType_ActivityInsAddJoinTimes = 40, //活动副本增加参与次数
    ItemEffectType_LevelBreakThough = 41, //等级突破
    ItemEffectType_AddHorseSkin = 42, //获得坐骑皮肤
    ItemEffectType_MagicBookChapter = 43, //获得章节
    ItemEffectType_MagicBookElement = 44, //获得元素魔尘
    ItemEffectType_UseVipGift = 45, //使用VIP礼包
    ItemEffectType_MergeNone = 50, //碎片合成
    ItemEffectType_MergeAddItem = 51, //多个物品一起使用
    ItemEffectType_MergeAddPet = 52, //使用宠物蛋
    ItemEffectType_MergeAddHorse = 53, //坐骑合成
    ItemEffectType_AddCharmDressTime = 55, //时装增加时效
    ItemEffectType_Max = 60, //最大值
};

// 道具跳转界面
public enum ItemLinKType
{
    Link_Enhance = 1, //跳转装备强化
    Link_Append = 2, //跳转装备追加
    Link_Refine = 3, //跳转装备精炼
    Link_WingType = 4, //跳转翅膀界面
    Link_PetSkill = 5, //跳转宠物技能
    Link_PetPower = 6, //跳转宠物资质
    Link_Combine = 7, //跳转合成
    Link_EmoSquare = 8, //跳转恶魔广场
    Link_BloodSquare = 9, //跳转血色城堡
    Link_PlayerSkill = 10, //跳转角色技能
    Link_PetAttr = 11, //跳转宠物属性
    Link_ExrRefine = 12, //跳转卓越属性洗炼
    Link_SpecialRefine = 13, //跳转史诗属性洗炼
    Link_OnlinePractice = 14, //跳转在线修炼
    Link_HorseAttrUI = 15, //跳转坐骑界面
    Link_HorseAdvance = 16, //跳转坐骑进阶
    Link_HorseWash = 17, //跳转坐骑洗练
    Link_GuildContri = 18, //跳转战盟旗帜捐献
    Link_ReName = 19, //人物-改名界面
    Link_Identify = 20, //跳转道具鉴定
    Link_Honor = 21, //跳转头衔晋升
    Link_ResetPoint = 22, //跳转人物洗点界面
    Link_Setting = 23, //设置界面
    Link_ReAttr = 24, //再生界面
    Link_Lotto = 25, //宝藏界面
    Link_DailyActive = 26, //日常界面
    Link_Compose = 53, //跳转道具合成
    Link_CrossRealm = 28, //跨服聊天界面
    Link_GodOfWing = 29, //神翼界面
    Link_CollectionCard = 30, //典藏卡界面
    Link_AllenceChangName = 31, //战盟改名界面
    Link_Hallow = 32, //圣器升级界面
    Link_HeadPortiait = 33, //头像界面
    Link_MeiLanBook = 34, //魔法书界面
    Link_GodEquip = 35, //神装界面
    Link_Sheild = 36, //护盾界面
    Link_Rune = 37, //符文界面
    Link_Talent = 38, //大师天赋
    Link_Suit = 39, //套装
    Link_Transformer = 40, //变身界面
    Link_TransformerUpStar = 41, //变身升星界面
    Link_TransformerSkin = 42, //变身附灵界面
    Link_ChangeOcc = 43, //更转职业
    Link_Enchant = 44, //附魔界面
    Link_Melting = 45, //熔炼界面
};


