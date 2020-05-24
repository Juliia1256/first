using System;

namespace Reminder.Domain
{
	public class ReminderSchedulerSettings
	{
		public TimeSpan ReadyTimerInterval { get; }
		public TimeSpan SendTimerInterval { get; }

		public ReminderSchedulerSettings(
			TimeSpan readyTimerInterval, 
			TimeSpan sendTimerInterval)
		{
			ReadyTimerInterval = readyTimerInterval;
			SendTimerInterval = sendTimerInterval;
		}
	}
}