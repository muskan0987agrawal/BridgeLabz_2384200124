// See https://aka.ms/new-console-template for more information


using System;

// Interface for GPS System
interface IGPS
{
    void GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Abstract class Vehicle
abstract class Vehicle : IGPS
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;
    private string location;

    // Encapsulation: Properties
    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value > 0 ? value : 0; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = string.IsNullOrWhiteSpace(value) ? "Unknown Driver" : value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value > 0 ? value : 1; }
    }

    // Abstract Method for Fare Calculation
    public abstract double CalculateFare(double distance);

    // Concrete Method for Vehicle Details
    public virtual void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per KM: {RatePerKm}");
    }

    // IGPS Methods (Location Tracking)
    public void GetCurrentLocation()
    {
        Console.WriteLine($"Current Location: {location}");
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
        Console.WriteLine($"Updated Location: {location}");
    }
}

// Car Class (Premium Ride)
class Car : Vehicle
{
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm; // Normal rate
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine(" This is a Car Ride!");
    }
}

//  Bike Class (Affordable Ride)
class Bike : Vehicle
{
    public override double CalculateFare(double distance)
    {
        return distance * (RatePerKm * 0.8); // 20% cheaper
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine(" This is a Bike Ride!");
    }
}

//  Auto Class (Budget Ride)
class Auto : Vehicle
{
    public override double CalculateFare(double distance)
    {
        return distance * (RatePerKm * 0.9); // 10% cheaper
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("This is an Auto Ride!");
    }
}

//  Main Program with Switch Statement
class Program
{
    static void Main()
    {
        Console.WriteLine("Ride-Hailing Application:");
        Console.WriteLine("1. Book a Car");
        Console.WriteLine("2. Book a Bike");
        Console.WriteLine("3. Book an Auto");
        Console.WriteLine("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Vehicle ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Driver Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Rate Per KM: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Distance (KM): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Car car = new Car { VehicleId = id, DriverName = name, RatePerKm = rate };
                car.GetVehicleDetails();
                Console.WriteLine($"Total Fare: {car.CalculateFare(distance)}");
                break;

            case 2:
                Bike bike = new Bike { VehicleId = id, DriverName = name, RatePerKm = rate };
                bike.GetVehicleDetails();
                Console.WriteLine($"Total Fare: {bike.CalculateFare(distance)}");
                break;

            case 3:
                Auto auto = new Auto { VehicleId = id, DriverName = name, RatePerKm = rate };
                auto.GetVehicleDetails();
                Console.WriteLine($"Total Fare: {auto.CalculateFare(distance)}");
                break;

            default:
                Console.WriteLine("Invalid Choice! Try Again.");
                break;
        }
    }
}



