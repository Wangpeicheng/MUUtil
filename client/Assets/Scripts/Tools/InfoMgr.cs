
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public interface IInfo
{

    void Load(BinaryReader reader);


    int GetKey();

    string ToString();
}

public class InfoMgr<T> where T : IInfo, new()
{
    private static InfoMgr<T> _instance;
    private Dictionary<int, T> _dic;


    public static InfoMgr<T> Instance
    {
        get
        {
            if (null == _instance)
            {
                _instance = new InfoMgr<T>();
            }
            return _instance;
        }

        private set { _instance = value; }
    }

    public Dictionary<int, T> InfoDic
    {
        get {
            if (_dic == null)
            {
                LoadData<T>(ToolHelper.Instance.file);
            }
            return _dic; 
        }
        set { _dic = value; }
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

    public bool Init(string file)
    {
        Clear();
       
        if (_dic == null)
        {
            _dic = new Dictionary<int, T>();
        }

        //BinaryReader reader = ReadFile(file);

        FileStream stream = File.OpenRead(file);
        BinaryReader reader = new BinaryReader(stream, System.Text.Encoding.UTF8);
        if (null == reader)
        {
            Console.WriteLine("ReadFile Failed.");
            if(null != stream)
            {
                stream.Close();
            }
            return false;
        }

        // ��ȡ��������
        int count = reader.ReadInt32();
        if (count == 0)
        {
            // ��
            stream.Close();
            reader.Close();
            return true;
        }
        for (uint i = 0; i < count; ++i)
        {
            T t = new T();
            t.Load(reader);
            int key = t.GetKey();
            if (_dic.ContainsKey(key))
            {
                Console.WriteLine("Key({0}) confilicated.", key);
                stream.Close();
                reader.Close();
                return false;
            }

            _dic[key] = t;
        }
    //    GC.Collect();
        stream.Close();
        reader.Close();
        return true;
    }

    public void Clear()
    {
        if (_dic != null)
        {
            _dic.Clear();
        }
    }

    public T GetInfo(int key)
    {
        if (_dic == null)
        {
            LoadData<T>(ToolHelper.Instance.file);
        }
        if (_dic.ContainsKey(key))
            return _dic[key];

        return default(T);
    }
}
