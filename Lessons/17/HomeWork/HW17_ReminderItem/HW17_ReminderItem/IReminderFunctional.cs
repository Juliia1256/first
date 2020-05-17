using System;
using System.Collections.Generic;
using System.Text;

namespace HW17_ReminderItem
{
    interface IReminderFunctional
    {
        void InterceptMessage(string message);
        void RecordMessage(string message);
        void Expectation(int timeToExpectoin);
        void SendMessage();
    }
}
