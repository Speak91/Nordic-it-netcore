using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 95;
            int height = 23;
            Console.SetWindowSize(width, height);
            int operationselection = 0;
            double firstnumber = 0;
            double secondnumber = 0;
            string testnumber = string.Empty;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Добро пожаловать в калькулятор, для начала выберите номер операции которую хотите осуществить");
            Console.WriteLine(@"1. Сложение
2. Вычитание
3. Умножение 
4. Деление
5. Возведение в степень");
            try
            {
                operationselection = int.Parse(Console.ReadLine());
                while (operationselection < 1 | operationselection > 5)
                {
                    Console.WriteLine("Такой операции не существует повторите попытку");
                    operationselection = int.Parse(Console.ReadLine());
                }

                OperationSelection(operationselection);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено недопустимое значение, программа завершает свою работу, нажмите любую кнопку");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }
            if (operationselection == 5) //Возведение в степень
            {
                Console.WriteLine("Введите число");
                firstnumber = NumberTest(testnumber);
                Console.WriteLine("Введите степень в какую хотите возвести число");
                secondnumber = NumberTest(testnumber);
            }
            else
            {
                Console.WriteLine("Введите первое число");
                firstnumber = NumberTest(testnumber);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите второе число");
                secondnumber = NumberTest(testnumber);
            }
            Operation(operationselection, firstnumber, secondnumber);
            Console.WriteLine("Для выхода нажмите любую кнопку");
            Console.ReadKey();
        }
        static void OperationSelection(int num) //Выбор операции
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Выбрано сложение");
                    break;
                case 2:
                    Console.WriteLine("Выбрано вычитание");
                    break;
                case 3:
                    Console.WriteLine("Выбрано умножение");
                    break;
                case 4:
                    Console.WriteLine("Выбрано деление");
                    break;
                case 5:
                    Console.WriteLine("Выбрано возведение в степень");
                    break;
                default:
                    break;
            }
        }
        static double NumberTest (string testnumber) //Проверка на ввод числа
        {
            double number = 0;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено неверное значение, повторите попытку");
            }
            return number;
        }
        static void Operation(int operationselection, double firsnumber, double secondnumber) //проведение вычислений
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (operationselection)
            {
                case 1:
                    Console.WriteLine($"Результат сложения {firsnumber} + {secondnumber} = {firsnumber + secondnumber}");
                    break;
                case 2:
                    Console.WriteLine($"Результат вычитания {firsnumber} - {secondnumber} = {firsnumber - secondnumber}");
                    break;
                case 3:
                    Console.WriteLine($"Результат умножения {firsnumber} * {secondnumber} = {firsnumber * secondnumber}");
                    break;
                case 4:
                    if (firsnumber == 0 || secondnumber == 0)
                    {
                        Console.WriteLine($"Результат деления {firsnumber} / {secondnumber} = 0");
                        break;
                    }
                    Console.WriteLine($"Результат деления {firsnumber} / {secondnumber} = {firsnumber / secondnumber}");
                    break;
                case 5:
                    Console.WriteLine($"{firsnumber} в степени {secondnumber} = {Math.Pow(firsnumber, secondnumber)}");
                    break;
                default:
                    break;
            }
        }
        
    }
}
