using System;
using System.Text;

namespace L14_C00_interface_IDisposable_Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			using var fw2 = new FileWriter("test2.txt");
			fw2.Write("test");

			using (var fw = new FileWriter("test.txt"))
			{
				fw.Write("Hello\r\n");
				fw.Write("World\r\n");

				for (int i = 0; i < 10; i++)
					fw.Write(i + " ");
			}
		}
	}
}
