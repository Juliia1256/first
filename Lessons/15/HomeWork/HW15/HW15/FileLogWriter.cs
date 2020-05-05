using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW15
{
    class FileLogWriter : AbstractLogWriter
    {
        public FileLogWriter() { }
        public void WriteToFile()
        {
            File.AppendAllText("Log.txt", Errortype);
        }


    }
}
