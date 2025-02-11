//See https://aka.ms/new-console-template for more information
using System;
namespace ECommerce_Platform
{


    public class Program2
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            while (true)
            {
                Console.WriteLine("ECommerce Platform: ");
                Console.WriteLine("1. Add Clothing detail: ");
                Console.WriteLine("2. Add Electronics Detail: ");
                Console.WriteLine("3. Add Groceries Details");
                Console.WriteLine("4. View Details: ");
                Console.WriteLine("5. Exit");

                Console.Write("Enter the choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Clothing tshirt = new Clothing();
                        Console.Write("Enter Product Id: ");
                        tshirt.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        tshirt.Name = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        tshirt.Price = Convert.ToInt32(Console.ReadLine());
                        products.Add(tshirt);
                        Console.WriteLine($"{tshirt.Name} is added in the product");
                        break;

                    case 2:
                        Electronics laptop = new Electronics();
                        Console.Write("Enter Product Id: ");
                        laptop.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        laptop.Name = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        laptop.Price = Convert.ToInt32(Console.ReadLine());
                        products.Add(laptop);
                        Console.WriteLine($"{laptop.Name} is added in the product");
                        break;

                    case 3:
                        Groceries rice = new Groceries();
                        Console.Write("Enter Product Id: ");
                        rice.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        rice.Name = Console.ReadLine();
                        Console.Write("Enter the Price: ");
                        rice.Price = Convert.ToInt32(Console.ReadLine());
                        products.Add(rice);
                        Console.WriteLine($"{rice.Name} is added in the product\n");
                        break;
                    case 4:
                        if (products.Count == 0)
                        {
                            Console.WriteLine("No Product to Display!");
                        }

                        // Display details of all products
                        foreach (var product in products)
                        {
                            product.DisplayDetails();
                            Console.WriteLine("-----------------------------------");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Existing....");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
            }
        }
    }
}