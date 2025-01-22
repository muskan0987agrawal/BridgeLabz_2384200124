using System;

namespace HeightConverter // Class namespace
{
    class Program // Main class
    {
	  //Function to convert height from cm to feet and inches
        static void ConvertHeight(double heightInCm)
        {
            // Conversion constants
            double cmInInch = 2.54; // 1 inch = 2.54 cm
			
            int inchInFoot = 12; // 1 foot = 12 inches

            // Calculate the total number of inches
            double totalInches = heightInCm / cmInInch;

            // Calculate feet
            int feet = (int)(totalInches / inchInFoot);

            // Calculate remaining inches
            int inches = (int)(totalInches % inchInFoot);

            // Output the results
            Console.WriteLine("Your Height in cm is "+ heightInCm +" cm While in feet is "+ feet+" feet and inches is "+inches + " inches.");
        }
		
        static void Main(string[] args) // Entry point of the program
        {
            // Take height in centimeters as input from the user
			
            Console.Write("Enter your height in centimeters: ");
			
            double heightInCm = Convert.ToDouble(Console.ReadLine());

            // Call the function to convert height to feet and inches
			
            ConvertHeight(heightInCm);
        }

      
    }
}
