using System;
using TimeEvent;

namespace EventsMessage
{
    public interface IMessage
    {
         void SentMessage(object sender, EventArgs e);
    }
}
