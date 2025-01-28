/*using System;

class EuclideanDistance
{
    // Method to calculate Euclidean distance between two points
    static double GetEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Method to find the equation of the line (slope and y-intercept) given two points
    static double[] GetLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];
        
        // Calculate the slope (m)
        double m = (y2 - y1) / (x2 - x1);
        
        // Calculate the y-intercept (b)
        double b = y1 - (m * x1);
        
        // Store the slope and y-intercept in the result array
        result[0] = m;
        result[1] = b;

        return result;
    }

    static void Main()
    {
        // Taking input for two points (x1, y1) and (x2, y2)
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = GetEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance}");

        // Calculate the equation of the line
        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"The equation of the line is: y = {lineEquation[0]}*x + {lineEquation[1]}");
    }
}
*/
