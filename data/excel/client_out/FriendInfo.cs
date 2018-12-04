

// 聊天消息来源
public enum ChatFromType
{
    ChatFromType_None = 0, //
    ChatFromType_Self = 1, //自己发送消息
    ChatFromType_Friend = 2, //好友
    ChatFromType_Stranger = 3, //陌生人
};

// 存储数据是否变化
public enum DirtyChangeType
{
    DirtyChangeType_None = 0, //
    DirtyChangeType_Mail = 1, //邮件变化
    DirtyChangeType_Chat = 2, //消息变化
    DirtyChangeType_Session = 3, //是否未读消息
};

// 聊天消息时间显示
public enum ChatDate
{
    ChatDate_None = 0, //不显示时间
    ChatDate_CurrentDay = 1, //当前日期
    ChatDate_SameDay = 2, //过去时间同一天
    ChatDate_NewDay = 2, //与过去时间相比不是同一天
};


