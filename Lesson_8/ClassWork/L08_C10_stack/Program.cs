using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Stack<string> numbers = new Stack<string>();
		numbers.Push("one");
		numbers.Push("two");
		numbers.Push("three");
		numbers.Push("four");
		numbers.Push("five");

		// A stack can be enumerated without disturbing its contents.
		foreach (string number in numbers)
		{
			Console.WriteLine(number);
		}

		while (numbers.Count > 0)
		{
			string n = numbers.Pop();
			Console.Write($"Processing \"{n}\"... ");
			// here we can really do something with popped element :)
			Console.WriteLine("OK");
		}
	}
}