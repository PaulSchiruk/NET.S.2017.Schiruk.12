using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEvent
{
    public class Timer
    {
        //private readonly DateTime whenEnd;
        private int whenEnd;


        // public Timer(TimeSpan when) { whenEnd = DateTime.Now + when; }
        public string Message { get; set; }
        public Timer(int when)
        {
            whenEnd = when;
        }

        public event EventHandler TimerEndEventHandler;

        public bool IncrementTime()
        {
            WhenEnd--;
            if (WhenEnd <= 0) return false;
            return true;
        }
        protected virtual void OnTimerEnd(EventArgs e)
        {
            TimerEndEventHandler?.Invoke(this, e);
        }

        public int WhenEnd
        {
            get => whenEnd;
            set
            {
                if (value <= 0) OnTimerEnd(EventArgs.Empty);
                whenEnd = value;

            }
        }
    }
}
