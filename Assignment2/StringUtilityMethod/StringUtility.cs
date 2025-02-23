using System;

namespace StringUtilityMethod
{
    public class StringUtility
    {
        public static string Reverse(string str)
        {

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
            return new string (charArray);
        }

        public static bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        }
    }
