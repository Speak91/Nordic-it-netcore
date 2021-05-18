using System;
using System.Text;

namespace Lesson06_08_foreach_crypto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;

			Console.Write("Enter text to crypt: ");
			string source = Console.ReadLine();

			Console.Write("Enter numeric shift crypto key : ");
			int key = int.Parse(Console.ReadLine());

			Console.Write("Encrypted string: ");
			foreach(char letter in source)
			{
				Console.Write((char)(letter + key));
			}

			Console.WriteLine();
		}
	}
}
