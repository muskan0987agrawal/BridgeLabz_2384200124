/*using System;

class GcdLcmCalculator
{
    // Function to calculate the GCD using Euclidean algorithm
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the LCM
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);  // Using the relation: LCM(a, b) = (a * b) / GCD(a, b)
    }

    // Function to get input from the user
    static void GetInputAndCalculate()
    {
        Console.WriteLine("Enter two numbers to calculate their GCD and LCM:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        // Display the results
        Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"The LCM of {num1} and {num2} is: {lcm}");
    }

    // Main function to drive the program
    static void Main()
    {
        GetInputAndCalculate();  // Get the input and calculate GCD and LCM
    }
}
*/