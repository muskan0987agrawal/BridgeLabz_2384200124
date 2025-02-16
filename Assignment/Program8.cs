//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "File.txt"; 

//        try
//        {
//            Console.WriteLine("Enter text to write to the file (press Enter on an empty line to stop):");

//            using (StreamWriter sw = new StreamWriter(filePath))
//            {
//                while (true)
//                {
//                    string input = Console.ReadLine();

//                    if (string.IsNullOrWhiteSpace(input)) 
//                        break;

//                    sw.WriteLine(input); 
//                }
//            }

//            Console.WriteLine($"User input has been written to {filePath}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}
