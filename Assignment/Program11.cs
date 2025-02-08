using System;

// Superclass: Vehicle
internal class Vehicle
{
    protected string Model;
    protected int MaxSpeed;

    public void SetVehicleDetails(string model, int maxSpeed)
    {
        this.Model = model;
        this.MaxSpeed = maxSpeed;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model} \nMax Speed: {MaxSpeed} km/h");
    }
}

// Interface: Refuelable (Implemented by PetrolVehicle)
interface IRefuelable
{
    void Refuel();
}

// Subclass: ElectricVehicle (Extends Vehicle)
internal class ElectricVehicle : Vehicle
{
    private int BatteryCapacity; // in kWh

    public void SetElectricDetails(string model, int maxSpeed, int batteryCapacity)
    {
        SetVehicleDetails(model, maxSpeed);
        this.BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine($"{Model} is charging. Battery capacity: {BatteryCapacity} kWh.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}

// Subclass: PetrolVehicle (Extends Vehicle & Implements IRefuelable)
internal class PetrolVehicle : Vehicle, IRefuelable
{
    private int FuelCapacity; // in liters

    public void SetPetrolDetails(string model, int maxSpeed, int fuelCapacity)
    {
        SetVehicleDetails(model, maxSpeed);
        this.FuelCapacity = fuelCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine($"{Model} is refueling. Fuel capacity: {FuelCapacity} liters.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
    }
}

// Main Program
internal class Program
{
    public static void Main()
    {
        // Creating Electric Vehicle Object
        ElectricVehicle tesla = new ElectricVehicle();
        tesla.SetElectricDetails("Tesla Model S", 250, 100);

        // Creating Petrol Vehicle Object
        PetrolVehicle ford = new PetrolVehicle();
        ford.SetPetrolDetails("Ford Mustang", 220, 60);

        // User interaction using while loop
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. View Electric Vehicle Details");
            Console.WriteLine("2. Charge Electric Vehicle");
            Console.WriteLine("3. View Petrol Vehicle Details");
            Console.WriteLine("4. Refuel Petrol Vehicle");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nElectric Vehicle Details:");
                    tesla.DisplayInfo();
                    Console.WriteLine("----------------------");
                    break;
                case 2:
                    tesla.Charge();
                    Console.WriteLine("----------------------");
                    break;
                case 3:
                    Console.WriteLine("\nPetrol Vehicle Details:");
                    ford.DisplayInfo();
                    Console.WriteLine("----------------------");
                    break;
                case 4:
                    ford.Refuel();
                    Console.WriteLine("----------------------");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
