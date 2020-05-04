using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW13
{
    class MultipleLogWriter : AbstractLogWriter
    {
        public MultipleLogWriter(AbstractLogWriter[]args) : base() { }

        public override void LogInfo(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
            File.AppendAllText("Log.txt", errortype);
            Console.WriteLine(errortype);
        }
        public override void LogWarning(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
            File.AppendAllText("Log.txt", errortype);
            Console.WriteLine(errortype);

        }
        public override void LogError(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
            File.AppendAllText("Log.txt", errortype);
            Console.WriteLine(errortype);
        }
    }
}
