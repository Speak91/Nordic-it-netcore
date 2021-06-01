using System;

partial class Program
{
	static void Main()
	{
		var pet1 = new Pet();
		pet1.Age = 10;
		pet1.Name = "Leo";
		pet1.Kind = PetKind.Mouse;
		pet1.Sex = 'f';

		Console.WriteLine($"{pet1.Name} is a {pet1.Kind} ({pet1.Sex}) of {pet1.Age} years old.");

		var pet2 = new Pet
		{
			Name = "Bob",
			Age = 15,
			Kind = PetKind.Dog,
			Sex = 'M'
		};

		Console.WriteLine($"{pet2.Name} is a {pet2.Kind} ({pet2.Sex}) of {pet2.Age} years old.");
	}
}
