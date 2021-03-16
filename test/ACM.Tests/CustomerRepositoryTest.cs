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
    }
}
