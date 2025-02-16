//using System;
//using System.IO;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "File.txt"; // Change this to your file path

//        try
//        {
//            // Open the binary file as a FileStream
//            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            {
//                // StreamReader automatically converts byte stream to character stream
//                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
//                {
//                    string content = sr.ReadToEnd(); // Read entire file as a character stream
//                    Console.WriteLine("File Content:");
//                    Console.WriteLine(content);
//                }
//            }
//        }
//        catch (FileNotFoundException)
//        {
//            Console.WriteLine("Error: File not found.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}
