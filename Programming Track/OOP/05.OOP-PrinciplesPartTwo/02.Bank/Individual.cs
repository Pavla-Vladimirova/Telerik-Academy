using System;
using System.Linq;

namespace _02.Bank
{
    public class Individual : Customer
    {
        public Individual(string ownerFisrtName, string ownerLastName, string adress, string contactNumber) 
            : base(ownerFisrtName, ownerLastName, adress, contactNumber)
        {
        }

        public override string ToString()
        {
            return string.Format("Owner: {0} {1}, Adress: {2}, Contact Number: {3}",this.OwnerFisrtName,this.OwnerLastName,this.Adress,this.ContactNumber) ;
        }
    }
}
