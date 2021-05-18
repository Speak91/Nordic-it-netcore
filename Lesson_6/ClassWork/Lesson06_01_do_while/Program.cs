using System;

namespace Lesson06_01_do_while
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;

			Console.WriteLine("Enter integer values: ");
			do
			{
				int i;
				
				try
				{
					i = int.Parse(Console.ReadLine());
					sum += i; // sum = sum + i
				}
				catch (Exception)
				{
					Console.WriteLine("Wrong input value");
					//continue;
					// throw;
				}

				
			} while (sum < 100);

			Console.WriteLine($"Sum is: {sum}");
		}
	}
}
