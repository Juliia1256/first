using System;
using System.IO;


namespace HW15
{
    class MultipleLogWriter : AbstractLogWriter
    {
        public MultipleLogWriter(AbstractLogWriter[] args) { }
        public MultipleLogWriter() { }
        public void MultiWrite(AbstractLogWriter[] loger)
        {
            foreach (var item in loger)
            {
                if (item is ConsoleLogWriter)
                {
                    Console.WriteLine(Errortype);
                }
                if (item is FileLogWriter)
                {
                    File.AppendAllText("Log.txt", Errortype);
                }

            }
        }
    }
}
