using System;
using System.Text;
using System.Threading;
namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Привет {name}!, ждем 5 секунд" );
            Thread.Sleep(6000);
            Console.WriteLine($"До свидания {name}, для завершения нажми любую кнопку");
            Console.ReadKey();
        }
    }
}
