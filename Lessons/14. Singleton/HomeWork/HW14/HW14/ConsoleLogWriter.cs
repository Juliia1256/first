using System;
using System.Collections.Generic;
using System.Text;

namespace HW14
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        private static ConsoleLogWriter _instance;
        public static ConsoleLogWriter Instance => _instance ??= new ConsoleLogWriter();
        private ConsoleLogWriter() { }
        public override void WriteLog(string errortype)
        {
            Console.WriteLine(errortype);
        }
    }
}
