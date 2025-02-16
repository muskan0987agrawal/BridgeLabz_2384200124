// using System;
//using System.Text;
//using System.Diagnostics;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // Define the file path 
//        string filePath = "file.txt";

//        // Call method to read and display file contents line by line
//        ReadFileLineByLine(filePath);
//    }

//    static void ReadFileLineByLine(string filePath)
//    {
//        try
//        {
//            // Open the file for reading using StreamReader inside a 'using' block
//            // 'using' ensures the StreamReader is disposed properly after use
//            using (StreamReader sr = new StreamReader(filePath))
//            {
//                string line;

//                // Read and print each line until the end of the file is reached
//                while ((line = sr.ReadLine()) != null)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//        }
//        catch (Exception e)
//        {
//            // Handle exceptions such as file not found or access issues
//            Console.WriteLine($"Error reading file: {e.Message}");
//        }
//    }
//}