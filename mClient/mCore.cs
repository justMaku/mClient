using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mClient
{
    public static class mCore
    {
        public static CallBackEvent Event;             // For sending events to the UI

        public static void Debug()
        {
            Event m2 = new Event(EventType.EVENT_LOG, "0", new object[0]);
            Event(m2);
        }

        public static void Init(CallBackEvent e)
        {
            Event = e;
        }

        public static void SendError(string msg)
        {
            Event m2 = new Event(EventType.EVENT_ERROR, "0", new object[1] { msg });
            Event(m2);
        }
    }



    public class Event
    {
        public EventType eventType;
        public string eventTime;
        public object[] eventArgs;

        public Event(EventType type, string time, params object[] parms)
        {
            eventType = type;
            eventTime = time;
            eventArgs = parms;
        }
    }

    public enum EventType
    {
        EVENT_REALMLIST,
        EVENT_CHARLIST,
        EVENT_ADD_OBJECT,
        EVENT_DEL_OBJECT,
        EVENT_UDT_OBJECT,
        EVENT_LOG,
        EVENT_CHAT_MSG,
        EVENT_ERROR,
        EVENT_DISCONNECT,
    }

    // Delegates - Used to make calls to the UI from this .dll
    public delegate void CallBackEvent(Event e);

}
