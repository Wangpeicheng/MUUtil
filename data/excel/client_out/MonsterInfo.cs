

// 怪物类型
public enum MonsterType
{
    MonsterType_Monster = 1, //怪物
    MonsterType_Jingying = 2, //精英
    MonsterType_Boss = 3, //Boss
    MonsterType_Summon = 4, //召唤物
    MonsterType_Fly = 5, //飞行物
    MonsterType_WorldBoss = 6, //世界Boss
    MonsterType_Pet = 7, //宠物
    MonsterType_Mercenary = 8, //雇佣兵
    MonsterType_Horse = 9, //坐骑
    MonsterType_Nian = 10, //年兽
    MonsterType_ChaosBoss = 11, //跨服boss
};

// 怪物攻击阵营数量
public enum MonsterCamp
{
    MonsterAtkCampSize = 2, //怪物攻击阵营数量
};

// 怪物经验分配方式
public enum MonsterExpType
{
    Montser_DmgMax = 0, //伤害最高获得
    Montser_DmgShare = 1, //伤害平分
    Montser_DmgRatio = 2, //伤害比例分配
    Montser_DmgAll = 3, //伤害获得全部经验
};

// 掉落归属统计方式
public enum MonsterDmgBelongType
{
    MonsterDmgBelongType_None = 0, //不统计
    MonsterDmgBelongType_Self = 1, //个人
    MonsterDmgBelongType_Team = 2, //队伍
};


