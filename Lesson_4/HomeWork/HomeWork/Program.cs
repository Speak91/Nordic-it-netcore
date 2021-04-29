using System;

namespace HomeWork
{
    class Program
    {

        [Flags]

        enum Packaging
        {
            packingVolumeOf1Liters = 0001,
            packingVolumeOf5Liters = 0b0101,
            packingVolumeOf20Liters = 0b010100
        }

        static void Main(string[] args)
        {
            int width = 83;
            int height = 25;

            double input = 0;
            Console.SetWindowSize(width, height);
            Console.WriteLine("Данная программа позволит расчитать, какое количество упаковок обьемом 1л, 5л, 20л \nпотребуется для упаковки вашего сока");
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");

            while (!double.TryParse(Console.ReadLine(), out input))  //ввод пользователя
            {
                Console.WriteLine("Неправильный ввод повторите попытку");
            }

            int value = (int)Math.Ceiling(input); //округление 
            int remainderDivision = 0; //переменная для записи остатка от деления
            int result = 0; //результат деления

            var a = Convert.ToInt32(Packaging.packingVolumeOf1Liters);
            var b = Convert.ToInt32(Packaging.packingVolumeOf5Liters);
            var c = Convert.ToInt32(Packaging.packingVolumeOf20Liters);

            result = value / c; //Расчет необходимого количества 20 литровых упаковок
            remainderDivision = value % c;

            Console.WriteLine("Вам потребуются следующие контейнеры: ");
            Console.WriteLine($"20 л: {result}шт.");

            if (remainderDivision <= 0) //Проверка на отсутствие остатка
            {
                Console.WriteLine("Для закрытия программы нажмите любую кнопку");
                Console.ReadKey();
                return;
            }

            result = remainderDivision / b; //Расчет необходимого количества 5 литровых упаковок
            remainderDivision = remainderDivision % b; ////Расчет необходимого количества литровых упаковок

            if (result > 0)
            {
                Console.WriteLine($"5 л: {result}шт.");
            }

            if (remainderDivision <= 0)
            {
                Console.WriteLine("Для закрытия программы нажмите любую кнопку");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"1 л: {remainderDivision}шт.");
            Console.WriteLine("Для закрытия программы нажмите любую кнопку");
            Console.ReadKey();

        }
    }
}
