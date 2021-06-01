using System;


class Program
{
	static void Main(string[] args)
	{
		var pet1 = new Pet();
		pet1.Age = 10;
		pet1.Name = "Leo";
		pet1.Kind = PetKind.Mouse;
		pet1.Sex = 'f';

		Console.WriteLine(pet1.Description);

		var pet2 = new Pet
		{
			Name = "Bob",
			Age = 15,
			Kind = PetKind.Dog,
			Sex = 'M'
		};

		Console.WriteLine(pet2.Description);
	}
}
