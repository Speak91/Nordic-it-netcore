using System;

class Program
{
	static void Main()
	{
		Person p1 = new Person();

		// p1.m_age - inaccessible as it is private
		p1.Name = "Andrei";
		p1.Age = 36;
		p1.SetBirthPlace("Leningrad");
		p1.SetBirthPlace("Petushki");

		Person p2 = new Person()
		{
			Name = "Masha",
			Age = 12
		};

		p2.SetBirthPlace("Moskva");

		//Console.WriteLine(p2.GetPropertiesString());
		//Console.WriteLine(p2.PropertiesString);


		// Name: Andrei, Age: 36



		Person[] persons = new Person[10];
		persons[0] = new Person();
		persons[0].Name = "test";

		int[] numbers = new int[10];
		numbers[0] = 1;

	}
}

class Person
{
	int _age;               // implicitly private field: bad practice! always use "private"!
							// "_" prefix is used for member variables

	private string _birthPlace;

	public int Age          // another one public property
	{
		get                 // getter of the property
		{
			return _age;
		}
		set                 // setter of the property
		{
			if (value <= 0 || value >= 140) 
				throw new Exception();
				
			_age = value;
		}
	}

	public string Name { get; set; } // public property

	public string PropertiesString
	{
		get
		{
			return $"Name: {Name}, Age: {Age}.";
		}
	}

	public string GetPropertiesString()
	{
		return $"Name: {Name}, Age: {Age}.";
	}

	public void SetBirthPlace(string birthPlace)
	{
		if (birthPlace == null)
		{
			throw new ArgumentNullException(nameof(birthPlace));
		}

		if (_birthPlace != null)
		{
			throw new Exception("Birth place cannot be overriden.");
		}

		_birthPlace = birthPlace;
	}

	public void WriteOutProperties()
	{
		Console.WriteLine(PropertiesString);
	}
}
