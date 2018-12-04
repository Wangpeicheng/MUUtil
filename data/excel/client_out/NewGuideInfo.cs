

// 开启新手引导触发条件类型
public enum NewGuideConditionType
{
    None = 0, //无
    Level = 1, //等级到达
    Accept = 2, //接受任务
    Perform = 3, //完成任务
    InstansEnd = 4, //开启结算
    MonsterDie = 5, //怪物死亡
    CompleteAimGuide = 6, //完成目标指引
    CommitTranfer = 7, //完成转职任务
    CompleteAimGuideNone = 8, //完成目标指引(无道具)
    ClickTask = 9, //点击任务
};

// 新手引导类型
public enum NewGuideType
{
    ForceStep = 0, //强制步骤
    NormalTips = 1, //普通提示
    Function = 2, //功能开启
    TaskTips = 3, //任务提示
    AwardTips = 4, //奖励提示
    Skill = 5, //技能开启
    UnForceStep = 6, //非强制步骤
};


