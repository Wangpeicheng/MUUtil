

// 宠物被动技能效果
public enum PetSkillPassiveEffectType
{
    PSPEffectType_None = 0, //
    PSPEffectType_SubCD = 1, //降低技能CD
    PSPEffectType_PetDamageHeal = 2, //宠物造成的伤害恢复主人HP
    PSPEffectType_IgnoreDef = 3, //完全忽视目标防御
    PSPEffectType_DamageAddPer = 4, //提升伤害百分比
    PSPEffectType_AddBuff = 5, //为被击单位施加buff
    PSPEffectType_Splash = 6, //溅射
    PSPEffectType_PoisonBuff = 7, //毒buff
    PSPEffectType_AddCoin = 8, //获得金币
    PSPEffectType_AddBaseAttr = 9, //加基础属性
    PSPEffectType_AddAttr = 10, //加属性
    PSPEffectType_AddStre = 11, //加力量
    PSPEffectType_AddInte = 12, //加智力
    PSPEffectType_AddDext = 13, //加敏捷
    PSPEffectType_AddCons = 14, //加体力
    PSPEffectType_AddAssistAttr = 15, //加宠物协/助战百分比
    PSPEffectType_AddHpDefAtk = 16, //攻防血
    PSPEffectType_AddAttrByStep = 17, //加属性通过阶级
    PSPEffectType_Max = 18, //最大值
};

// 宠物被动技能触发类型
public enum PetPassiveSkillTriggerType
{
    PetPassiveSkillTriggerType_None = 0, //
    PetPassiveSkillTriggerType_Rand = 1, //战斗概率触发
    PetPassiveSkillTriggerType_Time = 2, //周期触发
    PetPassiveSkillTriggerType_Cond = 3, //战斗条件触发
    PetPassiveSkillTriggerType_SteCurr = 4, //出战触发
};

// 宠物被动技能触发条件
public enum PetPassiveSkillTriggerCond
{
    PetPassiveSkillTriggerCond_OwenHpPer = 1, //主人血量低于百分比
    PetPassiveSkillTriggerCond_TargetHpPer = 2, //目标血量低于百分比
    PetPassiveSkillTriggerCond_CD = 3, //技能cd好了
    PetPassiveSkillTriggerCond_OwenHpPerHigh = 4, //主人血量高于百分比
    PetPassiveSkillTriggerCond_TargetHpPerHigh = 5, //目标血量高于百分比
};


