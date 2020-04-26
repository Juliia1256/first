using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW13
{
    class MultipleLogWriter : AbstractLogWriter
    {
        public MultipleLogWriter() : base() { }

        public override string Description => $"{LogTime:yyyy-MM-dd}T{LogTime:HH:mm:ss}\t{Message}\n";

        public void MultipleLog()
        {
            File.AppendAllText("logfile.txt", Description);
            Console.WriteLine(Description);
        }
    }
}
