/* using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

 internal class ExtractDateFormat
  {
    static void ValidDate(string text)
    {
        string pattern = "\\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\\d{4}\\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> date = new List<string>();
        foreach (Match match in matches)
        {
            date.Add(match.Value);
        }

        if (date.Count > 0)
        {
            Console.WriteLine(string.Join(", ", date));
        }
        else
        {
            Console.WriteLine("No Dates format found");
        }
    }

    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        ValidDate(text);

    }
}
*/
