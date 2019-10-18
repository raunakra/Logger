using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemo.Logger
{
    public class EventLogger : LogBase
    {
        public override void Log(string message)
        {
            EventLog eventLog = new EventLog(“”);
            eventLog.Source = "IDGEventLog";
            eventLog.WriteEntry(message);
        }
    }
}
