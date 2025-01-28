/*using System;

class ChocolateDistribution
{
    // Method to calculate chocolates per child and remaining chocolates
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        int[] result = new int[2]; // To store chocolates per child and remaining chocolates

        result[0] = numberOfChocolates / numberOfChildren; // Chocolates per child
        result[1] = numberOfChocolates % numberOfChildren; // Remaining chocolates
        
        return result;
    }

    static void Main()
    {
        // Taking input for number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calling the method to find chocolates per child and remaining chocolates
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Displaying the results
        Console.WriteLine("Each child gets " + result[0] + " chocolates.");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
}
*/