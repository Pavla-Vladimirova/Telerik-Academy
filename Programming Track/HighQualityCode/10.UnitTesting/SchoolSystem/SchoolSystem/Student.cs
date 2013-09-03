using System;
using System.Linq;

namespace SchoolSystem
{
    public class Student
    {
        private const int MIN_UNIQUE_NUMBER = 10000;
        private const int MAX_UNIQUE_NUMBER = 99999;
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of a student cannot be null");
                }
                if (value == string.Empty)
                {
                    throw new ArgumentException("The name of a student cannot be empty");
                }
                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < MIN_UNIQUE_NUMBER || value > MAX_UNIQUE_NUMBER)
                {
                    throw new ArgumentOutOfRangeException("The unique number of a student must be between "+ MIN_UNIQUE_NUMBER + " and "  + MAX_UNIQUE_NUMBER);
                }
                this.uniqueNumber = value;
            }
        }

    }
}
