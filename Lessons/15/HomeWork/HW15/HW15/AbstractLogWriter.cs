using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    abstract class AbstractLogWriter : ILogWriter

    {

        public AbstractLogWriter() { }
        public virtual void LogInfo(string message)
        {
            var errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
            WriteLog(errortype);
        }
        public virtual void LogWarning(string message)
        {
            var errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
            WriteLog(errortype);
        }
        public virtual void LogError(string message)
        {
            var errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
            WriteLog(errortype);
        }

        public abstract void WriteLog(string Errortype);
    }
}

