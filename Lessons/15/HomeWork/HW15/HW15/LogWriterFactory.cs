using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class LogWriterFactory
    {
        private LogWriterFactory() { }
        protected static LogWriterFactory instance;
        public static LogWriterFactory Instance => instance ??= new LogWriterFactory();
        public ILogWriter GetLogWriter<T>(T parametrs) where T : ILogWriter
        {
            return parametrs;
        }
    }
}
