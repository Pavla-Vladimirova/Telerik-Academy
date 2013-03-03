using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace _06.ExecuteMethodAtEachGivenSecond
{
    public delegate void SimpleDelegate();
    class TimeCounter
    {
        private int repeatingInterval;

        public TimeCounter(int repeatingInterval)
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

        public static void Hello()
        {
            Console.WriteLine("Hello to you ");
        }
        public static void HelloToo()
        {
            Console.WriteLine("Hello to you too ");
        }

        public void RepeatAfterInterval()
        {
            SimpleDelegate newDelegate = new SimpleDelegate(Hello);
            newDelegate += HelloToo;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (true)
            {
                Thread.Sleep(this.RepeatingInterval);
                newDelegate();
            }
        }
    }
}
