/*using System.Text;

class Program2
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Remove duplicate characters from the string
        string result = RemoveDuplicates(input);

        // Display the result after removing duplicates
        Console.WriteLine($"String after removing duplicates: {result}");
    }

    static string RemoveDuplicates(string str)
    {
        // StringBuilder to store the result without duplicates
        StringBuilder sb = new StringBuilder();

        // Iterate through each character in the input string
        for (int i = 0; i < str.Length; i++)
        {
            bool found = false;

            // Check if the character already exists in StringBuilder
            for (int j = 0; j < sb.Length; j++)
            {
                if (sb[j] == str[i])
                {
                    found = true; // Mark as duplicate
                    break; // Exit inner loop
                }
            }

            // If character is not a duplicate, append it to StringBuilder
            if (!found)
            {
                sb.Append(str[i]);
            }
        }

        // Convert StringBuilder to string and return the result
        return sb.ToString();
    }
}
*/