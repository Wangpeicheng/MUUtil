

// 帮会职务类型
public enum GuildPosition
{
    GuildPosition_None = 0, //候补成员
    GuildPosition_Normal = 100, //普通成员
    GuildPosition_Elite = 200, //精英
    GuildPosition_Presbyter = 300, //长老
    GuildPosition_DeputyLeader = 400, //副帮主
    GuildPosition_Leader = 500, //帮主
};

// 帮会操作类型
public enum GuildOptType
{
    GuildOptType_ChangeName = 1, //修改名字
    GuildOptType_ChangeContext = 2, //修改通告
    GuildOptType_ChangeLimitType = 3, //修改加入限制类型
    GuildOptType_ChangeLimitLevel = 4, //修改加入限制等级
    GuildOptType_ChangeBadge = 5, //修改徽章
    GuildOptType_KickMember = 6, //踢人
    GuildOptType_InviteJoin = 7, //邀请加入
    GuildOptType_AskJoinAccept = 8, //申请加入受理
    GuildOptType_LeaveGuild = 9, //离开帮会
    GuildOptType_ClearAskJoinAccept = 10, //清空申请加入表
    GuildOptType_ChangeLeader = 11, //转让会长
    GuildOptType_OpenInstance = 12, //副本开启
    GuildOptType_GrowUpLevel = 13, //升级帮会
    GuildOptType_ChangePosition = 14, //职务任免
    GuildOptType_GiveUpLeader = 15, //会长卸任
    GuildOptType_OpenGuardHome = 16, //开启守护家园
    GuildOptType_SendNotice = 17, //通告发送
    GuildOptType_ChangeDeclaration = 18, //修改宣言
    GuildOptType_BossControl = 19, //战盟Boss指挥
    GuildOptType_ManorDeclearWar = 20, //战盟领地宣战
};

// 帮会加入限制类型
public enum GuildLimitType
{
    GuildLimitType_NoLimit = 0, //自由加入
    GuildLimitType_LevelLimit = 1, //等级限制
};

// 帮会属性
public enum GuildAttr
{
    GuildAttr_GuildName = 1, //名称
    GuildAttr_LeaderName = 2, //帮主名
    GuildAttr_LeaderId = 3, //帮主角色编号
    GuildAttr_Context = 4, //公告
    GuildAttr_Level = 5, //等级
    GuildAttr_MemCount = 6, //成员总数
    GuildAttr_MemMaxCount = 7, //成员上限
    GuildAttr_PKPoint = 8, //战力值
    GuildAttr_LimitType = 9, //限制类型
    GuildAttr_LimitLevel = 10, //限制等级
    GuildAttr_BadgeId = 11, //徽章编号
    GuildAttr_Exp = 12, //经验
    GuildAttr_Money = 13, //金钱
    GuildAttr_Prestige = 14, //声望
    GuildAttr_Bonus = 15, //红利
    GuildAttr_BackUpMemCount = 16, //后备成员数
    GuildAttr_Declaration = 17, //宣言
    GuildAttr_PowerRankNum = 18, //战力排名
};

// 战盟排序类型
public enum GuildSortType
{
    GuildSortType_ID = 0, //Id
    GuildSortType_Level = 1, //等级
    GuildSortType_LimitLevel = 2, //限制等级
    GuildSortType_Power = 3, //战力
};

// 帮会成员属性
public enum GuildMemAttr
{
    GuildMemAttr_MemName = 1, //名称
    GuildMemAttr_Level = 2, //等级
    GuildMemAttr_Position = 3, //职务
    GuildMemAttr_Occupation = 4, //职业
    GuildMemAttr_PKPoint = 5, //战力值
    GuildMemAttr_CurContribution = 6, //成员总数
    GuildMemAttr_TotalContribution = 7, //成员上限
    GuildMemAttr_IsOnline = 8, //是否在线
    GuildMemAttr_LastLoginTime = 9, //最近登陆时间
    GuildMemAttr_HasSeekHelp = 10, //是否有求助
};

// 帮会事件类型
public enum GuildEventType
{
    GuildEventType_Create = 1, //帮会创建
    GuildEventType_MemberLeave = 2, //成员离开帮会
    GuildEventType_MemberJoin = 3, //成员加入帮会
    GuildEventType_Rename = 4, //帮会重命名
};

// 帮会捐献类型
public enum GuildContrType
{
    GuildContrType_Item = 1, //捐献物品
    GuildContrType_Cyanite = 2, //捐献水晶
    GuildContrType_Diamond = 3, //捐献钻石
};

// 战盟属性改变来源类型
public enum GuildAttrChgSrcType
{
    GuildAttrChgSrcType_None = 0, //默认类型
    GuildAttrChgSrcType_Instance = 1, //战盟副本
};


