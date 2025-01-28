/*using System;

class CollinearityCheck
{
    // Method to calculate the slope between two points
    static double CalculateSlope(int x1, int y1, int x2, int y2)
    {
        return (double)(y2 - y1) / (x2 - x1);
    }

    // Method to check if three points are collinear using the slope formula
    static bool ArePointsCollinearUsingSlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculating the slopes
        double slopeAB = CalculateSlope(x1, y1, x2, y2);
        double slopeBC = CalculateSlope(x2, y2, x3, y3);
        double slopeAC = CalculateSlope(y3, y1, x3, x1);
		
        // Checking if slopes are equal
        return slopeAB == slopeBC && slopeAB == slopeAC;
    }

    // Method to check if three points are collinear using the area of triangle formula
    static bool ArePointsCollinearUsingArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Using the area formula
        int area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        
        // If area is 0, points are collinear
        return area == 0;
    }

    static void Main()
    {
        // Sample points
        int x1 = 2, y1 = 4;
        int x2 = 4, y2 = 6;
        int x3 = 6, y3 = 8;

        Console.WriteLine($"Checking collinearity for points A({x1}, {y1}), B({x2}, {y2}), C({x3}, {y3})");

        // Check using slope method
        if (ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the slope method.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the slope method.");
        }

        // Check using area method
        if (ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the area method.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the area method.");
        }
    }
}
*/