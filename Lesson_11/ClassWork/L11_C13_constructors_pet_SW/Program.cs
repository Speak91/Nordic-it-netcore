using System;

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet(
			"Cat",
			"Tom",
			'M',
			DateTimeOffset.Parse("2011-03-14"));
		pet1.WriteDescription();

		Pet pet2 = new Pet(
			"Mouse",
			"Minnie",
			'F',
			DateTimeOffset.Parse("2017-03-14"));
		pet2.WriteDescription(true);
	}
}