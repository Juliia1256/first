using NUnit.Framework;
using System;

namespace Reminder.Storage.Tests
{
	public class ReminderItemFilterTests
	{
		// Добавить тесты на свойства ReminderItemFilter

		[Test]
		public void WhenReminderFilterByStatusReady()
		{
			var f3 = ReminderItemFilter.ByStatus(ReminderItemStatus.Ready); 

		}
		[Test]
		public void WhenReminderFilterByStatusSent()
		{
			var f3 = ReminderItemFilter.ByStatus(ReminderItemStatus.Sent);
		}
		[Test]
		public void WhenReminderFilterFromNow()
		{

			var f4 = ReminderItemFilter.FromNow();
		}
		public void WhenReminderFilterByDateTime()
		{

			var f4 = ReminderItemFilter.ByDateTime(DateTimeOffset.UtcNow);
		}

	}
}