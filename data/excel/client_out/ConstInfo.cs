

// 常量表标识
public enum ConstValueType
{
    ConstValueType_ActivityDouble = 1, //活动副本双倍经验需要钥匙
    ConstValueType_ActivityTrible = 2, //活动副本三倍经验需要钥匙
    ConstValueType_HpPoolMax = 3, //血池上限
    ConstValueType_MpPoolMax = 4, //蓝池上限
    ConstValueType_FirstAidPoolMax = 5, //急救药上限
    ConstValueType_FirstAidCD = 6, //急救药cd
    ConstValueType_FirstAidSingleValue = 7, //急救药单次补充万分比
    ConstValueType_CofCSaleCountLimit = 8, //商会出售额度
    ConstValueType_CofCPriceRefreshTime = 9, //商会刷新时间
    ConstValueType_CofCPriceRefreshCount = 10, //商会刷新数量
    ConstValueType_MarketExpireTime = 11, //市场过期时间
    ConstValueType_SameScreenRadius = 12, //同屏攻击范围
    ConstValueType_MarketCD = 13, //市场商品购买冷却时间
    ConstValueType_MedicineHpSetInit = 14, //药品回复血量初始设定值
    ConstValueType_MedicineMpSetInit = 15, //药品回复魔法初始设定值
    ConstValueType_ChangeOccupationLimit = 16, //转职等级限制
    ConstValueType_DbClickInterval = 20, //双击时间间隔
    ConstValueType_FCReward = 21, //首充礼包
    ConstValueType_JoysticResponseTime = 22, //摇杆响应时间
    ConstValueType_HpMpSacl = 23, //客户端显示血蓝急救上限缩放
    ConstValueType_DiamondExchangeCrystal = 24, //钻石兑换水晶倍数
    ConstValueType_DiamondExchangeGold = 25, //钻石兑换金币倍数
    ConstValueType_ChangeOccupationCondition = 26, //完成其中任意一个任务开启转职功能
    ConstValueType_ReliveItemId = 27, //复活需要的道具ID
    ConstValueType_CreateAllienceCDTime = 28, //创建战盟cd时间
    ConstValueType_CreateAllienceLvLimit = 29, //战盟开启等级
    ConstValueType_CreateAllienceCrystalCost = 30, //创建战盟消耗水晶
    ConstValueType_ResetPointFreeLvLimit = 31, //免费洗点最大等级
    ConstValueType_ResetPointCostCyanite = 32, //洗点消耗水晶 
    ConstValueType_ResetRewardTaskCost = 33, //悬赏任务刷新金币消耗 
    ConstValueType_ReliveCDTime = 35, //读秒复活时间(s) 
    ConstValueType_TransCDTime = 36, //小地图瞬移进入挂机时间(s) 
    ConstValueType_ReliveCost = 37, //复活需要的钻石数量
    ConstValueType_RenameAllienceCrystalCost = 38, //战盟重命名消耗水晶
    ConstValueType_JoinAllienceMaxLv = 41, //战盟加入等级上限
    ConstValueType_ExpPoolCapacityByTime = 42, //经验池容量(小时)
    ConstValueType_TeamInstanceMinLevel = 45, //组队副本进入最低等级
    ConstValueType_TicketAtRoleInit = 49, //新创建角色默认获得钻石数
    ConstValueType_MaxGuildMoney = 50, //最大战盟资金
    ConstValueType_MaxGuildContribution = 51, //最大战盟贡献
    ConstValueType_ArenaDefeatChallengeCD = 58, //竞技场挑战失败冷却保护CD
    ConstValueType_ArenaEraseDefeatCDBaseCost = 59, //竞技场付费消除保护CD花费钻石常量（*时间=实际花费）
    ConstValueType_ArenaDailyRewardTime = 60, //竞技场排名奖励每日结算时间(H:h)
    ConstValueType_ArenaRefreshOpponentCD = 61, //竞技场刷新对手列表CD时间(s)
    ConstValueType_ArenaRobotName = 66, //竞技场机器人名称
    ConstValueType_FlowSpeed = 63, //飘字时间控制速度
    ConstValueType_FlowHeight = 64, //飘字高度
    ConstValueType_FlowTime = 65, //飘字停留时间
    ConstValueType_WorshipDailyCount = 68, //每日膜拜次数
    ConstValueType_WorshipMaxCount = 69, //最大被膜拜次数
    ConstValueType_GuildMemberActiveAddExp = 70, //战盟每点活跃度增加经验值
    ConstValueType_MarketMaxPrice = 72, //市场上架最高魔晶价格
    ConstValueType_YellowPlayerNameColor = 73, //黄名善恶值名字显示
    ConstValueType_RedPlayerNameColor = 74, //红名善恶值名字显示
    ConstValueType_NormalPlayerNameColor = 53, //角色头顶玩家名称文本字体颜色(正常善恶值显示)
    ConstValueType_GrayPlayerNameColor = 75, //灰名善恶值名字显示
    ConstValueType_MaxBuffOverlayTime = 76, //Buff叠加最大时间(毫秒)
    ConstValueType_KillWhitePlayerPK = 77, //击杀白名玩家pk值
    ConstValueType_KillYellowPlayerPK = 78, //击杀黄名玩家pk值
    ConstValueType_PKPerMinute = 79, //每分钟pk值减少的数量
    ConstValueType_HangTime = 80, //副本不操作挂机时间
    ConstValueType_TargetTeleportDefaultLen = 81, //目标瞬移在无目标情况下默认的位移距离（默认方向为正方向）
    ConstValueType_EquipColorUpRate = 82, //装备觉醒初始成功率
    ConstValueType_LockOneExtAttrCostNum = 83, //锁定一条卓越属性消耗的越晶石
    ConstValueType_LockTwoExtAttrCostNum = 84, //锁定两条卓越属性消耗的越晶石
    ConstValueType_EquipColorUpLuckyMax = 85, //觉醒幸运最高值
    ConstValueType_NoLockExtAttrCostNum = 86, //不锁定消耗卓越属性消耗的卓越晶石
    ConstValueType_ExtAttrCostCoin = 87, //卓越洗练消耗金币数量跟卓越晶石系数
    ConstValueType_SpecailAttrCostNum = 88, //史诗洗练消耗的混沌晶石数量
    ConstValueType_SpecailAttrCostCoin = 89, //史诗洗练消耗金币数量跟混沌晶石系数
    ConstValueType_MercenaryFollowLen = 90, //雇佣兵离主人多远开始跟随
    ConstValueType_MercenaryGotoLen = 91, //雇佣兵离主人多远开始瞬移(防止卡住)
    ConstValueType_MaxClimbTowerSweepCount = 92, //最大爬塔副本每日扫荡次数
    ConstValueType_MercenaryLevelParam = 95, //雇佣兵等级系数
    ConstValueType_PassiveSkillAddBuffFlag = 96, //被动技能添加buff所属标记
    ConstValueType_MonsterResumePer = 97, //怪物回家,巡逻状态血量回复(占总血量百分比)
    ConstValueType_MonsterResumeCycle = 98, //怪物回血时间周期(单位:毫秒)
    ConstValueType_MyMerenaryTitleName = 104, //自己雇佣兵血条颜色 名字颜色
    ConstValueType_MyTeamMerenaryTitleName = 105, //队友和盟友雇佣兵血条颜色 名字颜色
    ConstValueType_OtherMerenaryTitleName = 106, //其他雇佣兵血条颜色 名字颜色
    ConstValueType_HitParam = 107, //战斗公式命中参数(万分比)
    ConstValueType_ArenaExportRankTime = 108, //竞技场每日定时输出排名时间
    ConstValueType_ArenaExportRankCount = 109, //竞技场每日定时输出排名数量限制
    ConstValueType_WorlkRankLogTime = 110, //世界排行榜每日定时输出排名时间
    ConstValueType_WorldRankLogCount = 111, //世界排行榜每日定时输出排名数量限制
    ConstValueType_WorldChatLimitLevel = 112, //世界聊天限制等级
    ConstValueType_WorldChatFreqLimit = 113, //世界聊天频率限制
    ConstValueType_MapLineAutoLimit = 114, //地图自动分线阀值
    ConstValueType_ButtonCollTime = 116, //按钮冷却时间
    ConstValueType_MoWuRuQinRange = 117, //魔物入侵触发区域范围
    ConstValueType_MarketRefreshPriceInterval = 121, //市场刷新计算标准价格时间间隔
    ConstValueType_MarketNoticeTime = 122, //市场物品上架公示期(s)
    ConstValueType_RoleAttrInitPoint = 123, //角色初始可分配属性点
    ConstValueType_PracticeGetTime = 124, //修炼提取时间(单位:秒)
    ConstValueType_PracticeMaxTime = 125, //修炼时间总额上限(单位:秒)
    ConstValueType_PracticeDailyAddTime = 126, //修炼每日增加时间(单位:秒)
    ConstValueType_PracticeItemCount = 127, //每日修炼道具使用上限
    ConstValueType_PracticeItemID = 128, //修炼道具编号
    ConstValueType_PracticeExpMul = 129, //修炼杀怪经验系数(百分比)
    ConstValueType_ModelRotateSpeed = 130, //模型旋转速度
    ConstValueType_MarketBanSalePeriod = 136, //市场禁止上架时间段
    ConstValueType_OffKillMonTimeMul = 137, //离线杀怪时间系数(百分比)
    ConstValueType_MinOffKillMonTime = 138, //离线最短杀怪时间(单位:秒)
    ConstValueType_MaxOffKillMonTime = 139, //离线最长杀怪时间(单位:秒)
    ConstValueType_MaxOffTime = 140, //离线时间最大值(单位:秒)
    ConstValueType_RefershNearTeamCD = 141, //附近队伍刷新CD(单位:秒)
    ConstValueType_RefershTargetTeamCD = 142, //目标队伍刷新CD(单位:秒)
    ConstValueType_LinkMesTag = 143, //消息链接标识
    ConstValueType_TeamExpBuffId = 146, //组队经验Buff编号
    ConstValueType_LoginQueueBegNum = 147, //登录排队多少人开始小于等于单服最大人数
    ConstValueType_LoginQueuePerSec = 148, //登录排队人数小于最大人数时，每秒进入多少个
    ConstValueType_MatchInstanceMapId = 149, //匹配机制集合地图id
    ConstValueType_ChatLimit = 151, //聊天字符长度
    ConstValueType_GuildBuildTaskMaxRing = 152, //战盟建设任务最大环
    ConstValueType_VoiceLimit = 153, //聊天语音时间长度
    ConstValueType_TreasFlowerTime = 154, //挖宝进度条时间（毫秒）
    ConstValueType_GuildGuardHomeRefreshDayTimes = 155, //守护家园每日刷新次数
    ConstValueType_GuildGuardHomeRefreshMoney = 156, //守护家园刷新需要战盟资金
    ConstValueType_Version_Minor = 158, //最低协议版本号
    ConstValueType_Version_Major = 159, //最高协议版本号
    ConstValueType_GuildEliteScoreMul = 160, //战盟精英评分系数
    ConstValueType_ConstValueType_RecoverCD = 161, //打坐恢复cd时间(毫秒)
    ConstValueType_GuildMaxPrestige = 162, //战盟最大声望
    ConstValueType_GuildSendNoticeCost = 163, //战盟发布公告消耗(金币)
    ConstValueType_HorseAttrValueScore = 167, //坐骑属性数值评分(白绿蓝紫橙)
    ConstValueType_HorseAttrIdScore = 168, //坐骑属性类型评分(初级中级高级)
    ConstValueType_HorsePrimeryAttrId = 169, //坐骑初级属性ID
    ConstValueType_HorseSecondaryAttrId = 170, //坐骑中级属性ID
    ConstValueType_HorseAdvancedAttrId = 171, //坐骑高级属性ID
    ConstValueType_GuildDailyGiftId = 178, //战盟每日礼包编号
    ConstValueType_MaxGuildBonus = 179, //最大战盟红利
    ConstValueType_GuildPartyQuizTime = 180, //战盟酒会出题间隔时间(秒)
    ConstValueType_GuildPartyQuizCount = 181, //战盟酒会出题数
    ConstValueType_GuildPartyExpTime = 182, //战盟酒会经验获得间隔时间(秒)
    ConstValueType_GuildPartyToastCount = 183, //战盟酒会敬酒次数
    ConstValueType_RewardTaskStarItem = 184, //悬赏任务星星兑换
    ConstValueType_IdentifyHorseTime = 185, //坐骑鉴定时间
    ConstValueType_GuildSceneMapId = 186, //战盟场景编号
    ConstValueType_CatchHorseDistance = 187, //坐骑抓捕最大距离
    ConstValueType_GuildPartyStartDayTime = 188, //战盟酒会开启时间(小时#分钟)
    ConstValueType_GuildPartyLastTime = 189, //战盟酒会持续时间(秒)
    ConstValueType_GuildPartyQuizStartTime = 190, //战盟酒会答题开始时间(秒)
    ConstValueType_GuildDailyGiftNeedContri = 191, //战盟每日礼包领取消耗贡献
    ConstValueType_MountIntervalTime = 192, //骑乘间隔时间
    ConstValueType_GuildCaravanSeekHelpCount = 193, //战盟商队求助次数
    ConstValueType_GuildCaravanDailyHelpCount = 194, //战盟商队每日帮助次数
    ConstValueType_GuildCaravanMinProgress = 195, //战盟商队最低进度
    ConstValueType_GuildCaravanMaxProgress = 196, //战盟商队最大进度
    ConstValueType_MountLeftWarTime = 197, //脱战时间（秒）包含技能动作时间
    ConstValueType_HorseExpAdd = 198, //坐骑经验药剂提供经验
    ConstValueType_PetExpAdd = 199, //宠物经验药剂提供经验
    ConstValueType_HorseExpItemID = 203, //宠物经验药剂道具ID
    ConstValueType_UnlockHonorID = 204, //初解锁头衔ID
    ConstValueType_BattleInstanceStartTime = 205, //战场每日开启时间
    ConstValueType_BattleInstanceEndTime = 206, //战场每日结束时间
    ConstValueType_SpeedBase = 208, //宠物经验药剂道具ID
    ConstValueType_SpeedWalk = 209, //走路速度加成
    ConstValueType_SpeedFly = 210, //飞行速度加成
    ConstValueType_SpeedSwim = 211, //游泳速度加成
    ConstValueType_FlowCount = 212, //FlowLabel数量上线
    ConstValueType_ProgressOffset = 213, //坐骑抓捕Loading界面偏移
    ConstValueType_LoginQueueParamA = 215, //登录排队人数显示参数A
    ConstValueType_LoginQueueParamB = 216, //登录排队人数显示参数B
    ConstValueType_GuildPartyExpMul = 221, //战盟酒会挂机经验系数(万分比)
    ConstValueType_WorshipExpMul = 222, //膜拜经验系数(万分比)
    ConstValueType_NextDayRewardOpenLevel = 223, //次日登录开放等级
    ConstValueType_NextDayRewardPet = 224, //次日登录奖励宠物
    ConstValueType_SwitchLineMapMax = 227, //玩家自由切线地图角色数量上限
    ConstValueType_PracticeOpenLevel = 228, //修炼开放等级
    ConstValueType_DayExchangeGoldMax = 233, //每日兑换金币上限
    ConstValueType_DayExchangeCyantieMax = 234, //每日兑换水晶上限
    ConstValueType_ExchangeGoldMax = 235, //单次兑换金币上限
    ConstValueType_ExchangeCyantieMax = 236, //单次兑换水晶上限
    ConstValueType_OnlineRewardOpenLevel = 238, //在线礼包功能开启等级
    ConstValueType_DropItemDistance = 239, //道具手套和武器离地距离
    ConstValueType_EnhanceSuitNum = 240, //强化追加套装属性件数
    ConstValueType_SevenRewardOpenLevel = 241, //七天登录开启等级
    ConstValueType_AllienceEquipBuildTime = 242, //战盟打造装备延时（毫秒）
    ConstValueType_TeamWorldAnnounceCD = 243, //组队世界邀请喊话cd
    ConstValueType_InviteTeamMemberCD = 244, //组队队长发起进入副本倒计时CD
    ConstValueType_SevenAchieveOpenLevel = 245, //七日达成开启等级
    ConstValueType_MarketPriceUpMaxPer = 251, //交易行价格最大涨幅（万分位）
    ConstValueType_MarketPriceDownMaxPer = 252, //交易行价格最大跌幅（万分位）
    ConstValueType_ExpPrizeOpenLevel = 254, //离线/修炼经验奖励开启等级
    ConstValueType_EquipEnhanceGridID = 280, //添加装备进阶引导时候优先排序的装备ID
    ConstValueType_EquipAwakeGridID = 281, //添加装备觉醒引导时候优先排序的装备ID
    ConstValueType_EnhanceCDTime = 282, //自动强化单次间隔时间（毫秒）
    ConstValueType_AppendCDTime = 283, //自动追加单次间隔时间（毫秒）
    ConstValueType_WingStrengthCDTime = 284, //翅膀自动强化单次间隔时间（毫秒）
    ConstValueType_OffExpPrizeVipBuyMul = 285, //离线经验Vip购买消耗水晶(水晶/分钟)
    ConstValueType_ItemDetectInterval = 286, //道具拾取自动吸附时间间隔
    ConstValueType_RoleRenameCostItemId = 287, //角色改名消耗道具ID
    ConstValueType_WhiteItemName = 288, //物品飞出白名单模块
    ConstValueType_WhiteItemStayTime = 289, //道具出现后停留时间（毫秒）
    ConstValueType_OccTaskFinish = 290, //转职任务完成显示转职界面
    ConstValueType_DropMonsterLevel = 291, //掉落大于怪物等级
    ConstValueType_GuildBuildTaskLimitLevel = 293, //战盟建设任务限制等级
    ConstValueType_GuildCaravanTaskLimitLevel = 294, //战盟商会任务限制等级
    ConstValueType_GemUnEquipCost = 295, //宝石卸载花费
    ConstValueType_RechargeRebateRate = 297, //充值返还倍率
    ConstValueType_AuctionGuildDisTime = 298, //战盟拍卖持续时间（秒）
    ConstValueType_AuctionGlobalDisTime = 299, //全服拍卖持续时间（秒）
    ConstValueType_TurntableMaxFreeDrawTimes = 300, //奇迹转盘每日免费次数上限
    ConstValueType_TurntableDrawOneTimesCost = 301, //单抽货币类型/价格
    ConstValueType_TurntableDrawTenTimesCost = 302, //十连抽货币类型/价格
    ConstValueType_TurntableRefreshCost = 303, //奖池刷新货币类型/价格
    ConstValueType_TurntableDrawTimes = 307, //抽取多少次后，加入1库道具进入随机
    ConstValueType_GuildFirstJoinContri = 308, //首次加入战盟获得贡献值
    ConstValueType_ResetPoinAutoLevel = 309, //小于该等级会自动分配属性大于等于该等级则不自动分配
    ConstValueType_QiuJinTicketDailyUseCount = 310, //囚禁之岛每日门票使用次数
    ConstValueType_PracticeExpGetPrice = 311, //修炼单颗经验球提取价格(钻石)
    ConstValueType_MaxOffTimeAdd = 312, //离线托管卡增加挂机时间(秒)
    ConstValueType_MaxOffTimeAddItemId = 313, //离线托管卡道具编号
    ConstValueType_NewbieGuideInstanceId = 315, //新手引导关副本ID
    ConstValueType_AuctionActiveDisTime = 316, //拍卖活动持续时间(分钟)
    ConstValueType_HorseExpShopId = 317, //坐骑经验药水商品id
    ConstValueType_GuildAutoChangeLeaderTime = 318, //盟主转让盟主之位时间（小时）
    ConstValueType_GuildAutoKickTime = 319, //自动请离战盟时间（小时）
    ConstValueType_GuildGuardHomeDefiniteTime = 320, //保卫家园默认开启时间(小时#分钟)
    ConstValueType_GuildInstanceDefiniteTime = 321, //魔物入侵默认开启时间(小时#分钟)
    ConstValueType_GuildOfflineExpGainTime = 322, //离线挂机免费领取时间（小时）
    ConstValueType_GuildAutoDismissTime = 323, //战盟自动解散时间（小时）
    ConstValueType_SetOutExpOpenLevel = 326, //暂离功能开启等级
    ConstValueType_ServerLevelRoleLevelLimit = 330, //服务器等级经验加成生效，玩家等级要求
    ConstValueType_ServerLevelRankNum = 331, //服务器等级计算，玩家等级排行榜数量
    ConstValueType_ServerLevelExpAdd = 332, //服务器等级经验加成
    ConstValueType_GuildSkillAddBuffFlag = 333, //战盟技能添加buff所属标记
    ConstValueType_GuildOffExpTimeGainCount = 334, //战盟离线挂机时间每日领取次数
    ConstValueType_TurnTableOneDrawStarNum = 335, //单抽1次获得积分数
    ConstValueType_TurnTableTenDrawStarNum = 336, //单抽10次获得积分数
    ConstValueType_MonsterDmgStopTime = 337, //怪物伤害停止时间(秒)
    ConstValueType_TeamInstanceExpShareMul = 340, //组队副本经验共享系数(万分比)
    ConstValueType_GuildEquipMakeNoteColor = 341, //战盟装备打造公告最低品质
    ConstValueType_OffExpOpenInitTime = 345, //托管挂机功能开启后初始时间（小时）
    ConstValueType_NameValidRange = 349, //角色名称合法范围(A#B|C#D)
    ConstValueType_NewRoleMapPos = 350, //角色新手进入地图坐标区域
    ConstValueType_HpMpPoolBuy = 351, //生命，魔法储备直接金币购买(红价格#数量#蓝价格#数量)
    ConstValueType_OffExpNoDisturbTime = 356, //离线挂机消息免打扰最大时长(小时)
    ConstValueType_MaxOffExp = 357, //离线挂机经验值获得上限
    ConstValueType_GemType = 358, //宝石属性关联
    ConstValueType_MinSkillDmg = 359, //技能最小伤害浮动
    ConstValueType_MaxSkillDmg = 360, //技能最大伤害浮动
    ConstValueType_ArenaChallengeTicket = 361, //竞技场挑战券ID(使用可替代次数进入竞技场)
    ConstValueType_PandoraBeInvite = 363, //潘多拉秘境每日被邀请次数
    ConstValueType_HorseCollectMaxDayTimes = 365, //坐骑每日抓捕成功次数上限
    ConstValueType_TeamLeaderVerifyActivityTimes = 366, //组队队长默认同意发起活动时间（秒）
    ConstValueType_GuildAuctionBonusLimit = 367, //战盟拍卖个人获得分红上限（百分比）
    ConstValueType_HonerShopTipsLv = 368, //荣誉商店提示红点等级
    ConstValueType_GuildEquipMakingAddBless = 369, //战盟打造出现卓越装备补偿祝福值
    ConstValueType_AuctionOpenLevel = 371, //拍卖行功能开启等级
    ConstValueType_NewbieGuideMapId = 373, //新手引导关地图ID
    ConstValueType_GotoEnempy = 374, //传送到仇人身边价格 类型|价格
    ConstValueType_PrivateChatLevelLimit = 375, //私聊等级限制
    ConstValueType_HorseShopTipsLv = 376, //坐骑商店提示红点等级
    ConstValueType_ReportNum = 377, //每日举报数量
    ConstValueType_FreeDrawItemId = 378, //免费寻宝消耗道具ID
    ConstValueType_TaskUseFlyMinDis = 379, //任务飞鞋可传送距离
    ConstValueType_ReliveInPlacePosition = 380, //连续死亡战盟内播报（职务）
    ConstValueType_ReliveInPlaceCount = 381, //连续死亡次数
    ConstValueType_TaskFlyItemInfoId = 382, //飞鞋道具ID
    ConstValueType_EveryDayReportTimes = 383, //每天举报次数
    ConstValueType_HolyVesselAttrList = 384, //圣器属性列表
    ConstValueType_HolyVesselOpenLevel = 385, //圣器开放等级
    ConstValueType_CaptureMountsRefreshCD = 386, //天降神驹界面更新时间间隔（秒）
    ConstValueType_MarketCreditMax = 387, //交易行商誉值上限
    ConstValueType_Reporttime = 388, //举报冷却时间
    ConstValueType_PrivilegeCardAddHangTime = 389, //奇迹特权卡，挂机时间上限时间增加（秒）
    ConstValueType_PrivilegeCardReward = 390, //特权卡购买后返还货币/数量
    ConstValueType_GuildAddOffTime = 391, //战盟离线托管每日增加时间（秒）
    ConstValueType_BaseOffTime = 392, //离线托管基础时长（秒）
    ConstValueType_TaskFlyInterval = 393, //任务传送允许点击间隔
    ConstValueType_MapCount = 394, //大地图数量
    ConstValueType_RedPacketHidenTime = 395, //界面红包提醒消失时间
    ConstValueType_RedPacketGiveOutTimeOut = 396, //红包发放过期时间
    ConstValueType_RedPacketOpenMaxTime = 397, //每日红包开启数量
    ConstValueType_RedPacketMinGetValuePer = 399, //红包分配最小百分比
    ConstValueType_RedPacketMaxGetValuePer = 400, //红包分配最最大百分比
    ConstValueType_PandoraSystip = 402, //挖出来好东西公告
    ConstValueType_OutOfFightInterval = 405, //脱离战斗时间(ms)
    ConstValueType_OneKeyFinishRewardTaskPrice = 406, //悬赏任务一键完成价格
    ConstValueType_OneKeyFinishRewardTaskExpRatio = 407, //悬赏任务一键完成经验系数
    ConstValueType_RedPacketTimeOut = 408, //红包超时删除时间
    ConstValueType_RedPacketRecordMaxCount = 409, //红包记录最大数
    ConstValueType_EquipEnhanceNotice = 413, //装备强化到达几阶时公告
    ConstValueType_ArenaWin = 414, //竞技场连胜次数公告
    ConstValueType_EquipPowerOnNotice = 415, //装备追加到达几阶时公告
    ConstValueType_ShareAward = 416, //分享奖励
    ConstValueType_ArenaRankNotice = 417, //进入竞技场前N名播放公告
    ConstValueType_MarketRandNoticeTime = 418, //交易行随机上架时间(秒)
    ConstValueType_WorldBossBottomPrizeDmgPer = 421, //魔王死亡时对魔王造成伤害保底奖励发放条件（万分比）
    ConstValueType_RedFortressTicketDailyUseCount = 422, //赤色要塞每日门票使用次数
    ConstValueType_HuanYingTicketDailyUseCount = 423, //幻影寺院每日门票使用次数
    ConstValueType_JueDouChangTicketDailyUseCount = 424, //角斗场每日门票使用次数
    ConstValueType_AmounceNoticeUpTime = 425, //个人公告翻页毫秒
    ConstValueType_AmounceNoticeDisTime = 426, //个人公告消失毫秒
    ConstValueType_GlobalChatItem = 427, //跨服聊天消耗道具
    ConstValueType_GuildBuildTaskOpenPreTaskId = 428, //战盟建设任务开启前置任务
    ConstValueType_KalimaVipLv = 430, //神庙vip等级
    ConstValueType_DailyRewardTaskCount = 431, //悬赏任务每日次数
    ConstValueType_BossComingTime = 432, //魔王即将刷新提前提示时间（秒）
    ConstValueType_OfflineExpDoubleGetSpend = 433, //离线双倍经验领取消耗(货币类型#值)
    ConstValueType_GodofWingEnhanceCDTime = 434, //神翼自动强化单词间隔时间（毫秒）
    ConstValueType_BossLevingTime = 436, //魔王即将离开提前提示时间（秒）
    ConstValueType_CheckEquipState = 443, //装备检测（等级段内多少级检测一次）
    ConstValueType_GuildRenameCostItemId = 444, //战盟改名消耗道具ID
    ConstValueType_TeamMonsterDmgStopTime = 445, //组队掉落移除时间
    ConstValueType_EquipRecoverItem = 446, //装备回收生成道具ID
    ConstValueType_TeamInsKillLimitKickTime = 448, //组队副本杀满踢出时间
    ConstValueType_TeamDropMonsterLevel = 449, //组队无掉落等级差距
    ConstValueType_TurntableFreeTime = 450, //宝藏免费倒计时冷却时间（秒）
    ConstValueType_TurntableBigPrizeInit = 452, //玩家大奖初始系数
    ConstValueType_TurntableBigPrizeReset = 453, //玩家大奖重置系数
    ConstValueType_TurntableBigPrizeR = 454, //宝藏大奖系数R
    ConstValueType_LuoLanCityWarOpenDay = 456, //跨服罗兰城战第一开启时间
    ConstValueType_LuoLanCityWarOpenTime = 457, //跨服罗兰城战开启时间
    ConstValueType_LuoLanCityWarEndTime = 458, //跨服罗兰城战持续时间（秒）
    ConstValueType_LuoLanCityWarOpenWeekDay = 459, //跨服罗兰城战开启日期
    ConstValueType_LuoLanCityWarMinLvl = 460, //跨服罗兰城战最低参战等级
    ConstValueType_AutoRecoverEquipColor = 461, //自动回收的装备等级
    ConstValueType_AutoRecoverEquipLvl = 462, //自动回收装备需要人物等级
    ConstValueType_LuoLanGoldCastellanReward = 464, //罗兰金色城主奖励
    ConstValueType_LuoLanSilveryCastellanReward = 465, //罗兰银色城主奖励
    ConstValueType_SealTime = 472, //等级封印自然时间开始日期时间戳
    ConstValueType_ClearSuitEquipId = 474, //几阶装备以上合成不保留套装属性
    ConstValueType_SetRendezvousCD = 476, //群龙争霸集结点cd
    ConstValueType_HangerControlCheckCdTime = 477, //小秘书挂机野外托管重置CD检查是否有可执行的任务(秒)
    ConstValueType_HangerCheckCdTime = 478, //小秘书挂机托管检查CD(秒)
    ConstValueType_HangerPauseWaitTime = 479, //小秘书暂停等待时间(秒)
    ConstValueType_HangerMonthCardActive = 480, //月卡开启小秘书功能(0不开启1开启)
    ConstValueType_HitPowerParam = 481, //命中率乘方系数
    ConstValueType_ReturnPlayerBuffId = 482, //回流专属BuffID(组队经验加成)
    ConstValueType_ExpSealBuffId = 483, //经验印章BuffID(组队经验加成)
    ConstValueType_TeamBuffReqRate = 484, //组队Buff更新频率（秒）
    ConstValueType_BuffUIRefreshRate = 485, //Buff详细界面刷新频率（秒）
    ConstValueType_ReturnPlayerActivityCommentId = 486, //回流活动ID(勇者归来)
    ConstValueType_BattleConfigureOpenCost = 487, //战斗配置切换开启格子的5个条件
    ConstValueType_MarketMinPrice = 488, //交易行道具最低限价
    CostValueType_ChangeJobLevel = 489, //转换职业最低等级
    CostValueType_ChangeJobItems = 490, //转换消耗道具
    CostValueType_BackLevelGift = 491, //勇者归来礼包（等级）
    CostValueType_BackVipGift = 492, //勇者归来礼包（vip）
    ConstValueType_SoulBallWeight = 494, //魂珠洗练品质权重
    CostValueType_KillMonsterResumeCD = 495, //击杀怪物回复类属性内置cd(ms)
    CostValueType_KillRoleResumeCD = 496, //击杀玩家回复类属性内置cd(ms)
    CostValueType_MaxReAttrLockCount = 497, //最大再生属性锁定条数
    CostValueType_StrongestTeamCreateNeedLvl = 498, //最强战队创建战队所需角色等级
    CostValueType_StrongestTeamAppendNeedLvl = 499, //最强战队加入战队所需角色等级
    CostValueType_BetMoney = 510, //竞猜选择金额
    CostValueType_WinBetRatio = 512, //竞猜成功返还
    ConstValueType_WorldCupGuessReward = 513, //世界杯猜胜负奖励。道具id#道具数量|道具id#道具数量
    ConstValueType_WorldCupGuessGroupMatchTime = 514, //世界杯小组赛时间。开始时间#结束时间
    ConstValueType_WorldCupGuessGroupMatchFlowerNum = 515, //世界杯小组赛每日鲜花数
    ConstValueType_WorldCupGuess16and18Time = 516, //世界杯16强-8强时间。开始时间#结束时间
    ConstValueType_WorldCupGuess16and18FlowerNum = 517, //世界杯16强-8强每日鲜花数
    ConstValueType_WorldCupGuessSemifinalsTime = 518, //半决赛/决赛时间。开始时间#结束时间
    ConstValueType_WorldCupGuessSemifinalsFlowerNum = 519, //半决赛/决赛每日鲜花数
    ConstValueType_WorldCupChampoinItem = 520, //决赛道具id
    ConstValueType_ExpedtionSpeedUpItem = 525, //远征加速道具消耗(#分割)
    ConstValueType_ExpedtionSpeedUpTime = 526, //远征加速时间(秒)
    ConstValueType_ExpedtionFriendTime = 527, //远征协助加速时间(万分比)
    ConstValueType_ExpedtionEffectSpeedUpItem = 528, //远征效果加速道具消耗(#分割)
    ConstValueType_ExpedtionEffectSpeedUpTime = 529, //远征效果加速时间(秒)
    ConstValueType_ExpedtionAssistRewardTime = 530, //远征协助获取奖励次数
    ConstValueType_ExpedtionAssistRewardTicket = 531, //远征协助获取钻石数量
    ConstValueType_WorldCupStartEndTime = 534, //世界杯开始结束时间
    ConstValueType_WorldCupGuess8and4Time = 536, //世界杯8强时间。开始时间#结束时间
    ConstValueType_GuildAuctionRatio = 538, //战盟拍卖行税率(万分比)
    ConstValueType_EloMatchDay1 = 539, //新手天梯最大开服天数
    ConstValueType_EloMatchDay2 = 540, //中级天梯最大开服天数
    ConstValueType_GuildMercenaryHelpTimes = 543, //战盟佣兵每日可以求助次数
    ConstValueType_GuildMercenaryBeHelpTime = 544, //战盟佣兵冷却时间（秒）
    ConstValueType_ExpedtionStoreSpeedUpTime = 546, //远征仓库加速时间
    ConstValueType_ExpedtionFactorySpeedUpTime = 547, //远征工厂加速时间
    ConstValueType_DaLanChargeUrl = 598, //大蓝客户端充值url
    ConstValueType_DaLanIosChargeUrl = 599, //大蓝ios客户端充值url
    ConstValueType_DaLanIosChargeUrl2 = 595, //大蓝ios客户端充值url2
    ConstValueType_UnlockPetGroup = 606, //解锁宠物格子花费
    ConstValueType_GuildAuctionBonusLimitRatio = 611, //添加战盟分红总量上限倍率(万分位)
    ConstValueType_ActivityInstanceChaosType = 612, //跨区服活动副本
    ConstValueType_PVPInstanceChaosType = 613, //跨区服pvp副本
    ConstValueType_PetReliveMinLevel = 614, //宠物可重生最低等级
    ConstValueType_PetReliveLevelBackItemId = 615, //宠物重生返回经验物品道具
    ConstValueType_PetReliveLevelBackRatio = 616, //宠物重生等级折算比例(百分比)
    ConstValueType_PetReliveStepBackRatio = 617, //宠物重生进阶折算比例(百分比)
    ConstValueType_EloMatchDay = 624, //天梯分段。最大开服天数#最大开服天数
    ConstValueType_Elo2v2ID = 626, //天梯分段对应2v2副本id
    ConstValueType_Elo4v4ID = 628, //天梯分段对应幻影寺院副本id
    ConstValueType_Max = 635, //最大值，超过该值记得修改
};


