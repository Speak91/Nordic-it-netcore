using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> intList = new List<int> { 10, 20, 30, 40 };
		intList.AddRange(new[] { 50, 60, 70, 80 }); // add new 4 elements
		Console.WriteLine(string.Join(", ", intList));
		// 10, 20, 30, 40, 50, 60, 70, 80

		intList.RemoveRange(4, 2); // remove 2 elements from index 4 
		Console.WriteLine(string.Join(", ", intList));
		// 10, 20, 30, 40, 70, 80
	}
}