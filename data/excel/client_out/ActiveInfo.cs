

// 活跃度类型
public enum ActiveType
{
    ActiveType_StoryInstance = 1, //剧情副本
    ActiveType_ActivityInstance = 2, //活动副本
    ActiveType_AwardTask = 3, //悬赏任务
    ActiveType_JJC = 4, //竞技场
    ActiveType_TTT = 5, //通天之塔
    ActiveType_QJZZ = 6, //囚禁之岛
    ActiveType_ExpInstance = 7, //单人经验副本
    ActiveType_MonsterInstance = 8, //战盟魔物入侵
    ActiveType_TeamInstance = 9, //组队副本
    ActiveType_KDBossInstance = 10, //魔王昆顿
    ActiveType_GuildParty = 11, //战盟酒会
    ActiveType_AncientBattleInstacnce = 12, //古战场
    ActiveType_MeleeInstance = 13, //勇者大乱斗
    ActiveType_DragHome = 14, //龙之乡
    ActiveType_GetHorse = 15, //抓坐骑
    ActiveType_DragFight = 16, //魔龙讨伐
    ActiveType_WorldBoss = 17, //世界boss
    ActiveType_Instance = 18, //单人副本
    ActiveType_AllienceCaravan = 19, //战盟商队
    ThreeTimesExp = 20, //3倍经验
    ActiveType_Rank = 21, //日常膜拜
    ActiveType_AllenceFighting = 22, //领地争夺
    ActiveType_WeaponBuild = 23, //战盟打造
    ActiveType_HighLadder = 24, //天梯
    ActiveType_DailyShare = 50, //每日分享
};

// 活跃度类型
public enum ActiveCompleteType
{
    ActiveCompleteType_CompleteInstance = 1, //完成副本
    ActiveCompleteType_EnterInstance = 2, //进入副本
    ActiveCompleteType_AwardTask = 3, //悬赏任务
    ActiveCompleteType_ClimbTower = 4, //指定时间进入地图
    ActiveCompleteType_VIPLevel = 5, //VIP等级
    ActiveCompleteType_OnEnhance = 6, //装备强化
    ActiveCompleteType_OnPowerOn = 7, //装备追加
    ActiveCompleteType_loginIn = 8, //登录游戏
    ActiveCompleteType_GuildEquipMaking = 9, //战盟打造
    ActiveCompleteType_InstanceType = 10, //进入副本用类型判断
};

// 活跃度区别类型
public enum ActiveSubType
{
    ActiveSubType_Daily = 1, //日常活动
    ActiveSubType_TimeLimit = 2, //限时活动
    ActiveSubType_Festival = 3, //节日活动
};


