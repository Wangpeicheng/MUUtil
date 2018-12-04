

// 拍卖种类
public enum AuctionClass
{
    AuctionClass_Guild = 0, //战盟拍卖
    AuctionClass_Global = 1, //全服拍卖
};

// 拍卖物品类型
public enum AuctionItemType
{
    AuctionItemType_SmpItem = 0, //简单道具
    AuctionItemType_Item = 1, //道具
    AuctionItemType_Pet = 2, //宠物
    AuctionItemType_Horse = 3, //坐骑
};

// 拍卖交易类型
public enum AuctionTradeType
{
    AuctionTradeType_Fixed = 0, //一口价成交
    AuctionTradeType_Compete = 1, //竞拍成交
    AuctionTradeType_AbortiveToGlobal = 2, //流拍至全服拍卖
};

// 拍卖活动类型
public enum AuctionActiveType
{
    AuctionActiveType_GuildBoss = 1, //魔龙讨伐
    AuctionActiveType_GuildInstance = 2, //魔物入侵
    AuctionActiveType_Kundun = 3, //昆顿降临
    AuctionActiveType_GuildManor = 5, //战盟领地
    AuctionActiveType_LuoLanIns = 6, //罗兰城战
    AuctionActiveType_DragonFightIns = 7, //跨服boss
    AuctionActiveType_GoldenCastleIns = 8, //黄金城堡
    AuctionActiveType_Max = 9, //拍卖活动最大值
};


