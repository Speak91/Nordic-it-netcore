namespace L15_C01_generic_methods
{

	public static class Swapper
	{
		public static void Swap<T>(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}

		//public static void Swap<T>(ref T a, ref T b) where T : struct
		//{
		//	T temp = a;
		//	a = b;
		//	b = temp;
		//}

		//public static void Swap<T>(ref T a, ref T b) where T: class
		//{
		//	T temp = a;
		//	a = b;
		//	b = temp;
		//}
	}
}
