using System;

class DistanceKilometerToMiles{
     public static void Main(String[] args){
 
        Console.Write("Enter the distance in kilometer: ");
 
        //Take input from the user and stores the value in inputKilometer
        double inputKilometer = Convert.ToDouble(Console.ReadLine());
 
        //Conversion kilometer to miles 
        // as we know 1km =1.6 miles
        double kilometerToMiles = inputKilometer * 1.6 ;
 
        //Printing..
        Console.WriteLine("The Total Miles is " + kilometerToMiles + " mile for the given " + inputKilometer + " km");
		
		Console.ReadLine(); //To holds the console Screen
 }
 }
 