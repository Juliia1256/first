using NUnit.Framework;
using System;
using Reminder.Storage.Memory;

namespace Reminder.Storage.Tests
{
    public class ReminderItemFilterTests
    {
        ReminderItemStorage storage;

        [SetUp]
        public void Set()
        {
            storage = new ReminderItemStorage();
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message one", DateTimeOffset.Now.AddMinutes(-1), "User1", ReminderItemStatus.Ready));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message two", DateTimeOffset.Now.AddMinutes(-1), "User2"));
            storage.Add(
                new ReminderItem(Guid.NewGuid(), "header", "message three", DateTimeOffset.Now.AddMinutes(20), "User3"));

        }
        [Test]
        public void WhenReminderFilterByStatusReady()
        {
            var result = storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Ready));
            Assert.IsNotEmpty(result);
            Assert.AreEqual("message one", result[0].Message);
        }

        [Test]
        public void WhenReminderFilterFromNow()
        {

            var result = storage.FindBy(ReminderItemFilter.FromNow());
            Assert.IsNotEmpty(result);
            Assert.AreEqual("message two", result[0].Message);
        }
        public void WhenReminderFilterByDateTime()
        {

            var f4 = ReminderItemFilter.ByDateTime(DateTimeOffset.UtcNow);
        }
        [Test]
        public void WhenReminderFilterByStatusSent_ThenNotFound()
        {
            var result = storage.FindBy(ReminderItemFilter.ByStatus(ReminderItemStatus.Sent));
            Assert.IsEmpty(result);

        }

    }
}