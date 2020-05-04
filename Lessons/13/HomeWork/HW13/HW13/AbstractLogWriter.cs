using System;
using System.IO;

namespace HW13
{
    abstract class AbstractLogWriter : ILogWriter
    {
        public DateTimeOffset LogTime { get; set; }
        public AbstractLogWriter()
        {
            LogTime = DateTimeOffset.UtcNow;
        }
        public virtual void LogInfo(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
        }
        public virtual void LogWarning(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
        }
        public virtual void LogError(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
        }
    }

}
