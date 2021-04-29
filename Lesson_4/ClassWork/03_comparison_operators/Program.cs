using System;

namespace _03_comparison_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03_comparison_operators");

            Console.WriteLine(10 > 15); //false
            Console.WriteLine(10 < 15); //true
            Console.WriteLine(10 <= 15); //true
            Console.WriteLine(10 != 15); //true 
            Console.WriteLine("10" == "10"); //true
            Console.WriteLine("ABC" == "ABC"); //true

            int a = 18;
            int b = a++;
            Console.WriteLine("-----");
            Console.WriteLine(a == b); 
            Console.WriteLine(a != b); 
            Console.WriteLine(a > b); 
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

        }
    }
}
