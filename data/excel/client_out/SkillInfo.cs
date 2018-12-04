

// 技能效果
public enum SkillEffect
{
    SkillEffect_Size = 8, //效果最大值
};

// 技能攻击目标类型
public enum SkillTargetType
{
    SkillTargetType_None = 0, //
    SkillTargetType_Self = 1, //角色目标自己
    SkillTargetType_Team = 2, //角色目标队友
    SkillTargetType_OtherRole = 4, //角色目标其他角色
    SkillTargetType_Monster = 8, //角色目标怪物
    SkillTargetType_MonsterSelf = 16, //怪物目标自己
    SkillTargetType_MonsterCamp = 32, //怪物目标自己阵营
    SkillTargetType_MonsterAtkCamp = 64, //怪物目标可攻击阵营
    SkillTargetType_RoleMercenary = 128, //角色雇佣兵
    SkillTargetType_MonsterMercenary = 256, //怪物雇佣兵
};

// 技能效果类型
public enum SkillEffectType
{
    SkillEffectType_None = 0, //
    SkillEffectType_PhyDmg = 1, //物理伤害
    SkillEffectType_MagDmg = 2, //魔法伤害
    SkillEffectType_AddBuff = 3, //增加BUFF
    SkillEffectType_DelBuff = 4, //删除BUFF
    SkillEffectType_DelBuffGroup = 5, //删除类型BUFF
    SkillEffectType_Summon = 6, //召唤怪物
    SkillEffectType_Back = 7, //击退
    SkillEffectType_Down = 8, //击倒
    SkillEffectType_Charge = 9, //冲锋
    SkillEffectType_Indraft = 10, //吸入
    SkillEffectType_DownIndraft = 11, //击倒吸入
    SkillEffectType_MonsterSummon = 12, //怪物召唤
    SkillEffectType_Fly = 13, //击飞
    SkillEffectType_ForwardFly = 14, //向前击飞
    SkillEffectType_ReflectStatDamage = 15, //反弹统计伤害
    SkillEffectType_HitBackOutMapEffect = 16, //怪物特殊击退
    SkillEffectType_PerDmg = 17, //比例伤害
    SkillEffectType_MonsterTeleport = 18, //怪物瞬移
    SkillEffectType_MonsterPosSummon = 19, //怪物点召唤
    SkillEffectType_AddDotBuff = 20, //增加DotBUFF
    SkillEffectType_ForwardTeleport = 21, //前方瞬移
    SkillEffectType_TargetBlockTeleport = 22, //目标阻挡瞬移
    SkillEffectType_TargetNoBlockTeleport = 23, //目标非阻挡瞬移
    SkillEffectType_SummonMercenary = 24, //召唤雇佣兵
    SkillEffectType_NoBreakBack = 25, //不打断击退
    SkillEffectType_ModifyTargetSkillCD = 26, //修改指定技能冷却
    SkillEffectType_ModifyAllSkillCD = 27, //修改所有技能冷却
    SkillEffectType_SummonNormalMonster = 28, //召唤普通怪物
    SkillEffectType_DirHpDmg = 29, //直接血量伤害
    SkillEffectType_LenPhyDmg = 30, //距离物理伤害
    SkillEffectType_LenMagDmg = 31, //距离魔法伤害
    SkillEffectType_ShieldDmg = 32, //直接护盾伤害
    SkillEffectType_BoomShieldDmg = 33, //自爆护盾伤害
    SkillEffectType_AdaptiveDmg = 34, //自适应伤害
};

// 技能效果受击动作
public enum SkillEffectAction
{
    SkillEffectAction_None = 0, //
    SkillEffectAction_Back = 1, //后仰
};

// 伤害范围类型
public enum SkillAttackRangeType
{
    SkillAttackRangeType_None = 0, //
    SkillAttackRangeType_Circle = 1, //圆形
    SkillAttackRangeType_Sector = 2, //锥形
    SkillAttackRangeType_Rectangle = 3, //矩形
    SkillAttackRangeType_Lock = 4, //锁定
};

// 怪物攻击类型
public enum SkillMonsterAtkType
{
    SkillMonsterAtkType_None = 0, //
    SkillMonsterAtkType_Lock = 1, //锁定
    SkillMonsterAtkType_Self = 2, //自己
    SkillMonsterAtkType_SelfCircle = 3, //自身圆
    SkillMonsterAtkType_SelfRect = 4, //自身矩形
    SkillMonsterAtkType_TargetCircle = 5, //目标圆
};

// 冲锋位移方向
public enum SkillMoveDirectionType
{
    SkillMoveDirectionType_None = 0, //
    SkillMoveDirectionType_Forward = 1, //前
    SkillMoveDirectionType_Back = 2, //后
    SkillMoveDirectionType_Left = 3, //左
    SkillMoveDirectionType_Right = 4, //右
};

// 技能常量定义
public enum SkillConstValue
{
    SkillConst_PrepareLimit = 300, //起手动作超过该值才会启动准备步骤
    SkillConst_CDLimit = 250, //技能cd最小值，服务器用
};

// 技能触发类型
public enum SkillTriggerType
{
    SkillTriggerType_None = 0, //
    SkillTriggerType_Role = 1, //主动触发
    SkillTriggerType_Skill = 2, //连招触发
    SkillTriggerType_Buff = 3, //BUFF触发
};

// 技能延迟类型
public enum SkillDelayType
{
    SkillDelayType_None = 0, //
    SkillDelayType_Circle = 1, //旋转型
    SkillDelayType_Spread = 2, //扩散型
};

// 自动Or手动连招
public enum SkillComboType
{
    SkillComboType_None = 0, //
    SkillComboType_Manual = 1, //手动
    SkillComboType_Auto = 2, //自动
};

// 属性类型
public enum HangArea
{
    HangArea_SameMap = 0, //全地图挂机
    HangArea_SameScreen = 1, //全屏挂机
};


