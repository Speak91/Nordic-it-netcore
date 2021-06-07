using System;

public partial class Person
{
	public string Name { get; set; }

	public int Age { get; set; }

	public Person() { }

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
	// Person.cs
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