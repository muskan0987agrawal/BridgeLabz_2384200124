/*using System;

class FriendComparison
{
    // Method to take user input for ages and return the ages array
    public static int[] GetAges()
    {
        int[] ages = new int[3];
        string[] friends = { "Amar", "Akbar", "Anthony" };

        // Loop to input age for each friend
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter {friends[i]}'s age: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        return ages;
    }

    // Method to take user input for heights and return the heights array
    public static double[] GetHeights()
    {
        double[] heights = new double[3];
        string[] friends = { "Amar", "Akbar", "Anthony" };

        // Loop to input height for each friend
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter {friends[i]}'s height (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        return heights;
    }

    // Method to find the youngest friend
    public static string FindYoungest(int[] ages)
    {
        int youngestAge = ages[0];
        string youngestFriend = "Amar";

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                if (i == 1) youngestFriend = "Akbar";
                else if (i == 2) youngestFriend = "Anthony";
            }
        }

        return youngestFriend;
    }

    // Method to find the tallest friend
    public static string FindTallest(double[] heights)
    {
        double tallestHeight = heights[0];
        string tallestFriend = "Amar";

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                if (i == 1) tallestFriend = "Akbar";
                else if (i == 2) tallestFriend = "Anthony";
            }
        }

        return tallestFriend;
    }

    // Main method to input data and display results
    static void Main()
    {
        // Get ages and heights by calling the methods
        int[] ages = GetAges();
        double[] heights = GetHeights();

        // Find and display the youngest and tallest friends
        string youngest = FindYoungest(ages);
        string tallest = FindTallest(heights);

        Console.WriteLine($"The youngest friend is: {youngest}");
        Console.WriteLine($"The tallest friend is: {tallest}");
    }
}
*/