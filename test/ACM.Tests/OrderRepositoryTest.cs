using System;
using Xunit;

namespace ACM.Tests
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieValidTest()
        {
            OrderRepository orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new System.DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            Order actual = orderRepository.Retrieve(10);

            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}
