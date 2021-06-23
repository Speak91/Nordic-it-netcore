using System.Collections.Generic;

namespace HomeWork
{

    class Program
    {
        static void Main(string[] args)
        {
            FileLogWriter fileLogWriter = new FileLogWriter();
            ConsoleLogWriter consoleLog = new ConsoleLogWriter();
            List<ILogWriter> logs = new List<ILogWriter>();
            logs.Add(fileLogWriter);
            logs.Add(consoleLog);
            MultipleLogWriter logWriter = new MultipleLogWriter(logs);
            logWriter.LogError("Error");
            logWriter.LogInfo("Info");
            logWriter.LogInfo("Warning");
        }
    }
}
