using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW12
{
    class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }

        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName)
            : base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
            Debug.WriteLine("Constructor PhoneReminderItem(AlarmDate, AlarmMessage, ChatName, AccountName)");
        }
        public override string Description =>
    $@"{GetType().Name}
        Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        Alarm message: {AlarmMessage} 
        Time to alarm: {TimeToAlarm} 
        Is out dated: {IsOutdated}
        Chat name is: {ChatName}
        Account name is: {AccountName}";

        //        public override void WriteProperties()
        //        {
        //            Console.WriteLine(
        //            $@"{GetType().Name}
        //Alarm date: {AlarmDate:dd.MM.yyyy HH:mm}
        //Alarm message: {AlarmMessage} 
        //Time to alarm: {TimeToAlarm} 
        //Is out dated: {IsOutdated}
        //Chat name is: {ChatName}
        //Account name is: {AccountName}");
        //}
    }
}
