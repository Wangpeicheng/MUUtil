

// 状态类型
public enum StateTransType
{
    None = 0, //
    Login = 1, //角色登陆
    Login_Idel = 2, //选角待机
    Safe_Idle = 3, //（安全区）待机
    Safe_Walk = 4, //（安全区）行走
    Safe_Show1 = 5, //（安全区）待机表演一
    Safe_Show2 = 6, //（安全区）待机表演二
    No_Wing_Idle = 7, //（战斗区）无翅膀待机
    No_Wing_Walk = 8, //（战斗区）无翅膀跑步
    Wing_Idle = 9, //（战斗区）有翅膀待机
    Wing_Walk = 10, //（战斗区）有翅膀飞行
    Swim = 11, //（战斗区）游泳
    ShowIdel = 12, //怪物表演
    GetHit = 13, //普通受击
    HitBack = 14, //击退
    HitDownPre = 15, //击倒（从站立到倒地）
    HitDownLoop = 16, //击倒（倒地Loop)
    HitDownEnd = 17, //击倒（倒地起身)
    Dizzy = 18, //眩晕
    Death_Stand = 19, //站立时死亡
    Death_Down = 20, //倒地时死亡
    Relive = 21, //复活
    UnChooseIdel = 22, //未选中待机
    ChooseWingShow = 23, //选中表演（带翅膀）
    ChooseShow = 24, //选中表演（无翅膀）
    ChooseWingIdel = 25, //选中待机（带翅膀）
    ChooseIdel = 26, //选中待机（无翅膀）
    MountIdel = 27, //骑乘待机动作
    MountWalk = 28, //骑乘跑步动作
    Collect = 29, //采集动作
    Born = 30, //出生动作
    Attack1 = 31, //普攻1
    Attack2 = 32, //普攻2
    Attack3 = 33, //普攻3
    Attack4 = 34, //普攻4
    Attack5 = 35, //普攻5
    Skill1 = 36, //技能状态1
    Skill2 = 37, //技能状态2
    Skill3 = 38, //技能状态3
    Skill4 = 39, //技能状态4
    Skill5 = 40, //技能状态5
    Skill6 = 41, //技能状态6
    Skill7 = 42, //技能状态7
    Skill8 = 43, //技能状态8
};


