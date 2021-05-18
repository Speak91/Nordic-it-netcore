using System;

namespace Lesson06_04_while
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] numbers = { -1.5F, 2.5F, 17.5F, -2F };

			float sum = 0;
			int i = 0;
			while (i < 4)
			{
				sum += numbers[i++];
				Console.WriteLine($"The sum of numbers is {sum}");
			}

			// Expected output
			// -1.5
			// 1.0
			// 18.5
			// 16.5
		}
	}
}
