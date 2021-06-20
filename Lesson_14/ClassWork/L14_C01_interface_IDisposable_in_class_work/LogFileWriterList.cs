using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace L14_C01_interface_IDisposable_in_class_work
{
	class LogFileWriterList : IEnumerable<LogFileWriter>, IDisposable
	{
		private List<LogFileWriter> _logFileWriters;

		public LogFileWriterList()
		{
			_logFileWriters = new List<LogFileWriter>();
		}

		public void Add(LogFileWriter logFileWriter)
		{
			_logFileWriters.Add(logFileWriter);
		}

		public void Clear()
		{
			Dispose();

			_logFileWriters.Clear();
		}

		public bool Remove(LogFileWriter logFileWriter)
		{
			logFileWriter?.Dispose();

			return _logFileWriters.Remove(logFileWriter);
		}

		public void Dispose()
		{
			if (_logFileWriters == null)
				return;
			
			foreach (LogFileWriter writer in _logFileWriters)
			{
				writer?.Dispose();
			}
		}

		public IEnumerator<LogFileWriter> GetEnumerator()
		{
			return _logFileWriters.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
