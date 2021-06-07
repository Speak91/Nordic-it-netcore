using System;

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = "Cat";
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		pet1.DateOfBirth = DateTimeOffset.Parse("2012-01-01T12:00:00+0300");
		pet1.WriteDescription("*");

		Pet pet2 = new Pet
		{
			Kind = "Mouse",
			Name = "Minnie",
			Sex = 'F',
			DateOfBirth = DateTimeOffset.Parse("2016-06-01T12:00:00+0300")
		};
		pet2.WriteDescription("+", true);
	}
}