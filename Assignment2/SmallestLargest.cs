/*using System;

class SmallestLargest
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int[] result = new int[2]; // To store the smallest and largest numbers

        // Finding smallest and largest using Math.Min() and Math.Max()
        result[0] = Math.Min(Math.Min(number1, number2), number3); // Smallest number
        result[1] = Math.Max(Math.Max(number1, number2), number3); // Largest number
        
        return result;
    }

    static void Main()
    {
        // Taking input for three numbers
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        // Calling the method to find smallest and largest
        int[] result = FindSmallestAndLargest(num1, num2, num3);

        // Displaying the results
        Console.WriteLine("Smallest number is: " + result[0]);
        Console.WriteLine("Largest number is: " + result[1]);
    }
}
*/