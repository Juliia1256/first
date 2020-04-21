using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm1 = new ReminderItem
            {
              AlarmDate = new DateTimeOffset(2020,04,22,7,0,0, 0, new TimeSpan(3, 0, 0)),
              AlarmMessage = $"Wake up!"
            };
            var alarm2 = new ReminderItem
            {
                AlarmDate = new DateTimeOffset(2020, 04, 17, 15, 30, 0, 0, new TimeSpan(3,0,0)),
                AlarmMessage = $"Wake up!"
            };
            alarm1.WriteProperties();
            alarm2.WriteProperties();
        }
    }
}
