// See https://aka.ms/new-console-template for more information

using VehicleRentalSystem;

class Program3
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        while (true)
        {
            Console.WriteLine("\n Vehicle Rental System");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Add Bike");
            Console.WriteLine("3. Add Truck");
            Console.WriteLine("4. View Vehicles & Calculate Costs");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Car car = new Car();
                    Console.Write("Enter Vehicle Number: ");
                    car.VehicleNumber = Console.ReadLine();
                    car.VehicleType = "Car";
                    Console.Write("Enter Rental Rate: ");
                    car.RentalRate = Convert.ToInt32(Console.ReadLine());
                    vehicles.Add(car);
                    break;

                case 2:
                    Bike bike = new Bike();
                    Console.Write("Enter Vehicle Number: ");
                    bike.VehicleNumber = Console.ReadLine();
                    bike.VehicleType = "Bike";
                    Console.Write("Enter Rental Rate: ");
                    bike.RentalRate = Convert.ToInt32(Console.ReadLine());
                    vehicles.Add(bike);
                    break;

                case 3:
                    Truck truck = new Truck();
                    Console.Write("Enter Vehicle Number: ");
                    truck.VehicleNumber = Console.ReadLine();
                    truck.VehicleType = "Truck";
                    Console.Write("Enter Rental Rate: ");
                    truck.RentalRate = Convert.ToInt32(Console.ReadLine());
                    vehicles.Add(truck);
                    break;

                case 4:
                    if (vehicles.Count == 0)
                    {
                        Console.WriteLine("No vehicles to display.");
                    }
                    else
                    {
                        Console.Write("Enter number of days for rental: ");
                        int days = Convert.ToInt32(Console.ReadLine());

                        foreach (var vehicle in vehicles)
                        {
                            vehicle.DisplayDetails();
                            IInsurable insurable = (IInsurable)vehicle;
                            Console.WriteLine($"Insurance Cost: {insurable.CalculateInsurance()}");
                            Console.WriteLine($"Total Rental Cost: {vehicle.CalculateRentalCost(days)}");
                            Console.WriteLine(insurable.GetInsuranceDetails());
                            Console.WriteLine();
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again!");
                    break;
            }
        }
    }
}
