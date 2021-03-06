using System.Collections.Generic;

namespace ACM
{
    public class Customer
    {
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
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

        public override string ToString() => FullName;

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
