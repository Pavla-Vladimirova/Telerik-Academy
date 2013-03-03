using System;
using System.Linq;

//07.Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace _06.ExecuteMethodAtEachGivenSecond
{
    public class TestDelegates
    {
        static void Main(string[] args)
        {
            TimeCounter test = new TimeCounter(2000);
            test.RepeatAfterInterval();
        }
    }
}
