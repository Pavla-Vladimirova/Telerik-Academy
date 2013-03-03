using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AbstractHuman
{
    public class Worker : Human, IComparable<Worker>
    {
        private double weekSlaray;
        private double workHoursPerDay;

        public Worker(string firstName,string lastName,double weekSlaray, double workHoursPerDay):base(firstName,lastName)
        {
            this.weekSlaray = weekSlaray;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double WeekSlaray
        {
            get
            {
                return this.weekSlaray;
            }
            set
            {
                this.weekSlaray = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour=0;
            return moneyPerHour = this.WeekSlaray / (5 * this.WorkHoursPerDay);
        }

        public int CompareTo(Worker other)
        {
            return this.MoneyPerHour().CompareTo(other.MoneyPerHour());
        }

        public override string ToPrint()
        {
            return string.Format("{0} {1}, money per hour: {2:0.0###} $ ", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
