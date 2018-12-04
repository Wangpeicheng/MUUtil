
using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using ProtoBuf;
using System.Runtime.Serialization.Formatters.Binary;
using Proto;

public class FileHelper
{
    public string datapath
    {
        get
        {
            return
#if  UNITY_ANDROID
   "jar:file://" + Application.dataPath + "!/assets/"+ RuntimePlat+"/";   
#elif UNITY_IPHONE
    "file://" + Application.dataPath + "/Raw/" + RuntimePlat + "/";
#else
 "file:///" + Application.dataPath + "/StreamingAssets/" + RuntimePlat + "/";
#endif
        }
    }



    public readonly string readOnlyPath = Application.persistentDataPath + "/";
    public readonly string savepath = Application.persistentDataPath + "/";

    private static FileHelper _instance;

    private FileHelper()
    {
#if UNITY_IPHONE
        if (1 == PlayerPrefs.GetInt("IOSAuditVersion"))
        {
             readOnlyPath = Application.streamingAssetsPath + "/" + RuntimePlat + "/";
        }
#elif UNITY_ANDROID
        readOnlyPath = savepath;
#elif UNITY_EDITOR || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
        readOnlyPath = Application.streamingAssetsPath + "/" + RuntimePlat + "/";
#endif
    }

    public static FileHelper Instance
    {
        get
        {
            if (null == _instance)
            {
                _instance = new FileHelper();
            }
            return _instance;
        }
        private set { _instance = value; }
    }


    public string RuntimePlat
    {
        get
        {
            string target = "pc";
#if UNITY_ANDROID
            target = "android";
#elif UNITY_IPHONE
            target = "ios";
#endif
            return target;
        }
    }

    public void Serialize<T>(T t, string path)
    {
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, t);
            stream.Flush();
            stream.Close();
        }
        catch (Exception e)
        {
            DebugUtil.LogError(e.Message);
        }
    }

    public T DeSerialize<T>(string path)
    {
        if (!File.Exists(path))
            return default(T);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            T t = (T)formatter.Deserialize(stream);
            stream.Flush();
            stream.Close();
            return t;
        }
        catch (Exception e)
        {
            DebugUtil.LogError(e.Message);
        }
        return default(T);
    }

    public void Delete(string path)
    {
        if (Directory.Exists(path))
        {
            //Debug.Log("delete DeletFolder" + path);
            Directory.Delete(path, true);
        }
        else
        {
            if (File.Exists(path))
            {
                //Debug.Log("delete file" + path);
                File.Delete(path);
            }
        }
    }

    public bool Exists(string path)
    {
        return File.Exists(path);
    }
}