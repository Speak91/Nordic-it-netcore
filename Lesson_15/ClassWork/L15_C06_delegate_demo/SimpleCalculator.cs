using System.Diagnostics;

namespace L15_C06_delegate_demo
{
	public static class SimpleCalculator
	{
		public static int Sum(int x, int y)
		{
			Debug.WriteLine($"{nameof(Sum)} called");
			return x + y;
		}

		public static int Multiply(int x, int y)
		{
			Debug.WriteLine($"{nameof(Multiply)} called");
			return x * y;
		}
	}
}
