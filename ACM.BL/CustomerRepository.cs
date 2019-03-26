using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Cretae the instaaance of the Customer class
            //Pass in the request id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated costumer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;

        }

        //Saves the current customer
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
