using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RepeatAfterIntervalWithEVENT
{
    public class Publisher
    {
        private int repeatingInterval;
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(Publisher p, EventArgs e);

        public Publisher(int repeatingInterval)
        {
            this.repeatingInterval = repeatingInterval;
        }

        public int RepeatingInterval
        {
            get
            {
                return this.repeatingInterval;
            }
            set
            {
                this.repeatingInterval = value;
            }
        }

        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(this.RepeatingInterval);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
}
