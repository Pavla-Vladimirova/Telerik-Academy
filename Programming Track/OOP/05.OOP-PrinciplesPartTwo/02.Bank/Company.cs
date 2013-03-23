using System;
using System.Linq;

namespace _02.Bank
{
    public class Company : Customer
    {
        private string companyName;

        public Company( string companyName,string ownerFisrtName, string ownerLastName, string adress, string contactNumber) 
            : base(ownerFisrtName, ownerLastName, adress, contactNumber)
        {
            this.CompanyName = companyName;
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            private set
            {
                this.companyName = value;
            }
        }

        public override string ToString()
        {
           return string.Format("Company Name: {0}, Owner: {1} {2}, Adress: {3}, Contact Number: {4}",this.CompanyName,this.OwnerFisrtName,this.OwnerLastName,this.Adress,this.ContactNumber);
        }
    }
}
