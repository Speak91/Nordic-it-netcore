using System;
using System.IO;

namespace L10_C08_class_adding_method_SW
{
	class PetPresenterFile
	{
		public void Present(Pet pet, string fileName)
		{
			File.WriteAllText(fileName, pet.Description);
		}
	}
}
