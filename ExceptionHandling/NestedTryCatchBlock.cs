/* using System;

class NestedTryCatchExample
{
    static void PerformDivision(int[] numbers, int index, int divisor)
    {
        try
        {
            // Outer try block to catch IndexOutOfRangeException
            try
            {
                int value = numbers[index]; // May throw IndexOutOfRangeException
                Console.WriteLine($"Value at index {index}: {value}");

                // Inner try block to catch DivideByZeroException
                try
                {
                    int result = value / divisor; // May throw DivideByZeroException
                    Console.WriteLine($"Division result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }

    static void Main()
    {
        Console.Write("Enter the array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];
        Console.WriteLine("Enter array elements:");

        try
        {
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.Write("Enter index to access: ");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        PerformDivision(numbers, index, divisor);

        Console.WriteLine("Program execution completed.");
    }
}
*/