/*using System;
 class FriendsComparison{
	 
  //function to calculate height of the friend
  static void Comparison(){

    // Arrays to store ages and heights
    int[] ages = new int[3];
    double[] heights = new double[3];
    string[] names = { "Amar", "Akbar", "Anthony" };

    // Taking input for ages and heights
    Console.WriteLine("Enter the ages and heights of Amar, Akbar, and Anthony:");

    for (int i = 0; i < 3; i++)
    {
      Console.Write($"{names[i]}'s age: ");
      string input = Console.ReadLine(); //input the age 
      if (!int.TryParse(input, out ages[i]) || ages[i] < 0) //execute if user enter invaid input
      {
        Console.WriteLine("Invalid input for age. Please enter a positive integer.");
        i--; // Retry the same friend
      }

      Console.Write($"{names[i]}'s height (in cm): "); //input the height
      if (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] < 0)
      {
        Console.WriteLine("Invalid input for height. Please enter a positive number.");
        i--; // Retry the same friend
      }
    }
    int youngestIndex = 0;
    int tallestIndex = 0;

    for (int i = 1; i < 3; i++)
    {
      if (ages[i] < ages[youngestIndex])
      {
        youngestIndex = i;
      }

      if (heights[i] > heights[tallestIndex])
      {
        tallestIndex = i;
      }
    }

    // Display the results
    Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} with an age of {ages[youngestIndex]} years.");
    Console.WriteLine($"The tallest friend is {names[tallestIndex]} with a height of {heights[tallestIndex]} cm.");
  }
  static void Main(){
    Comparison();
  }
}

*/