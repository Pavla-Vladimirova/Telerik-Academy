using System;
using System.Linq;

namespace _01.MobilePhoneDevice
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private int durationInSeconds;

        public Call(DateTime date, DateTime time, string dialedPhoneNumber, int durationInSeconds)
        {
            this.Date = date;
            this.Time=time;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.DurationInSeconds = durationInSeconds;
        }

        public int DurationInSeconds
        {
            get {  return this.durationInSeconds; }
            set { this.durationInSeconds = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber;}
            set { this.dialedPhoneNumber = value; }
        }

        public DateTime Time
        {
            get {  return this.time; }
            set  { this.time = value; }
        }

        public DateTime Date
        {
            get{ return this.date;}
            set{ this.date = value;}
        }

        public override string ToString()
        {
            return string.Format("\n -Date of call: {0:d}; \n -Time of call: {1:T}; \n -Dialed Number: {2}; \n -Duration(in seconds): {3};",
                this.Date,this.Time,this.DialedPhoneNumber,this.DurationInSeconds);
        }
    }
}
