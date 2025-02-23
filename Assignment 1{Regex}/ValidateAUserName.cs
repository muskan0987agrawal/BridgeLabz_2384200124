/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    internal class ValidateAUserName
    {
    public static string ValidUsername(string username)
    {
        // Define the regex pattern
        string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        bool match = Regex.IsMatch(username, pattern);
        
        if (username.Length < 5 || username.Length >15)
        {
            return "Either Name is too short or too Long";
        }

        else if (!match){
            return "Invalid username";
        }

        return "Valid userName";
    }
}
    internal class Program1
    {
        public static void Main(string[] args)
        {
            // Take input from the user
            Console.Write("Enter a username : ");
            string username = Console.ReadLine();

        // Validate and print the result
        Console.WriteLine(ValidateAUserName.ValidUsername(username));


    }
      }
*/
