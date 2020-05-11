using System;
using System.Collections.Generic;
using System.Text;

namespace HW14
{
    class MultipleLogWriter : AbstractLogWriter
    {
        private ILogWriter[] _logscollection;
        public MultipleLogWriter(ILogWriter[] arg)
        {
            _logscollection = arg;
        }
        public override void LogInfo(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogInfo(message);
            }
        }
        public override void LogWarning(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogWarning(message);
            }
        }
        public override void LogError(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogError(message);
            }
        }
        public override void WriteLog(string Errortype) { }
    }
}

