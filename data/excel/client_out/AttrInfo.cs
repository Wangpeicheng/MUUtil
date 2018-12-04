

// 属性类型
public enum AttrType
{
    AttrType_maxHpBase = 1, //基础生命
    AttrType_maxHpAdd = 2, //生命数值修正
    AttrType_maxHpPer = 3, //生命百分比修正
    AttrType_maxMpBase = 4, //基础魔法
    AttrType_maxMpAdd = 5, //魔法数值修正
    AttrType_maxMpPer = 6, //魔法百分比修正
    AttrType_maxHp = 9, //生命上限(计算战斗力使用)
    AttrType_maxMp = 10, //魔法上限(计算战斗力使用)
    AttrType_phyDef = 11, //物理防御(计算战斗力使用)
    AttrType_magDef = 12, //魔法上限(计算战斗力使用)
    AttrType_minAtk = 13, //最小攻击(计算战斗力使用)
    AttrType_maxAtk = 14, //最大攻击(计算战斗力使用)
    AttrType_holyAtk = 15, //神圣攻击(计算战斗力使用)
    AttrType_holyDef = 16, //神圣防御(计算战斗力使用)
    AttrType_minAtkBase = 19, //基础最小攻
    AttrType_minAtkAdd = 20, //最小攻数值修正
    AttrType_minAtkPer = 21, //最小攻百分比修正
    AttrType_maxAtkBase = 22, //基础最大攻
    AttrType_maxAtkAdd = 23, //最大攻数值修正
    AttrType_maxAtkPer = 24, //最大攻百分比修正
    AttrType_phyDefBase = 25, //基础物防
    AttrType_phyDefAdd = 26, //物防数值修正
    AttrType_phyDefPer = 27, //物防百分比修正
    AttrType_magDefBase = 28, //基础魔防
    AttrType_magDefAdd = 29, //魔防数值修正
    AttrType_magDefPer = 30, //魔防百分比修正
    AttrType_phyAtkRate = 40, //物理伤害率
    AttrType_magAtkRate = 41, //魔法伤害率
    AttrType_phyDefRate = 42, //物理减伤率
    AttrType_magDefRate = 43, //魔法减伤率
    AttrType_phyAtkAdd = 44, //附加物理伤害
    AttrType_phyAtkSub = 45, //抵抗物理伤害
    AttrType_magAtkAdd = 46, //附加魔法伤害
    AttrType_magAtkSub = 47, //抵抗魔法伤害
    AttrType_hitRate = 48, //命中
    AttrType_dodgeRate = 49, //闪避
    AttrType_excellentRate = 50, //卓越一击率
    AttrType_luckyRate = 51, //幸运一击率
    AttrType_ignoreRate = 52, //无视一击率
    AttrType_criticalRate = 53, //致命一击率
    AttrType_consumeMpRate = 54, //耗魔率
    AttrType_phyReflectRate = 55, //物理反弹几率
    AttrType_phyReflectPer = 56, //物理反弹伤害
    AttrType_magReflectRate = 57, //魔法反弹几率
    AttrType_magReflectPer = 58, //魔法反弹伤害
    AttrType_bloodRate = 59, //吸血几率
    AttrType_bloodPer = 60, //吸血比例
    AttrType_resumeHp = 61, //生命恢复
    AttrType_resumeMp = 62, //魔法恢复
    AttrType_phyStrikeRate = 63, //物理穿透率
    AttrType_phyStrikeAdd = 64, //物理穿透值
    AttrType_magStrikeRate = 65, //魔法穿透率
    AttrType_magStrikeAdd = 66, //魔法穿透值
    AttrType_moveSpeedPer = 67, //移动速度修正
    AttrType_hitRateFixed = 68, //命中修正
    AttrType_dodgeRateFixed = 69, //闪避修正
    AttrType_atkBase = 101, //基础攻击
    AttrType_atkAdd = 102, //攻击数值修正
    AttrType_atkPer = 103, //攻击百分比修正
    AttrType_defBase = 104, //基础防御
    AttrType_defAdd = 105, //防御数值修正
    AttrType_defPer = 106, //防御百分比修正
    AttrType_atkRate = 107, //伤害率
    AttrType_atkDamage = 108, //附加伤害
    AttrType_defRate = 109, //减伤率
    AttrType_atkSub = 110, //抵抗伤害
    AttrType_strikeRate = 111, //防御穿透率
    AttrType_strikeAdd = 112, //防御穿透
    AttrType_encourgeAtkRate = 113, //鼓舞伤害率
    AttrType_encourgeDefRate = 114, //鼓舞减伤率
    AttrType_strePer = 120, //力量加成
    AttrType_streAdd = 121, //力量附加
    AttrType_dextPer = 122, //敏捷加成
    AttrType_dextAdd = 123, //敏捷附加
    AttrType_consPer = 124, //体力加成
    AttrType_consAdd = 125, //体力附加
    AttrType_intePer = 126, //智力加成
    AttrType_inteAdd = 127, //智力附加
    AttrType_moveSpeedAdd = 128, //移动速度附加
    AttrType_killMonsterExpPer = 150, //杀怪经验加成
    AttrType_killMonsterCoinPer = 151, //杀怪金币加成
    AttrType_roleAtkDamagePer = 160, //对角色伤害百分比加成
    AttrType_monsterAtkDamagePer = 161, //对怪物伤害百分比加成
    AttrType_roleDefDamagePer = 162, //伤害百分比减少
    AttrType_monsterDefDamagePer = 163, //
    AttrType_luckyDefRate = 164, //幸运一击抗性
    AttrType_luckyAtkDamagePer = 165, //幸运一击伤害加成
    AttrType_luckyDefDamagePer = 166, //幸运一击伤害减少
    AttrType_excellentDefRate = 167, //卓越一击抗性
    AttrType_excellentAtkDamagePer = 168, //卓越一击伤害加成
    AttrType_excellentDefDamagePer = 169, //卓越一击伤害减少
    AttrType_ignoreDefRate = 170, //无视一击抗性
    AttrType_ignoreAtkDamagePer = 171, //无视一击伤害加成
    AttrType_ignoreDefDamagePer = 172, //无视一击伤害减少
    AttrType_criticalDefRate = 173, //致命一击抗性
    AttrType_criticalAtkDamagePer = 174, //致命一击伤害加成
    AttrType_criticalDefDamagePer = 175, //致命一击伤害减少
    AttrType_controlDefRate = 176, //控制抵抗概率
    AttrType_controlIgnoreDefRate = 177, //忽视控制抵抗概率
    AttrType_waterAttrAtkPer = 178, //水属性伤害加成
    AttrType_waterAttrDefPer = 179, //水属性伤害减少
    AttrType_fireAttrAtkPer = 180, //火属性
    AttrType_fireAttrDefPer = 181, //
    AttrType_wingAttrAtkPer = 182, //风属性
    AttrType_wingAttrDefPer = 183, //
    AttrType_thunderAttrAtkPer = 184, //雷属性
    AttrType_thunderAttrDefPer = 185, //
    AttrType_landAttrAtkPer = 186, //地属性
    AttrType_landAttrDefPer = 187, //
    AttrType_darkAttrAtkPer = 188, //暗属性
    AttrType_darkAttrDefPer = 189, //
    AttrType_ignoreAttrDefPer = 190, //忽视抗性
    AttrType_doubleCoinLootPer = 191, //双倍金币掉落概率
    AttrType_doubleItemLootPer = 192, //双倍道具掉落概率
    AttrType_AtkLevel = 193, //增加(等级/5)攻击力
    AttrType_defLevel = 194, //增加(等级/5)防御力
    AttrType_GemAdd = 195, //增加一个宝石孔
    AttrType_AllEmementDefPer = 196, //全体属性抗性
    AttrType_AllEmementAtkPer = 197, //全体属性伤害
    AttrType_MaxHpLevel = 198, //增加(等级/x)生命上限
    AttrType_CollectHorseSpeedUpPer = 199, //坐骑抓捕加速百分比
    AttrType_GemHpPer = 301, //宝石百分比加基础属性强化追加
    AttrType_GemAtkPer = 302, //宝石百分比加基础属性强化追加
    AttrType_GemPhyDefPer = 303, //宝石百分比加基础属性强化追加
    AttrType_GemMagDefPer = 304, //宝石百分比加基础属性强化追加
    AttrType_GemHitPer = 305, //宝石百分比加基础属性强化追加
    AttrType_GemDodgePer = 306, //宝石百分比加基础属性强化追加
    AttrType_EquipBaseAttrPer = 310, //装备基础属性提升
    AttrType_EquipEnhanceAttrPer = 311, //装备强化和追加属性提升
    AttrType_EquipGemAttrPer = 312, //装备位已镶嵌的宝石属性提升
    AttrType_HpPoolPer = 313, //生命值补给效果提升
    AttrType_AidEffectPer = 314, //急救药恢复效果提升
    AttrType_maxShieldBase = 315, //护盾基础值
    AttrType_maxShieldAdd = 316, //护盾值修正
    AttrType_maxShieldPer = 317, //护盾百分比修正
    AttrType_shieldAbsorbRate = 318, //护盾吸收率
    AttrType_resumeShield = 319, //护盾回复
    AttrType_ignoreShieldRate = 320, //无视护盾一击率
    AttrType_ignoreShieldDefRate = 321, //抵抗无视护盾一击率
    AttrType_maxShield = 322, //护盾基上限(计算战斗力使用)
    AttrType_resumeShieldPer = 323, //护盾回复百分比
    AttrType_EquipPowerOnAttrPer = 330, //装备追加属性提升
    AttrType_horseExpPromotePer = 331, //坐骑经验药水效果提升
    AttrType_petExpPromotePer = 332, //宠物经验药水效果提升
    AttrType_bossAtkDmgPer = 333, //boss伤害百分比加成
    AttrType_normalEliteAtkDmgPer = 334, //小怪精英伤害百分比加成
    AttrType_phyReflectDefRate = 335, //抵抗物理反弹几率
    AttrType_phyReflectDefPer = 336, //抵抗物理反弹伤害
    AttrType_magReflectDefRate = 337, //抵抗魔法反弹几率
    AttrType_magReflectDefPer = 338, //抵抗魔法反弹伤害
    AttrType_holyAtkBase = 339, //神圣攻击基础值
    AttrType_holyAtkAdd = 340, //神圣攻击附加修正
    AttrType_holyAtkPer = 341, //神圣攻击百分比修正
    AttrType_holyDefBase = 342, //神圣防御基础值
    AttrType_holyDefAdd = 343, //神圣防御附加修正
    AttrType_holyDefPer = 344, //神圣防御百分比修正
    AttrType_holyAtkDmgPer = 345, //神圣伤害加成
    AttrType_holyDefDmgPer = 346, //神圣伤害减免
    AttrType_maxRage = 347, //怒气值上限
    AttrType_transformTimePer = 348, //变身时间百分比加成
    AttrType_transformRagePer = 349, //变身能量获取加成
    AttrType_killMonsterResumeHp = 351, //击杀怪物回复生命
    AttrType_killMonsterResumeHpPer = 352, //击杀怪物回复生命百分比
    AttrType_killRoleResumeHp = 353, //击杀玩家回复生命
    AttrType_killRoleResumeHpPer = 354, //击杀玩家回复生命百分比
    AttrType_killMonsterResumeShield = 355, //击杀怪物回复护盾
    AttrType_killMonsterResumeShieldPer = 356, //击杀怪物回复护盾百分比
    AttrType_killRoleResumeShield = 357, //击杀玩家回复护盾
    AttrType_killRoleResumeShieldPer = 358, //击杀玩家回复护盾百分比
    AttrType_ignoreResistRate = 361, //忽抗一击率
    AttrType_ignoreResistDefRate = 362, //忽抗一击抗性
    AttrType_ignoreResistAtkDamagePer = 363, //忽抗一击伤害加成
    AttrType_ignoreResistDefDamagePer = 364, //忽抗一击减免
    AttrType_petSecDmgAdd = 365, //宠物秒伤增加
    AttrType_petDmgPer = 366, //宠物伤害增加百分比
    AttrType_petFightExpPer = 367, //出战宠物经验加成
    AttrType_petXieExpPer = 368, //协战宠物经验加成
    AttrType_petZhuExpPer = 369, //助战宠物经验加成
    AttrType_expPerBuff = 370, //人物经验加成
};

// 兑换原类型
public enum ExchangeSrcType
{
    ExchangeSrcType_Normal = 0, //普通来源
    ExchangeSrcType_RolePanel = 1, //角色面板
    ExchangeSrcType_Market = 2, //市场
    ExchangeSrcType_AutoBuy = 3, //自动购买
    ExchangeSrcType_ItemMake = 4, //锻造
};

// 属性ID类型
public enum AttrIDType
{
    AttrIDType_Normal = 0, //普通属性
    AttrIDType_AddSkillLevel = 1, //特殊属性增加技能等级
    AttrIDType_AddSkillDmgPer = 2, //特殊属性增加技能伤害率
    AttrIDType_AddSkillDmgAdd = 3, //特殊属性增加技能伤害值
    AttrIDType_Max = 3, //属性ID类型最大值
};

// 元素属性
public enum ElementAttrType
{
    ElementAttrType_None = 0, //无
    ElementAttrType_Water = 1, //水
    ElementAttrType_Fire = 2, //火
    ElementAttrType_Wind = 3, //风
    ElementAttrType_Thunder = 4, //雷
    ElementAttrType_Land = 5, //地
    ElementAttrType_Dark = 6, //暗
    ElementAttrType_Adaptive = 11, //自适应属性
};


