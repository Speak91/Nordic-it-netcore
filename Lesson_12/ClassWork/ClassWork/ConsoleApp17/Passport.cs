using System;
namespace ConsoleApp17
{
    class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

        public Passport(string docNumber, DateTimeOffset issueDate, string country, string personName) : base("Паспорт", docNumber, issueDate)
        {
            Country = country;
            PersonName = personName;
        }

        public override string PropertiesString
        {
            get
            {
                return $"Наименование документа: {DocName} \n" +
                    $"Номер документа: {DocNumber} \n" +
                    $"Дата выдачи:{IssueDate:dd-MM-yy} \n" +
                    $"Страна {Country} \n" +
                    $"Имя владельца {PersonName}";
            }
        }

       

    }
}

