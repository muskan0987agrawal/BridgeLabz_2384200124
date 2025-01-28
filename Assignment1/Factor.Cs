/* using System;
class Factor{
  // Function to find all factors of a number
  static int[] FactorArray(int number){
        int count=0;
        // Count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
		
		// Create an array to store the factors
        int[] factors = new int[count];
        int index = 0;

        // Store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }
	//Function to print the array
	static void PrintArray(int[] arr)
	{
	  Console.WriteLine("Printing the array: ");
	  for(int i=0; i<arr.Length; i++)
	  {
	    Console.Write($"{arr[i]},  ");
	  }
	  Console.WriteLine();
	}
	
	// Calculate the sum of the digits in the array
	static int SumArray(int[] array)
	{
    	int sum = 0;
    	foreach (int digit in array)
    	{
        	sum += digit;
    	}
    	return sum;
	}
	
	// Calculate the Product of the digits in the array
    static int ProductArray(int[] array)
	{
    	int Prod = 1;
    	foreach (int digit in array)
    	{
        	Prod *= digit;
    	}
    	return Prod;
	}
	
	// Function to calculate the sum of squares of the factors
    static int SumOfSquares(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += (int)Math.Pow(factor, 2); // Calculate square using Math.Pow()
        }
        return sum;
    }

	static void Main(){
	
	   Console.Write("Enter a number to find its factors: ");
	   int input = int.Parse(Console.ReadLine());
	   
	  
        // Find factors and print them
        int[] factors = FactorArray(input);
        PrintArray(factors);
		
	
	   // Calculate the sum of the digits
        int sum = SumArray(factors); //call the function to sum the array
	  Console.WriteLine($"Sum of the Factor is: {sum}");
	  
	  int product = ProductArray(factors); //call the function to product the factor
      Console.WriteLine($"Product of Factor is : {product}");	  
	
	  Console.WriteLine($"sum of square of the factor is: {SumOfSquares(factors)}");
	}
}

*/