using System;

namespace L13_C01_abstract_source.Device
{
	public class VideoPlayer: AbstractMusicPlayer, IVideoPlayer
	{
		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLineWithCyan("Starting work with Video Player");
		}

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				_writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			_writer.WriteLine($"Playing video from {VideoSource}");
		}

		public override void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Video Player... Please wait about 10 seconds.");
		}
	}
}
