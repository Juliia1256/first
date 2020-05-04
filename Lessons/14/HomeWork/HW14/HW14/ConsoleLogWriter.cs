using System;
using System.Collections.Generic;
using System.Text;

namespace HW14
{
    class ConsoleLogWriter : ILogWriter
    {
        public DateTimeOffset LogTime { get; private set; }
        public ConsoleLogWriter()
        {
            LogTime = DateTimeOffset.UtcNow;
        }
        protected string _message;
        protected static ConsoleLogWriter instance;
        public static ConsoleLogWriter Instance => instance ??= new ConsoleLogWriter();
        public string Errortype;
        public void LogInfo(string message)
        {
            _message = message;
            Errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
        }
        public  void LogWarning(string message)
        {
            _message = message;
            Errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
        }
        public  void LogError(string message)
        {
            _message = message;
            Errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
        }
        public void WriteProperties()
        {
            Console.WriteLine(Errortype);
        }
    }
}
