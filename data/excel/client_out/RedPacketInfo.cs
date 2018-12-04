

// 红包原因类型
public enum RedPacketType
{
    RedPacketType_Charge = 1, //付费冲值
    RedPacketType_Achieventment = 2, //完成成就
};

// 红包状态
public enum RedPacketState
{
    RedPacketState_NotGiveOut = 0, //未发送
    RedPacketState_GiveOut = 1, //已发送
    RedPacketState_TimeOut = 2, //已过期
    RedPacketState_GiveOutEnd = 3, //发放结束
};

// 红包记录类型
public enum RedPacketRecordType
{
    RedPacketRecordType_GiveOut = 0, //红包发放
    RedPacketRecordType_End = 1, //红包结束
};


