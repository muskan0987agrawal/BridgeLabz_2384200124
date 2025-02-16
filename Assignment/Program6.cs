//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "file.txt"; 
//        string searchWord = "hello"; 
//        int count = 0;

//        try
//        {
//            using (StreamReader sr = new StreamReader(filePath))
//            {
//                string line;
//                while ((line = sr.ReadLine()) != null)
//                {
//                    // Convert to lowercase for case-insensitive search
//                    string[] words = line.ToLower().Split(new char[] { ' ', '.', ',', '?', '!', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

//                    foreach (string word in words)
//                    {
//                        if (word == searchWord.ToLower()) // Compare with lowercase version
//                        {
//                            count++;
//                        }
//                    }
//                }
//            }

//            Console.WriteLine($"The word '{searchWord}' appears {count} times in the file.");
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
