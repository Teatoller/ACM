using System;

namespace ACM
{
    public class OrderRepository
    {
        // Retrieve order
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new System.DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            Console.WriteLine($"Order: {order.ToString()}");

            return order;
        }

        // Save order
        public bool Save(Order order)
        {
            return true;
        }
    }
}
