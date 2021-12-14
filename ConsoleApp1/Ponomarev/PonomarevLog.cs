using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Ponomarev
{
    class PonomarevLog : LogAbstract, LogInterface
    {
        private static PonomarevLog instance;
        private List<string> LogLog = new List<string>();
        public LogInterface log(string str)
        {
            LogLog.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(LogLog.ToArray());
            return this;
        }
        public PonomarevLog I()
        {
            if (instance == null)
                instance = new PonomarevLog();
            return instance;
        }
    }
}
