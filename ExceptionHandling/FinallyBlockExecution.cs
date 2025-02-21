/*using System;

class DivisionOperations
{
    // Method to perform integer division
    public static int PerformDivision(int dividend, int divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return dividend / divisor;
    }
}

class Program
{
    public static void Main()
    {
        try
        {
            // Taking user input
            Console.Write("Enter first number (dividend): ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number (divisor): ");
            int num2 = int.Parse(Console.ReadLine());

            // Performing division
            int result = DivisionOperations.PerformDivision(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException Caught: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException Caught: Please enter valid integer values.");
        }
        finally
        {
            // Ensuring this block executes in all cases
            Console.WriteLine("Operation completed.");
        }
    }
}
*/
