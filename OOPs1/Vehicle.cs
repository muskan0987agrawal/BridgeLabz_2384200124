//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPs1
//{
//    internal class Vehicle
//    {
//        // Static variable shared by all vehicles
//        private static double RegistrationFee = 5000.0;

//        // Readonly variable: cannot be changed after assignment
//        public readonly int RegistrationNumber;
//        public string OwnerName;
//        public string VehicleType;

//        // Constructor using 'this' to initialize variables
//        public Vehicle(int regNumber, string owner, string type)
//        {
//            this.RegistrationNumber = regNumber;
//            this.OwnerName = owner;
//            this.VehicleType = type;
//        }

//        // Static method to update registration fee
//        public static void UpdateRegistrationFee(double newFee)
//        {
//            RegistrationFee = newFee;
//        }

//        // Method to display vehicle details
//        public void DisplayDetails()
//        {
//            Console.WriteLine($"\nRegistration Number: {RegistrationNumber}");
//            Console.WriteLine($"Owner Name: {OwnerName}");
//            Console.WriteLine($"Vehicle Type: {VehicleType}");
//            Console.WriteLine($"Registration Fee: {RegistrationFee}");
//            Console.WriteLine("-----------------------------");
//        }

//        // Method to check if an object is a Vehicle
//        public static void CheckInstance(object obj)
//        {
//            if (obj is Vehicle)
//            {
//                Console.WriteLine(" This is a valid Vehicle instance.");
//            }
//            else
//            {
//                Console.WriteLine(" This is NOT a Vehicle instance.");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter the number of Vehicles: ");
//            int numVehicles = int.Parse(Console.ReadLine());

//            // Allow user to update registration fee
//            Console.Write("Enter new Registration Fee: ");
//            double newFee = double.Parse(Console.ReadLine());
//            Vehicle.UpdateRegistrationFee(newFee);

//            // Create an array to store vehicles
//            Vehicle[] vehicles = new Vehicle[numVehicles];

//            // Take input from the user
//            for (int i = 0; i < numVehicles; i++)
//            {
//                Console.WriteLine($"\nEnter details for Vehicle {i + 1}:");
//                Console.Write("Registration Number: ");
//                int regNum = int.Parse(Console.ReadLine());

//                Console.Write("Owner Name: ");
//                string owner = Console.ReadLine();

//                Console.Write("Vehicle Type (Car/Bike/Truck): ");
//                string type = Console.ReadLine();

//                vehicles[i] = new Vehicle(regNum, owner, type);
//            }

//            // Display all vehicles after validation
//            Console.WriteLine("\n=== Vehicle Registration Details ===");
//            for (int i = 0; i < numVehicles; i++)
//            {
//                if (vehicles[i] is Vehicle)
//                {
//                    vehicles[i].DisplayDetails();
//                }
//            }

//        }
//    }
//}
