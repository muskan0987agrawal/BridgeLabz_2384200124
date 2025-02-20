/*using System;

namespace CollectionAssignment
{
    internal class Program2
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        public void FindFrequency(List<int> list)
        {

            foreach (int s in list)
            {
                if (!d.ContainsKey(s))
                {
                    d[s] = 0;
                }
                d[s]++;
            }


        }
        public void PrintDic()
        {
            foreach (var v in d)
            {
                Console.Write($"{v.Key} ");
            }
        }
    }
    internal class FindFrequencyOfELement
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 3, 1, 2, 2, 3, 4 };
            Program2 p = new Program2();
            p.FindFrequency(list);
            p.PrintDic();
        }
    }
}
*/

/*using System;

namespace CollectionAssignment
{
    internal class Program2
    {
        public class RemoveDuplicate
        {
            public static void LetsRemove(List<int> list)
            {
                HashSet<int> s = new HashSet<int>();
                foreach (int l in list) s.Add(l);
                foreach (int l in s) Console.Write(l + " ");

            }
            public static void Main()
            {
                List<int> list = new List<int>() { 3, 1, 2, 2, 3, 4 };
                LetsRemove(list);
                Console.ReadLine();
            }
        }
    }
}
*/