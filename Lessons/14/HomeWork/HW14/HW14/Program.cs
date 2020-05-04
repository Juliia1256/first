using System;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            var conslog = ConsoleLogWriter.Instance;
            var textlog = FileLogWriter.Instance;
            var conslog1 = ConsoleLogWriter.Instance;
            var textlog1 = FileLogWriter.Instance;
            conslog.LogInfo("Some information about the program");
            conslog1.LogWarning("Warning about possible problems in the program");
            textlog.LogError("Some information about the error in the program");
            textlog1.LogWarning("Warning about possible problems in the program");

            conslog.WriteProperties();
            conslog1.WriteProperties();
            textlog.WriteProperties();
            textlog1.WriteProperties();

        }
    }
}
