using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW13
{
    class FileLogWriter : AbstractLogWriter
    {
        public FileLogWriter() : base() { }

        public override string Description => $"{LogTime:yyyy-MM-dd}T{LogTime:HH:mm:ss}\t{Message}\n";
        public void  TextLog()
        {
            File.AppendAllText("logfile.txt", Description);
        }
    }

}
