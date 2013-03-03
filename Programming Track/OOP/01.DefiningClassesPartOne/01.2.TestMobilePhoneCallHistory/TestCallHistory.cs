using _01.MobilePhoneDevice;
using System;
using System.Collections.Generic;
using System.Linq;

//12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

namespace _01._2.TestMobilePhoneCallHistory
{
    class TestCallHistory
    {
        static void Main(string[] args)
        {
            // first GSM
            Display newDisplay = new Display(3.5f, 16000000);
            Battery newBattery = new Battery("1305 mAh, typical", 470f, 6f, BatteryType.LiIon);
            List<Call> newCallHistory = new List<Call>();
            GSM mobile = new GSM("Sony Xperia", "Sony", 400, "Malculm", newBattery, newDisplay, newCallHistory);

            //adding some calls
            mobile.AddCall();
            mobile.AddCall();
            mobile.AddCall();
            Console.WriteLine(mobile);
            mobile.PrintCallHistory();

            //total call price
            Console.WriteLine("The total price is {0}\n",mobile.TotalCallPrice(0.37));

            //delete the longest call
            int index = mobile.MaxDurationIndex();
            mobile.DeleteCall(index);
            Console.WriteLine("AFTER REMOVING(longest call)");
            mobile.PrintCallHistory();

            //total price after removing conversation with maximum duration
            Console.WriteLine("The total price(after removing) is {0}\n", mobile.TotalCallPrice(0.37));

            //delete all history
            mobile.ClearHistory();
            Console.WriteLine("AFTER DELETING(all call history)");
            mobile.PrintCallHistory();
        }
    }
}
