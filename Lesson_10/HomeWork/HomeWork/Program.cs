using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            const int amountOfPeople = 3;
            Person[] persons = new Person[amountOfPeople];
            for (int i = 0; i < amountOfPeople; i++)
            {
                persons[i] = new Person();
                try
                {
                    persons[i].Input(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Произощла ошибка {e.Message} повторите попытку");
                    i--;
                }
            }
            for (int i = 0; i < amountOfPeople; i++)
            {
                Console.WriteLine(persons[i].Description);
            }
        }
    }
}
