using System;

namespace L11_С17_PhoneBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var phoneBook = new PhoneBook();
			phoneBook.AddContact(new Contact("Andrei", "88005555555", "Moscow"));
			phoneBook.AddContact(new Contact("Masha", "88000999999", "Piter"));

			Console.WriteLine(phoneBook.FindContact("Andrei")?.Description);
			Console.WriteLine(phoneBook.FindContact("Ivan")?.Description);
		}
	}
}
