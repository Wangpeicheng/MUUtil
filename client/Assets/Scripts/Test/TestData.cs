using UnityEngine;
using System.Collections;

public class TestData : MonoBehaviour 
{
	void Start () 
    {
        ToolHelper.Instance.LoadConfigTable();
        foreach (var item in InfoMgr<BigMapInfo>.Instance.InfoDic)
        {
            DebugUtil.Log("big map id " + item.Value.ID + " nameid " + item.Value.nameLanID);
        }
	}
	

}
