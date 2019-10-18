using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemo.Logger
{
    public class ErrorLog
    {
        public void doLog(Exception ex, string messageTemplate)
        {
            Log.Error(ex.StackTrace,messageTemplate);
        }
    }
}
