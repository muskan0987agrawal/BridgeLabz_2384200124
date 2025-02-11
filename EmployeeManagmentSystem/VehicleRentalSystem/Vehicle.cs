using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal abstract class Vehicle
    {
        private string vehicleNumber;
        private string vehicleType;
        private int rentalRate;

        // Vehicle Number Property (Validation)
        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine(" Error: Vehicle number cannot be empty!");
                    Environment.Exit(0); // Stop program
                }
                vehicleNumber = value;
            }
        }

        // Vehicle Type Property (Validation)
        public string VehicleType
        {
            get { return vehicleType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Vehicle type cannot be empty!");
                    Environment.Exit(0);
                }
                vehicleType = value;
            }
        }

        // Rental Rate Property (Validation)
        public int RentalRate
        {
            get { return rentalRate; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Error: Rental rate must be greater than zero!");
                    Environment.Exit(0);
                }
                rentalRate = value;
            }
        }
        public abstract double CalculateRentalCost(int days);

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Rental Rates: {rentalRate}");
            
        }

    }
        

}
