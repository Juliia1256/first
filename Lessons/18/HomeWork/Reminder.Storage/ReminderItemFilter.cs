using System;

namespace Reminder.Storage
{
	public class ReminderItemFilter
	{
		public DateTimeOffset DateTime { get; private set; }
		public ReminderItemStatus Status { get; private set; }

		public bool IsByDateTime =>
			DateTime != default;

		public bool IsByStatus =>
			Status != default;

		public static ReminderItemFilter ByStatus(ReminderItemStatus status) => //descriptive creation method
			new ReminderItemFilter
			{
				Status = status
			};

		public static ReminderItemFilter ByDateTime(DateTimeOffset datetime) =>
			new ReminderItemFilter
			{
				DateTime = datetime
			};

		public static ReminderItemFilter FromNow() =>
			new ReminderItemFilter
			{
				Status = ReminderItemStatus.Created,
				DateTime = DateTimeOffset.UtcNow
			};
	}
}