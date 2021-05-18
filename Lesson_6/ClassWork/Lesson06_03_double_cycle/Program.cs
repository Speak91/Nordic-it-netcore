using System;

namespace Lesson06_03_double_cycle
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				int a = 0;
				bool externalExit = false;

				do
				{
					try
					{
						Console.Write("Enter a number: ");
						a = int.Parse(Console.ReadLine());

						if (a < 0)
						{
							externalExit = true;
							break;
						}
					}
					catch
					{
						continue;
					}

					break;
				} while (true);

				if (externalExit)
					break;

				Console.WriteLine($"{a} * {a} = {a * a}");

				Console.WriteLine("Enter 'continue' to contine");
			} while (Console.ReadLine() == "continue");

			Console.WriteLine("The end");
		}		
	}
}
