using System;
using System.Linq;

namespace _03.InvalidRangeApplicationException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        T startOfRange;
        T endOfRange;
        public InvalidRangeException(string msg,T startOfRange, T endOfRange)
            :this(msg)
        {
            this.startOfRange = startOfRange;
            this.endOfRange = endOfRange;
        }

        public InvalidRangeException(string msg) : base(msg)
        {
	    }

        public InvalidRangeException(string msg, Exception innerEx)
		    : base(msg, innerEx)
	    {
	    }

        public T StartOfRange
        {
            get
            {
                return this.startOfRange;
            }
            set
            {
                this.startOfRange = value;
            }
        }

        public T EndOfRange
        {
            get
            {
                return this.endOfRange;
            }
            set
            {
                this.endOfRange = value;
            }
        }

        public override string Message
        {
            get
            {
                string result = string.Format("{0} (Range[ {1}..{2} ])",
                    base.Message, this.StartOfRange,this.EndOfRange);
                return result;
            }
        }
    }
}
