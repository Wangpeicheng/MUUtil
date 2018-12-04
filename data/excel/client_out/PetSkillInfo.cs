

// 打击点类型
public enum HitPointType
{
    HitPointType_Host = 1, //主人
    HitPointType_Target = 2, //目标
};

// 属性类型
public enum BaseAttrType
{
    BaseAttrType_Stre = 1, //力量
    BaseAttrType_Dext = 2, //敏捷
    BaseAttrType_Cons = 3, //体力
    BaseAttrType_Inte = 4, //智力
};

// 打击目标
public enum PetSkillTargetType
{
    PetSkillTargetType_Owner = 1, //主人
    PetSkillTargetType_OwnerTeam = 2, //主人队友
    PetSkillTargetType_OwnerTarget = 4, //主人目标人
    PetSkillTargetType_OwnerTargetBoss = 8, //boss
    PetSkillTargetType_OwnerTargetElite = 16, //精英怪
    PetSkillTargetType_OwnerTargetNomal = 32, //普通怪
    PetSkillTargetType_PetSelf = 64, //宠物自己
};

// 宠物技能类型
public enum PetSkillEffectType
{
    PetSkillEffectType_None = 0, //
    PetSkillEffectType_PhyAttack = 1, //物理攻击
    PetSkillEffectType_MagAttack = 2, //魔法攻击
    PetSkillEffectType_Heal = 3, //治疗
    PetSkillEffectType_AddBuff = 4, //加buff
    PetSkillEffectType_RemoveBuff = 5, //删除buff
    PetSkillEffectType_Summon = 6, //召唤怪物
    PetSkillEffectType_PoisonBuff = 7, //毒buff
    PetSkillEffectType_Max = 10, //最大值
};


