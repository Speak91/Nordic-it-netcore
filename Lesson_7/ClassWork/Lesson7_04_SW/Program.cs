using System;

namespace Lesson7_04_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			//const int size = 100;
			//double[] values = new double[size];
			//const double startValue = 0;

			//for (int i = 0; i < size; i++)
			//{
			//	values[i] = startValue + i * double.Epsilon;
			//}

			//for (int i = 0; i < size; i++)
			//{
			//	Console.WriteLine(
			//		$"{values[i]}\t" +
			//		$"{Math.BitIncrement(values[i])}\t" +
			//		$"{Math.BitDecrement(values[i])}");
			//}

			//Console.WriteLine("Enter two real numbers to multiply them:");
			//var d1 = double.Parse(Console.ReadLine());
			//var d2 = double.Parse(Console.ReadLine());

			//Console.WriteLine(
			//	d1.ToString("0:#") + " * " + d2.ToString("0:#") + " = " +
			//	(d1 * d2).ToString("0:#"));
			//Console.WriteLine("{0:0.##} + {1:0.##} = {2:0.##}", d1, d2, d1 + d2);
			//Console.WriteLine($"{d1:#.##} * {d2:#.##} = {d1 * d2:#.##}");

			//double numberOne = GetDoubleValueSafe("Введите первое вещественное число");
			//double numberTwo = GetDoubleValueSafe("Введите второе вещественное число");

			//Console.WriteLine("Конкатенация " + numberOne + " * " + numberTwo + " = " + numberOne * numberTwo);
			//Console.WriteLine("Форматированние {0:#.##} + {1:#.##} = {2:#.##}", numberOne, numberOne, numberOne + numberTwo);
			//Console.WriteLine($"Интерполяция {numberOne} - {numberTwo} = {Math.BitIncrement(numberOne - numberTwo)}");

			Console.WriteLine("Enter two real numbers to multiply them: ");
			var d1 = double.Parse(Console.ReadLine());
			var d2 = double.Parse(Console.ReadLine());

			Console.WriteLine(
				d1.ToString("0.#") + "*" + d2.ToString("0.#") + "=" + (d1 * d2).ToString("0.#"));

			Console.WriteLine("{0:0.##}+{1:0.##}={2:0.##}", d1, d2, d1 + d2);
			Console.WriteLine($"{d1:#.##} - {d2:#.##}={d1 - d2:#.##}");
		}

		static double GetDoubleValueSafe(string prompt)
		{
			Console.WriteLine(prompt);
			double number;
			while (double.TryParse(Console.ReadLine(), out number) == false)
			{
				Console.WriteLine("Вы ввели не корректное значение");
			}

			return number;
		}
	}
}
