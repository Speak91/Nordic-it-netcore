using System;

namespace Lesson05_06_self_work3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите длительность договора аренды в годах: ");
			string inputString = Console.ReadLine();

			int numberOfYears = 0;

			try
			{
				numberOfYears = int.Parse(inputString);
			}
			catch(FormatException e)
			{
				Console.WriteLine($"Вы ввели нецелочисленное значение, код ошибки: {e.HResult}");
				throw;
				// throw new Exception(); << это плохо, так как скрывает оригинальное исключение.
			}
			catch(OverflowException e)
			{
				Console.WriteLine($"Вы ввели значение вне разрешённого дипазона, код ошибки: {e.HResult}");
				throw;
			}
			catch(Exception e)
			{
				Console.WriteLine($"Неизвестная ошибка, код ошибки: {e.HResult}");
				throw;
			}

			if (numberOfYears < 1 || numberOfYears > 30)
			{
				throw new Exception("Введённое значение выходит за рамки диапазона 1..30.");
				// Console.WriteLine("Вы ввели неверное значение!");
				// return;
			}

			string yearsString = string.Empty;

			switch (numberOfYears)
			{
				case 1:
				case 21:
					yearsString = "год";
					break;
				case 2:
				case 3:
				case 4:
				case 22:
				case 23:
				case 24:
					yearsString = "года";
					break;
				default:
					yearsString = "лет";
					break;
			}

			Console.WriteLine(
				"Договор аренды оформлен на период длительностью "
				+ $"{numberOfYears} {yearsString}");
		}
	}
}
