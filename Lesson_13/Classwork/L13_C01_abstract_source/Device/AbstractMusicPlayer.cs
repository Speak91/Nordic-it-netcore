using System;
using System.Collections.Generic;
using System.Text;

namespace L13_C01_abstract_source.Device
{
	public abstract class AbstractMusicPlayer: IMusicPlayer, IRestartable
	{
		protected ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public virtual void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				_writer.WriteLineWithYellow("It is nothing to play. Set the music source and try again.");
				return;
			}

			_writer.WriteLineWithYellow($"Playing music from {MusicSource}");
		}

		public abstract void Restart();
	}
}
