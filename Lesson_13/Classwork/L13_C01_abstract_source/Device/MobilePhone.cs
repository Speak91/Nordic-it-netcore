using System;

namespace L13_C01_abstract_source.Device
{
	public class MobilePhone : AbstractMusicPlayer, ICaller
	{
		public MobilePhone(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLineWithCyan("Starting work with Mobile Phone");
		}

		public void Call(string phoneNumber)
		{
			_writer.WriteLine($"Calling {phoneNumber}...");
		}

		public override void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Mobile Phone... Displaying splash screen while loading.");
		}
	}
}
