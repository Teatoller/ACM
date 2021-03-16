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

            // var myObject = new Object();
            // Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        // Save product
        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //store procedure 
                    }
                    else
                    {
                        // update store procedure
                    }

                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
