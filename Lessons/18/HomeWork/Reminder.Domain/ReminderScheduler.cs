using System;
using Reminder.Storage;
//using TimersTimer = System.Timers.Timer;
using ThreadingTimer = System.Threading.Timer; //setting a synonym

namespace Reminder.Domain
{
	public class ReminderScheduler : IDisposable
	{
		public event EventHandler<ReminderSentEventArgs> ReminderSent;

		private readonly IReminderItemStorage _storage;
		private readonly ReminderSchedulerSettings _settings;
		private ThreadingTimer _readyTimer;
		private ThreadingTimer _sendTimer;

		public ReminderScheduler(IReminderItemStorage storage, ReminderSchedulerSettings settings)
		{
			_storage = storage;
			_settings = settings;
		}

		public void Run()
		{
			_readyTimer = new ThreadingTimer(OnReadyTimerTick, null, TimeSpan.Zero, _settings.ReadyTimerInterval);
			_sendTimer = new ThreadingTimer(OnSenderTimerTick, null, TimeSpan.Zero, _settings.SendTimerInterval);
		}

		public void Dispose()
		{
			_readyTimer.Dispose();
			_sendTimer.Dispose();
		}

		private void OnReadyTimerTick(object state)   //selects suitable objects
		{
			var items = _storage.FindBy(ReminderItemFilter.FromNow());

			foreach (var item in items)
			{
				item.Status = ReminderItemStatus.Ready;
				_storage.Update(item);
			}
		}

		private void OnSenderTimerTick(object state)   //sends matching objects
		{
			var items = _storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));

			foreach (var item in items)
			{
				item.Status = ReminderItemStatus.Sent;
				_storage.Update(item);
				ReminderSent?.Invoke(this, new ReminderSentEventArgs(item));
			}
		}
	}
}