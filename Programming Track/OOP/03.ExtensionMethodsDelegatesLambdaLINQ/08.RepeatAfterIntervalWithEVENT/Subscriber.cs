using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RepeatAfterIntervalWithEVENT
{
    public class Subscriber
    {
        public void Subscribe(Publisher p)
        {
            p.Tick += new Publisher.TickHandler(Hello);
            p.Tick += new Publisher.TickHandler(HelloToo);
        }

        private void Hello(Publisher p, EventArgs e)
        {
            Console.WriteLine("Hello to you");
        }

        public void HelloToo(Publisher p, EventArgs e)
        {
            Console.WriteLine("Hello to you too");
        }
    }
}
