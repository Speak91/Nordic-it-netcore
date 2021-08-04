using System;
using System.Threading;

namespace C17_C00_events_demo_2
{
	public class WorkPerformedEventArgs : EventArgs
	{
		public int Hours { get; set; }
		public  WorkType WorkType { get; set; }
    }

	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			Thread threadForAlice = new Thread(() =>
			{
				Worker workerAlice = new Worker("Alice");
				workerAlice.WorkPerformed += OnWorkerWorkPerformed;
				workerAlice.WorkComplete += OnWorkerWorkComplete;
				workerAlice.DoWork(20, WorkType.Work);
			});

			Thread threadForBob = new Thread(() =>
			{
				Worker workerBob = new Worker("Bob");
				workerBob.WorkPerformed += OnWorkerWorkPerformed;
				workerBob.WorkComplete += OnWorkerWorkComplete;
				workerBob.DoWork(5, WorkType.DoNothing);
			});

			threadForAlice.Start();
			threadForBob.Start();

			threadForAlice.Join();
			threadForBob.Join();
		}

		private static void OnWorkerWorkPerformed(object sender, WorkPerformedEventArgs e)
		{
			Console.WriteLine($"Work of type '{e.WorkType}' performed for about {e.Hours} hours.");
		}

		static void OnWorkerWorkComplete(object sender, EventArgs e)
		{
			if (sender != null)
				Console.WriteLine($"{((Worker)sender).Name} has finished his work!");
		}
	}
}
