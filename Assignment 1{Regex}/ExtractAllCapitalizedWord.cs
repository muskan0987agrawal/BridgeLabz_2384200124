/* using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class ExtractAllCapitalizedWord
{
    public static List<string> CapitalizedWord(string text)
    {
        string pattern = "\\b[A-Z][a-z]*\\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> capitalWords = new List<string>();
        foreach (Match match in matches)
        {
            capitalWords.Add(match.Value);
        }
        return capitalWords;
    }
 }

class Program5
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        List<string> words = ExtractAllCapitalizedWord.CapitalizedWord(text);
        if (words.Count > 0)
        {
            Console.WriteLine(string.Join(",", words));
        }
        else
        {
            Console.WriteLine("No Capitalized words found");
        }
    }
}
*/

