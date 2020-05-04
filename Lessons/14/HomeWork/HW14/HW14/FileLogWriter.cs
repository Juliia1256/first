using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW14
{
    class FileLogWriter : ILogWriter
    {
        public DateTimeOffset LogTime { get; private set; }
        public FileLogWriter()
        {
            LogTime = DateTimeOffset.UtcNow;
        }

        protected string _message;
        protected static FileLogWriter instance;
        public static FileLogWriter Instance => instance ??= new FileLogWriter();
        public string Errortype;
        public  void LogInfo(string message)
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
            File.AppendAllText("Log.txt", Errortype);
        }
    }
}
