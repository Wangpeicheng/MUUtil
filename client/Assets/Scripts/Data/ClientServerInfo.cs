using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


public class ClientServerInfo: IInfo
{
    public int id; // id
    public string host; // host
    public int port; // port

    public  void Load(BinaryReader reader)
    {
    }

    public  int GetKey()
    {
        return id;
    }

}
