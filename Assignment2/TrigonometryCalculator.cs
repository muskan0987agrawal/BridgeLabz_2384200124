/*using System;

class TrigonometryCalculator
{
    // Method to calculate various trigonometric functions
    public double[] CalculateTrigonometricFunctions(double angle)
    {
        // Converting angle from degrees to radians
        double radians = angle * (Math.PI / 180);

        // Calculating sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Returning the results in an array
        return new double[] { sine, cosine, tangent };
    }

    static void Main()
    {
        // Taking user input for angle in degrees
        Console.Write("Enter an angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Creating an object of TrigonometryCalculator to call the method
        TrigonometryCalculator calculator = new TrigonometryCalculator();
        
        // Getting the trigonometric functions
        double[] results = calculator.CalculateTrigonometricFunctions(angle);

        // Displaying the results
        Console.WriteLine($"Sine of {angle}°: {results[0]}");
        Console.WriteLine($"Cosine of {angle}°: {results[1]}");
        Console.WriteLine($"Tangent of {angle}°: {results[2]}");
    }
}

*/