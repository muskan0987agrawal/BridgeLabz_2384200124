//using System.Text;
//using System.Text;

//class Program3
//{
//    static void Main()
//    {
//        // Define an array of strings to be concatenated
//        string[] strings = { "Hello", " ", "World", "!", " Welcome", " to", " C#" };

//        // Call the method to concatenate all strings in the array
//        string result = ConcatenateStrings(strings);

//        // Display the concatenated result
//        Console.WriteLine($"Concatenated string: {result}");
//    }

//    static string ConcatenateStrings(string[] strings)
//    {
//        // StringBuilder is used for efficient string concatenation
//        StringBuilder sb = new StringBuilder();

//        // Iterate through each string in the array and append it to StringBuilder
//        foreach (string str in strings)
//        {
//            sb.Append(str);
//        }

//        // Convert StringBuilder to a regular string and return the result
//        return sb.ToString();
//    }
//}