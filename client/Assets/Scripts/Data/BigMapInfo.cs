using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


[Serializable]
public class BigMapInfo: IInfo
{
    public int ID; // ID
    public string mapName; // 地图名称
    public int isPlayingQuit; // 是否允许中途退出
    public int isShowQuitBtn; // 显示离开按钮
    public int isCreateTeam; // 是否允许创建队伍
    public int isJoinTeam; // 是否允许加入队伍
    public int isLeaveTeam; // 是否允许离开队伍
    public int isRemoveTeam; // 是否允许踢出队伍
    public int isHang; // 是否可挂机
    public int isSameMapHang; // 同屏挂机
    public int isSameScreenHang; // 全屏挂机
    public int attackPriorityId; // 攻击优先级ID
    public int isAffectBySystemSetting; // 挂机受系统设置影响
    public int isPkModeLock; // PK模式锁定
    public int isAllowPlaceRelive; // 是否允许原地复活
    public string reliveType; // 允许复活类型
    public string cameraFx; // 镜头特效路径
    public int isShowDamageNumber; // 伤害数字是否正常显示
    public int openLev; // 允许进入最低等级限制
    public int isShowCountDonw; // 是否开启倒计时
    public int iscanswim; // 战斗区是否游泳
    public int isAllowTransOccup; // 是否允许转职
    public int isAllowShowPet; // 是否允许宠物出现
    public int isAllowShowSprite; // 是否允许精灵出现
    public int isShieldWing; // 是否屏蔽翅膀
    public int isRecordHangExp; // 是否记录挂机经验
    public int miniMapScale; // 小地图坐标缩放
    public int isMini; // 是否有小地图标识
    public int recoverBuff; // 战场恢复BUFF
    public int canMount; // 是否允许上马
    public string reliveTime; // 复活时间
    public string areaName; // 对应世界地图区域
    public int loading; // 地图loading
    public int showNameType; // 玩家名字显示类型
    public int showBloodType; // 玩家血条显示类型
    public int isShowUnionName; // 是否显示战盟名字
    public int isShowTitle; // 是否显示称号
    public int isShowHonor; // 是否显示头衔
    public int otherRoleEffectNum; // 显示其他角色技能特效数量
    public int paramX; // 镜头参数X
    public int RotateY; // Top相机旋转Y
    public int isCanCatchHorse; // 是否允许出现读条按钮
    public int quitId; // 退出提示LanID
    public int chatposFind; // 是否允许跳转寻路
    public int isStoryMap; // 是否副本地图
    public int isUseEmergencyBlood; // 是否使用血瓶
    public int isPopInteraction; // 是否弹出玩家交互UI
    public int reliveAutoAttackTime; // 死亡复活自动挂机
    public int idleAutoAttackTime; // 长时间待机自动挂机
    public int nameLanID; // 地图名称id
    public string Icon; // 右侧图片
    public int canTransformer; // 是否可变身
    public int IsCrossServer; // 是否跨服
    public int IsHangerMap; // 小秘书挂机点

    public  void Load(BinaryReader reader)
    {
        ID = reader.ReadInt32();
 
        int mapNameLen = reader.ReadInt32();
        mapName = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(mapNameLen));
 
        isPlayingQuit = reader.ReadInt32();
 
        isShowQuitBtn = reader.ReadInt32();
 
        isCreateTeam = reader.ReadInt32();
 
        isJoinTeam = reader.ReadInt32();
 
        isLeaveTeam = reader.ReadInt32();
 
        isRemoveTeam = reader.ReadInt32();
 
        isHang = reader.ReadInt32();
 
        isSameMapHang = reader.ReadInt32();
 
        isSameScreenHang = reader.ReadInt32();
 
        attackPriorityId = reader.ReadInt32();
 
        isAffectBySystemSetting = reader.ReadInt32();
 
        isPkModeLock = reader.ReadInt32();
 
        isAllowPlaceRelive = reader.ReadInt32();
 
        int reliveTypeLen = reader.ReadInt32();
        reliveType = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(reliveTypeLen));
 
        int cameraFxLen = reader.ReadInt32();
        cameraFx = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(cameraFxLen));
 
        isShowDamageNumber = reader.ReadInt32();
 
        openLev = reader.ReadInt32();
 
        isShowCountDonw = reader.ReadInt32();
 
        iscanswim = reader.ReadInt32();
 
        isAllowTransOccup = reader.ReadInt32();
 
        isAllowShowPet = reader.ReadInt32();
 
        isAllowShowSprite = reader.ReadInt32();
 
        isShieldWing = reader.ReadInt32();
 
        isRecordHangExp = reader.ReadInt32();
 
        miniMapScale = reader.ReadInt32();
 
        isMini = reader.ReadInt32();
 
        recoverBuff = reader.ReadInt32();
 
        canMount = reader.ReadInt32();
 
        int reliveTimeLen = reader.ReadInt32();
        reliveTime = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(reliveTimeLen));
 
        int areaNameLen = reader.ReadInt32();
        areaName = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(areaNameLen));
 
        loading = reader.ReadInt32();
 
        showNameType = reader.ReadInt32();
 
        showBloodType = reader.ReadInt32();
 
        isShowUnionName = reader.ReadInt32();
 
        isShowTitle = reader.ReadInt32();
 
        isShowHonor = reader.ReadInt32();
 
        otherRoleEffectNum = reader.ReadInt32();
 
        paramX = reader.ReadInt32();
 
        RotateY = reader.ReadInt32();
 
        isCanCatchHorse = reader.ReadInt32();
 
        quitId = reader.ReadInt32();
 
        chatposFind = reader.ReadInt32();
 
        isStoryMap = reader.ReadInt32();
 
        isUseEmergencyBlood = reader.ReadInt32();
 
        isPopInteraction = reader.ReadInt32();
 
        reliveAutoAttackTime = reader.ReadInt32();
 
        idleAutoAttackTime = reader.ReadInt32();
 
        nameLanID = reader.ReadInt32();
 
        int IconLen = reader.ReadInt32();
        Icon = System.Text.Encoding.UTF8.GetString(reader.ReadBytes(IconLen));
 
        canTransformer = reader.ReadInt32();
 
        IsCrossServer = reader.ReadInt32();
 
        IsHangerMap = reader.ReadInt32();
 
    }

    public  int GetKey()
    {
        return ID;
    }

}
