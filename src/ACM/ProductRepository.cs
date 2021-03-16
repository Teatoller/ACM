using System;

namespace ACM
{
    public class ProductRepository
    {
        //Retreive all products
        // public List<Product> Retrieve()
        // {
        //     return new List<Product>();
        // }

        // Retrieve one product
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Ginger";
                product.productDescription = "Spice flavoring";
                product.CurrentPrice = (decimal?)24.6;
            }

            return product;
        }

        // Save product
        public bool Save(Product product)
        {
            return true;
        }
    }
}
