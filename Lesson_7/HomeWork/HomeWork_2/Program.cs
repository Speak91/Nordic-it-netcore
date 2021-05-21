using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите непустую строку");

            string output = CheckingForBlankCharacterBeginningLine();

            output = output.ToLower();

            char[] sReverse = output.ToCharArray();
            Array.Reverse(sReverse);
            output = new string(sReverse);

            Console.WriteLine($"В перевернутом виде выглядит вот так: " + output);
        }

        static string CheckingForBlankCharacterBeginningLine()
        {
            string output = string.Empty;
            while ((output = Console.ReadLine()).StartsWith(" "))
            {
                Console.WriteLine("Пустой ввод или в начале строки стоит пробел, повторите попытку");
            }
            return output;
        }
    }
}
