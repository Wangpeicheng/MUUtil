using UnityEngine;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Proto;
using System.Text;
using Net;
using ProtoBuf;
using System.Runtime.InteropServices;
using System.Linq;

public class ToolHelper : Singleton<ToolHelper>
{
    public string file;

    public void LoadConfigTable()
    {
        file = FileHelper.Instance.readOnlyPath + "text/";
#if UNITY_EDITOR||UNITY_STANDALONE_WIN
        file = Application.dataPath + "/StreamingAssets/" + FileHelper.Instance.RuntimePlat + "/text/";
#endif

        LoadData<BigMapInfo>(file);
    }

    void LoadData<T>(string file) where T : IInfo, new()
    {
        string fileName = file + typeof(T).ToString().ToLower() + ".bin";
        if (!File.Exists(fileName))
        {
            DebugUtil.LogError("file not exits:" + fileName);
            return;
        }

        InfoMgr<T>.Instance.Init(fileName);
    }
}