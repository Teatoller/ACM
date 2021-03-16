using System.Collections.Generic;
using Xunit;

namespace ACM.Tests
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieValidTest()
        {
            CustomerRepository customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Steven",
                LastName = "Ennis",
                EmailAddress = "steven@test.me"
            };

            Customer actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Steven",
                LastName = "Ennis",
                EmailAddress = "steven@test.me",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "Miggrade",
                            StreetLine2 = "Mid lane",
                            City = "Nairobi",
                            State = "Westward",
                            Country = "Kenya",
                            PostalCode = "124",
                        },
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "Big brigade",
                            StreetLine2 = "Brow lane",
                            City = "Nambale",
                            State = "yardling",
                            Country = "Kenya",
                            PostalCode = "365",
                        }
                    }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
