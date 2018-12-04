

// 交互类型
public enum ProgressInteractType
{
    ProgressInteractType_None = 1, //
    ProgressInteractType_Script = 2, //脚本交互
    ProgressInteractType_CollectHorse = 3, //采集坐骑
    ProgressInteractType_IdentityHorse = 4, //鉴定坐骑
    ProgressInteractType_CollectTask = 5, //采集任务
    ProgressInteractType_TreasureBox = 6, //活动奇迹宝箱
    ProgressInteractType_ScriptCollect = 7, //脚本采集
    ProgressInteractType_MAX = 10, //交互类型最大值
};

// 打断类型
public enum ProgressInterruptType
{
    ProgressInterruptType_All = 1, //所有打断类型
    ProgressInterruptType_BeAtt = 2, //受击类型除外
    ProgressInterruptType_Max = 5, //打断类型最大值
};


