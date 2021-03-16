using System;
using System.Collections.Generic;

namespace ACM
{
    public class CustomerRepository
    {
        //Retreive all customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Steven";
                customer.LastName = "Ennis";
                customer.EmailAddress = "steven@test.me";
            }

            return customer;
        }

        // Save customer
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
