using System;
using System.IO;
using System.Net.Http;

namespace HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            var conslog = new ConsoleLogWriter();
            var textlog = new FileLogWriter();
            var textlog2 = new FileLogWriter();
            var multilog = new MultipleLogWriter();
            var multilog2 = new MultipleLogWriter();
            conslog.LogError();
            textlog.LogInfo();
            textlog2.LogWarning();
            multilog.LogWarning();
            multilog2.LogError();

            conslog.WriteToConsole();
            textlog.TextLog();
            textlog2.TextLog();
            multilog.MultipleLog();
            multilog2.MultipleLog();
        }
        
    }
}
