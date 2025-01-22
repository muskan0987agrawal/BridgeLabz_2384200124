using System;
     class AreaOfTriangle {// Main class
	
	    // Function to calculate the area of the triangle
	
        static double CalculateArea(double baseOfTriangle, double heightOfTriangle)
        {
            return 0.5 * baseOfTriangle * heightOfTriangle;
        }
    

   
        static void Main(string[] args) // Entry point of the program
        {
            // Take the base as input
            Console.Write("Enter the base of the triangle: ");
            double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

            // Take the height as input
            Console.Write("Enter the height of the triangle: ");
            double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

            // Call the function to calculate the area of the triangle
            double area = CalculateArea(baseOfTriangle, heightOfTriangle);

            // Output the result
            Console.WriteLine("The base of the triangle is "+ baseOfTriangle+" and the height of the triangle is "+ heightOfTriangle +" . The area of the triangle is " + area );
        }

    }