using System;

    class CalculatePerimeterOfSquare // Main class
    {
	     // Function to calculate the side of the square
        static double CalculateSide(double perimeter)
        {
            return (perimeter / 4); // Side = Perimeter / 4
        }
		
        static void Main(string[] args) // Entry point of the program
        {
            // Take the perimeter as input from the user
            Console.Write("Enter the perimeter of the square: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            // Call the function to calculate the side of the square
            double side = CalculateSide(perimeter);

            // Output the result
            Console.WriteLine("The length of the side is "+ side +" whose perimeter is "+ perimeter);
        }

       
    }

