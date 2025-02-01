/*using System;

class Vehicle{
	//instance Variable
	string ownerName ;
	string vehicleType;
	
	//declare class variable  (shared across all instances
	static double registrationFee = 20000;
	
	//Parametrized Constructor
	public Vehicle(string ownerName, string vehicleType){
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
	}
	
	//Display Vehicle Detail
	public  void DisplayVehicleDetails(){
		Console.WriteLine($"Owner Name: {ownerName} \tVehicle type: {vehicleType} \tRegistration Fee: {registrationFee}");
	}
	
	//class method to update registrationFee
	public static void UpdateRegistrationFee(double newFee){
		 registrationFee = newFee;
		 Console.WriteLine($"\nRegistration Fee updated to: {registrationFee:C}\n");
	}
}

class VehicleRegistration{
	static void Main(){
		//instance of the class
		Vehicle v1= new Vehicle("John" , "Car");
		Vehicle v2= new Vehicle("Qwerty" , "Bike");
		Vehicle v3= new Vehicle("Jame" , "Thar");
		
		 // Display initial vehicle details
        Console.WriteLine("Initial Vehicle Details:");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
        v3.DisplayVehicleDetails();

        // Update the registration fee using the class method
        Vehicle.UpdateRegistrationFee(6000.00);

        // Display vehicle details after updating registration fee
        Console.WriteLine("Vehicle Details after Registration Fee Update:");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
        v3.DisplayVehicleDetails();
    }
}
*/