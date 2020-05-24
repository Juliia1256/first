using System;
using Reminder.Domain;
using Reminder.Storage;
using Reminder.Storage.Memory;

namespace Reminder
{
	class Program
	{
		static void Main()
		{
			var storage = new ReminderItemStorage();
			storage.Add(
				new ReminderItem(Guid.NewGuid(), "header", "message one", DateTimeOffset.Now.AddSeconds(20), "Artem"));
			storage.Add(
				new ReminderItem(Guid.NewGuid(), "header", "message two", DateTimeOffset.Now.AddMinutes(-1), "Artem"));
			storage.Add(
				new ReminderItem(Guid.NewGuid(), "header", "message three", DateTimeOffset.Now.AddMinutes(1), "Artem"));

			using var scheduler = new ReminderScheduler(
				storage,
				new ReminderSchedulerSettings(
					readyTimerInterval: TimeSpan.FromSeconds(3),
					sendTimerInterval: TimeSpan.FromSeconds(5))
			);
			scheduler.ReminderSent += (sender, args) =>
				Console.WriteLine($"Reminder for: {args.DateTime} with message: {args.Message}");
			scheduler.Run();

			Console.WriteLine("Scheduler working");
			Console.ReadKey();

		}
	}
}