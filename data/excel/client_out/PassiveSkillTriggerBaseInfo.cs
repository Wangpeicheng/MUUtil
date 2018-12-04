

// 被动技能触发条件类型
public enum PassiveSkillTriggerType
{
    PassiveSkillTriggerType_None = 0, //
    PassiveSkillTriggerType_Team = 1, //队伍触发
    PassiveSkillTriggerType_Self = 2, //个人触发
    PassiveSkillTriggerType_BeginAttack = 3, //释放技能
    PassiveSkillTriggerType_AttackWithTarget = 4, //攻击到目标
    PassiveSkillTriggerType_BeAttackedWithTarget = 5, //受到单位攻击
    PassiveSkillTriggerType_ShieldResume = 6, //护盾回复
    PassiveSkillTriggerType_EnterMap = 7, //进入地图
    PassiveSkillTriggerType_Persist = 8, //持续生效
    PassiveSkillTriggerType_AttackBefore = 9, //技能作用到目标
    PassiveSkillTriggerType_SkillKill = 10, //技能击杀单位
    PassiveSkillTriggerType_SkillMiss = 11, //技能目标未命中
    PassiveSkillTriggerType_SkillBroken = 12, //技能被打断
    PassiveSkillTriggerType_Transform = 13, //变身
};

// 被动技能执行条件类型
public enum PassiveSkillExecCondType
{
    PassiveSkillExecCondType_None = 0, //
    PassiveSkillExecCondType_ShieldPerHigher = 1, //护盾值高于百分比
    PassiveSkillExecCondType_ShieldPerLower = 2, //护盾值低于百分比
    PassiveSkillExecCondType_HorseStar = 3, //坐骑星数大于等于
    PassiveSkillExecCondType_PetStar = 4, //宠物星数大于等于
    PassiveSkillExecCondType_GemStar = 5, //宝石等级大于等于
    PassiveSkillExecCondType_GodWing = 6, //神翼等级大于等于
    PassiveSkillExecCondType_EquipEnhance = 7, //全身强化等级大于等于
    PassiveSkillExecCondType_EquipPowerOn = 8, //全身追加等级大于等于
    PassiveSkillExecCondType_ShieldLevel = 9, //护盾等级大于等于
    PassiveSkillExecCondType_Pokedex = 10, //典藏卡评分大于等于
    PassiveSkillExecCondType_AchivePoint = 11, //总成就点大于等于
    PassiveSkillExecCondType_GodEquip = 12, //神装放入装备
    PassiveSkillExecCondType_HpPerHigher = 13, //血量高于百分比
    PassiveSkillExecCondType_HpPerLower = 14, //血量低于百分比
    PassiveSkillExecCondType_AtBuffGroup = 15, //处于状态组
    PassiveSkillExecCondType_IsHard = 16, //处于硬直状态
    PassiveSkillExecCondType_PetEquip = 17, //宠物出战
    PassiveSkillExecCondType_InTransform = 18, //自身处于变身状态
};

// 被动技能执行效果类型
public enum PassiveSkillExecEffectType
{
    PassiveSkillExecEffectType_None = 0, //
    PassiveSkillExecEffectType_AddBuff = 1, //挂载buff
    PassiveSkillExecEffectType_AddBaseAttr = 2, //增加基础属性
    PassiveSkillExecEffectType_AddPkAttr = 3, //增加pk属性
    PassiveSkillExecEffectType_ModifySkillDmg = 4, //修改技能伤害
    PassiveSkillExecEffectType_ModifyAllSkillCD = 5, //修改所有技能冷却
    PassiveSkillExecEffectType_ModifyTargetSkillCD = 6, //修改指定技能冷却
    PassiveSkillExecEffectType_AddRage = 7, //加怒气
    PassiveSkillExecEffectType_Max = 8, //最大值
};

// 被动技能触发目标类型
public enum PassiveSkillTriggerTargetType
{
    PassiveSkillTriggerTargetType_OtherRole = 1, //其他角色
    PassiveSkillTriggerTargetType_Monster = 2, //小怪
    PassiveSkillTriggerTargetType_Jingying = 4, //精英怪
    PassiveSkillTriggerTargetType_Boss = 8, //Boss
    PassiveSkillTriggerTargetType_Mercenary = 16, //雇佣兵
    PassiveSkillTriggerTargetType_FakeMonster = 32, //玩家镜像
    PassiveSkillTriggerTargetType_RoleSelf = 64, //自己
    PassiveSkillTriggerTargetType_TeamMember = 128, //队友
};

// 被动技能执行目标类型
public enum PassiveSkillExecTargetType
{
    PassiveSkillExecTargetType_Self = 1, //自己
    PassiveSkillExecTargetType_TeamMember = 2, //队友
    PassiveSkillExecTargetType_Mercenary = 4, //自己的雇佣兵
    PassiveSkillExecTargetType_Atker = 8, //攻击方
    PassiveSkillExecTargetType_Target = 16, //目标方
};

// 被动技能-基础属性类型
public enum PassiveSkillBaseAttrType
{
    PassiveSkillBaseAttrType_Stre = 1, //加力量
    PassiveSkillBaseAttrType_Inte = 2, //加智力
    PassiveSkillBaseAttrType_Dext = 3, //加敏捷
    PassiveSkillBaseAttrType_Cons = 4, //加体力
    PassiveSkillBaseAttrType_SIDC = 5, //加四维
};


