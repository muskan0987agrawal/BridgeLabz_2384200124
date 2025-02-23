/*using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class FindRepeatingWords
{
    static List<string> GetRepeatingWords(string text)
    {
        List<string> repeatingWords = new List<string>();
        string pattern = "\\b(\\w+)\\b(?:.*\\b\\1\\b)";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            if (!repeatingWords.Contains(match.Groups[1].Value.ToLower()))
            {
                repeatingWords.Add(match.Groups[1].Value);
            }
        }

        return repeatingWords;
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        List<string> result = GetRepeatingWords(text);

        if (result.Count > 0)
        {
            Console.WriteLine("Repeating Words: " + string.Join(", ", result));
        }
        else
        {
            Console.WriteLine("No repeating words found.");
        }
    }
}
*/