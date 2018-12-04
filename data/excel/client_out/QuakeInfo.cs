

// 震动坐标类型
public enum CoordType
{
    CoordType_Self = 0, //自身面向
    CoordType_World = 1, //世界坐标
    CoordTyoe_Camera = 2, //镜头面向
};

// 影响目标类型
public enum AffectTargetType
{
    AffectTargetType_Self = 0, //自己
    AffectTargetType_SelfAndEnemy = 1, //自己和敌方
    AffectTargetType_All = 2, //所有人
};

// 震动方向类型
public enum DirectionType
{
    DirectionType_Plus = 0, //正
    DirectionType_Minus = 1, //负
};


