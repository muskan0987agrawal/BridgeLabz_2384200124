/* using System;
using System.Collections.Generic;


namespace CollectionAssignment
{
    internal class TwoSetAreEqual
    {
        public static bool TwoSetEquals<T>(List<T> s1, List<T> s2)
        {
            if (s1.Count() != s2.Count())
            {
                return false;
            }

            foreach (var i in s1)
            {
                if (!IsEqual(i, s2))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEqual<T>(T i, List<T> s2)
        {
            foreach (var t in s2)
            {
                if (i.Equals(t)) return true ;
            }
            return false;
        }
    }

    internal class Program5
    {
        public static void Main(string[] args)
        {
            //    List<int> set1 = new List<int> { 1, 2,4, 3};
            //List<int> set2 = new List<int> { 3, 2,4, 1 };
            List<string> set1 = new List<string> { "apple", "kiwi", "mango"};
            List<string> set2 = new List<string> { "kiwi", "mango","Papaya"};

            Console.WriteLine("Are the sets equal? " + TwoSetAreEqual.TwoSetEquals(set1, set2)); 
          
        }
    }
}
*/