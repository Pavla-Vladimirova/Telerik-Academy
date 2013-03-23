using System;
using System.Linq;

namespace _02.Bank
{
    public abstract class Customer
    {
        private string ownerFisrtName;
        private string ownerLastName;
        private string adress;
        private string contactNumber;

        public Customer(string ownerFisrtName, string ownerLastName, string adress, string contactNumber)
        {
            this.OwnerFisrtName = ownerFisrtName;
            this.OwnerLastName = ownerLastName;
            this.Adress = adress;
            this.ContactNumber = contactNumber;
        }

        public string Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return this.contactNumber;
            }
            set
            {
                this.contactNumber = value;
            }
        }

        public string OwnerFisrtName
        {
            get
            {
                return this.ownerFisrtName;
            }
            private set
            {
                this.ownerFisrtName = value;
            }
        }

        public string OwnerLastName
        {
            get
            {
                return this.ownerLastName;
            }
            private set
            {
                this.ownerLastName = value;
            }
        }
    }
}
