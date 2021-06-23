namespace HomeWork
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        private static ConsoleLogWriter instance;
        private ConsoleLogWriter()
        { }
        public static ConsoleLogWriter GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogWriter();
            }
            return instance;
        }
    }
}
