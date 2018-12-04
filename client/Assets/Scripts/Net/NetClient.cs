
using System.Collections;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System;
using System.IO;
using ProtoBuf;
using WorldSvr;
using ClientServer;

namespace ClientServer
{

}

namespace Net
{

    public class NetClient
    {

        [DllImport("__Internal")]
        public static extern string getIPv6(string mHost, string mPort);

        public static string GetIPv6(string host, string port)
        {
            string ip = string.Empty;
#if UNITY_IPHONE 
			ip = getIPv6(host,port);
#else
            ip = host + "&&ipv4";
#endif
            return ip;
        }

        public void GetIPType(string serverIp, string serverPorts, out string newServerIp, out AddressFamily newIPType)
        {
            newIPType = AddressFamily.InterNetwork;
            newServerIp = serverIp;
            try
            {
                string mIPv6 = GetIPv6(serverIp, serverPorts);
                if (!string.IsNullOrEmpty(mIPv6))
                {
                    string[] m_StrTemp = System.Text.RegularExpressions.Regex.Split(mIPv6, "&&");
                    if (m_StrTemp != null && m_StrTemp.Length >= 2)
                    {
                        string IPType = m_StrTemp[1];
                        if (IPType == "ipv6")
                        {
                            newServerIp = m_StrTemp[0];
                            newIPType = AddressFamily.InterNetworkV6;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                DebugUtil.Log("GetIPv6 error:" + e);
            }
        }




        public string ip = "192.168.1.245";
        public int port = 889000;
        public uint Opentime;
        public uint svrFlag;
        public const short HEADER_LENGTH = 6; //包头的长度
        public const short HEADER_SERVER_LEN = 4;
        public const int DefaultBufferSize = 1024;
        public byte[] m_RecvDataBuffer = new byte[DefaultBufferSize];
        public byte[] m_TotalBuffer = new byte[DefaultBufferSize];
        public byte[] m_RecvDataBuffer_WorldServer = new byte[DefaultBufferSize];
        public byte[] m_TotalBuffer_WorldServer = new byte[DefaultBufferSize];
        public int m_iRcvLength = 0;
        public int m_iRcvSerLen = 0;
        public STATUS m_Status = STATUS.kReady;
        public Socket m_socket;
        public Socket m_socketclient;
        public Action<int> showPingCallBack;
        public float pingStartTime;
        public float receiveTime;
        public float pingEndTime;
        public const int maxSerId = 65535;
        public const int minSerId = 1;
        public int lastSerId = 0;
        public int LastSerId
        {
            get { return lastSerId; }
            set { lastSerId = value; }
        }
        public int MinSerId
        {
            get { return minSerId; }
        }
        public int MaxSerId
        {
            get { return maxSerId; }
        }
        public float PingEndTime
        {
            get { return pingEndTime; }
            set { pingEndTime = value; }
        }
        public bool isConnected = false;
        public bool IsConnected
        {
             get { return isConnected && (null != m_socket && m_socket.Connected); }
             set { isConnected = value; }
        }
        public float ReceiveTime
        {
            get
            {
                return receiveTime;
            }
        }
        public Action connectedAct;
        public bool needReconnect = false;
        public int ping;

        public bool NeedReconnect
        {
            get { return needReconnect; }
            set
            {
                if (needReconnect != value)
                {
                    needReconnect = value;
                }
            }
        }

        public int Ping
        {
            get
            {
                return ping;
            }
            set
            {
                ping = value;
                if (showPingCallBack != null)
                    showPingCallBack(ping);
            }
        }
        public float PingStartTime
        {
            get
            {
                return pingStartTime;
            }
        }
        public static NetClient instance;
        public NetClient() { }
        public static NetClient Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new NetClient();
                }
                return instance;
            }
            set { instance = value; }
        }

