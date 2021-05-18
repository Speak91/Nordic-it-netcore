using System;

namespace Lesson06_02_do_while_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите exit для выхода (1)");
			do
			{
			} while (Console.ReadLine() != "exit");

			Console.WriteLine("Введите exit для выхода (2)");
			do
			{
				if (Console.ReadLine() == "exit")
					break;
			} while (true);

			Console.WriteLine("Введите exit для выхода (3)");
			do
			{
				string s = Console.ReadLine();
				if (s == "exit")
					break;

				if (s.Length <= 15)
				{
					Console.WriteLine($"Введена строка длиной {s.Length}");
					continue;
				}

				Console.WriteLine("Слишком длинная строка, попробуйте ещё раз");
			} while (true);
		}


	}
}
