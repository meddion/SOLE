using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Logger
    {
        internal void NewException(Exception e)
        {
            Write?.Invoke("Виключна ситуація " + e.Message);
            WriteException?.Invoke(e.ToString());
        }
        internal void NewMsg(string msg)
        {
            Write?.Invoke(msg);
        }
        public delegate void LogEventHandler(string msg);
        public event LogEventHandler WriteException;
        public event LogEventHandler Write;
    }
}
