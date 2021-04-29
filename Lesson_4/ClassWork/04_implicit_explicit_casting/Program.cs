using System;

namespace _04_implicit_explicit_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04_implicit_explicit_casting");

            //implicit casting examples - неявное приведение типа
            int a = 10;
            double b = a;

            var c = a + 0.1F + 0.2;

            double g = 9.81;

            // int g2 = g; // Ошибка неявного приведения т.к в меньшую сторону приводить нельзя
            int g2 = (int)g;
            Console.WriteLine(g);
            Console.WriteLine(g2);

            Console.WriteLine("-------");

            long e = long.MaxValue;
            int f = (int)e;
            Console.WriteLine(e);
            Console.WriteLine(f);

            
        }
    }
}