        //关闭连接
        public void Close(bool bForceClose = false)
        {
            if (STATUS.kReady == m_Status && !bForceClose)
            {
                IsConnected = false;
                return;
            }
            //--MiracleEventCenter.Instance.Publish<MiracleConnectServerEvent>(null, new MiracleConnectServerEvent(false, Opentime));
            UnityEngine.Debug.LogError("Socket Connect Close!~");

            try
            {
                if (null != m_socket)
                {
                    if (STATUS.kConnected == m_Status)
                    {
                        if (m_socket.Connected)
                        {
                            m_socket.Shutdown(SocketShutdown.Both);
                        }
                        else
                        {
                            m_socket.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                DebugUtil.Log(e.ToString());
            }
            finally
            {
                if (null != m_socket)
                {
                    m_socket.Close();
                    m_socket = null;
                }
                m_Status = STATUS.kReady;
                IsConnected = false;
                //--MiracleGameManager.Instance.needCheckNetWorkStatus = true;
                m_iRcvLength = 0;
                m_iRcvSerLen = 0;
                Array.Clear(m_RecvDataBuffer, 0, m_RecvDataBuffer.Length);
                Array.Clear(m_TotalBuffer, 0, m_TotalBuffer.Length);
                EventDispatcher.Instance.queue.Clear();
            }
        }

        /// <summary>
        /// Creates the socket.
        /// </summary>
        /// <returns>The socket.</returns>
        /// <param name="host">Host.</param>
        /// <param name="port">Port.</param>
        public Socket CreateSocket(ref string host, int port)
        {
            string newHost = string.Empty;
            AddressFamily newAddressFamily = AddressFamily.InterNetwork;
            //获得ip type
            GetIPType(host, port.ToString(), out newHost, out newAddressFamily);

            if (!string.IsNullOrEmpty(newHost))
            {
                host = newHost;
            }

            return new Socket(newAddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(string host, int port, Action action = null)
        {
            if (STATUS.kReady != m_Status)
            {
                if (null != m_socket)
                {
                    if (STATUS.kConnected == m_Status)
                    {
                        if (m_socket.Connected)
                        {
                            m_socket.Shutdown(SocketShutdown.Both);
                            m_socket.Disconnect(true);
                        }
                    }
                    m_socket.Close();
                    m_socket = null;
                }
            }
            LastSerId = 0;
            Array.Clear(m_RecvDataBuffer, 0, m_RecvDataBuffer.Length);
            Array.Clear(m_TotalBuffer, 0, m_TotalBuffer.Length);

            IPAddress address;
            if (!IPAddress.TryParse(host, out address))
            {
                try
                {

                    var hostAll = Dns.GetHostAddresses(host);
                    if (hostAll.Length > 0)
                    {
                        address = hostAll[0];
                        host = address.ToString();
                    }
                    else
                    {
                        DebugUtil.Log("NDS Get Host is null");

                    }
                }
                catch (Exception ex)
                {
                    DebugUtil.LogError(ex.Message);
                }

            }
            else
            {
                address = IPAddress.Parse(host);

            }

            m_socket = CreateSocket(ref host, port);
            m_Status = STATUS.kConnecting;
            IPEndPoint iep = new IPEndPoint(address, port);
            connectedAct = action;
            m_socket.BeginConnect(iep, new AsyncCallback(Connected), m_socket);
        }

        public void Connected(IAsyncResult iar)
        {
            Socket sock = (Socket)iar.AsyncState;

            if (m_socket != null && m_socket == sock && m_socket.Connected)
            {
                bool success = true;
                try
                {
                    m_socket.EndConnect(iar);
                }
                catch (Exception ex)
                {
                    Close();
                    success = false;
                }

                //--MiracleGameManager.Instance.needCheckNetWorkStatus = true;
                if (success)
                {
                    m_Status = STATUS.kConnected;
                    IsConnected = true;
                    if (connectedAct != null)
                    {
                        connectedAct();
                        connectedAct = null;
                    }
                    StartReceiving();
                    NeedReconnect = true;
                }
                else
                {
                    DebugUtil.LogError("Connected Error::   " + success.ToString());
                }
                //--MiracleEventCenter.Instance.Publish<MiracleConnectServerEvent>(null, new MiracleConnectServerEvent(success, Opentime));
            }
            else
            {
                DebugUtil.LogError("Connected Error!!socket not connected!");
                Close();
                //Connect(ip, port);
            }
        }

        public void StartReceiving()
        {
            if (m_socket != null && m_socket.Connected)
            {
                try
                {
                    m_socket.BeginReceive(m_RecvDataBuffer, 0, DefaultBufferSize, SocketFlags.None, new AsyncCallback(RecvData), m_socket);
                }
                catch (System.Exception ex)
                {
                    DebugUtil.Log(ex.ToString());
                    Close();
                }
            }
            else
            {
                DebugUtil.LogError("Connected Error!");
            }
        }

        public void RefreshTime()
        {
            pingStartTime = UnityEngine.Time.realtimeSinceStartup;
            receiveTime = UnityEngine.Time.realtimeSinceStartup;
        }
        public void StartPing()
        {
            pingStartTime = UnityEngine.Time.realtimeSinceStartup;
        }
        public void EndPing()
        {
            receiveTime = UnityEngine.Time.realtimeSinceStartup;
            pingEndTime = UnityEngine.Time.realtimeSinceStartup;
            Ping = (int)((receiveTime - pingStartTime) * 0.5f * 1000);
        }

        public void RecvData(IAsyncResult iar)
        {
            lock (this)
            {
                try
                {
                    Socket socket = (Socket)iar.AsyncState;

                    if (m_socket == null || m_socket != socket)
                        return;
                    int recv = socket.EndReceive(iar);
                    if (recv > 0)
                    {
                        RevPacketDeal(recv);
                        //继续接收数据
                        // m_socket.BeginReceive(m_RecvDataBuffer, m_iRcvLength, DefaultBufferSize - m_iRcvLength, SocketFlags.None, new AsyncCallback(RecvData), null);
                        StartReceiving();
                    }
                }
                catch (Exception ex)
                {
                    // 加入socket关闭事件
                    DebugUtil.LogError(ex.Message);
                    Close();
                }
            }
        }

        public int OnCheckPacket(ref byte[] data, int revLen, bool hasSerId)
        {
            UInt16 packet_len = 0;
            if (hasSerId)
            {
                //前4个字节记录长度+协议ID，传输协议内容
                if (revLen < HEADER_LENGTH)
                {
                    //数据包头还没有到齐;
                    return -3;
                }

                packet_len = WatchUInt16Head(data, 0);

                if (revLen - HEADER_LENGTH < packet_len)
                {
                    //数据包还没有到齐;
                    return -2;
                }

                //还有包为收完
                if (packet_len > m_TotalBuffer.Length)
                {
                    return -1;
                }
            }
            else
            {
                //前4个字节记录长度+协议ID，传输协议内容
                if (revLen < HEADER_SERVER_LEN)
                {
                    //数据包头还没有到齐;
                    return -3;
                }

                packet_len = WatchUInt16Head(data, 0);

                if (revLen - HEADER_SERVER_LEN < packet_len)
                {
                    //数据包还没有到齐;
                    return -2;
                }

                //还有包为收完
                if (packet_len > m_TotalBuffer_WorldServer.Length)
                {
                    return -1;
                }
            }


            return (int)packet_len;
        }

        //暂定2个字节长度的包头,读取消息长度（2字节长度）
        public UInt16 WatchUInt16Head(byte[] data, int pos)
        {
            return (UInt16)(data[pos] << 8 | data[pos + 1]);
        }

        //读取消息长度(4字节长度)
        public UInt32 WatchUInt32Head(byte[] data, int pos)
        {
            return (UInt32)(data[pos] << 24 | data[pos + 1] << 16 | data[pos + 2] << 8 | data[pos + 3]);
        }

        public void SendData(byte[] bytes, bool load = true)
        {
            //--if (SDKController.Instance.IsGuideStoryOpen)
                SendToClientServer(bytes);

            if (STATUS.kConnected != m_Status)
            {
                //DebugUtil.Log("Send Error, STATUS.kConnected:" + m_Status.ToString());
                //--MiracleEventCenter.Instance.Publish<MiracleSocketEvt>(null, new MiracleSocketEvt());
                Close();
                return;
            }

            //if (load)
            //{
            //    MiracleUIManager.Instance.ShowPanel(MiracleEnumType.UIType.UILoading, Vector3.zero, false);
            //}

            try
            {
                if (m_socket.Connected)
                {
                    ushort id = WatchUInt16Head(bytes, 2);
                    if (id != 605 && id != 113)
                    {
                        DebugUtil.Log("Send ID: " + id.ToString());
                    }
                    m_socket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, new AsyncCallback(SendDataEnd), null);
                }
                else
                {
                    DebugUtil.LogError("socket Connect fail");
                    IsConnected = false;
                    //--MiracleEventCenter.Instance.Publish<MiracleSocketEvt>(null, new MiracleSocketEvt());
                }
            }
            catch (Exception ex)
            {
                DebugUtil.LogError(ex.StackTrace + " -- " + ex.Message);
                Close();
            }
        }

        public void SendDataEnd(IAsyncResult iar)
        {
            try
            {
                m_socket.EndSend(iar);
            }
            catch (Exception e)
            {
                DebugUtil.Log(e.ToString());
                Close();
            }
        }

        public void EndConnect()
        {
            NeedReconnect = false;
            if (STATUS.kReady == m_Status)
            {
                IsConnected = false;
                return;
            }
            try
            {
                if (null != m_socket)
                {
                    if (STATUS.kConnected == m_Status)
                    {
                        if (m_socket.Connected)
                        {
                            m_socket.Shutdown(SocketShutdown.Both);
                        }
                        else
                        {
                            m_socket.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                DebugUtil.Log(e.ToString());
            }
            finally
            {
                if (null != m_socket)
                {
                    m_socket.Close();
                    m_socket = null;
                }
                m_Status = STATUS.kReady;
                IsConnected = false;
            }
        }


        #region 获取服务器
        public List<ClientServerInfo> info = new List<ClientServerInfo>();
        public bool isBeginSend = false;
        //public bool isApplicationPlay = true;
        public  int currentindex = 0;


        public void ConnectAimServer(ClientServerInfo temp, int index)
        {
            //if (!isApplicationPlay) return;
            // 首先判断是ip地址还是域名。
            string host = temp.host;
            IPAddress address;
            if (!IPAddress.TryParse(temp.host, out address))
            {
                try
                {
                    var hostAll = Dns.GetHostAddresses(temp.host);
                    if (hostAll.Length > 0)
                    {
                        address = hostAll[0];
                        host = address.ToString();
                    }
                    else
                    {
                        DebugUtil.Log("NDS Get Host is null");

                    }
                }
                catch (Exception ex)
                {
                    DebugUtil.LogError(ex.Message);
                    ConnectAimServer((currentindex + 1) % info.Count);
                }

            }
            else
            {
                address = IPAddress.Parse(host);

            }

            m_socketclient = CreateSocket(ref host, temp.port);
            //DebugUtil.Log("<color=green>ConnectServerAim ip " + host + " port " + temp.port + "</color>");
            IPEndPoint iep = new IPEndPoint(address, temp.port);
            m_RecvDataBuffer_WorldServer = new byte[DefaultBufferSize];
            IAsyncResult result = m_socketclient.BeginConnect(iep, new AsyncCallback(ConnectCallBack), m_socketclient);
            if (!result.AsyncWaitHandle.WaitOne(5000, false))
            {
                CloseSocket();
               // if (info.Count > currentindex + 1)
                { ConnectAimServer((currentindex + 1)%info.Count); }

                //else
                //{ 
                //   // ConnectAimServer(currentindex + 1 - info.Count); 
                //   // DebugUtil.LogError("连接目录服务器出错");
                //}
            }

        }
        //public bool isConnectFail = false;
        int tryConnectNum = 0;
        public void ConnectAimServer(int index)
        {
            if (++tryConnectNum > info.Count)
            {
                tryConnectNum = 0;
                //--MiracleUIManager.Instance.OpenServerFlower();
                return;

            }
            currentindex = index;
            ConnectAimServer(info[index], index);
        }
        public byte[] GetData_ClientServerlist<CmdClientWorldServerListReq>(CmdClientWorldServerListReq req)
        {
            using (MemoryStream m = new MemoryStream())
            {
                Serializer.Serialize<CmdClientWorldServerListReq>(m, req);
                byte[] bytes = m.ToArray();
                byte[] contents = MessageHelper.Instance.MakePacket((UInt16)CmdClientWorld.CmdClientWorld_ServerListReq, bytes);
                return contents;
            }
        }
        public void ConnectCallBack(IAsyncResult iar)
        {
            if (m_socketclient != null && m_socketclient.Connected)
            {
                bool success = true;
                try
                {
                    m_socketclient.EndConnect(iar);
                }
                catch (Exception ex)
                {
                    DebugUtil.LogError(ex.Message);
                    success = false;
                }

                if (!success)
                {
                    CloseSocket();
                    //isConnectFail = true;
                    if (info.Count > currentindex + 1)
                        ConnectAimServer(currentindex + 1);
                    else
                        ConnectAimServer(currentindex + 1 - info.Count);
                }
                else
                {
                    try
                    {
                        tryConnectNum = 0;
                        m_socketclient.BeginReceive(m_RecvDataBuffer_WorldServer, 0, DefaultBufferSize, SocketFlags.None, new AsyncCallback(RecvDataClient), null);
                    }
                    catch (System.Exception ex)
                    {
                        DebugUtil.Log(ex.Message);
                        CloseSocket();
                    }
                    CmdClientWorldServerListReq req = new CmdClientWorldServerListReq();
                    req.chanel = 1;
                    req.userId = new byte[2] { 0, 1 };
                    req.hversion = 1;
                    req.mversion = 1;
                    req.lversion = 1;
                    byte[] bytes = GetData_ClientServerlist<CmdClientWorldServerListReq>(req);
                    try
                    {
                        if (m_socketclient.Connected)
                        {
                            //DebugUtil.LogError("开始发送");
                            ushort id = WatchUInt16Head(bytes, 2);
                            m_socketclient.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, new AsyncCallback(SendDataEnd_client), null);
                            isBeginSend = true;
                        }
                        else
                        {
                            DebugUtil.LogError("socket Connect fail");
                            //MiracleEventCenter.Instance.Publish<MiracleSocketEvt>(null, new MiracleSocketEvt());
                        }
                    }
                    catch (Exception ex)
                    {
                        DebugUtil.LogError(ex.StackTrace + " -- " + ex.Message);
                        CloseSocket();
                    }
                }
            }
            else
            {
                CloseSocket();
                //DebugUtil.LogError("连接超时");
                //isConnectFail = true;
                if (info.Count > currentindex + 1)
                    ConnectAimServer(currentindex + 1);
                else
                    ConnectAimServer(currentindex + 1 - info.Count);
            }
        }
        void SendDataEnd_client(IAsyncResult iar)
        {
            try
            {
                int len = m_socketclient.EndSend(iar);
            }
            catch (Exception e)
            {
                DebugUtil.Log(e.ToString());
            }
        }
        public void RecvDataClient(IAsyncResult iar)
        {
            lock (this)
            {
                try
                {
                    int recv = m_socketclient.EndReceive(iar);
                    //DebugUtil.LogError("EndReceive");

                    if (recv > 0)
                        RevPacketDeal_WorldServer(recv);
                    try
                    {
                        //DebugUtil.LogError("开始接收");
                        m_socketclient.BeginReceive(m_RecvDataBuffer_WorldServer, 0, DefaultBufferSize, SocketFlags.None, new AsyncCallback(RecvDataClient), null);
                    }
                    catch (System.Exception ex)
                    {
                        DebugUtil.Log(ex.Message);
                        CloseSocket();
                    }
                }
                catch (Exception ex)
                {
                    // 加入socket关闭事件
                    DebugUtil.LogError(ex.Message);
                    CloseSocket();
                }
            }
        }
        public void CloseSocket()
        {
            try
            {
                if (m_socketclient != null && m_socketclient.Connected)
                {
                    //LingerOption lo = new LingerOption(true, 0);
                    //m_socketclient.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.DontLinger, true);
                    m_socketclient.Shutdown(SocketShutdown.Both);
                    m_socketclient.Disconnect(true);
                }
            }
            catch (Exception e)
            {
                DebugUtil.Log(e.ToString());
            }
            finally
            {
                if (null != m_socketclient)
                {
                    m_socketclient.Close(0);
                    m_socketclient = null;
                }
            }
        }
        #endregion

        public  void RevPacketDeal(int recv)
        {
            if (recv <= 0)
            {
                //--MiracleEventCenter.Instance.Publish<MiracleSocketEvt>(null, new MiracleSocketEvt());
                DebugUtil.LogError("Net Error");
                return;
                //throw new Exception("Net Error");
            }

            m_iRcvLength += recv;

            if (m_iRcvLength <= DefaultBufferSize)
            {
                Buffer.BlockCopy(m_RecvDataBuffer, 0, m_TotalBuffer, m_iRcvLength - recv, recv);
                Array.Clear(m_RecvDataBuffer, 0, m_RecvDataBuffer.Length);
                if (m_TotalBuffer.Length > DefaultBufferSize)
                {
                    Buffer.BlockCopy(m_TotalBuffer, 0, m_RecvDataBuffer, 0, m_iRcvLength);
                    m_TotalBuffer = new byte[DefaultBufferSize];
                    Buffer.BlockCopy(m_RecvDataBuffer, 0, m_TotalBuffer, 0, m_iRcvLength);
                    Array.Clear(m_RecvDataBuffer, 0, m_RecvDataBuffer.Length);
                }
            }
            else//超出长度
            {
                byte[] temp = new byte[m_iRcvLength - recv];
                Buffer.BlockCopy(m_TotalBuffer, 0, temp, 0, temp.Length);
                Array.Clear(m_TotalBuffer, 0, m_TotalBuffer.Length);
                m_TotalBuffer = new byte[m_iRcvLength];
                Buffer.BlockCopy(temp, 0, m_TotalBuffer, 0, temp.Length);
                Buffer.BlockCopy(m_RecvDataBuffer, 0, m_TotalBuffer, temp.Length, recv);
                Array.Clear(m_RecvDataBuffer, 0, m_RecvDataBuffer.Length);
                temp = null;
            }

            while (true)
            {
                int iPacketLength = OnCheckPacket(ref m_TotalBuffer, m_iRcvLength, true); //返回包体的长度

                //包的正常长度
                if (iPacketLength >= 0)
                {
                    //包接受完毕,数据处理
                    NetMsg msg = MessageHelper.Instance.ParserPacket(m_TotalBuffer, iPacketLength, true);
                    EventDispatcher.Instance.InsertMsg(msg);
                    m_iRcvLength -= (iPacketLength + HEADER_LENGTH);

                    byte[] bufferData = new byte[m_iRcvLength];
                    Buffer.BlockCopy(m_TotalBuffer, iPacketLength + HEADER_LENGTH, bufferData, 0, bufferData.Length);
                    Array.Clear(m_TotalBuffer, 0, m_TotalBuffer.Length);
                    Buffer.BlockCopy(bufferData, 0, m_TotalBuffer, 0, bufferData.Length);

                    //长度为0，包体无内容
                    if (m_iRcvLength == 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }
        }

        public void RevPacketDeal_WorldServer(int recv)
        {
            if (recv <= 0)
            {
                m_socketclient.Close();
            }

            m_iRcvSerLen += recv;

            if (m_iRcvSerLen <= DefaultBufferSize)
            {
                Buffer.BlockCopy(m_RecvDataBuffer_WorldServer, 0, m_TotalBuffer_WorldServer, m_iRcvSerLen - recv, recv);
                Array.Clear(m_RecvDataBuffer_WorldServer, 0, m_RecvDataBuffer_WorldServer.Length);
                if (m_TotalBuffer_WorldServer.Length > DefaultBufferSize)
                {
                    Buffer.BlockCopy(m_TotalBuffer_WorldServer, 0, m_RecvDataBuffer_WorldServer, 0, m_iRcvSerLen);
                    m_TotalBuffer_WorldServer = new byte[DefaultBufferSize];
                    Buffer.BlockCopy(m_RecvDataBuffer_WorldServer, 0, m_TotalBuffer_WorldServer, 0, m_iRcvSerLen);
                    Array.Clear(m_RecvDataBuffer_WorldServer, 0, m_RecvDataBuffer_WorldServer.Length);
                }
            }
            else//超出长度
            {
                byte[] temp = new byte[m_iRcvSerLen - recv];
                Buffer.BlockCopy(m_TotalBuffer_WorldServer, 0, temp, 0, temp.Length);
                Array.Clear(m_TotalBuffer_WorldServer, 0, m_TotalBuffer_WorldServer.Length);
                m_TotalBuffer_WorldServer = new byte[m_iRcvSerLen];
                Buffer.BlockCopy(temp, 0, m_TotalBuffer_WorldServer, 0, temp.Length);
                Buffer.BlockCopy(m_RecvDataBuffer_WorldServer, 0, m_TotalBuffer_WorldServer, temp.Length, recv);
                Array.Clear(m_RecvDataBuffer_WorldServer, 0, m_RecvDataBuffer_WorldServer.Length);
                temp = null;
            }

            while (true)
            {
                int iPacketLength = OnCheckPacket(ref m_TotalBuffer_WorldServer, m_iRcvSerLen, false); //返回包体的长度

                //包的正常长度
                if (iPacketLength >= 0)
                {
                    //包接受完毕,数据处理
                    NetMsg msg = MessageHelper.Instance.ParserPacket(m_TotalBuffer_WorldServer, iPacketLength, false);
                    EventDispatcher.Instance.InsertMsg(msg);
                    m_iRcvSerLen -= (iPacketLength + HEADER_SERVER_LEN);

                    byte[] bufferData = new byte[m_iRcvSerLen];
                    Buffer.BlockCopy(m_TotalBuffer_WorldServer, iPacketLength + HEADER_SERVER_LEN, bufferData, 0, bufferData.Length);
                    Array.Clear(m_TotalBuffer_WorldServer, 0, m_TotalBuffer_WorldServer.Length);
                    Buffer.BlockCopy(bufferData, 0, m_TotalBuffer_WorldServer, 0, bufferData.Length);

                    //长度为0，包体无内容
                    if (m_iRcvSerLen == 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }
        }

        public void SendToClientServer(byte[] rev)
        {
            NetMsg msg = MessageHelper.Instance.ParserPacket(rev, rev.Length - HEADER_SERVER_LEN, false);
            //--MiracleClientServer.Instance.RevClientMsg(msg);
        }

        public void RevClientServer(byte[] rev)
        {
            NetMsg msg = MessageHelper.Instance.ParserPacket(rev, rev.Length - HEADER_SERVER_LEN, false);
            EventDispatcher.Instance.InsertMsg(msg);
        }

        public enum STATUS
        {
            kReady,
            kConnecting,
            kConnected
        };
    }
}