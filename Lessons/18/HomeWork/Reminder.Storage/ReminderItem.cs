using System;

namespace Reminder.Storage
{
	public class ReminderItem
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
		public DateTimeOffset DateTimeUtc { get; set; }
		public string UserId { get; set; }
		public ReminderItemStatus Status { get; set; }

		public ReminderItem(
			Guid id, 
			string title, 
			string message, 
			DateTimeOffset dateTimeUtc, 
			string userId,
			ReminderItemStatus status = ReminderItemStatus.Created)
		{
			Id = id;
			Title = title;
			Message = message;
			DateTimeUtc = dateTimeUtc;
			UserId = userId;
			Status = status;
		}
	}
}