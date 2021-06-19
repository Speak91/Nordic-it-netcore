using System;
using System.Collections;
using System.Collections.Generic;

namespace L13_C00_abstract_demo
{
	class Program
	{
		static void Main()
		{
			using (SomeThing thing = new SomeThing())
			{
				foreach(var o in thing)
				{

				}
			}

		}
	}

	public class SomeThing : IDisposable, IEnumerable<int>
	{
		public void Dispose()
		{
			Console.WriteLine("Disposing done.");
		}

		public IEnumerator<int> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
