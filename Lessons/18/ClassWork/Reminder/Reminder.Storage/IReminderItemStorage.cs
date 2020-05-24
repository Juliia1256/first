using System;
using System.Security.Cryptography.X509Certificates;

namespace Reminder.Storage
{
    public interface IReminderItemStorage
    {
        //CRUD
        void Add(ReminderItem item);
        ReminderItem Find(Guid id);
        ReminderItem[] FindByDateTime(DateTimeOffset dateTime) => FindBy(ReminderItemFilter.ByDateTime(dateTime));
        ReminderItem[] FindBy(ReminderItemFilter filter);

        void Update(ReminderItem item);
        void Delete(Guid id);


    }
}
