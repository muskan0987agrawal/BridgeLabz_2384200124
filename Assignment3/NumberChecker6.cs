/*using System;

class NumberChecker6
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to find the greatest factor of a number
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (var factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (var factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors
    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
	public static bool IsPerfectNumber(int number, int[] factor){
		int sum = SumOfFactors(factor);
		return sum == number;
	}
	
	 // Method to check if a number is a abundant number
	public static bool IsAbundantNumber(int number, int[] factor){
		int sum = SumOfFactors(factor);
		return sum > number;
	}
	
    // Method to check if a number is a deficient number
	public static bool IsDeficientFctors(int number, int[] factor){
	    int sum = SumOfFactors(factor);
		return sum < number;
	}
	
  // Method to calculate factorial of a number
    public static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }

    // Method to check if a number is a Strong Number
    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            sum += Factorial(digit); // Add the factorial of the digit to the sum
            number /= 10; // Remove the last digit
        }

        return sum == originalNumber; // Check if sum equals the original number
    }
	
	static void Main(){
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);

        Console.WriteLine($"Array Factors of {number}: {string.Join(", ", factors)}");
        Console.WriteLine($"Greatest Factor: {FindGreatestFactor(factors)}");
        Console.WriteLine($"Sum of Factors: {SumOfFactors(factors)}");
        Console.WriteLine($"Product of Factors: {ProductOfFactors(factors)}");
        Console.WriteLine($"Product of Cube of Factors: {ProductOfCubeOfFactors(factors)}");
        Console.WriteLine($"Is Perfect Number: {IsPerfectNumber(number, factors)}");
        Console.WriteLine($"Is Abundant Number: {IsAbundantNumber(number, factors)}");
        Console.WriteLine($"Is Deficient Number: {IsDeficientFctors(number, factors)}");
        Console.WriteLine($"Is Strong Number: {IsStrongNumber(number)}");
    
 }
}
*/