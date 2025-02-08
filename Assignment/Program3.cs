 /*using System;

namespace VehicleTransportSystem
{
    // Base class: Vehicle
    internal class Vehicle
    {
        // Attributes
        private int MaxSpeed;
        private string FuelType;

        // Setter method to assign values (Encapsulation)
        public void SetVehicle(int maxSpeed, string fuelType)
        {
            this.MaxSpeed = maxSpeed;
            this.FuelType = fuelType;
        }

        // Virtual method to display vehicle details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
        }
    }

    // Subclass: Car
    internal class Car : Vehicle
    {
        // Corrected attribute: SeatCapacity instead of PayloadCapacity
        private int SeatCapacity;

        // Setter method for Car
        public void SetCarDetails(int maxSpeed, string fuelType, int seatCapacity)
        {
            base.SetVehicle(maxSpeed, fuelType);
            this.SeatCapacity = seatCapacity;
        }

        // Overriding DisplayInfo to include Seat Capacity
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity: {SeatCapacity}");
        }
    }

    // Subclass: Truck
    internal class Truck : Vehicle
    {
        private int PayloadCapacity; // Capacity in kg

        // Setter method for Truck
        public void SetTruckDetails(int maxSpeed, string fuelType, int payloadCapacity)
        {
            SetVehicle(maxSpeed, fuelType);
            this.PayloadCapacity = payloadCapacity;
        }

        // Overriding DisplayInfo to include Payload Capacity
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
        }
    }

    // Subclass: Motorcycle
    internal class Motorcycle : Vehicle
    {
        private bool HasSidecar;

        // Setter method for Motorcycle
        public void SetMotorcycleDetails(int maxSpeed, string fuelType, bool hasSidecar)
        {
            base.SetVehicle(maxSpeed, fuelType);
            this.HasSidecar = hasSidecar;
        }

        // Overriding DisplayInfo to include Sidecar information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }

    // Main Program Class
    internal class Program
    {
        public static void Main()
        {
            // Creating objects and using setter methods
            Car car = new Car();
            car.SetCarDetails(180, "Petrol", 5);

            Truck truck = new Truck();
            truck.SetTruckDetails(120, "Diesel", 5000);

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.SetMotorcycleDetails(150, "Petrol", false);

            // Storing them in a Vehicle array (Polymorphism)
            Vehicle[] vehicles = { car, truck, motorcycle };

            // Displaying details using polymorphism (dynamic method dispatch)
            Console.WriteLine("Displaying Vehicle Details:");
            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
        }
      
    }
}
*/