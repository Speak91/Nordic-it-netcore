using System;
using System.Collections.Generic;
using System.Text;

namespace L17_C06_events_eventargs_SW
{
	public class RandomDataGenerationDoneEventArgs: EventArgs
	{
		public byte[] RandomData { get; set; }
	}
}
