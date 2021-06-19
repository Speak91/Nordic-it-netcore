using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);

    }
    class FileLogWriter : AbstractLogWriter
    {
        string logName = @"log.txt";
        public string Messsage { get; set; }


        override public void LogError(string message)
        {

            File.AppendAllText(logName, $"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Error \t {message} " + Environment.NewLine);
        }
        override public void LogInfo(string message)
        {
            File.AppendAllText(logName, $"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Info \t {message} " + Environment.NewLine);
        }

        override public void LogWarning(string message)
        {
            File.AppendAllText(logName, $"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Warning \t {message} " + Environment.NewLine);
        }
    }
    class ConsoleLogWriter : AbstractLogWriter
    {

    }
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
    abstract public class AbstractLogWriter : ILogWriter
    {
    
        virtual public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Error \t {message} ");
        }

        virtual public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Info \t {message} ");
        }

        virtual public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy:MM:dd:t:HH:mm:ss+0000")}\t Warning \t {message} ");
        }
    }

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
