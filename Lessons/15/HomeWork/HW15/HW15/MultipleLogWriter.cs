using System;
using System.IO;


namespace HW15
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] _logscollection;
        public MultipleLogWriter(ILogWriter[] arg)
        {
            _logscollection = arg;
        }
        public void LogInfo(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogInfo(message);
            }
        }
        public  void LogWarning(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogWarning(message);
            }
        }
        public  void LogError(string message)
        {
            foreach (var log in _logscollection)
            {
                log.LogError(message);
            }
        }
    }
}
