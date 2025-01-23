/* using System;

class Program17
{
    void CalculateBonus()
    {
        // Input: Take salary and years of service
        Console.Write("Enter the employee's salary (INR): ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Calculate the bonus if years of service > 5
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05; // 5% of salary
            Console.WriteLine($"The bonus amount for {yearsOfService} years of service is INR {bonus}");
        }
        else
        {
            Console.WriteLine("No bonus is given as the years of service are 5 or less.");
        }
    }

    static void Main(string[] args)
    {
        Program17 p = new Program17();
        p.CalculateBonus();
    }
}*/
