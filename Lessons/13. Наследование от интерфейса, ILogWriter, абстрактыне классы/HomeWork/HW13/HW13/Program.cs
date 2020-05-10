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
            var textlog = new FileLogWriter("log.txt");
            var multi = new ILogWriter[]{conslog, textlog}; //save instances in a variable 
            var multilog = new MultipleLogWriter(multi);  //create a new instance and pass as an argument a variable that stores a collection of instances
            multilog.LogInfo("Some information about the program"); //new event to record
            multilog.LogError("Some information about the error in the program");
            multilog.LogInfo("Warning about possible problems in the program");
            multilog.LogError("Some information about the error in the program");

        }

    }
}
