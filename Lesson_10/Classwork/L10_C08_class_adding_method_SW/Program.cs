using System;

namespace L10_C08_class_adding_method_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var petPresenterConsole = new PetPresenterConsole();
			var petPresenterFile = new PetPresenterFile();

			Pet pet1 = new Pet();
			pet1.Kind = PetKind.Cat;
			pet1.Name = "Tom";
			pet1.Sex = 'M';
			pet1.Age = 8;
			pet1.SetBirthPlace("Moscow");

			petPresenterConsole.Present(pet1);
			petPresenterFile.Present(pet1, @"d:\pet1.txt");

			Pet pet2 = new Pet
			{
				Kind = PetKind.Mouse,
				Name = "Minnie",
				Sex = 'F',
				Age = 1
			};
			pet2.SetBirthPlace("St.Petersburg");

			petPresenterConsole.Present(pet2);
			petPresenterFile.Present(pet1, @"d:\pet2.txt");
		}
	}
}