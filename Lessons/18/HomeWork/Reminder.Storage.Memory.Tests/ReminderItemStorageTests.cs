using System;
using NUnit.Framework;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderItemStorageTests
    {
        ReminderItemStorage storage;

        [SetUp]
        public void Set()
        {
            storage = new ReminderItemStorage();
        }
        //test group to verify the add method
        [Test]
        public void WhenItemIsNull_ThenThrowsArgumentNullException()
        {

            Assert.Catch<ArgumentNullException>(() =>
                storage.Add(null)
            );
        }
        [Test]
        public void WhenAddAlreadyExistItem_ThenThrowsArgumentException()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "Header",
                "Message",
                DateTimeOffset.Now,
                "UserId");
            storage.Add(item);
            Assert.Catch<ArgumentException>(() =>
                storage.Add(item)
            );
        }
        //test group to verify the search method
        [Test]
        public void WhenItemNotExists_ThenFindByIdGivenThrowArgumentException()
        {
            var id = Guid.NewGuid();
            var exception = Assert.Catch<ArgumentException>(() =>
                storage.Find(id)
            );
            StringAssert.Contains(id.ToString("N"), exception.Message);
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
            storage.Add(item);
            var result = storage.Find(item.Id);

            Assert.AreEqual(item.Id, result.Id);
            Assert.AreEqual(item.Title, result.Title);
            Assert.AreEqual(item.Message, result.Message);
        }

        //test group to test data update method
        [Test]
        public void WhenUpdateItemIsNull_ShouldThrowArgumentNullException()
        {

            Assert.Catch<ArgumentNullException>(() =>
                storage.Update(null)
            );
        }

        [Test]
        public void WhenUpdateItemNotExists_ShouldThrowArgumentException()
        {
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
            storage.Add(item);

            item.Message = "New message";
            storage.Update(item);

            var result = storage.Find(item.Id);
            Assert.AreEqual("New message", result.Message);
        }

        //test group to test filter search method
        [Test]
        public void WhenCreatedItemsFindByReadyStatus_ShouldReturnEmpty()
        {
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message one", DateTimeOffset.Now.AddSeconds(-1), "User"));

            var result = storage.FindBy(
                ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));
            Assert.IsEmpty(result);
        }

        [Test]
        public void WhenCreatedItemsFindFromNow_ShouldReturnMatchingElements()
        {
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message two", DateTimeOffset.Now.AddMinutes(-1), "User"));

            var result = storage.FindBy(ReminderItemFilter.FromNow());

            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("message two", result[0].Message);
        }

        //test group to test data deletion method
        [Test]
        public void WhenDeletedItemIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Catch<ArgumentNullException>(() =>
                storage.Delete(default)
            );
        }

        [Test]
        public void WhenDeletedItemNotExists_ShouldThrowArgumentException()
        {
            var id = Guid.NewGuid();

            Assert.Catch<ArgumentException>(() =>
                storage.Delete(id)
            );
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
            storage.Add(item);
            storage.Delete(item.Id);
            Assert.Catch<ArgumentException>(() =>
                storage.Find(item.Id)
            );

        }
    }
}