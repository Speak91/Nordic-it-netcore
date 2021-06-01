using System;
using System.Diagnostics;

namespace Lesson09_01_BubbleSorting
{
	class Program
	{
		static void Main(string[] args)
		{
			const int maxValue = int.MaxValue;
			const int arrayLength = 1000;

			for (int i = 1; i < 41; i++)
			{
				var sw = new Stopwatch();
				int[] arr = GetSourceArray(i * arrayLength, maxValue);
				//WriteArray(arr);

				sw.Start();
				int[] bubbleSortedArray = BubbleSort(arr);
				sw.Stop();
				long bubbleMs = sw.ElapsedMilliseconds;

				sw.Reset();

				sw.Start();
				int[] dotNetSortedArray = DotNetSort(arr);
				sw.Stop();
				long dotNetMs = sw.ElapsedMilliseconds;

				Console.WriteLine($"Bubble: {bubbleMs}ms\t\t.NET: {dotNetMs}ms");
				//WriteArray(arr);
			}
		}

		static int[] DotNetSort(int[] arr)
		{
			var result = (int[])arr.Clone();
			Array.Sort(result);
			return result;
		}

		static int[] BubbleSort(int[] arr)
		{
			//var result = new int[arr.Length];
			//arr.CopyTo(result, 0);
			var result = (int[])arr.Clone();

			for (int j = 0; j < result.Length - 1; j++)
			{
				int limit = result.Length - j - 1;
				for (int i = 0; i < limit; i++)
				{
					if (result[i] > result[i + 1])
					{
						int temp = result[i + 1];
						result[i + 1] = result[i];
						result[i] = temp;
					}
				}
			}

			return result;
		}

		static void WriteArray(int[] array)
		{
			Console.WriteLine(string.Join(", ", array));
		}

		static int[] GetSourceArray(int length, int maxValue)
		{
			int[] arr = new int[length];

			var rnd = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxValue);
			}

			return arr;
		}
	}
}
