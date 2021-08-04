using System;
using System.Collections.Generic;
using System.Text;

namespace C17_C00_events_demo_2
{

	public class Worker
	{
		public string Name { get; set; }

		public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

		public event EventHandler WorkComplete;

		public Worker()
		{
		}

		public Worker(string name)
		{
			Name = name;
		}

		public virtual void DoWork(int hours, WorkType workType)
		{
			for(int i = 0; i < hours; i++)
			{
				for (int j = 0; j < 100000; j++);

				var e = new WorkPerformedEventArgs
				{
					Hours = i + 1,
					WorkType = workType
				};
				OnWorkPerformed(this,e);
			}

			OnWorkComplete(this, EventArgs.Empty);
		}

		protected virtual void OnWorkPerformed(object sender, WorkPerformedEventArgs e)
		{
			WorkPerformed?.Invoke(sender, e);
		}

		protected virtual void OnWorkComplete(object sender, EventArgs e)
		{
			WorkComplete?.Invoke(sender, e);
		}
	}
}
