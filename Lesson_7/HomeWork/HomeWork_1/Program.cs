using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = 0;

            Console.WriteLine("Введите строку из нескольких слов");

            try
            {
                string[] output = CheckingSentenceLength(Console.ReadLine());
                for (int i = 0; i < output.Length; i++)
                {
                    if (output[i].StartsWith("А") || output[i].StartsWith("а"))

                    {
                        wordCount++;
                    }

                }
                Console.WriteLine($"Количество слов начинающихся c буквы А: {wordCount}");
            }

            catch (Exception e)
            {

                Console.WriteLine("Что-то пошло не так, покажите строчку ниже разработчику ПО");
                Console.WriteLine(e);
            }

        }

        static string[] CheckingSentenceLength(string input)
        {
            string[] output = input.Split(' ', '.', ',');
            for (int i = 0; i < input.Length; i++)
            {

                if (output.Length < 2 || output[1] == "")
                {
                    Console.WriteLine("Слишком мало слов, повторите попытку");
                    input = Console.ReadLine();
                    output = input.Split(' ', '.', ',');
                    continue;
                }

            }

            return output;
        }
    }
}
