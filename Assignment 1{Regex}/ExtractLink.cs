/* using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class ExtractLink
{
    public static List<string> GetLinks(string text)
    {
        // Define the regex pattern for extracting links
        string pattern = "https?://[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}(/[a-zA-Z0-9._%+-]*)*";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> links = new List<string>();
        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }
        return links;
    }
}

class Program7
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence containing links: ");
        string text = Console.ReadLine();

        List<string> links = ExtractLink.GetLinks(text);
        if (links.Count > 0)
        {
            Console.WriteLine(string.Join(", ", links));
        }
        else
        {
            Console.WriteLine("No valid links found.");
        }
    }
}
*/
