using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число не превышающее 2 миллиардов");
            int input = 0;
            int count = 0;
            while (true)
            {  
               
                if (int.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.WriteLine("Ошибка System.FormatException! Попробуйте ещё раз:");
                    continue;
                }
                if (input > 2_000_000_000)
                {
                    Console.WriteLine("Ошибка System.OverflowException! Попробуйте ещё раз:");
                    continue;
                }
                else
                {
                    while (input != 0)
                    {
                        if ((input % 10) % 2 == 0)
                        {
                            count++;
                        }
                        input = input / 10;
                    }
                   
                }
                Console.WriteLine("Количество четных цифр: {0}", count);
                Console.ReadKey();
                break;
            }
            
          
        }
    }
}
