using System;

namespace L15_C01_generic_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			// int

			object o1 = new object();
			object o2 = o1;

			int a = -1;
			int b = 100;

			Console.WriteLine($"a = {a}, b = {b}");

			Swapper.Swap(ref a, ref b);

			Console.WriteLine($"a = {a}, b = {b}");

			// byte

			byte c = 0;
			byte d = 100;

			Console.WriteLine($"c = {c}, d = {d}");

			Swapper.Swap(ref c, ref d);

			Console.WriteLine($"c = {c}, d = {d}");

			// string

			string s1 = "s1";
			string s2 = "s2";

			Console.WriteLine($"{nameof(s1)} = {s1}, {nameof(s2)} = {s2}");

			Swapper.Swap(ref s1, ref s2);

			Console.WriteLine($"{nameof(s1)} = {s1}, {nameof(s2)} = {s2}");

			// Account
			var account1 = new Account<int>(1, "Andrei");
			var account2 = new Account<int>(2, "Petr");

			Console.WriteLine($"{nameof(account1)} = {account1}, {nameof(account2)} = {account2}");

			Swapper.Swap(ref account1, ref account2);

			Console.WriteLine($"{nameof(account1)} = {account1}, {nameof(account2)} = {account2}");

			Account<int> account3;
			UpdateName(out account3);
			int i = account3.Id;
			Console.WriteLine($"{nameof(account1)} = {account1}");

			AccountFabrique fabrique = new AccountFabrique();
			//var account = fabrique.CreateAccount<int>(10, "Nadia");

			var account12 = fabrique.CreateAccount<Account<int>>();
			account12.Name = "Created from fabrique";
			Console.WriteLine(account12);
		}

		private static void UpdateName(out Account<int> account)
		{
			account = new Account<int>(3, "Sveta");
			account.Name = "Mr./Mrs. " + account.Name;
		}
	}
}
