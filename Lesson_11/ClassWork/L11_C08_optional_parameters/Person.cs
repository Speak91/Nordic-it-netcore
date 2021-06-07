using System;

class Person
{
	public string Name { get; set; }

	public int Age { get; set; }

	public void WriteProperties(int years = 10)
	{
		Console.WriteLine(
			$"Name: {Name}, age in {years} years: {AgeInSomeYears(years)}.");
	}

	public int AgeInSomeYears(int yearsToAdd)
	{
		return Age + yearsToAdd;
	}
}