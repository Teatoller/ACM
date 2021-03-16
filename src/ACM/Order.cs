using System;
using System.Collections.Generic;

namespace ACM
{
    public class Order
    {
        public Order(): this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItem = new List<OrderItem>();
        }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItem { get; set; }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} (({OrderId}))";
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
