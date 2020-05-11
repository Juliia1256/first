using System;
using System.IO;

namespace HW13
{
    abstract class AbstractLogWriter : ILogWriter
    {
        private string Errortype;
        public AbstractLogWriter() { }
        public virtual void LogInfo(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
            WriteLog(Errortype);
        }
        public virtual void LogWarning(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
            WriteLog(Errortype);
        }
        public virtual void LogError(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
            WriteLog(Errortype);
        }

        public abstract void WriteLog(string Errortype);
    }

}
