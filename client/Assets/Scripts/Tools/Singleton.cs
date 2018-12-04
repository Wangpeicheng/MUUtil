
using UnityEngine;
using System.Collections;
using System;

public class Singleton<T> where T : new()
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
