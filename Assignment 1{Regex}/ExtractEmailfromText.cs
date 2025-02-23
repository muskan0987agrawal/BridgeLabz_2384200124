/*using System;
using System.Text.RegularExpressions;
 internal class ExtractEmailfromText
  {
    public static List<string> GetEmails(string text)
      {
            // Define the regex pattern for email extraction
            string pattern =  @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";


        MatchCollection matches = Regex.Matches(text, pattern);

            List<string> emails = new List<string>();
            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }
            return emails;
        }
    }

    internal class Program1
    {
        public static void Main(string[] args)
        {
            // Take input from the user
            Console.Write("Enter text containing email addresses: ");
            string text = Console.ReadLine();

            // Extract and print email addresses
            List<string> emails = ExtractEmailfromText.GetEmails(text);

            if (emails.Count > 0)
            {
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
            }
            else
            {
                Console.WriteLine("No email addresses found.");
            }
        }
    }
*/

