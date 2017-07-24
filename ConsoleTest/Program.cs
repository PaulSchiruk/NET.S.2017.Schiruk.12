using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeEvent;
using EventsMessage;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timerCrutch = new Timer(10);
            timerCrutch.Message = "Hello world!";
            Fax f = new Fax();
            MobilePhone mp = new MobilePhone();
            timerCrutch.TimerEndEventHandler += f.SentMessage;
            timerCrutch.TimerEndEventHandler += mp.SentMessage;
            while (timerCrutch.IncrementTime()){}

            Console.ReadLine();
        }
    }
}
