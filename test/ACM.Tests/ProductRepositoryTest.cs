using Xunit;

namespace ACM.Tests
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieValidTest()
        {
            ProductRepository productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Ginger",
                productDescription = "Spice flavoring",
                CurrentPrice = (decimal?)24.6
            };

            Product actual = productRepository.Retrieve(2);

            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.productDescription, actual.productDescription);
        }
    }
}
