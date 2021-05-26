using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
	static void Main()
	{
		var list = new List<double>();

		Console.WriteLine("Enter double precision float values (enter \"stop\" to finish");
		do
		{
			string input = Console.ReadLine();
			if (input.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
			{
				break;
			}

			try
			{
				list.Add(double.Parse(input));
			}
			catch (Exception)
			{
				Console.WriteLine("Error! Not a number entered! Aborting");
				throw;
			}
		} while (true);

		if (list.Count > 0)
		{
			double sum = 0;
			foreach (double d in list)
			{
				sum += d;
			}

			double avg = sum / list.Count;

			Console.WriteLine($"Sum: {sum:#.###}, Average: {avg:#.###}");
		}
		else
		{
			Console.WriteLine("No data to work with!");
		}
	}
}