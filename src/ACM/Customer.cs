using System.Collections.Generic;

namespace ACM
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private string fullName;
        public string FullName
        {

            get
            {
                fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        //Retreive all customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        // Retrieve customer
        public Customer Retrieve(int CustomerId)
        {
            return new Customer();
        }

        // Save customer
        public bool Save()
        {
            return true;
        }

        // Validate customer name
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
                return isValid;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
