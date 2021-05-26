using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		Dictionary<string, string> countries = new Dictionary<string, string>
		{
			{"Россия", "Москва" },
			{"Франция", "Париж"},
			{"Германия", "Берлин"},
			{"Великобритания", "Лондон"}
		};

		while (true)
		{
			int index = (new Random()).Next(countries.Count);
			KeyValuePair<string, string> kvp = countries.ElementAt(index);
			string country = kvp.Key;
			string capital = kvp.Value;

			Console.Write($"Введите столицу страны \"{country}\": ");
			var answer = Console.ReadLine()?.Trim();
			if (capital.Equals(answer, StringComparison.InvariantCultureIgnoreCase))
			{
				Console.WriteLine("Правильно!");
			}
			else
			{
				Console.WriteLine("Вы проиграли :( Выходим...");
				break;
			}
		}
	}
}