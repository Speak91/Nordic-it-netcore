using System;

namespace _07_enums
{
    class Program
    {
        enum Season : byte
        {
            Winter = 3,
            Spring = 6,
            Summer = 9,
            Autumn = 12
        }
        enum Day {Mo, Tu, We, Th, Fr, Sa, Su}
        
        enum DateTime : byte 
        { 
           Morning = 100,
           Midday = 150,
           Evening = 200,
           Night = 250,
        }
        
        static void Main(string[] args)
        {
            var today = Day.We;

            Console.WriteLine(today);

            Console.WriteLine("Enter current day time: ");
            var seasons = (Season)Enum.Parse(typeof(Season), Console.ReadLine());
            Console.WriteLine(seasons);

            //Season now = Season.Spring;
            //int numberForSummer = ((int)now) + 3; //Вывод чисел enum
            //Console.WriteLine(((Season)numberForSummer));         

        }
    }
}
