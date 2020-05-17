using System;
using System.Collections.Generic;
using System.Text;

namespace HW17_ReminderItem
{
    class ReminderItem : IReminderFunctional
    {
        private Guid _id;
        private string _user;
        private string _text;
        private string _header;
        private DateTimeOffset _fireDate;

        public Guid Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public string Header { get; set; }
        public DateTimeOffset FireDate { get; set; }

        public ReminderItem() { }

        public void InterceptMessage(string message)
        {
        }
        public void RecordMessage(string message)
        {
        }
        public void Expectation(int timeToExpectoin)
        {
        }
        public void SendMessage()
        {
        }
    }
}
