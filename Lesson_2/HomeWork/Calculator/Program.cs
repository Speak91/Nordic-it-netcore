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
            int operationSelection = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            string testNumber = string.Empty;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Добро пожаловать в калькулятор, для начала выберите номер операции которую хотите осуществить");
            Console.WriteLine(@"1. Сложение
2. Вычитание
3. Умножение 
4. Деление
5. Возведение в степень");
            try
            {
                operationSelection = int.Parse(Console.ReadLine());
                while (operationSelection < 1 | operationSelection > 5)
                {
                    Console.WriteLine("Такой операции не существует повторите попытку");
                    operationSelection = int.Parse(Console.ReadLine());
                }

                OperationSelection(operationSelection);
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено недопустимое значение, программа завершает свою работу, нажмите любую кнопку");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }

            if (operationSelection == 5) //Возведение в степень
            {
                Console.WriteLine("Введите число");
                firstNumber = NumberTest(testNumber);
                Console.WriteLine("Введите степень в какую хотите возвести число");
                secondNumber = NumberTest(testNumber);
            }

            else
            {
                Console.WriteLine("Введите первое число");
                firstNumber = NumberTest(testNumber);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите второе число");
                secondNumber = NumberTest(testNumber);
            }

            Operation(operationSelection, firstNumber, secondNumber);
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

        static double NumberTest (string testNumber) //Проверка на ввод числа
        {
            double number = 0;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено неверное значение, повторите попытку");
            }

            return number;
        }

        static void Operation(int operationSelection, double firsNumber, double secondNumber) //проведение вычислений
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (operationSelection)
            {
                case 1:
                    Console.WriteLine($"Результат сложения {firsNumber} + {secondNumber} = {firsNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Результат вычитания {firsNumber} - {secondNumber} = {firsNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Результат умножения {firsNumber} * {secondNumber} = {firsNumber * secondNumber}");
                    break;
                case 4:
                    if (firsNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine($"Результат деления {firsNumber} / {secondNumber} = 0");
                        break;
                    }

                    Console.WriteLine($"Результат деления {firsNumber} / {secondNumber} = {firsNumber / secondNumber}");
                    break;
                case 5:
                    Console.WriteLine($"{firsNumber} в степени {secondNumber} = {Math.Pow(firsNumber, secondNumber)}");
                    break;
                default:
                    break;
            }
        }
        
    }
}
