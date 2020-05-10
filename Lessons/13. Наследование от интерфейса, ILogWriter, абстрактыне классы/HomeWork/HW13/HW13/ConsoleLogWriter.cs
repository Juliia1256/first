using System;


namespace HW13
{
    class ConsoleLogWriter: AbstractLogWriter
    {
        public ConsoleLogWriter() { }

        public override void WriteLog(string Errortype)
        {
            Console.WriteLine(Errortype); 
        }

    }
}
