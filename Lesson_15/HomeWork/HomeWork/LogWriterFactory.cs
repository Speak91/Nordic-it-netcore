using System.Collections.Generic;

namespace HomeWork
{
    class LogWriterFactory
    {
        private static LogWriterFactory instance;
        private LogWriterFactory()
        {

        }
        public static ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {
            if (instance == null)
                instance = new LogWriterFactory();

            ConsoleLogWriter ConsoleLog = new ConsoleLogWriter();
            FileLogWriter FileLog = new FileLogWriter();
            MultipleLogWriter MultipleLog = new MultipleLogWriter(new List<ILogWriter> { ConsoleLog, FileLog });
            MultipleLog.LogError("Error");
            MultipleLog.LogInfo("Info");
            MultipleLog.LogInfo("Warning");
            return MultipleLog;
        }
    }
}
