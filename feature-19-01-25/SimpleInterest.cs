using System;
class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}