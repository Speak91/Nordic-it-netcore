using System.Collections.Generic;

namespace HomeWork
{
    class MultipleLogWriter : AbstractLogWriter
    {
        private List<ILogWriter> logs;
        public MultipleLogWriter(List<ILogWriter> logWriters)
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

    }
}
