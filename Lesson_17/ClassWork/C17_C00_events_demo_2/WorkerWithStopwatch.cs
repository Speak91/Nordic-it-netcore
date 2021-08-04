using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C17_C00_events_demo_2
{
	public class WorkerWithStopwatch: Worker
	{
		private long _lastWorkElapsedMilliseconds = 0;

		public override void DoWork(int hours, WorkType workType)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			base.DoWork(hours, workType);

			sw.Stop();
			_lastWorkElapsedMilliseconds = sw.ElapsedMilliseconds;
			Debug.WriteLine($"Worker '{Name}' finished his work in {sw.ElapsedMilliseconds} ms");	
		}

		protected override void OnWorkComplete(object sender, EventArgs e)
		{

			base.OnWorkComplete(sender, e);

		}
	}
}
