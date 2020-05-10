using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW13
{
    class FileLogWriter : AbstractLogWriter
    {
        private string _nameOfFile;
        public FileLogWriter(string name) 
        {
            _nameOfFile = name;
        }
        public override void WriteLog(string Errortype)
        {
            File.AppendAllText(_nameOfFile, Errortype);
        }
    }

}
