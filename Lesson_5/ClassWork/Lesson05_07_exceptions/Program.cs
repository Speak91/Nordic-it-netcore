using System;

namespace Lesson05_07_exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter the number value less than 100: ");
			string input = Console.ReadLine();
			int num = int.Parse(input);

			if (num >= 100)
			{
				var ex = new Exception("The program can't work with the value more or equals to 100.");
				throw ex;
			}
		}
	}
}
