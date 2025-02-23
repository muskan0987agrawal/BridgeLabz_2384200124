/*Ausing System;
using System.Text.RegularExpressions;


internal class HexCcolorCode
    {
        public static void ValidHexCode(String code)
        {
            string pattern = "^[#][0-9 A-f a-f]{6}";
            Match match = Regex.Match(code, pattern);
        if (match.Success)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
      }
    }

internal class Program3
{
    public static void Main()
    {
        // Take input from the user
        Console.Write("Enter a Hex Color Code : ");
        string code = Console.ReadLine();

        // Validate and print the result
        HexCcolorCode.ValidHexCode(code);
    }
}
*/