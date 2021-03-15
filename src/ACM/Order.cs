using System;

namespace ACM
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        // Retrieve order
        public Order Retrieve(int OrderId)
        {
            return new Order();
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

            if (OrderDate == null)
            {
                isValid = false;
                return isValid;
            }
            return isValid;
        }
    }
}
