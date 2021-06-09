using System;
namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset dateTime = DateTimeOffset.Parse("2021-06-07 17:32");
            DateTimeOffset dateTimeForPassport = DateTimeOffset.Parse("2021-06-10");
            BaseDocument baseDocument = new BaseDocument("Паспорт", "456789", dateTimeForPassport);
            baseDocument.WriteToConsole();

            Console.WriteLine();
            Passport passport = new Passport("456789",dateTimeForPassport, "Россия", "Иванов Иван Иванович");
            passport.WriteToConsole();
            Passport passport2 = new Passport("456789", dateTimeForPassport, "Россия", "Иванов Иван Иванович");
            passport2.WriteToConsole();
            Console.WriteLine(baseDocument.Equals(passport));

            

        }

    }
}
