using System;
namespace ConsoleApp17
{
    class BaseDocument
    {
        public string DocName { get; set; }
        public string DocNumber { get; set; }
        public DateTimeOffset IssueDate { get; set; }

        public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
        {
            DocName = docName;
            DocNumber = docNumber;
            IssueDate = issueDate;
        }
        public virtual string PropertiesString
        {
            get
            {
                return $"Наименование документа: {DocName} \n" +
                    $"Номер документа: {DocNumber} \n" +
                    $"Дата выдачи:{IssueDate:dd-MM-yy} ";
            }
        }
        public void WriteToConsole()
        {
            Console.WriteLine(PropertiesString);
        }
        public override bool Equals(object obj)
        {
            return obj is BaseDocument
            && DocName == ((BaseDocument)obj).DocName
            && IssueDate == ((BaseDocument)obj).IssueDate
            && DocNumber == ((BaseDocument)obj).DocNumber;
        }

    }
}
