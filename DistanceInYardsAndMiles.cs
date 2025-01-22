using System;

    class DistanceInYardsAndMiles // Main class
    {
	     // Function to convert the distance from feet to yards and miles
        static void ConvertDistance(double distanceInFeet)
        {

            // Convert feet to yards
            double distanceInYards = distanceInFeet / 3;

            // Convert yards to miles
            double distanceInMiles = distanceInYards / 1760;

            // Output the results
            Console.WriteLine("The distance in feet is "+ distanceInFeet +" while in yards is "+ distanceInYards +" and in miles is "+ distanceInMiles);
			
		}
			
        static void Main(string[] args) // Entry point of the program
        {
          
            Console.Write("Enter the distance in feet: ");
            double distanceInFeet = Convert.ToDouble(Console.ReadLine());

            // Call the function to convert the distance
            ConvertDistance(distanceInFeet);
        }

       
	}