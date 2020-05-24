using NUnit.Framework;
using System;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemStorageTests
    {
        [Test]
        public void WhenItemIsNull_ThenThrowArgumentNullException()
        {
            var storage = new ReminderItemStorage();
            Assert.Catch<ArgumentNullException>(() =>
            storage.Add(null)
            );
        }
        [Test]
        public void WhenItemNotExist_ThenCanFindById()
        {
            var storage = new ReminderItemStorage();
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserID");

            storage.Add(null);
            var result = storage.Find(item.Id);
            Assert.NotNull(result);
            Assert.AreEqual(item.Id, result.Id);
            Assert.AreEqual(item.Massege, result.Massege);
        }
        [Test]
        public void WhenItemExists_ThenThrowsArgumentException()
        {
            var storage = new ReminderItemStorage();
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");

            storage.Add(item);

            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Add(item)
            );
            Assert.IsTrue(exception.Message.Contains(item.Title));
        }
    }
}