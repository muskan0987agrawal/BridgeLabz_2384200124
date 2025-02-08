/* using System;


namespace Inheritance
{
    internal class Order
    {
        protected string orderId;
        protected DateTime OrderDate;

        public void SetOrderDetail(string orderId, DateTime OrderDate)
        {
            this.orderId = orderId;
            this.OrderDate = OrderDate;
        }

        // Get Order Status (to be overridden)
        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"\nOrder ID: {orderId} \tOrder Date: {OrderDate}");
        }
    }

    internal class ShippedOrder: Order
    {
        protected string TrackingNumber;

        public void SetShippedOrderDetails(string orderId, DateTime OrderDate, string TrackingNumber)
        {
            SetOrderDetail(orderId, OrderDate);
            this.TrackingNumber = TrackingNumber;
        }


        // Overriding GetOrderStatus
        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }

        public void DisplayDetail()
        {
            base.DisplayOrder();
            Console.WriteLine($"\nTracking Number is {TrackingNumber}");
        }

    }
    //  Subclass: DeliveredOrder (Inheriting from ShippedOrder)
    internal class DeliveryOrder: ShippedOrder
    {
        private DateTime deliveryDate;

        public void SetDeliveryOrder(string orderId, DateTime OrderDate, string TrackingNumber, DateTime deliveryDate)
        {
            SetShippedOrderDetails(orderId, OrderDate, TrackingNumber);
            this.deliveryDate = OrderDate;
        }
      
        // Overriding GetOrderStatus
        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }

        public void DisplayOrder()
        {
            DisplayDetail();
            Console.WriteLine("\nDelivery Date: "+ deliveryDate.ToString());
        }
    }
    internal class Program6
    {
        public static void Main()
        {
            //  Create a Delivered Order (Multilevel Inheritance)
            DeliveryOrder order = new DeliveryOrder();
            order.SetDeliveryOrder("101", DateTime.Now.AddDays(-5), "TRK123456", DateTime.Now);

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n What would you like to see?");
                Console.WriteLine("1  View Order Details");
                Console.WriteLine("2  View Order Status");
                Console.WriteLine("0  Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n Order Details:");
                        order.DisplayOrder();
                        break;

                    case "2":
                        Console.WriteLine($"\nOrder Status: {order.GetOrderStatus()}");
                        break;

                    case "0":
                        Console.WriteLine("\n Exiting... Thank you!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("\n Invalid choice! Please enter a valid option.");
                        break;
                }

            }
        }
    }
}
*/