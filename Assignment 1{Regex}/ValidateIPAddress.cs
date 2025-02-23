/*using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class ValidateIPAddress
{
    public static bool IsValidIPv4(string ipAddress)
    {
        // Define the regex pattern for IPv4 validation
        string pattern = "^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$";

        return Regex.IsMatch(ipAddress, pattern);
    }
}

class Program10
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter an IP address: ");
        string ipAddress = Console.ReadLine();

        if (ValidateIPAddress.IsValidIPv4(ipAddress))
        {
            Console.WriteLine("Valid IPv4 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv4 address");
        }
    }
}
*/