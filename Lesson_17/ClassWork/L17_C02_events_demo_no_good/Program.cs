using System;

namespace L17_C02_events_demo_no_good
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	class Program
	{
		public delegate int WorkPerformedHandler(
			int hours,
			WorkType workType);

		static void Main(string[] args)
		{
			var del1 = new WorkPerformedHandler(WorkPerformed1);
			var del2 = new WorkPerformedHandler(WorkPerformed2);
			var del3 = new WorkPerformedHandler(WorkPerformed3);

			del1 += del2 + del3;

			int finalResult = del1(1, WorkType.Work);
			Console.WriteLine(finalResult);
		}

		static int WorkPerformed1(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed1)} called with ({workType},{hours})");

			return hours + 1;
		}

		static int WorkPerformed2(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed2)} called with ({workType},{hours})");

			return hours + 2;
		}

		static int WorkPerformed3(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed3)} called with ({workType},{hours})");

			return hours + 3;
		}
	}
}
