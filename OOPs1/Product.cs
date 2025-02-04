//using System;
//using System.Runtime.CompilerServices;

//class Product
//{
//    private static double Discount = 10.0; // Shared across all products
//    public readonly int ProductId=1; // Readonly: cannot be changed
//    public string ProductName;
//    public double Price;
//    public int Quantity;

//    // Constructor using 'this'
//    public Product(int productId, string name, double price, int quantity)
//    {
//        this.ProductId = productId ; // Assign a unique ProductID
//        this.ProductName = name;
//        this.Price = price;
//        this.Quantity = quantity;
//    }

//    // Static method to update discount
//    public static void UpdateDiscount(double newDiscount)
//    {
//      Discount = newDiscount;
//    }

//    // Display product details
//    public void DisplayProduct()
//    {
//        Console.WriteLine($"\nID: {ProductId}");
//        Console.WriteLine($"Product Name: {ProductName}");
//        Console.WriteLine($"Price: {Price}");
//        Console.WriteLine($"Quantity: {Quantity}");
//        Console.WriteLine($"Final Price: ${(Price * Quantity) * (1 - Discount / 100):0.00}");
//        Console.WriteLine($"----------------------------");
//    }

//    // Method to check if an object is a Product
//    public static void CheckInstance(object obj)
//    {
//        if (obj is Product)
//        {
//            Console.WriteLine(" This is a valid Product instance.");
//        }
//        else
//        {
//            Console.WriteLine(" This is NOT a Product instance.");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the number of Products: ");
//        int numProducts = int.Parse( Console.ReadLine() );

//        //Allow user to update discount
//        Console.Write("Enter discount Percentage: ");
//        double discount = double.Parse(Console.ReadLine());
//        Product.UpdateDiscount(discount);
//        Console.WriteLine("Updated discount is: "+ discount);

//        //creating a fixed-size array to store products
//        Product[] cart = new Product[numProducts];

//        //Taking input from the user
//        for (int i = 0; i < numProducts; i++) {
//            Console.WriteLine($"\nEnter details for Product {i+1}");
//            Console.Write("Product Id: ");
//            int id = int.Parse(Console.ReadLine());

//            Console.Write("Product Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Price: ");
//            double price = double.Parse(Console.ReadLine());

//            Console.Write("Quantity: ");
//            int quantity = int.Parse(Console.ReadLine());

//            cart[i] = new Product(id, name, price, quantity);
//        }

//        //Display all product after validation
//        Console.WriteLine("\n===Shopping Cart Deatils===");
//        for (int i = 0; i < numProducts; i++) {
//            if (cart[i] is Product)
//            {
//                cart[i].DisplayProduct();
//            }
//        }

//     }
//}

