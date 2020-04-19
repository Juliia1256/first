using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm1 = new ReminderItem
            {
              AlarmDate = new DateTime(2020,04,19,7,0,0),
              AlarmMessage = $"Wake up!"
            };
            var alarm2 = new ReminderItem
            {
                AlarmDate = new DateTime(2020, 04, 17, 15, 30, 0),
                AlarmMessage = $"Wake up!"
            };
            alarm1.WriteProperties();
            alarm2.WriteProperties();
        }
    }
}
