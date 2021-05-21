using System;
using System.Text;

namespace Lesson7_01_escape_sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Console.WriteLine("Hello	World!");
			Console.WriteLine("Hello\tWorld!");
			Console.WriteLine("Hello\nWorld!");

			Console.WriteLine("♥ \u2665 \u2601");
			Console.WriteLine("\a");

			Console.WriteLine("test\fpage\fbreak");

			Console.WriteLine("C:\temp\test.file.txt");
			Console.WriteLine("C:\\temp\\test.file.txt");
			Console.WriteLine(@"C:\temp\test.file.txt");

			Console.WriteLine(@"Hello
My name is Andrei");

			Console.WriteLine(
				"Hello\n" +
				"My name is Andrei");

			string[] names =
			{
				"Andrei",
				"Maria",
				"Petr",
				"Hydrolysis1",
				"Pavel",
			};

			foreach(string name in names)
			{
				Console.Write(name + "\t * \t");
			}

			Console.WriteLine();
			Console.WriteLine("===================");

			for (int i = 0; i < names.Length; i++)
			{
				Console.Write(names[i]);
				if (i < names.Length - 1)
				{
					Console.Write("\t * \t");
				}
			}

			Console.WriteLine();
			Console.WriteLine("===================");

			foreach (string name in names)
			{
				Console.Write(name.PadLeft(12, ' ') + "\n");
			}

			Console.WriteLine(@"""C:\test workspace\test.file.txt""");
		}
	}
}
