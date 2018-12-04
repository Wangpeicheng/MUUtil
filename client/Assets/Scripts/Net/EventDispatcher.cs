
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using Proto;
using ProtoBuf;

namespace Net
{
    public delegate void EventListenerDelegate(NetMsg msg);

    public class EventDispatcher
    {
        private static EventDispatcher _instance;

        private EventDispatcher() { }

        public static EventDispatcher Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new EventDispatcher();
                }
                return _instance;
            }
            private set { _instance = value; }
        }

        private Dictionary<UInt16, List<EventListenerDelegate>> eventListeners = new Dictionary<UInt16, List<EventListenerDelegate>>();
        public Dictionary<UInt16, List<EventListenerDelegate>> EventListeners
        {
            get { return eventListeners; }
            private set { eventListeners = value; }
        }

        public void AddEventListener(UInt16 eventType, EventListenerDelegate listener)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                List<EventListenerDelegate> list = eventListeners[eventType];
                list.Add(listener);
            }
            else
            {
                List<EventListenerDelegate> list = new List<EventListenerDelegate>();
                list.Add(listener);
                eventListeners.Add(eventType, list);
            }
        }

        public void RemoveEventListener(UInt16 eventType, EventListenerDelegate listener)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType].Remove(listener);

                if (eventListeners[eventType].Count == 0)
                {
                    eventListeners.Remove(eventType);
                }
            }
        }


        public Queue<NetMsg> queue = new Queue<NetMsg>();
        public void InsertMsg(NetMsg msg)
        {
            if((int)msg.evtId == 0)
            {
                DebugUtil.LogError(msg.evtId.ToString() + " "+ (null ==  msg.data).ToString());
                return;
            }
            queue.Enqueue(msg);
        }

        //public void ProcessEvents(NetMsg msg)
        //{
        //    Debug.Log("MSG ID : " + msg.evtId);
        //    if (eventListeners.ContainsKey(msg.evtId))
        //    {
        //        foreach (EventListenerDelegate listenr in eventListeners[msg.evtId])
        //        {
        //            listenr(msg);
        //        }
        //    }
        //}

        public void Clear()
        {
            this.eventListeners.Clear();
        }
    }
}