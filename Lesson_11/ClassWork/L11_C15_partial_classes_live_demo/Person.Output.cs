using System;

partial class Person
{	
	public void WriteProperties(int years)
	{
		Console.WriteLine(
			$"Name: {Name}, age in {years} years: {AgeInSomeYears(years)}.");
	}

	public void WritePropertiesShort(int years)
	{
		Console.WriteLine(
			$"Name: {Name}.");
	}
}
