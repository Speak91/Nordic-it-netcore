using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float downPaymentAmount = 0f;
            float percentageDailyIncome = 0f;
            float accumulationAmount = 0f;
            float result = 0f;
            int numberOfDays = 0;
            float f = 100f;

            try
            {
                Console.WriteLine("Введите сумму первоначального взноса в формате 100,25 где 100 рубли а 25 копейки");
                downPaymentAmount = CheckingForNumberInput();

                Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01):");
                percentageDailyIncome = CheckingForNumberInput();

                Console.WriteLine("Введите желаемую сумму накопления в рублях:");
                accumulationAmount = CheckingForNumberInput();

                result = downPaymentAmount * percentageDailyIncome;

                while (f < accumulationAmount)
                {
                    numberOfDays++;
                    f *= (1f + result / 100f);
                }

                Console.WriteLine($"Необходимое количество дней для накопления {accumulationAmount}Р при ставке {Math.Round(result, 2)}% составит {numberOfDays}");
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
        static float CheckingForNumberInput()
        {
            float testValue = 0f;

            while (float.TryParse(Console.ReadLine(), out testValue) == false || testValue < 0)
            {
                Console.WriteLine("Введено некоректное значение повторите попытку");
            }

            return testValue;
        }
    }
}
