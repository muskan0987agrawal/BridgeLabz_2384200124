/*using System;

class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        // Applying the wind chill formula
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }

    static void Main()
    {
        // Taking user input for temperature and wind speed
        Console.Write("Enter the temperature (in Fahrenheit): ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter the wind speed (in miles per hour): ");
        double windSpeed = double.Parse(Console.ReadLine());

        // Creating an object of WindChillCalculator to call the method
        WindChillCalculator calculator = new WindChillCalculator();
        
        // Calculating wind chill
        double windChill = calculator.CalculateWindChill(temperature, windSpeed);

        // Displaying the result
        Console.WriteLine("The wind chill temperature is: " + windChill + "°F");
    }
}
*/

