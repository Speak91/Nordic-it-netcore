using System;

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = "Cat";
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		pet1.DateOfBirth = DateTimeOffset.Parse("2011-03-14");
		pet1.WriteDescription();

		Pet pet2 = new Pet
		{
			Kind = "Mouse",
			Name = "Minnie",
			Sex = 'F',
			DateOfBirth = DateTimeOffset.Parse("2017-03-14")
		};
		pet2.WriteDescription(true);

		pet1.UpdateParameters("Garfield");
		pet1.WriteDescription();

		pet1.UpdateParameters(
			"Mouse",
			"Mickey",
			'M',
			DateTimeOffset.Parse("2017-01-01"));
		pet1.WriteDescription(true);
	}
}