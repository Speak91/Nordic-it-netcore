using System;

namespace L10_C00_program_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();
			p1.Age = 100;
			p1.Name = "Andrei";
			p1.SetDateOfBirth(DateTimeOffset.Parse("2010-10-25+0000"));

			Console.WriteLine($"Age is: {p1.Age}");
			Console.WriteLine($"Name is: {p1.Name}");
			Console.WriteLine($"Date of Birth is: {p1.GetDateOfBirth()}");

			Person p2 = new Person
			{
				Age = 16,
				Name = "Masha"
			};

			Console.WriteLine(p2.Name);
		}
	}
}
