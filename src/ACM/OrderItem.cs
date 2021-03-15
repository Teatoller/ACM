using System;

namespace ACM
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItenId = orderItemId;
        }
        public int OrderItenId { get; private set; }
        public DateTimeOffset? OrderItemDate { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        // Retrieve order
        public OrderItem Retrieve(int OrderItenId)
        {
            return new OrderItem();
        }

        // Save order
        public bool Save()
        {
            return true;
        }

        // Validate order date
        public bool Validate()
        {
            var isValid = true;

            if (ProductId <= 0)
            {
                isValid = false;
                return isValid;
            }
            if (PurchasePrice == null)
            {
                isValid = false;
                return isValid;
            }
            if (Quantity <= 0)
            {
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
