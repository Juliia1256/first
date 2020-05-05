using System;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            var conslog = new ConsoleLogWriter();
            var textlog = new FileLogWriter();
            var conslog1 = new ConsoleLogWriter();
            var textlog1 = new FileLogWriter();

            var multi = new AbstractLogWriter[] { conslog, textlog, conslog1, textlog1 };
            conslog.LogInfo("Some information about the program");
            textlog.LogError("Some information about the error in the program");
            conslog1.LogInfo("Warning about possible problems in the program");
            textlog1.LogError("Some information about the error in the program");
            //conslog.WriteToConsole();
            var sample = new MultipleLogWriter();
            sample.MultiWrite(multi);


        }
    }
}
