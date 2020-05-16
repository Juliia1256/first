using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class LogWriterFactory
    {
        private LogWriterFactory() { }
        private static LogWriterFactory _instance;
        public static LogWriterFactory Instance => _instance ??= new LogWriterFactory();
        public ILogWriter GetLogWriter<T>(object parametrs) where T : ILogWriter
        {
            if (typeof(T) == typeof(ConsoleLogWriter))
            {
                return new ConsoleLogWriter();
            }
            else if (typeof(T) == typeof(FileLogWriter))
            {
                return new FileLogWriter (parametrs as string);
            }
            else if (typeof(T) == typeof(MultipleLogWriter))
            {
                return new MultipleLogWriter(parametrs as ILogWriter[]);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
