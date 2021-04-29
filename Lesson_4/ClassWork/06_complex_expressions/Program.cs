using System;

namespace _06_complex_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("06_complex_expressions");

            //double a = 3;
            //double b = 4;
            //double c = Math.Sqrt(a * a + Math.Pow(b, 2));
            //Console.WriteLine(c);
            Console.WriteLine("Данная программа позволит расчитать боковую и полную площади правильной пирамиды");
            double a;
            double h;
            double n;
            double s1;
            double s2;
            double s3;
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите h");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите n");
            n = double.Parse(Console.ReadLine());

            var x = Math.Tan(3.14 / n);
            var y = a / (2 * x);
            s1 = (n * a / 2) * Math.Sqrt(h * h + y * y);
            Console.WriteLine(s1);
            s2 = (h * n * Math.Pow(a, 2)) / (12*x);
            Console.WriteLine(s2);
            
        }
    }
}
