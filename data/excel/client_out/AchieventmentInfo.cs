

// 所属总类
public enum Achieventment_MainClass
{
    Achieventment_Tototal = 1, //成就总览
    Achieventment_Growth = 2, //个人成长
    Achieventment_Partner = 3, //伙伴培养
    Achieventment_Equip = 4, //装备打造
    Achieventment_Active = 5, // 活动日常
    Achieventment_Friend = 6, //社交关系
    Achieventment_Shine = 7, //光辉事迹
};

// 分项子类
public enum Achieventment_SubClass
{
    Achieventment_SubScore = 1, //成就总分
    Achieventment_SubLevel = 2, //等级
    Achieventment_SubChangeOcc = 3, //转职
    Achieventment_SubHorse = 4, //坐骑
    Achieventment_SubPet = 5, //宠物
    Achieventment_SubSpirit = 6, //精灵
    Achieventment_SubEquip = 7, //装备
    Achieventment_SubBuild = 8, //打造
    Achieventment_SubKillMonster = 9, //杀怪
    Achieventment_SubRewardTask = 10, //悬赏
    Achieventment_SubCaravan = 11, //商队
    Achieventment_SubActive = 12, //活动
    Achieventment_SubInstance = 13, //副本
    Achieventment_SubBattleInstance = 14, //古战场
    Achieventment_SubWorship = 15, //膜拜
    Achieventment_SubPVP = 16, //pvp
    Achieventment_SubGuild = 17, //战盟
    Achieventment_SubArena = 18, //竞技场
    Achieventment_SubQiongjing = 19, //囚禁之岛
    Achieventment_SubMoLong = 20, //魔龙讨伐
    Achieventment_SubKDBoss = 21, //困顿降临
    Achieventment_SubManor = 22, //领地争夺
    Achieventment_SubPower = 23, //追加
    Achieventment_SubGuildScience = 24, //战盟科技
    Achieventment_SubWing = 25, //翅膀
};

// 成就内容
public enum AchieventmentType
{
    AchieventmentType_Score = 0, //成就总分
    AchieventmentType_Level = 1, //角色等级
    AchieventmentType_ChangeOcc = 2, //转职次数
    AchieventmentType_Horse = 3, //获得坐骑
    AchieventmentType_Pet = 4, //获得宠物
    AchieventmentType_Spirit = 5, //获得精灵
    AchieventmentType_EquipRing = 6, //穿戴戒指
    AchieventmentType_Equipstar2 = 7, //穿戴紫2装备
    AchieventmentType_Equipstar3 = 8, //穿戴紫3装备
    AchieventmentType_EquipEnhance = 9, //强化介数
    AchieventmentType_EquipPower = 10, //追加等级
    AchieventmentType_EquipStoneLvl1 = 11, //镶嵌1级宝石
    AchieventmentType_BuildEquip = 12, //打造装备次数
    AchieventmentType_BuildStar1 = 13, //打造紫1装备
    AchieventmentType_BuildStar2 = 14, //打造紫2装备
    AchieventmentType_BuildStar3 = 15, //打造紫3装备
    AchieventmentType_KillMonster = 16, //杀怪数量
    AchieventmentType_CommitRewardTask = 17, //完成悬赏任务次数
    AchieventmentType_GuildCaravan = 18, //战盟商队发车次数
    AchieventmentType_Kantelu = 19, //通关坎特鲁次数
    AchieventmentType_EMo = 20, //通关恶魔广场次数
    AchieventmentType_Xuese = 21, //通关血色城堡次数
    AchieventmentType_Tower = 22, //通关通天之塔次数
    AchieventmentType_Cangbao = 23, //通关藏宝海湾次数
    AchieventmentType_jingying = 24, //通关精英挑战次数
    AchieventmentType_Expball = 25, //使用5倍经验球次数
    AchieventmentType_Instance = 26, //通关个人副本次数
    AchieventmentType_BattleInstance = 27, //进入古战场次数
    AchieventmentType_Worshipr = 28, //膜拜次数
    AchieventmentType_Dead = 29, //死亡次数
    AchieventmentType_Kill = 30, //击杀次数
    AchieventmentType_KillRedRole = 31, //击杀红名玩家次数
    AchieventmentType_JoinGuild = 32, //加入战盟
    AchieventmentType_GuildContribut = 33, //战盟捐献
    AchieventmentType_GuildAnswer = 34, //战盟答题
    AchieventmentType_GuildToast = 35, //战盟使用高级敬酒
    AchieventmentType_GuildBuild = 36, //战盟升级科技
    AchieventmentType_ArenaRank = 37, //竞技场第一名
    AchieventmentType_QiujingWing = 38, //囚禁获得一次胜利
    AchieventmentType_MoLingWing = 39, //魔龙讨伐个人第一
    AchieventmentType_KDBossWing = 40, //困顿个人第一
    AchieventmentType_Manor = 41, //占领1次冰霜之城
    AchieventmentType_EquipStoneLvl2 = 42, //镶嵌2级宝石
    AchieventmentType_EquipStoneLvl3 = 43, //镶嵌3级宝石
    AchieventmentType_RefreshTaskReward = 44, //刷新悬赏任务
    AchieventmentType_PetLvl = 45, //宠物等级
    AchieventmentType_PetGrade = 46, //宠物进阶
    AchieventmentType_PetRefine = 47, //宠物洗练
    AchieventmentType_HorseLvl = 48, //坐骑等级
    AchieventmentType_HorseStar = 49, //坐骑星数
    AchieventmentType_HorseEquip = 50, //坐骑装备
    AchieventmentType_WingLvl = 51, //翅膀代数
    AchieventmentType_GodWingLvl = 52, //神翼阶级
    AchieventmentType_HorseStoneLvl = 53, //坐骑炼魂等级
    AchieventmentType_EquipSuitEnchance = 54, //全身强化阶数
    AchieventmentType_EquipSuitPower = 55, //全身追加等级
    AchieventmentType_LuoLanCastellan = 56, //罗兰城主
    AchieventmentType_HolyVessellvl = 57, //圣器等级
    AchieventmentType_MagicBookLvl = 58, //魔法书等级
    AchieventmentType_MagicBookChapterGrad = 59, //魔法书章节品质
    AchieventmentType_MagicBookChapterLvl = 60, //魔法书章节等级
    AchieventmentType_GodEquipActivate = 67, //神装激活
};


