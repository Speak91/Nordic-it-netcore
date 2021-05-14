using System;

namespace Lesson05_05_switch
{
	class Program
	{
		public enum Color
		{
			Red, // 0
			Green, // 1
			Blue // 2
		}

		static void Main(string[] args)
		{
			var randomInstance = new Random();

			Color color = (Color)randomInstance.Next(0, 3);
			switch (color)
			{
				case Color.Red:
				case Color.Blue:
					Console.WriteLine("Red or Blue");
					break;
				case Color.Green:
					Console.WriteLine("Green");
					break;
				default:
					Console.WriteLine("Unknown");
					break;
			}

			int a = 10;
			switch (a)
			{
				case > 5: // for .net core 5+
					Console.WriteLine("a > 5");
					break;
			}
		}
	}
}
