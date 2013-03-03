using System;
using System.Linq;

//08.* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.

namespace _08.RepeatAfterIntervalWithEVENT
{
    class TestEvent
    {
        static void Main()
        {
            Publisher p = new Publisher(3000);
            Subscriber s = new Subscriber();
            s.Subscribe(p);
            p.Start();
        }
    }
}
