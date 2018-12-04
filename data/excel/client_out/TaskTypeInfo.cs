

// 任务类型
public enum TaskType
{
    Task_Type_None = 0, //直接完成类型
    Task_Type_Communication = 1, //对话类型
    Task_Type_LevelUp = 2, //升级类型
    Task_Type_Kill_Monster = 3, //杀怪类型
    Task_Type_Collect_Item = 4, //收集物品类型
    Task_Type_Pass_Story_Instance = 5, //通关剧情副本类型
    Task_Type_Kill_Monster1 = 6, //杀怪随机类型
    Task_Type_Change_Occupation = 7, //转职类型(基础转高级)
    Task_Type_Wing_Enhance = 8, //翅膀强化等级类型
    Task_Type_Wing_Advance = 9, //翅膀进阶等级类型
    Task_Type_EquipPos_Enhance = 10, //装备部位强化等级类型
    Task_Type_EquipPos_Enhance_Sum = 11, //装备部位强化等级之和类型
    Task_Type_BlackShop_Buy = 12, //黑市购买类型
    Task_Type_Skill_LevelUp = 13, //技能等级类型
    Task_Type_Occupation_Upgrade = 14, //职业进阶
    Task_Type_Enter_Activity_Instance = 15, //进入活动副本类型
    Task_Type_Enter_Team_Instance = 16, //进入组队副本类型
    Task_Type_Enter_PVP_Instance = 17, //进入PVP副本类型
    Task_Type_Enter_Arena_Instance = 18, //进入竞技场副本类型
    Task_Type_Pass_Activity_Instance = 19, //通关活动副本类型
    Task_Type_Pass_Team_Instance = 20, //通关组队副本类型
    Task_Type_Pass_PVP_Instance = 21, //通关PVP副本类型
    Task_Type_Pass_ClimbTower_Instance = 22, //通关爬塔副本类型
    Task_Type_Shop_Buy = 23, //商店购买类型
    Task_Type_Market_Buy = 24, //交易行购买类型
    Task_Type_Pet_LevelUp = 25, //宠物达到等级类型
    Task_Type_Pet_Learn_Skill = 26, //宠物学习技能类型
    Task_Type_Pet_Refine = 27, //宠物洗练类型
    Task_Type_Join_Guild = 28, //加入战盟类型
    Task_Type_Horse_LevelUp = 29, //坐骑达到等级类型
    Task_Type_Pass_Story_Instance_2 = 30, //通关剧情副本类型(包含非任务副本)
    Task_Type_Make_Equip = 31, //打造战盟装备
    Task_Type_Occupation_Exchange = 32, //转职类型(高级互转)
    Task_Type_Equip_Refine = 33, //装备洗练
    Task_Type_Worship = 34, //膜拜
    Task_Type_EquipPos_PowerOn = 35, //装备部位追加等级类型
    Task_Type_Story_Ins_Star = 36, //剧情副本评级星数
    Task_Type_Collection = 37, //采集任务
    Task_Type_Cross_Map = 38, //跨越地图
    Task_Type_Horse_Advance = 39, //坐骑升星
    Task_Type_GuildContribut = 40, //战盟捐赠
    Task_Type_GuildCaravanPay = 41, //商队缴纳
    Task_Type_GuildTask = 42, //狩猎任务
    Task_Type_GuildToast = 43, //战盟敬酒
    Task_Type_GuildInstance = 44, //参与魔物入侵
    Task_Type_HonorLevelUp = 45, //提升头衔
    Task_Type_PetGroup = 46, //宠物组合
    Task_Type_GuildScienceLevelUp = 47, //战盟科技等级
    Task_Type_GemNum = 48, //宝石数量
    Task_Type_UseFruit = 49, //使用果实
    Task_Type_ReviveGem = 50, //再生宝石使用一次
    Task_Type_GodWingLevel = 51, //神翼级数
    Task_Type_ShieldLevel = 52, //护盾级数
    Task_Type_HoseEquip = 53, //坐骑装备
    Task_Type_HoseStar = 54, //坐骑升星
    Task_Type_FinishInstance = 55, //完成一场幻影寺院或2V2
    Task_Type_UseExpBall = 56, //使用5倍经验球
    Task_Type_PetStar = 57, //宠物星数
    Task_Type_HolyVessel = 58, //圣器分解
    Task_Type_EquipStep = 59, //装备进阶
    Task_Type_GuildManor = 60, //参与一次领地占领
    Task_Type_SkillColumn = 61, //技能配置
    Task_Type_WoldBossReward = 62, //世界boss参与奖励
    Task_Type_AllocPoint = 63, //分配属性点
    Task_Type_MagicBookLevel = 64, //梅兰魔法书强化
    Task_Type_MagicBookChapter = 65, //梅兰魔法书章节镶嵌
    Task_Type_GodEquipEquip = 66, //神装装备
    Task_Type_GodEquipSuit = 67, //神装套装
    Task_Type_GodEquipRefine = 68, //神装洗练
    Task_Type_GodEquipActivate = 69, //神装激活
    Task_Type_RuneEquip = 70, //符文镶嵌
    Task_Type_RuneMake = 71, //符文打造
    Task_Type_RuneSteUp = 72, //符文进阶
    Task_Type_SuitEquipIdentify = 73, //套装鉴定
};

// 任务类别
public enum TaskClass
{
    Task_Class_Normal = 1, //主线任务
    Task_Class_Reward = 2, //悬赏任务
    Task_Class_Guide = 3, //引导任务
    Task_Class_Occupation = 4, //转职任务
    Task_Class_Branch = 5, //支线任务
    Task_Class_Caravan = 7, //商队任务
};


