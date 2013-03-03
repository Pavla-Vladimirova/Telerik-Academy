using _01.MobilePhoneDevice;
using System;
using System.Linq;

//07.Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

namespace _01._1.TestMobilePhoneDevice
{
    class TestMobile
    {
        static void Main(string[] args)
        {
            GSM[] mobiles = new GSM[2];

            // first GSM
            Display newDisplay = new Display(3.5f, 16000000);
            Battery newBattery = new Battery("1305 mAh, typical", 470f, 6f, BatteryType.LiIon);
            mobiles[0] = new GSM("Sony Xperia", "Sony", 400, "Malculm", newBattery,newDisplay);

            //second GSM
            Display newDisplay2 = new Display(5f, 16000000);
            Battery newBattery2 = new Battery("1305 mAh, typical", 350f, 7f, BatteryType.LiIon);
            mobiles[1] = new GSM("Nokia 5300", "Nokia", 400, "Neil", newBattery, newDisplay);

            for (int i = 0; i < mobiles.Length; i++)
            {
                Console.WriteLine(mobiles[i]);
                Console.WriteLine();
            }
            Console.WriteLine(GSM.Iphone4S);
        }
    }
}
