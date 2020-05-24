using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.Memory
{
	public class ReminderItemStorage : IReminderItemStorage
	{
		private readonly Dictionary<Guid, ReminderItem> _items;

		public ReminderItemStorage() :
			this(Array.Empty<ReminderItem>())
		{
		}

		public ReminderItemStorage(params ReminderItem[] items)
		{
			_items = items.ToDictionary(item => item.Id);
		}

		public void Add(ReminderItem item)
		{
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}

			if (!_items.TryAdd(item.Id, item))
			{
				throw new ArgumentException(
					$"Reminder item with title {item.Title} and id {item.Id:N} already exists in memory storage",
					nameof(item));
			}
			_items.Add(item.Id, item);
		}

		public ReminderItem Find(Guid id)
		{
			if (id == default)
			{
				throw new ArgumentNullException(nameof(id));
			}

			if (!_items.TryGetValue(id, out var item))
			{
				throw new ArgumentException(
					$"Reminder with id {id:N} not found", nameof(id));
			}

			return item;
		}

		public ReminderItem[] FindBy(ReminderItemFilter filter)
		{
			var query = _items.Values.AsEnumerable();

			if (filter.IsByStatus)
			{
				query = query.Where(item => item.Status == filter.Status);
			}

			if (filter.IsByDateTime)
			{
				query = query.Where(item => item.DateTimeUtc <= filter.DateTime);
			}

			return query.ToArray();
		}

		public void Update(ReminderItem item)
		{
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}

			if (!_items.ContainsKey(item.Id))
			{
				throw new ArgumentException(
					$"Reminder with title {item.Title} and id {item.Id:N} not found in memory storage", nameof(item));
			}

			_items[item.Id] = item;
		}

		public void Delete(Guid id)
		{
			if (id == default)
			{
				throw new ArgumentNullException(nameof(id));
			}

			var result = _items.Remove(id, out _);
			if (!result)
			{
				throw new ArgumentException(
					$"Reminder with id {id:N} not found in memory storage", nameof(id));
			}
			_items.Remove(id);
		}
	}
}