using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW12
{
    class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber)
            : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
            Debug.WriteLine("Constructor PhoneReminderItem(AlarmDate, AlarmMessage, PhoneNumber)");
        }

        public override string Description =>
            $@"{GetType().Name}
        Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        Alarm message: {AlarmMessage} 
        Time to alarm: {TimeToAlarm} 
        Is out dated: {IsOutdated}
        Phone number is: {PhoneNumber}";

        //        public override void WriteProperties()
        //        {
        //            Console.WriteLine(
        //            $@"{GetType().Name}
        //Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        //Alarm message: {AlarmMessage} 
        //Time to alarm: {TimeToAlarm} 
        //Is out dated: {IsOutdated}
        //Phone number is: {PhoneNumber}");
        //}
    }
}
