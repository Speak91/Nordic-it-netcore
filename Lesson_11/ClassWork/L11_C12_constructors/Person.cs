using System;

class Person
{
	public string Name { get; set; }

	public int Age { get; set; }

	public Person() { }

	/// <summary>
	/// Creates a new instance of Person class.
	/// </summary>
	/// <param name="name">Name of the person.</param>
	/// <param name="age">Age of the person.</param>
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}

	public void WriteProperties(int years)
	{
		Console.WriteLine(
			$"Name: {Name}, age in {years} years: {AgeInSomeYears(years)}.");
	}

	public int AgeInSomeYears(int yearsToAdd)
	{
		return Age + yearsToAdd;
	}

	public void UpdateProperties(string name, int age)
	{
		Name = name;
		Age = age;
	}

	public void UpdateProperties(int age)
	{
		Age = age;
	}

	public void UpdateProperties(string name)
	{
		Name = name;
	}
}