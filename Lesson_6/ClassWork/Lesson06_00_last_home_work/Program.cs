using System;

namespace Lesson06_00_last_home_work
{
	enum VegitableType
	{
		Carrot = 1,
		Potato = 2,
		Tomato = 3,
	}

	class Program
	{
		static void Main(string[] args)
		{
			VegitableType vegitableType;

			Console.WriteLine("Выберите с чем мы будем работать: 1 - морковка, 2 - картошка, 3 - помидоры");
			try
			{
				vegitableType = (VegitableType)int.Parse(Console.ReadLine());
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			Console.WriteLine("Введите количество овощей в килограммах: ");

			switch (vegitableType)
			{
				case VegitableType.Carrot:
					//Console.WriteLine("Введите количество моркови в килограммах: ");
					break;

				case VegitableType.Potato:
					//Console.WriteLine("Введите количество картошки в килограммах: ");
					break;

				case VegitableType.Tomato:
					//Console.WriteLine("Введите количество помидоров в килограммах: ");
					break;

				default:
					throw new InvalidOperationException("Unexpected option.");
			}

			Console.WriteLine("Hello World!");
		}
	}
}
