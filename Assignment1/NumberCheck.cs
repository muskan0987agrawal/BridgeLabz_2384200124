/*using System;

class NumberCheck
{
    // Method to check whether the number is positive or negative
    public static string IsPositive(int number)
    {
        return number >= 0 ? "Positive" : "Negative";
    }

    // Method to check whether the number is even or odd
    public static string IsEven(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    // Method to compare two numbers
    public static int CompareNumbers(int num1, int num2)
    {
        if (num1 > num2) return 1; // num1 is greater
        if (num1 == num2) return 0; // both are equal
        return -1; // num1 is less
    }

    // Main method to take input, check and display results
    static void Main()
    {
        int[] numbers = new int[5];
        
        // Taking input for 5 numbers from the user
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Loop through the array and check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            string positiveStatus = IsPositive(numbers[i]);
            if (positiveStatus == "Positive")
            {
                string evenOddStatus = IsEven(numbers[i]);
                Console.WriteLine($"Number {numbers[i]} is Positive and {evenOddStatus}");
            }
            else
            {
                Console.WriteLine($"Number {numbers[i]} is Negative");
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = CompareNumbers(numbers[0], numbers[4]);
        
        // Display the comparison result
        if (comparisonResult == 1)
            Console.WriteLine($"First number {numbers[0]} is greater than Last number {numbers[4]}");
        else if (comparisonResult == 0)
            Console.WriteLine($"First number {numbers[0]} is equal to Last number {numbers[4]}");
        else
            Console.WriteLine($"First number {numbers[0]} is less than Last number {numbers[4]}");
    }
}
*/