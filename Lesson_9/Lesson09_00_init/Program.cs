using System;

namespace Lesson09_00_init
{
	class Program
	{
		static void Main(string[] args)
		{
			const int length = 500;
			const int maxValue = 1000;

			var arr = new int[length];
			var rnd = new Random();

			for (int i = 0; i < arr.Length; i++) // N
			{
				arr[i] = rnd.Next(maxValue);
			}

			for (int i = 0; i < arr.Length; i++) // N
			{
				Console.WriteLine(arr[i]);
			}

			// O(N)
		}
	}
}
