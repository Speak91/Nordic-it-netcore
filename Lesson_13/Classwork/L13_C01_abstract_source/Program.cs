using L13_C01_abstract_source.Device;
using System;

namespace L13_C01_abstract_source
{
	class Program
	{
		static void Main(string[] args)
		{
			//AbstractMusicPlayer amp = new AbstractMusicPlayer();

			var  consoleWriter = new ConsoleWriter();

			//consoleWriter.WriteLineWithGreen("Class MobilePhone\n");

			var mobilePhone = new MobilePhone(consoleWriter);
			//mobilePhone.Call("+7916291XXXX");
			//mobilePhone.MusicSource = "Music in a Social Network";
			//mobilePhone.PlayMusic();
			//mobilePhone.Restart();

			consoleWriter.WriteLineWithGreen("\nClass RadioRecorder\n");

			var radioRecorder = new RadioRecorder(consoleWriter);
			//radioRecorder.MusicSource = "FM Radio Channel";
			//radioRecorder.PlayMusic();
			//radioRecorder.RecordingDestination = "Flash Drive";
			//radioRecorder.RecordMusic(TimeSpan.FromSeconds(15));
			//radioRecorder.Restart();

			consoleWriter.WriteLineWithGreen("\nClass VideoPlayer\n");

			var videoPlayer = new VideoPlayer(consoleWriter);
			//videoPlayer.VideoSource = "YouTube";
			//videoPlayer.PlayVideo();
			//videoPlayer.PlayMusic();
			//videoPlayer.MusicSource = "Podcast Server";
			//videoPlayer.PlayMusic();
			//videoPlayer.Restart();

			consoleWriter.WriteLine("\n\n");


			object[] devices = new object[3];
			devices[0] = mobilePhone;
			devices[1] = radioRecorder;
			devices[2] = videoPlayer;

			foreach (object device in devices)
			{
				if (device is AbstractMusicPlayer)
				{
					((AbstractMusicPlayer)device).MusicSource = "Internet";
					((AbstractMusicPlayer)device).PlayMusic();
				}

				if (device is ICaller)
				{
					((ICaller)device).Call("555-55-55");
				}

				if (device is VideoPlayer)
				{
					((VideoPlayer)device).VideoSource = "Internet";
					((VideoPlayer)device).PlayVideo();
				}

				if (device is IMusicRecoder)
				{
					((IMusicRecoder)device).RecordingDestination = "flash";
					((IMusicRecoder)device).RecordMusic(TimeSpan.FromSeconds(10));
				}
			}
		}
	}
}
