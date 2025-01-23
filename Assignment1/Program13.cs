/*using System;

class Program13
{
    void SumNaturalNumber()
    {
        Console.Write("Enter the Integer number: ");
        int number = int.Parse(Console.ReadLine()); // Input number from user

        if (number > 0 ) // Check if the number is positive and an integer
        {
            Console.WriteLine($"The number {number} is a natural number");

            // Calculate the sum of natural numbers using a loop
            double sum = 0;
			
            for (int i = 1;i <= number;i++)
            {
                sum += i;
            }

            // Calculate the sum using the formula
            double sumByFormula = (number * (number + 1)) / 2;

            // Print the results
            Console.WriteLine($"The sum of the first {number} natural numbers is:");
            Console.WriteLine($"Using a for loop: {sum}");
            Console.WriteLine($"Using the formula: {sumByFormula}");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }

    static void Main()
    {
        Program13 p = new Program13(); // Create an object of the class
        p.SumNaturalNumber(); // Access the method
    }
}
*/