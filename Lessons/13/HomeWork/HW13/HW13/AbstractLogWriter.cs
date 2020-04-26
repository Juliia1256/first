using System;
using System.Collections.Generic;
using System.Text;

namespace HW13
{
    abstract class AbstractLogWriter : ILogWriter
    {
        public DateTimeOffset LogTime { get; set; }
        public string Message{ get; set; }
        public AbstractLogWriter()
        {
            LogTime = DateTimeOffset.UtcNow;
        }
        public virtual void LogInfo()
        {
              this.Message = "Info\tSome informations";
        }
        public virtual void LogWarning()
        {
            this.Message = "Warning\tSome informations about warning";
        }
        public virtual void LogError()
        {
            this.Message = "Error\tSome informations about error";
        }
        public virtual string Description => $"{LogTime:yyyy-MM-dd}T{LogTime:HH:mm:ss}\t{Message}\n";

    }

}
