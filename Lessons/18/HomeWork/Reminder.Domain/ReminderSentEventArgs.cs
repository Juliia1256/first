using System;
using Reminder.Storage;

namespace Reminder.Domain
{
	public class ReminderSentEventArgs
	{
		public string Message { get; }
		public DateTimeOffset DateTime { get; }

		public ReminderSentEventArgs(ReminderItem item)
		{
			Message = item.Message;
			DateTime = item.DateTimeUtc;
		}
	}
}