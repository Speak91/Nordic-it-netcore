using System.Collections.Generic;

namespace HomeWork
{

    class Program
    {
        static void Main(string[] args)
        {
           
            List<ILogWriter> logs = new List<ILogWriter>();
            logs.Add(FileLogWriter.GetInstance());
            logs.Add(ConsoleLogWriter.GetInstance());
            MultipleLogWriter logWriter = MultipleLogWriter.GetInstance(logs);
            logWriter.LogError("Error");
            logWriter.LogInfo("Info");
            logWriter.LogInfo("Warning");
        }
    }
}
