using System;

namespace ConsoleApp18
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
            const int packetSizeL = 20;

            int numberOfLargePackets = 0; //переменная для записи количества больших пакетов
            int numberOfMediumPackets = 0; //переменная для записи количества средних пакетов
            int numberOfSmallPackets = 0; //переменная для записи количества маленьких пакетов

            double input = 0; //Запись ввода пользователя

            PacketSizes usedPacketSizes = 0;

            int remainderDivision = 0; //переменная для записи остатка от деления

            Console.WriteLine("Данная программа позволит расчитать, какое количество упаковок обьемом 1л, 5л, 20л \nпотребуется для упаковки вашего сока");
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");

            while (!double.TryParse(Console.ReadLine(), out input))  //ввод пользователя
            {
                Console.WriteLine("Неправильный ввод повторите попытку");
            }

            int value = (int)Math.Ceiling(input); //округление

            numberOfLargePackets = value / packetSizeL;
            remainderDivision = value % packetSizeL;

            if (remainderDivision > 0)
            {

                numberOfMediumPackets = remainderDivision / packetSizeM;
                remainderDivision = remainderDivision % packetSizeM;

                if (remainderDivision > 0)
                {
                    numberOfSmallPackets = remainderDivision;
                }

            }

            if (numberOfLargePackets > 0)
                usedPacketSizes = usedPacketSizes | PacketSizes.Large;

            if (numberOfMediumPackets > 0)
                usedPacketSizes = usedPacketSizes | PacketSizes.Medium;

            if (numberOfSmallPackets > 0)
                usedPacketSizes = usedPacketSizes | PacketSizes.Small;

            if ((usedPacketSizes & PacketSizes.Large) > 0)
            {
                Console.WriteLine("Вам потребуются следующие контейнеры: ");
                Console.WriteLine($"{packetSizeL} л: {numberOfLargePackets} шт.");
            }

            if ((usedPacketSizes & PacketSizes.Medium) > 0)
            {
                Console.WriteLine($"{packetSizeM} л: {numberOfMediumPackets} шт.");
            }

            if ((usedPacketSizes & PacketSizes.Small) > 0)
            {
                Console.WriteLine($"{packetSizeS} л: {numberOfSmallPackets} шт.");
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

    }
}
