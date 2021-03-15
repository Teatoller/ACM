using System;
using Xunit;

namespace ACM.Tests
{
    public class FullNameTest
    {
        [Fact]
        public void FullNameValidTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Steven";
            customer.LastName = "Ennis";

            string expected = "Ennis Steven";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmptyTest()
        {
            Customer customer = new Customer();
            customer.LastName = "Ennis";

            string expected = "Ennis";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmptyTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Steven";

            string expected = "Steven";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticCountTest()
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Steven";
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Jemima";
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Dave";
            Customer.InstanceCount += 1;

            int expected = 3;

            int actual = Customer.InstanceCount;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateTest()
        {
            // var customer = new Customer()
            // {
            //     LastName = "Steven",
            //     EmailAddress = "steven@example.com"
            // };
            var customer = new Customer();
            customer.LastName = "Abdi";
            customer.EmailAddress = "test@test.com";

            bool expected = true;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastNameTest()
        {
            var customer = new Customer()
            {
                EmailAddress = "steven@example.com"
            };

            bool expected = false;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
        }


    }
}
