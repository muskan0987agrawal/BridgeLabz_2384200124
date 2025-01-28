/*using System;

class Quadratic
{
    static void FindRoots(double a, double b, double c)
    {
        // Calculate the discriminant
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            // Two real roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"The roots are: x1 = {root1}, x2 = {root2}");
        }
        else if (delta == 0)
        {
            // One real root
            double root = -b / (2 * a);
            Console.WriteLine($"The root is: x = {root}");
        }
        else
        {
            // No real roots
            Console.WriteLine("No real roots.");
        }
    }

    static void Main()
    {
        // Take input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call method to find the roots
        FindRoots(a, b, c);
    }
}
*/