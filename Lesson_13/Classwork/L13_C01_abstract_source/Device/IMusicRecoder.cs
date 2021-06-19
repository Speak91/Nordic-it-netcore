using System;
using System.Collections.Generic;
using System.Text;

namespace L13_C01_abstract_source.Device
{
	interface IMusicRecoder
	{
		string RecordingDestination { get; set; }

		void RecordMusic(TimeSpan duration);
	}
}
