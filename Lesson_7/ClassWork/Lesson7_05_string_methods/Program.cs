using System;

namespace Lesson7_05_string_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "lorem ipsum test test test";

			//Console.WriteLine(s.Contains("ips")); // true
			//Console.WriteLine(s.StartsWith("ABC")); // false
			//Console.WriteLine(s.EndsWith("test")); // false

			// вывести на экран индексы всех букв "s"

			int searchFromIndex = 0;
			do
			{
				int index = s.IndexOf("tes", searchFromIndex); // 8
				if (index == -1) 
					break;

				Console.WriteLine(index);
				searchFromIndex = index + 1;
			}
			while (true);


			// -------------------------
			string a = "my test string";
			
			string b = a.Replace("test", "best");
			Console.WriteLine(a + "\n" + b);

			string c = a.Substring(3, 4);
			Console.WriteLine(a + "\n" + c);

			string[] lines = "here  we  go!"
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			foreach(string line in lines)
			{
				Console.WriteLine($"{line}: {line.Length}");
			}

			Console.WriteLine(string.Join(" ♥ ", lines));
		}
	}
}
