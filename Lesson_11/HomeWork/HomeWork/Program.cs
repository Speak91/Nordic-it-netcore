using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset datetime = DateTimeOffset.Parse("2021-06-07 13:41");
            ReminderItem bud1 = new ReminderItem(datetime, "Подьем");
            bud1.WriteProperties();

            DateTimeOffset datetime2 = DateTimeOffset.Parse("2021-06-07 17:32");
            ReminderItem bud2 = new ReminderItem(datetime2, "Подьем, проспишь!!!");
            bud2.WriteProperties();
        }
    }
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get { return DateTimeOffset.Now - AlarmDate; }
        }
        public bool IsOutdated
        {
            get { return DateTime.Now > AlarmDate; }
        }
        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public void WriteProperties()
        {
            Console.WriteLine($"Время будильника: {AlarmDate} \nСообщение: {AlarmMessage} \nВремя до звона будильника: {TimeToAlarm} \nБудильник пропущен {IsOutdated} \n");
        }
    }
}
