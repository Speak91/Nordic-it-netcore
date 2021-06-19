using System;
using System.Collections.Generic;
using System.Text;

namespace L13_C01_abstract_source.Device
{
	interface IVideoPlayer
	{
		string VideoSource { get; set; }

		void PlayVideo();
	}
}
