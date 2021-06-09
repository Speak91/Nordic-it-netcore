using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset datetime = DateTimeOffset.Parse("2021-06-07 13:41");

            DateTimeOffset datetime2 = DateTimeOffset.Parse("2021-06-07 17:32");

            DateTimeOffset dateTime3 = DateTimeOffset.Parse("2021-06-07 17:32");

            List<ReminderItem> reminderItems = new List<ReminderItem>();

            reminderItems.Add(new ReminderItem(datetime, "Подьем"));
            reminderItems.Add(new PhoneReminderitem(datetime2, "Вставай!!!", "+79681569428"));
            reminderItems.Add(new ChatReminderItem(dateTime3, "Подьем", "Mash", "Begemot85"));

            foreach (var item in reminderItems)
            {
                Console.WriteLine(item.WriteProperties);
            }
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

        public virtual string WriteProperties
        {
            get
            {
                return $"Тип обьекта {GetType().Name} \n" +
                    $"Время будильника: {AlarmDate} \n" +
                    $"Сообщение: {AlarmMessage} \n" +
                    $"Время до звона будильника: {TimeToAlarm}\n" +
                    $"Будильник пропущен {IsOutdated} \n";
            }
        }
    }

    class PhoneReminderitem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderitem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public override string WriteProperties
        {
            get
            {
                return $"Тип обьекта {GetType().Name} \n" +
                    $"Номер телефона { PhoneNumber} \n" +
                    $"Время будильника: {AlarmDate} \n" +
                    $"Сообщение: {AlarmMessage} \n" +
                    $"Время до звона будильника: {TimeToAlarm} \n" +
                    $"Будильник пропущен {IsOutdated} \n ";
            }
        }
    }

    class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName) : base(alarmDate, alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
            ChatName = chatName;
            AccountName = accountName;

        }

        public override string WriteProperties
        {
            get
            {
                return $"Тип обьекта {GetType().Name}\n" +
                     $"Название чата {ChatName}\n" +
                    $"Имя аккаунта {AccountName}\n" +
                $"Время будильника: {AlarmDate} \n" +
                    $"Сообщение: {AlarmMessage} \n" +
                    $"Время до звона будильника: {TimeToAlarm} \n" +
                    $"Будильник пропущен {IsOutdated} \n";
            }
        }
    }

}
