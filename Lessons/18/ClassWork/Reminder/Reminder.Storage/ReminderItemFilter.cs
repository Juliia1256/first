using System;

namespace Reminder.Storage
{
    public class ReminderItemFilter
    {
        public ReminderItemFilter(DateTimeOffset dateTime)
        {
            DateTime = dateTime;
        }

        public ReminderItemFilter(ReminderItemStatus status)
        {
            Status = status;
        }

        public DateTimeOffset DateTime { get; set; }
        public ReminderItemStatus Status { get; set; }
        public static ReminderItemFilter ByStatus(ReminderItemStatus status)=>new ReminderItemFilter(status);
        public static ReminderItemFilter ByDateTime(DateTimeOffset dateTime) => new ReminderItemFilter(dateTime);
        public static ReminderItemFilter FromNow() => ByDateTime(DateTimeOffset.UtcNow);
    }
}
