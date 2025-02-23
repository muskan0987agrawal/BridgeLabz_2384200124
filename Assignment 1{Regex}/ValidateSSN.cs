/* using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


internal class ValidateSSN
{
    static bool IsValidSSN(string text)
    {
        string pattern = "\\b\\d{3}-\\d{2}-\\d{4}\\b";
        return Regex.IsMatch(text, pattern);
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence containing an SSN: ");
        string text = Console.ReadLine();

        if (IsValidSSN(text))
        {
            Console.WriteLine("Valid SSN found");
        }
        else
        {
            Console.WriteLine("No valid SSN found");
        }
    }
}
*/