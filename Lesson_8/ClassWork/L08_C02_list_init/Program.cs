using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> intList = new List<int> { 10, 20, 30, 40 };
		var l = string.Join(", ", intList);
		Console.WriteLine(l);
		// 10, 20, 30, 40

		var strList = new List<string> { "one", "two", "three", "four" };
		Console.WriteLine(string.Join(", ", strList));
		// one, two, three, four
	}
}