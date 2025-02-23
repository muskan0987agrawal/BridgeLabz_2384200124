/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class ReplaceBadWord
{
    static string CensorWord(string text, List<string> badWords)
    {
        foreach (var badWord in badWords)
        {
            string pattern = "\\b" + Regex.Escape(badWord) + "\\b";
            text = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        }
        return text;
    }

    static void Main()
    {
        // Define a list of bad words
        List<string> badWords = new List<string> { "damn", "stupid" };

        // Take input from the user
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string result = CensorWord(text, badWords);
        Console.WriteLine("Censored Text: " + result);
    }
}

*/
