using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW14
{
    class FileLogWriter : AbstractLogWriter
    {
        private static FileLogWriter instance;
        public static FileLogWriter Instance => instance ??= new FileLogWriter();
        private string _nameOfFile;
        private FileLogWriter()
        {
            _nameOfFile = "TextLog.txt";
        }
        public override void WriteLog(string Errortype)
        {
            File.AppendAllText(_nameOfFile, Errortype);
        }
    }
}
