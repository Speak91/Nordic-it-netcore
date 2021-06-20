using System;

namespace L14_C01_interface_IDisposable_in_class_work
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Log Writing is running!");

			using (var logFileWriterInternal = new LogFileWriter(@"d:\test_log.txt"))
			{
				logFileWriterInternal.WriteToLog("test log record 1");
				logFileWriterInternal.WriteToLog("test log record 2");
			}

			using var logFileWriter = new LogFileWriter(@"d:\test_log.txt");
			logFileWriter.WriteToLog("test log record 1");
			logFileWriter.WriteToLog("test log record 2");


			using var logFileWriters = new LogFileWriterList();
			logFileWriters.Add(new LogFileWriter(@"d:\log1.txt"));
			logFileWriters.Add(new LogFileWriter(@"d:\log2.txt"));

			foreach (LogFileWriter writer in logFileWriters)
			{
				writer.WriteToLog("test");
			}

		}
	}
}
