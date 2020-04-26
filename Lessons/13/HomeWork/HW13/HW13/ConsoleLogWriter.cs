using System;
using System.Collections.Generic;
using System.Text;

namespace HW13
{
    class ConsoleLogWriter: AbstractLogWriter
    {
        public ConsoleLogWriter() : base()
        {
        }
        public override string Description => $"{LogTime:yyyy-MM-dd}T{LogTime:HH:mm:ss}\t{Message}\n";
        public void WriteToConsole()
        {
            Console.WriteLine(Description);
        }
    }
}
