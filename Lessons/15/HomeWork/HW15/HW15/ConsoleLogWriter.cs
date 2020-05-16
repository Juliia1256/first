using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class ConsoleLogWriter : AbstractLogWriter

    {
        public ConsoleLogWriter() { }

        public override void WriteLog(string errortype)
        {
            Console.WriteLine(errortype);
        }

    }
}
