using System;
using System.Diagnostics;

namespace L15_C06_delegate_demo
{
	//delegate int DoCalc(int a, int b);

	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(SimpleCalculator.Sum(10, 10));
			//Console.WriteLine(SimpleCalculator.Multiply(10, 10));

			//DoCalc performCalculation;
			int result;

			//performCalculation = SimpleCalculator.Sum;
			//result = performCalculation(10, 5);
			//Console.WriteLine(result);

			//performCalculation = SimpleCalculator.Multiply;
			//result = performCalculation(10, 5);
			//Console.WriteLine(result);

			//Console.WriteLine("***");

			//DoCalc doCalc1 = SimpleCalculator.Sum;
			//DoCalc doCalc2 = SimpleCalculator.Multiply;
			//DoCalc doCalc3 = (DoCalc)Delegate.Combine(doCalc1, doCalc2);

			//result = doCalc3(100, 100);
			//Console.WriteLine("doCalc3 (Sum, Multiply) = " + result);

			//DoCalc doCalc4 = doCalc1;
			//doCalc4 += doCalc2;
			//doCalc4 += doCalc3;
			//result = doCalc4(100, 100);
			//Console.WriteLine("doCalc4 (Sum, Multiply,(Sum, Multiply)) = " + result);

			//Console.WriteLine("***");
			//Debug.WriteLine("***");
			//doCalc4 = (DoCalc)Delegate.Remove(doCalc4, doCalc3);
			//result = doCalc4(100, 100);
			//Console.WriteLine("doCalc4 (Sum, Multiply) = " + result);

			//doCalc4 -= doCalc2;
			//result = doCalc4(100, 100);
			//Console.WriteLine("doCalc4 (Sum) = " + result);

			Func<int, int, int> performCalculation;
			performCalculation = SimpleCalculator.Sum;
			result = performCalculation(100, 100);
			Console.WriteLine(result);

			
			ConsoleWriteLine(1, 1.5F, true);
			Action<int, float, bool> cw;
			cw = ConsoleWriteLine;
			cw(15, MathF.PI, false);
		}

		private static void ConsoleWriteLine(int a, float b, bool c)
		{
			Console.WriteLine($"{a}, {b}, {c}");
		}
	}
}
