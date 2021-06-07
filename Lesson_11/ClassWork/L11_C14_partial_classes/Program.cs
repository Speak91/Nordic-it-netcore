using System;

class Program
{
	static void Main()
	{
		// declaring the array for names
		Person[] persons = new Person[2];

		for (int i = 0; i < persons.Length; i++)
		{
			Console.Write($"Enter name {i}: ");
			var name = Console.ReadLine();

			Console.Write($"Enter age {i}: ");
			var age = int.Parse(Console.ReadLine());

			persons[i] = new Person(name, age);
		}

		persons[0].UpdateProperties("Andrei Golyakov");
		persons[0].UpdateProperties("Andrei Golyakov", 36);
		persons[0].UpdateProperties(36);

		// Writing out the results
		for (int i = 0; i < persons.Length; i++)
		{
			persons[i].WriteProperties(4);
			persons[i].WriteProperties(12);
		}
	}
}
