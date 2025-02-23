/*using System;
using System.Text.RegularExpressions;

internal class ValidateLicensePlate
{
    public static string ValidatePlate(string plateNumber)
    {
        // Define the regex pattern
        string pattern = "^[A-Z]{2}[0-9]{4}$";

        if (!Regex.IsMatch(plateNumber, pattern))
        {
            return "Invalid license plate";
        }
        return "Valid license plate";
    }
}

internal class Program1
{
    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a license plate number: ");
        string plateNumber = Console.ReadLine();

        // Validate and print the result
        Console.WriteLine(ValidateLicensePlate.ValidatePlate(plateNumber));
    }
}
*/