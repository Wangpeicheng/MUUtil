
using UnityEngine;
using System.Collections;
using System;
using System.IO;
using ProtoBuf;
using Proto;

namespace Net
{
    public class MessageHelper
    {
        private static MessageHelper _instance;

        private MessageHelper() { }

        public static MessageHelper Instance
        {
            get
            {
                lock (typeof(MessageHelper))
                {
                    if (null == _instance)
                    {
                        _instance = new MessageHelper();
                    }
                    return _instance;
                }
            }
            private set { _instance = value; }
        }


        //字节数组打包
        public byte[] MakePacket(UInt16 cmd, byte[] content)
        {
            int packet_length = Packet.HEADER_LENGTH + Packet.HEADER_CMD_LENGTH + content.Length;
            Packet packet = new Packet(packet_length);
            packet.PushUInt16((UInt16)content.Length);
            packet.PushUInt16(cmd);
            packet.PushByteArray(content, content.Length);
            return packet.ByteArray();
        }

        //解析收到的字节数组
        public NetMsg ParserPacket(byte[] content, int length,bool hasSerId)
        {
            UInt16 header = 0;
            UInt16 evtId = 0;
            NetMsg msg = new NetMsg();
            byte[] data = new byte[length];
            Packet packet = new Packet(content, content.Length);
            packet.PopUInt16(ref header);
            packet.PopUInt16(ref evtId);
            if (hasSerId)
            {
                UInt16 serId = 0;
                packet.PopUInt16(ref serId);
                msg.serId = serId;
            }
            packet.PopByteArray(ref data, length);
            
            msg.evtId = evtId;
            msg.data = data;

            if(evtId == 0)
            {
                DebugUtil.LogError(header.ToString() + "  " + length.ToString());
            }
            return msg;
        }
    }
}
