using System;

namespace _01_arithmetic_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("01_arithmetic_operators!");
           
            Console.WriteLine(11 / 3);
            Console.WriteLine(11F / 3);
            Console.WriteLine(11.0 / 3);
            Console.WriteLine(11 % 3);
           
            Console.WriteLine("----------------");
           
            const int arg1 = 100;
            const int arg2 = 7;
            
            Console.WriteLine(arg1 + arg2);
            Console.WriteLine(arg1 - arg2);
            Console.WriteLine(arg1 / arg2);
            Console.WriteLine(arg1 * arg2);
            Console.WriteLine(arg1 % arg2);
           
            Console.WriteLine("----------------");
            
            const double arg3 = 48.13;
            const double arg4 = 2.5;
            Console.WriteLine(arg3 + arg4);
            Console.WriteLine(arg3 - arg4);
            Console.WriteLine(arg3 / arg4);
            Console.WriteLine(arg3 * arg4);
            Console.WriteLine(arg3 % arg4);

        }
    }
}
