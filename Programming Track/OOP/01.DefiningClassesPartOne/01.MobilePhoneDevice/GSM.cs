using System;
using System.Collections.Generic;
using System.Linq;

//01.Define class GSM holding instances of the classes Battery and Display
//02.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
//03.---> in class Battery
//04.Add a method in the GSM class for displaying all information about it. Try to override ToString().
//05.Use properties to encapsulate the data fields inside the GSM class.Ensure all fields hold correct data at any given time.
//06.Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//07.---> in TestMobilePhoneDevice
//08.Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
//09.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
//12.---> in TestMobilePhoneCallHistory
 
namespace _01.MobilePhoneDevice
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
        private static Battery iphoneBatteryCharacteristics=new Battery("Built-in rechargeable",225f,8f,BatteryType.LiIon);
        private static Display iphoneDisplayCharacteristics=new Display(4f,16000000);
        private static GSM iphone4S= new GSM("Iphone 4S","Apple",549,"Josh",iphoneBatteryCharacteristics,iphoneDisplayCharacteristics);
        private List<Call> callHistory=new List<Call>();
        private Random randomNumber = new Random();

        public GSM(string model,string manufacturer) 
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer,float price)
            :this(model,manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, float price,string owner)
            : this(model, manufacturer,price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, float price, string owner, Battery batteryCharacteristics)
            : this(model, manufacturer,price,owner)
        {
            this.BatteryCharacteristics = batteryCharacteristics;
        }

        public GSM(string model, string manufacturer, float price, string owner, Battery batteryCharacteristics, Display displayCharacteristics)
            : this(model, manufacturer,price,owner,batteryCharacteristics)
        {
            this.DisplayCharacteristics = displayCharacteristics;
        }

        public GSM(string model, string manufacturer, float price, string owner, Battery batteryCharacteristics, Display displayCharacteristics,List<Call> callHistory)
            : this(model, manufacturer, price, owner, batteryCharacteristics,displayCharacteristics)
        {
            this.CallHistory = callHistory;
        }
    

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public static GSM Iphone4S
        {
            get{ return iphone4S;}
            set{ iphone4S = value; }
        }

        public string Model 
        {
            get { return this.model; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model name! Write different than empty string!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            { 
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer name! Write different than empty string!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public float Price
        {
            get { return this.price; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid price! Write different than zero!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get{return this.owner;}
            set
            { 
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid owner name! Write different than empty string!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery BatteryCharacteristics
        {
            get { return this.batteryCharacteristics;}
            set{ this.batteryCharacteristics = value; }
        }

        public Display DisplayCharacteristics
        {
            get { return this.displayCharacteristics; }
            set {this.displayCharacteristics = value;}
        }

        public override string ToString()
        {
            return string.Format("Model: {0}; \nManufacturer: {1}; \nPrice: {2}$; \nOwner: {3}; \nBattery Characteristics: {4}; \nDisplay Characteristics: {5} \n",
                this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryCharacteristics, this.DisplayCharacteristics);
        }

        public void PrintCallHistory()
        {
            Console.WriteLine("Call History");
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            return;
        }

        public void AddCall()
        {
            int randomDur = randomNumber.Next(20, 361);
            DateTime date = DateTime.Now;
            DateTime time = date;
            string number = "088 99 88 99";
            int duration = randomDur;
            this.CallHistory.Add(new Call(date, time, number, duration));
        }

        public void DeleteCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public double TotalCallPrice(double pricePerMinute)
        {
            double total = 0;
            foreach (var item in this.CallHistory)
            {
                double minutes =(double)item.DurationInSeconds / 60;
                total += minutes * pricePerMinute;
            }
            return total;
        }

        public int MaxDurationIndex()
        {
            int maxDurIndex = 0;
            int maxDur = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].DurationInSeconds > maxDur)
                {
                    maxDurIndex = i;
                    maxDur = this.CallHistory[i].DurationInSeconds;
                }
            }
            return maxDurIndex;
        }
    }
}
