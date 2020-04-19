
using System;


namespace HW11
{
    class ReminderItem
    {
        public ReminderItem() { }

        public DateTime AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm
        {
            get
            {
                return AlarmDate-DateTimeOffset.Now;
            }
        }

        public bool IsOutdated
        {
            get
            {
                return TimeToAlarm >= TimeSpan.Zero;
            }
        }
        public void WriteProperties()
        {
            Console.WriteLine(
                @$"Alarm date: {AlarmDate}
Alarm message: {AlarmMessage} 
Time to alarm: {TimeToAlarm} 
Is out dated: {IsOutdated}");
        }

    }
}
