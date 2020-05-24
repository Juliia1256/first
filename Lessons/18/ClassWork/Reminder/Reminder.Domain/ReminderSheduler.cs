using System;
using System.Threading;
using Reminder.Storage;
using TimersTimer = System.Timers.Timer;
using ThreadingTimer = System.Threading.Timer;

namespace Reminder.Domain
{
    public class ReminderSheduler
    {
        private IReminderItemStorage _storage;
        public ReminderSheduler(IReminderItemStorage storage)
        {
            _storage = storage;
            var tt = new ThreadingTimer(
                OnReadyTimerTick,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(2)
                );
            var t2 = new ThreadingTimer(
             OnReadyTimerTick,
             null,
             TimeSpan.Zero,
               TimeSpan.FromSeconds(2)
                );
        }

        private void OnReadyTimerTick(object state)
        {
            var datetime = DateTimeOffset.UtcNow;
            var items = _storage.FindByDateTime(datetime);
            foreach (var item in items)
            {
                item.Status = ReminderItemStatus.Ready;
            }
        }
        private void OnSenderTimerTick(object state)
        {
            var status = ReminderItemStatus.Ready;
            // var items = _storage.FindByDateTime(datetime);
        }

        private void SendReminderItem(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
