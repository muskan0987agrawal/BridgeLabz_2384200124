/* using System;
class CalculateFactor
{
    static void Main()
    {

        Console.Write("Enter a positive integer to find its factors:  ");

        string num = Console.ReadLine();
        // Input validation
        if (!int.TryParse(num, out int number) || number <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        // Initialize variables
        int maxFactor = 10; // size of the array
        int[] factors = new int[maxFactor];
        int index = 0; // Index for tracking the number of elements in the array

        // Find factors and store in the array
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    // Double the size of the array if needed
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor]; //copying the elements in temp array
                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }
                    factors = temp;
                }
                factors[index++] = i; // Add the factor to the array
            }
        }
        // Display the factors
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();
    }
}
*/