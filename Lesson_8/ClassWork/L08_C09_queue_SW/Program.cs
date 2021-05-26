using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Queue<int> queue = new Queue<int>();

		WriteLineWithColor(
			"Enter the integer numbers for delayed evaluation of square root",
			ConsoleColor.DarkYellow);
		Console.WriteLine("(type \"run\" command to run the evaluation or \"exit\" to close the program):");

		while (true)
		{
			var input = Console.ReadLine();
			int number;

			if ("exit".Equals(input, StringComparison.InvariantCultureIgnoreCase))
			{
				WriteWithColor(
					$"Number of cancelled tasks in the queue: {queue.Count}. ",
					ConsoleColor.DarkYellow);
				Console.WriteLine("Cancelling...");
				break;
			}

			if ("run".Equals(input, StringComparison.InvariantCultureIgnoreCase))
			{
				if (queue.Count == 0)
				{
					WriteWithColor(
						"You have not tasks in the calculation queue!",
						ConsoleColor.DarkRed);
				}

				while (queue.Count > 0)
				{
					number = queue.Dequeue();
					WriteWithColor(
						$"sqrt({number}) = {MathF.Sqrt(number):0.##}",
						ConsoleColor.Green);
				}
				continue;
			}

			if (int.TryParse(input, out number))
			{
				queue.Enqueue(number);
				continue;
			}

			WriteWithColor(
				$"Unrecognized integer number \"{input}\" or command detected!",
				ConsoleColor.DarkRed);
		}
	}

	static void WriteWithColor(string text, ConsoleColor color)
	{
		Console.ForegroundColor = color;
		Console.Write(text);
		Console.ResetColor();
	}

	static void WriteLineWithColor(string text, ConsoleColor color)
	{
		WriteWithColor(text, color);
		Console.WriteLine();
	}
}