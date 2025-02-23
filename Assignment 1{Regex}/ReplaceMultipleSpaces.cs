/*using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class ReplaceMultipleSpaces
{
    public static string RemoveExtraSpaces(string text)
    {
        // Replace multiple spaces with a single space
        string processedText = Regex.Replace(text, "\\s+", " ").Trim();
        return processedText;
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence with multiple spaces: ");
        string text = Console.ReadLine();
        Console.WriteLine("After Removing multiple spaces: " + RemoveExtraSpaces(text) );
    }
}*/
