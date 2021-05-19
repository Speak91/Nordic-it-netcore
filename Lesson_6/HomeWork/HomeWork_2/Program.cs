using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal downPaymentAmount = 0;
            decimal percentageDailyIncome = 0;
            decimal accumulationAmount = 0;
            decimal result = 0;
            int numberOfDays = 0;

            try
            {
                Console.WriteLine("Введите сумму первоначального взноса в формате 100,25 где 100 рубли а 25 копейки");
                downPaymentAmount = Test();

                Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01):");
                percentageDailyIncome = Test();

                Console.WriteLine("Введите желаемую сумму накопления в рублях:");
                accumulationAmount = Test();

                result = downPaymentAmount * percentageDailyIncome;

                while (downPaymentAmount < accumulationAmount)
                {
                    numberOfDays++;
                    downPaymentAmount = downPaymentAmount + result;
                }

                Console.WriteLine($"Необходимое количество дней для накопления {accumulationAmount}Р при ставке {Math.Round(result, 1)}% составит {numberOfDays}");
            }

            catch (FormatException)
            {
                Console.WriteLine($"Вы ввели не верное значение!");
            }

            catch (System.OverflowException)
            {
                Console.WriteLine($"Введенное число превышает допустимое значение");
            }
          
          

        }
        static decimal Test()
        {
            decimal testValue = 0;

            while (decimal.TryParse(Console.ReadLine(), out testValue) == false || testValue <0)
            {
                Console.WriteLine("Введено некоректное значение повторите попытку");
            }

            return testValue;
        }
    }
}
