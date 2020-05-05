using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class ConsoleLogWriter : AbstractLogWriter

    {
        public ConsoleLogWriter() { } 
        public void WriteToConsole()
        {
            Console.WriteLine(Errortype);
        }

    }
}
