using System;

public partial class Person
{
	public void WriteProperties(int years)
	{
		Console.WriteLine(GetPropertiesString(years));
	}

	private int AgeInSomeYears(int yearsToAdd)
	{
		return Age + yearsToAdd;
	}

	private string GetPropertiesString(int years)
	{
		return $"Name: {Name}, age in {years} years: {AgeInSomeYears(years)}.";
	}
}