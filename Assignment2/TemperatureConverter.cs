/*using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Function to get the temperature unit and value from the user
    static void GetTemperatureInput()
    {
        Console.WriteLine("Choose the conversion:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius:F2}°C.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit:F2}°F.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please choose either 1 or 2.");
        }
    }

    // Main function to drive the program
    static void Main()
    {
        GetTemperatureInput();  // Get user input and perform conversion
    }
}
*/