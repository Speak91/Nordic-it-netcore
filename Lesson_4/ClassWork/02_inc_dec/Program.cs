using System;

namespace _02_inc_dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02_inc_dec");

            int a = 0;
            int b = 0;

            Console.WriteLine(a++); // 0
            Console.WriteLine(++b); // 1

            Console.WriteLine(a);   // 1
            Console.WriteLine(b);   // 1

            var c = 15;
            var d = c++; // d = 15, c = 16;
            var d2 = ++c; //d2 = 16, c = 16 

            var x = 0; 
            var y = x--; // y = 0,   x = -1
            var y2 = x--; // y2 = -1,  x = -1

            bool m = true;
            m = !m;
        }
    }
}
