using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> intList = new List<int>();
		intList.Add(10);
		intList.Add(20);
		intList.Add(30);
		intList.Add(40);

		Console.WriteLine(string.Join(", ", intList));
		// 10, 20, 30, 40

		List<string> strList = new List<string>();
		strList.Add("one");
		strList.Add("two");
		strList.Add("three");
		strList.Add("four");
		strList.Add("four");
		strList.Add(null);
		strList.Add(null);

		Console.WriteLine(string.Join(", ", strList));
		// one, two, three, four, four, ,
	}
}