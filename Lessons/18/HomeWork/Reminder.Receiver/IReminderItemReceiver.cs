using System;

namespace Reminder.Receiver
{
    public interface IReminderItemReceiver
    {
        event EventHandler<MessageReceivedEventArgs> MessageReceived;


    }
    public class MessageReceivedEventArgs : EventArgs
    {
    }
}
