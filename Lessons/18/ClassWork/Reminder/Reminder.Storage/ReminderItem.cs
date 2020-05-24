using System;

namespace Reminder.Storage
{
    public class ReminderItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Massege { get; set; }
        public DateTimeOffset DateTimeUTC { get; set; }
        public string IserID { get; set; }
        public ReminderItemStatus Status { get; set; }


        public ReminderItem(
            Guid id, 
            string title, 
            string massege, 
            DateTimeOffset dateTimeUTC, 
            string iserID, 
            ReminderItemStatus status = ReminderItemStatus.Created)
        {
            Id = id;
            Title = title;
            Massege = massege;
            DateTimeUTC = dateTimeUTC;
            IserID = iserID;
            Status = status;
        }
    }
}
