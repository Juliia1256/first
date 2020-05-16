using System;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            var conslog = LogWriterFactory.Instance.GetLogWriter<ConsoleLogWriter>(null);
            var textlog = LogWriterFactory.Instance.GetLogWriter<FileLogWriter>("FileLog.txt");
            var multilog = LogWriterFactory.Instance.GetLogWriter<MultipleLogWriter>(new[] { conslog, textlog });

            conslog.LogError("Some information about the error in the program");
            textlog.LogInfo("Some information about the program");
            multilog.LogWarning("Warning about possible problems in the program");

        }
    }
}
