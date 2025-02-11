// See https://aka.ms/new-console-template for more information
using OnineFoodSystem;

class Program6
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>();
        while (true)
        {
            Console.WriteLine(" Online Food Delivery System:");
            Console.WriteLine("1. Add Veg Item");
            Console.WriteLine("2. Add Non-Veg Item");
            Console.WriteLine("3. View Details");
            Console.WriteLine("4. Exit");

            Console.Write("Enter ur choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    VegItem veg = new VegItem();
                    Console.Write("Enter Item Name: ");
                    veg.ItemName = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    veg.Price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    veg.Quantity = Convert.ToInt32(Console.ReadLine());
                    foodItems.Add(veg);
                    Console.WriteLine($"{veg.ItemName} successfully added");
                    break;
                case 2:
                    NonVegItem nonVeg = new NonVegItem();
                    Console.Write("Enter Item Name: ");
                    nonVeg.ItemName = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    nonVeg.Price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    nonVeg.Quantity = Convert.ToInt32(Console.ReadLine());
                    foodItems.Add(nonVeg);
                    Console.WriteLine($"{nonVeg.ItemName} successfully added");
                    break;

                case 3:
                    if (foodItems.Count == 0)
                    {
                        Console.WriteLine("No food Items to display.");
                    }
                    else
                        foreach (var food in foodItems)
                        {
                            food.GetItemDetails();

                        }
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;

            }

        }
    }
}