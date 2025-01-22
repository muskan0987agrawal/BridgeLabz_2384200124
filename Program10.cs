using System;

class Program10
{
      void divideNChocolatesM()
    {
        // Get the number of chocolates and the number of children from the user
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calculate the number of chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Display the result
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
        Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program10 P = new Program10(); //creating an object of class
		P.divideNChocolatesM();  // access the function
	}
}
