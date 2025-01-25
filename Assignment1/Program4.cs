/*using System;

class Program4
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number= long.Parse(Console.ReadLine());
        int maxDigit = 10; // Initial size of the array
        int[] digits = new int[maxDigit]; // Array to store the digits
        int index = 0; // To track the position in the array

        // Extract digits and store in the array
        while (number != 0)
        {
            if (index == maxDigit)
            {
                // Increase the size of the array by 10
                maxDigit += 10;
                int[] temp = new int[maxDigit]; // Create a new temporary array
                for (int i = 0; i < digits.Length; i++) // Copy old array values to the new one
                {
                    temp[i] = digits[i];
                }
                digits = temp; // Assign the new array back to digits
            }

            digits[index] = (int)(number % 10); // Extract the last digit
            number /= 10; // Remove the last digit
            index++; // Move to the next array position
        }

        // Variables to store the largest and second-largest digits
        int largest = 0, secondLargest = 0;

        // Loop through the array to find the largest and second-largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second-largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second-largest
            }
        }

        // Display the results
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second-largest digit: {secondLargest}");
    }
}
*/