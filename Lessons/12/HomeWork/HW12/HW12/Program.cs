using System;
using System.Collections.Generic;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {

            var reminders = new List<ReminderItem>
            {
                new ReminderItem(alarmDate: new DateTimeOffset(2020, 04, 22, 7, 0, 0, 0, new TimeSpan(3, 0, 0)), alarmMessage: $"Wake up (ReminderItem)!"),
                new ReminderItem(alarmDate: new DateTimeOffset(2020, 04, 26, 7, 0, 0, 0, new TimeSpan(3, 0, 0)), alarmMessage: $"Wake up (ReminderItem)!"),
                new PhoneReminderItem(alarmDate: new DateTimeOffset(2020, 04, 29, 15, 30, 0, 0, new TimeSpan(3, 0, 0)), alarmMessage: $"Wake up (PhoneReminderItem)!", phoneNumber: "+79171486192"),
                new ChatReminderItem(alarmDate: new DateTimeOffset(2020, 04, 30, 15, 30, 0, 0, new TimeSpan(3, 0, 0)), alarmMessage: $"Wake up (ChatReminderItem)!", chatName: "Group chat", accountName: "JJ")
            };

            foreach (var reminder in reminders)
            {
                Console.WriteLine(reminder);
            }
            Console.ReadKey();

            //foreach (var reminder in reminders)
            //{
            //    reminder.WriteProperties();
            //}
            //Console.ReadKey();
        }
    }
}
