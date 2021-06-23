using System;
using System.IO;

namespace HomeWork
{
    class FileLogWriter : AbstractLogWriter
    {
        string logName = @"log.txt";
        public string Messsage { get; set; }
        private static FileLogWriter instance;
        private FileLogWriter()
        { }
        public static FileLogWriter GetInstance ()
        {
            if (instance == null)
                instance = new FileLogWriter();
            return instance;
        }
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
}
