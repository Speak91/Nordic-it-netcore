using System;

namespace C17_C00_events_demo
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public class Program
	{
		public delegate void WorkPerformedEventHandler(int hours, WorkType workType);

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			WorkPerformedEventHandler del1 = WorkPerformed1;

			//WorkPerformed1(8, WorkType.Work);
			//del1(8, WorkType.Work);

			//WorkPerformed1(1, WorkType.DoNothing);
			//del1(1, WorkType.DoNothing);

			WorkPerformedEventHandler del2 = WorkPerformed2;
			WorkPerformedEventHandler del3 = WorkPerformed3;
			del3 += del1 + del2;  // del3 = WorkPerformed3, WorkPerformed1, WorkPerformed2
			del3 -= del1;         // del3 = WorkPerformed3, WorkPerformed2
			del3(2, WorkType.DoNothing);
		}

		public static void WorkPerformed1(int hours, WorkType workType)
		{
			Console.WriteLine($"1 Work of type '{workType}': {hours} hours");
		}

		public static void WorkPerformed2(int hours, WorkType workType)
		{
			Console.WriteLine($"2 Work of type '{workType}': {hours} hours");
		}

		public static void WorkPerformed3(int hours, WorkType workType)
		{
			Console.WriteLine($"3 Work of type '{workType}': {hours} hours");
		}
	}
}
