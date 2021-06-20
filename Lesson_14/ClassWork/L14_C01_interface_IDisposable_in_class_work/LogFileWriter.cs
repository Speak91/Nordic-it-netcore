using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace L14_C01_interface_IDisposable_in_class_work
{
	public class LogFileWriter: IDisposable
	{
		private StreamWriter _logFileWriter;

		public string LogFileName { get; private set; }

		
		public LogFileWriter(string fileName)
		{
			LogFileName = fileName;

			Stream stream = File.Open(
				LogFileName,
				FileMode.OpenOrCreate,
				FileAccess.ReadWrite,
				FileShare.Read);

			_logFileWriter = new StreamWriter(stream);
		}

		public void WriteToLog(string logRecord)
		{
			_logFileWriter.WriteLine(
				"{0:yyyy-MM-dd hh:mm:ss.fff}+00:00\t{1}",
				DateTime.UtcNow,
				logRecord);
			_logFileWriter.Flush();
		}

		public void Dispose()
		{
			_logFileWriter?.Dispose();
		}
	}
}
