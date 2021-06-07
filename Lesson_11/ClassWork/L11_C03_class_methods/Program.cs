using System;

class Program
{
	static void Main()
	{
		// declaring the array for names
		Person[] persons = new Person[3];

		for (int i = 0; i < persons.Length; i++)
		{
			persons[i] = new Person();

			Console.Write($"Enter name {i}: ");
			persons[i].Name = Console.ReadLine();

			Console.Write($"Enter age {i}: ");
			persons[i].Age = int.Parse(Console.ReadLine());
		}

		// Writing out the results
		for (int i = 0; i < persons.Length; i++)
		{
			Console.WriteLine(persons[i].PropertiesString);
		}
	}
}
