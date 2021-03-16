using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM
{
    public class CustomerRepository
    {
        // Establish link between CustomerRepository and AddressRepository
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public AddressRepository addressRepository { get; set; }

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
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
