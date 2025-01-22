using System;

class Program12
{
    // Function to convert pounds to kilograms
    void ConvertPoundsToKilograms()
    {
	
	    // Input: weight in pounds
        Console.Write("Enter the weight in pounds: ");
	    double pounds =double.Parse(Console.ReadLine());
		
        // Conversion factor: 1 pound = 2.2 kg
        double kilograms = pounds * 2.2;
        
        // Output the result
        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kilograms}.");
    }

    static void Main()
    {
         Program12 P = new Program12(); //creating an object of class
		  P.ConvertPoundsToKilograms();
    }
}
