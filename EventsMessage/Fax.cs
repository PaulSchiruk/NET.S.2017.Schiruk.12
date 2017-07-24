using System;
using TimeEvent;

namespace EventsMessage
{
    public class Fax : IMessage
    {
        public void SentMessage(object sender, EventArgs e)
        {
            Console.WriteLine(((Timer)sender).Message + " to fax");
        }
    }
}
