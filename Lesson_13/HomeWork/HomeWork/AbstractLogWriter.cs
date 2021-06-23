using System;

namespace HomeWork
{
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
}
