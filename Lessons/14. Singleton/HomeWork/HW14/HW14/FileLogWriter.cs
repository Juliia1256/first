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
        private static string _nameOfFile;
        private FileLogWriter() { }
        public static void ChangeOfFileName(string nameOfFile)
        {
            _nameOfFile = nameOfFile;
        }
        public override void WriteLog(string errortype)
        {
            File.AppendAllText(_nameOfFile, errortype);
        }
    }
}
