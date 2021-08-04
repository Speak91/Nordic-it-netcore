using System;

namespace L17_C06_events_eventargs_SW
{
	public class RandomDataGenerator
	{
		public event EventHandler<RandomDataEventArgs> RandomDataGenerated;
		public event EventHandler<RandomDataGenerationDoneEventArgs> RandomDataGenerationDone;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			var result = new byte[dataSize];
			var rand = new Random();

			for(int i = 0; i < dataSize; i++)
			{
				result[i] = (byte)rand.Next(256);

				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					OnRandomDataGenerated(
						this,
						new RandomDataEventArgs
						{
							BytesDone = i + 1,
							TotalBytes = dataSize
						});
				}				
			}

			OnRandomDataGenerationDone(
				this,
				new RandomDataGenerationDoneEventArgs { RandomData = result });

			return result;
		}

		protected virtual void OnRandomDataGenerated(
			object sender, RandomDataEventArgs e)
		{
			if (RandomDataGenerated != null)
			{
				RandomDataGenerated(sender, e);
			}
		}

		protected virtual void OnRandomDataGenerationDone(
			object sender, RandomDataGenerationDoneEventArgs e)
		{
			if (RandomDataGenerationDone != null)
			{
				RandomDataGenerationDone(sender, e);
			}
		}
	}
}
