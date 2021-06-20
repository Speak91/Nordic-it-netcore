using System.Collections.Generic;

namespace L14_C00_interface_IDictionary_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "string 1";

			IteratorDemo iteratorDemo = new IteratorDemo();
			iteratorDemo[10] = "string 10";

			System.Console.WriteLine(iteratorDemo[10]);

		}
	}
}
