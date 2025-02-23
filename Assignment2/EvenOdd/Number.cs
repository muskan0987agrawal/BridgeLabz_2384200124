using System;
namespace NumberSystem
{
    public class Number
    {
        int num;
        public Number(int num)
        {
            this.num = num;
        }

        public string EvenAndOdd()
        {
            if (num % 2 == 0) { return "EVEN"; }
            return "ODD";
        }
    }
    internal class Program
    {
        public static void Main(string[] args)

        {
            Number n1 = new Number(24);
            Console.WriteLine(n1.EvenAndOdd());
        }

    }
}