using System;

namespace Lesson7_00_string_simple_operations
{
	class Program
	{
		static void Main(string[] args)
		{
			object o1 = new object();
			object o2 = new object();

			Console.WriteLine(o1 == o2); // Flase

			string s1 = "value1";
			string s2 = "value1";

			Console.WriteLine(s1 == s2); // True
			Console.WriteLine(s1.Equals(s2)); // True

			string input = Console.ReadLine();
			if(input == "show message")
			{
				Console.WriteLine("message");
			}

			if ("show message".Equals(input)) // invalid: if (input.Equals("show message"))
			{
				Console.WriteLine("message");
			}

			Console.WriteLine("=================================");
			Console.WriteLine("Test" == "test"); // False
			Console.WriteLine("Test".Equals("tesT", StringComparison.InvariantCultureIgnoreCase)); // True
		}
	}
}
