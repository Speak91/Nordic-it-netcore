namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = LogWriterFactory.GetLogWriter<ILogWriter>(@"log.txt");
            test.LogError("error!");
        }
    }
}
