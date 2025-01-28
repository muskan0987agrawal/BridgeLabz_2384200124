/*using System;

class AthleteRun
{


    // Method to calculate the number of rounds to complete 5 km (5000 meters)
    static double CalculateRoundsToCompleteRun(double side1, double side2, double side3)
    {
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds needed to complete 5000 meters
        double rounds = 5000 / perimeter;

        // Return the number of rounds (rounded to two decimal places)
        return Math.Round(rounds, 2);
    }
	   
    static void Main()
    {
        // Taking input for the 3 sides of the triangle
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Call the method to calculate and display the number of rounds needed to complete 5 km
        double rounds = CalculateRoundsToCompleteRun(side1, side2, side3);

        Console.WriteLine($"The athlete needs to complete {rounds} rounds to run 5 kilometers.");
    }
}
*/