

// buff效果类型
public enum BuffEffectType
{
    BuffEffectType_None = 0, //
    BuffEffectType_ResumeHp = 1, //回血
    BuffEffectType_DecoreateMaxAndCurrHp = 2, //血量加成
    BuffEffectType_TriggerSkill = 3, //触发技能
    BuffEffectType_Gold = 4, //无敌
    BuffEffectType_Stoic = 5, //霸体
    BuffEffectType_ChgMoveSpeed = 6, //修饰移动速度
    BuffEffectType_ChgPhyDef = 7, //修饰物理防御
    BuffEffectType_ChgMagDef = 8, //修饰魔法防御
    BuffEffectType_ChgMinAtk = 9, //修饰最小攻击
    BuffEffectType_ChgMaxAtk = 10, //修饰最大攻击
    BuffEffectType_ChgStre = 11, //修饰力量
    BuffEffectType_ChgDext = 12, //修饰敏捷
    BuffEffectType_ChgCons = 13, //修饰体力
    BuffEffectType_ChgInte = 14, //修饰智力
    BuffEffectType_ChgMaxHp = 15, //修饰生命上限
    BuffEffectType_ChgMaxMp = 16, //修饰魔法上限
    BuffEffectType_ChgPhyAtkRate = 17, //修饰物理伤害率
    BuffEffectType_ChgMagAtkRate = 18, //修饰魔法伤害率
    BuffEffectType_ChgPhyDefRate = 19, //修饰物理减伤率
    BuffEffectType_ChgMagDefRate = 20, //修饰魔法减伤率
    BuffEffectType_ChgPhyAtkAdd = 21, //修饰附加物理伤害
    BuffEffectType_ChgMagAtkAdd = 22, //修饰附加魔法伤害
    BuffEffectType_ChgPhyAtkSub = 23, //修饰抵抗物理伤害
    BuffEffectType_ChgMagAtkSub = 24, //修饰抵抗魔法伤害
    BuffEffectType_ChgHitRate = 25, //修饰命中
    BuffEffectType_ChgDodgeRate = 26, //修饰闪避
    BuffEffectType_ChgExcellentRate = 27, //修饰卓越一击率
    BuffEffectType_ChgLuckyRate = 28, //修饰幸运一击率
    BuffEffectType_ChgIgnoreRate = 29, //修饰无视一击率
    BuffEffectType_ChgCriticalRate = 30, //修饰致命一击率
    BuffEffectType_ChgConsumeMpRate = 31, //修饰耗魔率
    BuffEffectType_ChgPhyReflectRate = 32, //修饰物理反弹几率
    BuffEffectType_ChgPhyReflectPer = 33, //修饰物理反弹伤害
    BuffEffectType_ChgMagReflectRate = 34, //修饰魔法反弹几率
    BuffEffectType_ChgMagReflectPer = 35, //修饰魔法反弹伤害
    BuffEffectType_ChgBloodRate = 36, //修饰吸血几率
    BuffEffectType_ChgBloodPer = 37, //修饰吸血比例
    BuffEffectType_ChgResumeHp = 38, //修饰生命恢复
    BuffEffectType_ChgResumeMp = 39, //修饰魔法恢复
    BuffEffectType_ChgPhyStrikeRate = 41, //修饰物理穿透率
    BuffEffectType_ChgPhyStrikeAdd = 42, //修饰物理穿透值
    BuffEffectType_ChgMagStrikeRate = 43, //修饰魔法穿透率
    BuffEffectType_ChgMagStrikeAdd = 44, //修饰魔法穿透值
    BuffEffectType_ChgKillMonsterExp = 45, //修饰打怪获取经验
    BuffEffectType_RedName = 46, //红名惩罚
    BuffEffectType_ChgAtkRate = 47, //修饰伤害率
    BuffEffectType_ChgDefRate = 48, //修饰减伤率
    BuffEffectType_Dizzy = 50, //眩晕
    BuffEffectType_Freeze = 51, //冰冻
    BuffEffectType_FixedBody = 52, //定身
    BuffEffectType_StatDamage = 53, //统计伤害
    BuffEffectType_ChangeToMonster = 54, //变身怪物
    BuffEffectType_DisableAttack = 55, //无法攻击
    BuffEffectType_Silent = 56, //沉默
    BuffEffectType_SubHpByParam = 57, //参数扣血
    BuffEffectType_SubHpDirectly = 58, //直接扣血
    BuffEffectType_ChgBothDef = 59, //修饰物理魔法防御
    BuffEffectType_HideWeapon = 60, //武器隐藏
    BuffEffectType_ChangeWeapon = 61, //武器替换
    BuffEffectType_ChgHitRateFixed = 62, //修饰命中修正
    BuffEffectType_ChgDodgeRateFixed = 63, //修饰闪避修正
    BuffEffectType_ChangeModel = 64, //替换模型
    BuffEffectType_ChangeWing = 65, //替换翅膀
    BuffEffectType_ResumeHpMp = 66, //回血回蓝
    BuffEffectType_ChgEncourgeAtkRate = 67, //修饰鼓舞伤害率
    BuffEffectType_ChgEncourgeDefRate = 68, //修饰鼓舞减伤率
    BuffEffectType_ChgKillMonsterExpTeam = 69, //修饰组队打怪经验加成
    BuffEffectType_ChgPkAttr = 70, //修饰战斗属性
    BuffEffectType_AddRage = 71, //增加怒气
    BuffEffectType_ChgFieldKillMonsterExpTeam = 72, //修饰组队野外打怪经验加成
};


