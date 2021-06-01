using System;

namespace L10_C08_class_adding_method_SW
{
	class PetPresenterConsole
	{
		public void Present(Pet pet)
		{
			Console.WriteLine(pet.Description);
		}
	}
}
