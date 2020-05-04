using System;


namespace HW13
{
    class ConsoleLogWriter: AbstractLogWriter
    {
        public ConsoleLogWriter() : base() { }

       
        public override void LogInfo(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tInfo\t{message}\n";
            Console.WriteLine(errortype);
        }
        public override void LogWarning(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tWarning\t{message}\n";
            Console.WriteLine(errortype);
        }
        public override void LogError(string message)
        {
            var errortype = $"{LogTime:yyyy:MM:ddThh:mm:ss}+00:00\tError\t{message}\n";
            Console.WriteLine(errortype);
        }
    }
}
