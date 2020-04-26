using System;
using System.Collections.Generic;
using System.Text;

namespace HW13
{
    interface ILogWriter
    {
        public DateTimeOffset LogTime { get; set; }
        public string Message { get; set; }
        void LogInfo(string message) { }

        void LogWarning(string message) { }

        void LogError(string message) { }
    }
}
