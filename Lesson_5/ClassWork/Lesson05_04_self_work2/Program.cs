using System;

namespace Lesson05_04_self_work2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number from 0 to 100: ");

			int number;
			try
			{
				string s = Console.ReadLine();
				number = int.Parse(s);
			}
			catch(OverflowException e)
			{
				Console.WriteLine($"Error while parsing integer value from input string: {e.HResult}");
				throw;
			}
			catch (FormatException e)
			{
				Console.WriteLine($"Error while parsing integer value from input string: {e.HResult}");
				throw;
			}

			Console.WriteLine(
				(number < 50)
					? "Enter the number greater than 50"
					: "The entered number is greate or equal 50");

			//float a = Get
		}

		static float GetFloatNumber(string prompt)
		{
			Console.WriteLine(prompt);
			try
			{
				string s = Console.ReadLine();
				return float.Parse(s);
			}
			catch
			{
				Console.WriteLine("Ошибка ввода данных");
				throw;
			}
		}

	}
}
