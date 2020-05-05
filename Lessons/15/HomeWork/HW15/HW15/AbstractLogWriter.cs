using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class AbstractLogWriter :  ILogWriter

    {
        protected string Errortype { get; set; }
        public AbstractLogWriter() 
        {
            Errortype = Errortype;
        }
        public virtual void LogInfo(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
        }
        public virtual void LogWarning(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
        }
        public virtual void LogError(string message)
        {
            Errortype = $"{DateTimeOffset.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
        }

    }
}
