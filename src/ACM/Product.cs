namespace ACM
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string productDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public static int InstanceCount { get; set; }

        // Validate product name
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
                return isValid;
            }
            if (CurrentPrice==null)
            {
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
