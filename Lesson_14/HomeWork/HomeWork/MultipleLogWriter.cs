using System.Collections.Generic;

namespace HomeWork
{
    class MultipleLogWriter : AbstractLogWriter
    {
        private List<ILogWriter> logs;
        private static MultipleLogWriter instance;
        private MultipleLogWriter(List<ILogWriter> logWriters)
        {
            logs = logWriters;
        }
        override public void LogError(string message)
        {
            foreach (var item in logs)
            {
                item.LogError(message);
            }
        }

        override public void LogInfo(string message)
        {
            foreach (var item in logs)
            {
                item.LogInfo(message);
            }
        }

        override public void LogWarning(string message)
        {
            foreach (var item in logs)
            {
                item.LogWarning(message);
            }
        }
        public static MultipleLogWriter GetInstance(List<ILogWriter> logWriters)
        {
            List<ILogWriter> logWriters2 = logWriters;
           
            if (instance == null)
            {
                instance = new MultipleLogWriter(logWriters2);
            }
            return instance;
        }

    }
}
