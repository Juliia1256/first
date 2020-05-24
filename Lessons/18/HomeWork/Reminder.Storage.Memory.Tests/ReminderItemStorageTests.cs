using System;
using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemStorageTests
    {
        //test group to verify the add method
        [Test]
        public void WhenItemIsNull_ThenThrowsArgumentNullException()
        {
            var storage = new ReminderItemStorage();

            Assert.Catch<ArgumentNullException>(() =>
                storage.Add(null)
            );
        }
        [Test]
        public void WhenItemExists_ThenThrowsArgumentException()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");
            var storage = new ReminderItemStorage(item);

            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Add(item)
            );
            Assert.IsTrue(exception.Message.Contains(item.Title));
        }
        [Test]
        public void WhenItemExistsAndNotNull_ThenAddNewReminderItemToStorage()
        {
            var item = new ReminderItem(
            Guid.NewGuid(),
            "Header1",
            "Message1",
            DateTimeOffset.Now,
            "UserId1");
            var storage = new ReminderItemStorage(item);
            Assert.IsNotNull(storage);
        }
        //test group to verify the search method
        [Test]
        public void WhenItemNotExists_ThenFindByIdGivenThrowArgumentException()
        {
            var storage = new ReminderItemStorage();
            var id = Guid.NewGuid();

            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Find(id)
            );
            StringAssert.Contains(id.ToString("N"), exception.Message);
        }
        [Test]
        public void WhenItemIsNull_ThenFindByIdGivenArgumentNullException()
        {
            var storage = new ReminderItemStorage();
            Guid id = default;

            var exception = Assert.Catch<ArgumentNullException>(() =>
                storage.Find(id)
            );
            StringAssert.Contains("Value cannot be null.", exception.Message);
        }

        [Test]
        public void WhenItemExists_ThenFindByIdShouldReturnId()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");
            var storage = new ReminderItemStorage(item);
            var result = storage.Find(item.Id);

            Assert.AreEqual(item.Id, result.Id);
            Assert.AreEqual(item.Title, result.Title);
            Assert.AreEqual(item.Message, result.Message);
        }

        //test group to test data update method
        [Test]
        public void WhenUpdateItemIsNull_ShouldThrowArgumentNullException()
        {
            var storage = new ReminderItemStorage();

            Assert.Catch<ArgumentNullException>(() =>
                storage.Update(null)
            );
        }

        [Test]
        public void WhenUpdateItemNotExists_ShouldThrowArgumentException()
        {
            var storage = new ReminderItemStorage();
            var id = Guid.NewGuid();

            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Update(
                    new ReminderItem(
                        id,
                        "Header",
                        "Message",
                        DateTimeOffset.Now,
                        "UserId")
                )
            );
            Assert.IsTrue(exception.Message.Contains(id.ToString("N")));
        }

        [Test]
        public void WhenItemExists_ShouldSaveUpdatedItem()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");
            var storage = new ReminderItemStorage(item);

            item.Message = "New message";
            storage.Update(item);

            var result = storage.Find(item.Id);
            Assert.AreEqual("New message", result.Message);
        }

        //test group to test filter search method
        [Test]
        public void WhenCreatedItemsFindByReadyStatus_ShouldReturnEmpty()
        {
            var storage = new ReminderItemStorage();
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message one", DateTimeOffset.Now.AddSeconds(10), "User"));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message two", DateTimeOffset.Now.AddMinutes(-1), "User"));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message three", DateTimeOffset.Now.AddMinutes(1), "User"));

            var result = storage.FindBy(
                ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));

            Assert.IsEmpty(result);
        }

        [Test]
        public void WhenCreatedItemsFindFromNow_ShouldReturnMatchingElements()
        {
            var storage = new ReminderItemStorage();
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message one", DateTimeOffset.Now.AddSeconds(10), "User"));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message two", DateTimeOffset.Now.AddMinutes(-1), "User"));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message three", DateTimeOffset.Now.AddMinutes(1), "User"));

            var result = storage.FindBy(ReminderItemFilter.FromNow());

            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("message two", result[0].Message);
        }

        //test group to test data deletion method
        [Test]
        public void WhenDeletedItemIsNull_ShouldThrowArgumentNullException()
        {
            var storage = new ReminderItemStorage();

            Assert.Catch<ArgumentNullException>(() =>
                storage.Delete(default)
            );
        }

        [Test]
        public void WhenDeletedItemNotExists_ShouldThrowArgumentException()
        {
            var storage = new ReminderItemStorage();
            var id = Guid.NewGuid();

            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Delete(id)
            );
            Assert.IsTrue(exception.Message.Contains(id.ToString("N")));
        }

        [Test]
        public void WhenItemExists_ShouldDeletedItem()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");
            var storage = new ReminderItemStorage(item);
            storage.Delete(item.Id);
            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Find(item.Id)
            );
            StringAssert.Contains(item.Id.ToString("N"), exception.Message);
        }
    }
}