/*using System;

class CarRental
{
    // Attributes
    public string CustomerName ;
    public string CarModel ;
    public int RentalDays ;
    public double DailyRentalCost;

    // Default Constructor
    public CarRental()
    {
        CustomerName = "XYZ";
        CarModel = "Swift";
        RentalDays = 1;
        DailyRentalCost = 50.0; // Default daily rental cost (can be adjusted)
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRentalCost)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRentalCost = dailyRentalCost;
    }

    // Method to Calculate Total Cost
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRentalCost; // Total cost = rental days * daily rental cost
    }

    // Display Method
    public void DisplayRentalDetails()
    {
        double totalCost = CalculateTotalCost();
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Car Model: {CarModel}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Daily Rental Cost: {DailyRentalCost}");
        Console.WriteLine($"Total Rental Cost: {totalCost}");
    }
}

class Program6
{
    static void Main()
    {
        // Using Default Constructor
        CarRental rental1 = new CarRental();
        Console.WriteLine("Default Rental Details:");
        rental1.DisplayRentalDetails();

        // Using Parameterized Constructor
        CarRental rental2 = new CarRental("Muskan", "Toyota Corolla", 5, 60.0);
        Console.WriteLine("\nCustom Rental Details:");
        rental2.DisplayRentalDetails();
    }
}
*/