using System;

class Program1
{
    // Method to calculate and print quotient and remainder
    void PrintQuotientRemainder()
    {
        // Taking user input
        Console.Write("Enter the number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        Console.Write("Enter the number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Calculating quotient and remainder
        int findQuotient = num1 / num2;
        int findRemainder = num1 % num2;

        // Printing the result
        Console.WriteLine($"The Quotient is {findQuotient} and Remainder is {findRemainder} of two numbers {num1} and {num2}.");
    }

    // Main method
    static void Main(string[] args)
    {
        Program1 p = new Program1(); // Creating an object of class Program1
        p.PrintQuotientRemainder(); // Calling the method
    }
}
