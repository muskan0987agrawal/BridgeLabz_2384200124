/*using System;


namespace CollectionAssignment
{
    internal class Program2
    {
        Dictionary<String, int> d = new Dictionary<string, int>();
        public void FindFrequency(List<String> list)
        {

            foreach (String s in list)
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
                Console.Write($"{v.Key}: {v.Value}, ");
            }
        }
    }
    internal class FindFrequencyOfELement
    {
        public static void Main()
        {
            List<string> list = new List<string>() { "apple", "banana", "apple", "orange" };
            Program2 p = new Program2();
                p.FindFrequency(list);
            p.PrintDic();
        }
    }
}
*/