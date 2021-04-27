using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; // Переменная для изменения размера таблицы 
            int counter = 0; //переменная счетчик
            int[] multiplier = new int[num];
            int[] multiplicand = new int[num];
            int counterfillarray = 1;
            for (int i = 0; i < num; i++)
            {
                multiplier[i] = counterfillarray;
                multiplicand[i] = counterfillarray;
                counterfillarray++;
            }
            int result = 0; //переменная для записи результата умножения
            string output = ""; //переменная для вывода на экран
            Console.WriteLine($"   Таблица умножения Пифагора размером {num} * {num} элементов");
            for (int i = 0; i < multiplier.Length; i++)
            {
                if (counter == 0) //Вывод символа звездочки
                {
                    output = "*";
                    Console.Write($" {output.PadLeft(2)}");
                }
                if (counter >= 2) //вывод 2 столбца
                {
                    output = Convert.ToString(counter);
                    Console.Write($" {output.PadLeft(2)}");
                }
                if (counter != 0 && counter < 2)
                {
                    output = Convert.ToString(i);
                    Console.Write($" {output.PadLeft(2)}");
                }
                if (counter == 1)
                {
                    i = 0;
                }
                for (int j = 0; j < multiplier.Length; j++)
                {
                    result = multiplier[i] * multiplicand[j];
                    output = Convert.ToString(result);
                    Console.Write($"{output.PadLeft(4)} ");
                    if (j == 9)
                    {
                        counter++;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
