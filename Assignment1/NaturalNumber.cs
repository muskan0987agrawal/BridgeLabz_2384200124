/*using System;

class NaturalNumbersSum
{
    // Method to check if the input is a natural number
    static bool IsNaturalNumber(int n)
    {
        return n > 0; // A natural number is positive and starts from 1
    }

    // Method to calculate the sum of n natural numbers using recursion
    static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1; // Base case: the sum of the first natural number is 1
        return n + SumUsingRecursion(n - 1); // Recursive step
    }

    // Method to calculate the sum of n natural numbers using the formula
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2; // Formula for the sum of n natural numbers
    }

    // Main function
    static void Main()
    {
        Console.Write("Enter a number to find the sum of n natural numbers: ");
        int input= int.Parse(Console.ReadLine());
        if(!IsNaturalNumber(input))
		{ 
		  Console.Error.WriteLine("Invalid Number!! Not a natural number");
            Environment.Exit(0);
		}

        // Calculate the sum using recursion
        int sumRecursion = SumUsingRecursion(input);

        // Calculate the sum using the formula
        int sumFormula = SumUsingFormula(input);

        // Compare the results and print them
        Console.WriteLine($"Sum of the first {input} natural numbers using recursion: {sumRecursion}");
        Console.WriteLine($"Sum of the first {input} natural numbers using formula: {sumFormula}");

        // Verify that both methods produce the same result
        if (sumRecursion == sumFormula)
        {
            Console.WriteLine("Both computations are correct!");
        }
        else
        {
            Console.WriteLine("There is a mismatch in the results. Please check the methods.");
        }
    }
}
*/