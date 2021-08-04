using System;

namespace L17_C04_events_SW
{
	public delegate void RandomDataGeneratedHandler(int bytesDone, int totalBytes);

	public class RandomDataGenerator
	{
		public event RandomDataGeneratedHandler RandomDataGenerated;
		public event EventHandler RandomDataGenerationDone;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			var result = new byte[dataSize];
			var rand = new Random();

			for(int i = 0; i < dataSize; i++)
			{
				result[i] = (byte)rand.Next(256);

				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					OnRandomDataGenerated(i + 1, dataSize);
				}
			}

			OnRandomDataGenerationDone(this, EventArgs.Empty);

			return result;
		}

		protected virtual void OnRandomDataGenerated(int bytesDone, int totalBytes)
		{
			if (RandomDataGenerated != null)
			{
				RandomDataGenerated(bytesDone, totalBytes);
			}
		}

		protected virtual void OnRandomDataGenerationDone(object sender, EventArgs e)
		{
			if (RandomDataGenerationDone != null)
			{
				RandomDataGenerationDone(sender, e);
			}
		}
	}
}
