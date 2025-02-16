/* using System;
using System.Text;

namespace _15_02_2025StringBuilderFile
{
    internal class Program1
    {
       static string ReverseString(string str)
          {
             // Convert the input string to a StringBuilder for efficient modification
              StringBuilder sb = new StringBuilder(str);
              int length = sb.Length;

             // Swap characters from the start and end towards the middle
                for (int i = 0; i < length / 2; i++)
                {
                    // Store the character at the current position
                    char temp = sb[i];

                    // Swap it with the corresponding character from the end
                    sb[i] = sb[length - 1 - i];
                    sb[length - 1 - i] = temp;
                }

                // Return the modified string as a regular string
                return sb.ToString();
            }
        public static void Main()
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Reverse the input string using the ReverseString method
            string reversed = ReverseString(input);

            // Display the reversed string
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }

    }
       
*/