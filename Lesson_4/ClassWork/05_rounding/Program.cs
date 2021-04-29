using System;

namespace _05_rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05_rounding");
            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            double m = 10.51;

            Console.WriteLine(Convert.ToInt32(i)); // 9
            Console.WriteLine(Convert.ToInt32(j)); // 10
            Console.WriteLine(Convert.ToInt32(k)); // 10
            Console.WriteLine(Convert.ToInt32(l)); // it will be 10!
            Console.WriteLine(Convert.ToInt32(m)); // 11

            double f = Math.Round(l, 0 , MidpointRounding.AwayFromZero);
            Console.WriteLine(f);

            double z = 0.15;
            Console.WriteLine(Math.Floor(z));
            Console.WriteLine(Math.Ceiling(z));
        }
    }
}
