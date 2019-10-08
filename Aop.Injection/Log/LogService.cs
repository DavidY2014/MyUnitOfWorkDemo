using System;
using System.Collections.Generic;
using System.Text;

namespace Aop.Injection.Log
{
    public class LogService
    {
        private ILogger _loggr;
        public LogService(ILogger logger)
        {
            _loggr = logger;
        }

        public void WriteLog()
        {
            _loggr.LoggerHandler();
        }
    }
}
