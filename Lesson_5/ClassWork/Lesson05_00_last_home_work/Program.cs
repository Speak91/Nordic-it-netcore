using System;

namespace Lesson5_ClassWork
{
	class Program
	{
		[Flags]
		enum PacketSizes
		{
			Small = 1,   // 0x0000001
			Medium = 1 << 1,  // 0x0000010
			Large = 1 << 2,   // 0x0000100
		}

		static void Main(string[] args)
		{
			const int packetSizeS = 1;
			const int packetSizeM = 5;
			const int packetSizeL = 15;

			float value = 60.21F;
			int numberOfLargePackets = (int)(value / packetSizeL);
			int numberOfMediumPackets = 0;
			int numberOfSmallPackets = 1;

			PacketSizes usedPacketSizes = 0;

			if (numberOfLargePackets > 0)
				usedPacketSizes = usedPacketSizes | PacketSizes.Large;

			if (numberOfMediumPackets > 0)
				usedPacketSizes = usedPacketSizes | PacketSizes.Medium;

			if (numberOfSmallPackets > 0)
				usedPacketSizes = usedPacketSizes | PacketSizes.Small;

			Console.WriteLine("Hello World!");

			if ((usedPacketSizes & PacketSizes.Large) > 0)
			{
				// numberOfLargePackets of 15-litters packets
			}
			
			if (numberOfMediumPackets > 0)
			{
				// numberOfMediumPackets of 5-litters packets
			}

			if (numberOfSmallPackets > 0)
			{
				// numberOfSmallPackets of 1-litters packets
			}
		}
	}
}
