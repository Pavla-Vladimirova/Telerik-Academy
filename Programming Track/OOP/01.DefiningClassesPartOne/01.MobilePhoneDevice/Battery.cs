using System;
using System.Linq;

//01.define class Battery
//02.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//All unknown data fill with null.
//03.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
//05.Use properties to encapsulate the data fields inside the Battery class.Ensure all fields hold correct data at any given time.

namespace _01.MobilePhoneDevice
{
    public enum BatteryType 
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        private string batteryModel;
        private float hoursIdle;
        private float hoursTalk;
        private BatteryType batType;

        public Battery()
            : this(null, 0, 0,BatteryType.LiIon)
        {
        }

        public Battery(float idle, float talk)
        {
            this.HoursIdle = idle;
            this.HoursTalk = talk;
        }

        public Battery(string battery, float idle, float talk,BatteryType batType)
            : this(idle, talk)
        {
            this.BatteryModel = battery;
            this.BatType = batType;
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery model! Write different than empty string!");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public float HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid hours idle! Write different than zero!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public float HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid hours talk! Write different than zero!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatType
        {
            get { return this.batType; }
            set { this.batType = value; }
        }

        public override string ToString()
        {
           return string.Format("\n -Battery model: {0}; \n -Hours idle: {1}h; \n -Hours talk: {2}h; \n -Battery type: {3}",
                this.BatteryModel,this.HoursIdle,this.HoursTalk,this.batType);
        }
    }

    public class Program
    {
        static void Main()
        {
        }
    }
}
