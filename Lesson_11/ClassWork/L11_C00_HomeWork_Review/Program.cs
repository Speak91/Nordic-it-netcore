using System;

namespace L11_C00_HomeWork_Review
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			int rnd = rand.Next();
			Console.WriteLine(rnd);

			///

			const int amountOfPeople = 3;
			Person[] persons = new Person[amountOfPeople];

			for (int i = 0; i < amountOfPeople; i++)
			{
				persons[i] = GetPersonFromConsole(i);
				if (persons[i] == null)
				{
					i--;
				}
			}

			for (int i = 0; i < amountOfPeople; i++)
			{
				WritePersonToConsole(persons[i]);
			}

			///

			persons[0].UpdateProperties("Andrei");
			persons[0].UpdateProperties(120);
			persons[0].UpdateProperties("Sergei", 20);
		}

		static public Person GetPersonFromConsole(int personNumber)
		{
			try
			{
				var result = new Person();

				Console.Write($"Введите имя №{personNumber + 1}: ");
				result.Name = Console.ReadLine();

				Console.Write($"Введите возраст №{personNumber + 1}: ");
				result.Age = int.Parse(Console.ReadLine());

				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine($"Произощла ошибка {e.Message} повторите попытку");
				return null;
			}
		}

		static public void WritePersonToConsole(Person person)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(person.Description);
			Console.ResetColor();
		}
	}
}
