/* using System;

namespace CollectionAssignment
{
    //Custom Exception Class
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message) { }
    }

    internal class InvalidInput
    {
        public static double CalculateInterest(double amount, double rate, int years)
        {
             if (amount < 0)
                throw new InvalidInputException("Amount must be positive.");
            if (rate < 0)
                throw new InvalidInputException("Rate must be positive.");
            if (years < 0)
                throw new InvalidInputException("Years must be positive.");


            return (amount * rate * years) / 100;
        }
    }

    class Program6
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Rate: ");
                int rate = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the year");
                int year = int.Parse(Console.ReadLine());

                double interest = InvalidInput.CalculateInterest(amount, rate, year);
                Console.WriteLine($"Calculated Interest: {interest}");
            }
            catch (InvalidInputException ex)  //Custom exception handled here
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter numeric values.");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
*/