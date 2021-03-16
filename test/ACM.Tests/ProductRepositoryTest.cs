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

        [Fact]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                productDescription = "Furniture",
                ProductName = "Arm chair",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                productDescription = "Furniture",
                ProductName = "Arm chair",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.False(actual);
        }

    }
}
