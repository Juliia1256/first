using NUnit.Framework;
using System;


namespace Reminder.Storage.Tests
{
    public class ReminderItemFilterTests
    {

        [SetUp]
        public void Set()
        {
        }
        [Test]
        public void WhenReminderFilterByStatusReady()
        {
            var filter = ReminderItemFilter.ByStatus(ReminderItemStatus.Ready);
            Assert.NotNull(filter);
            Assert.IsTrue(filter.IsByStatus);
        }

        [Test]
        public void WhenReminderFilterFromNow()
        {
            var filter = ReminderItemFilter.FromNow();
            Assert.NotNull(filter);
            Assert.IsTrue(filter.IsByStatus);
            Assert.IsTrue(filter.IsByDateTime);
        }
        [Test]
        public void WhenReminderFilterByDateTime()
        {
            var filter = ReminderItemFilter.ByDateTime(DateTimeOffset.UtcNow);
            Assert.NotNull(filter);
            Assert.IsTrue(filter.IsByDateTime);
        }


    }
}