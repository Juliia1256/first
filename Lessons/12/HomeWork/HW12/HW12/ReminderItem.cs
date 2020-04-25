using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW12
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm
        {
            get
            {
                return AlarmDate - DateTimeOffset.Now;
            }
        }

        public bool IsOutdated
        {
            get
            {
                return TimeToAlarm <= TimeSpan.Zero;
            }
        }

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
            Debug.WriteLine("Constructor PhoneReminderItem(AlarmDate, AlarmMessage)");
        }
        public virtual string Description =>
            $@"{GetType().Name}
        Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        Alarm message: {AlarmMessage} 
        Time to alarm: {TimeToAlarm} 
        Is out dated: {IsOutdated}";

        public override string ToString()
        {
            return Description;
        }
        //        public virtual void WriteProperties()
        //        {
        //            Console.WriteLine(
        //            $@"{GetType().Name}
        //Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        //Alarm message: {AlarmMessage} 
        //Time to alarm: {TimeToAlarm} 
        //Is out dated: {IsOutdated}");
        //}
    }
}
