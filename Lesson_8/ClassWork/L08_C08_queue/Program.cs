using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Queue<string> numbers = new Queue<string>();
		numbers.Enqueue("one");
		numbers.Enqueue("two");
		numbers.Enqueue("three");
		numbers.Enqueue("four");
		numbers.Enqueue("five");

		// A queue can be enumerated without disturbing its contents.
		foreach (string number in numbers)
		{
			Console.WriteLine(number);
		}

		while (numbers.Count > 0)
		{
			string n = numbers.Dequeue();
			Console.Write($"Processing \"{n}\"... ");
			// here we can really do something with dequeued element :)
			Console.WriteLine("OK");
		}
	}
}