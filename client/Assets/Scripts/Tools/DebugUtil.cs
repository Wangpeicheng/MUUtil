
using UnityEngine;
using System.Collections;
using System;
using System.IO;
using Proto;
using Net;
public class DebugUtil : MonoBehaviour
{
    public static DebugUtil Instance;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }



    public static void Log(string newString)
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.Log(newString + "   " + System.DateTime.Now);
        }
    }
    public static void LogWarning(string newString)
    {
        //#if UNITY_EDITOR||UNITY_STANDALONE_OSX||UNITY_STANDALONE_WIN
        //        if (windowText.Length > debuglen)
        //        {
        //            windowText = "";
        //        }
        //        windowText = windowText + "\n" + newString + " \nLogTime : " + System.DateTime.Now;
        //Debug.LogWarning(newString + "   " + System.DateTime.Now);
        //        //MiracleLog.Instance.Log("LogWarning:" + newString);
        //#endif
        /*
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.LogWarning(newString + "   " + System.DateTime.Now);
        }
        */
    }
    public static void LogError(string newString)
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.LogError(newString + "   " + System.DateTime.Now);
        }
    }

}

