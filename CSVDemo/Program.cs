//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//using System;
//using System.IO;
//class ReadCSV
//{
//    static void Main()
//    {
//        string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
//        using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
//        using (StreamWriter writer = new StreamWriter(fs))
//        {
//            writer.WriteLine("John, 35, London"); // New data
//            Console.WriteLine(writer);
//        }
       
//        //File.WriteAllText(filePath, "Hello, this is a text file!");
//        //Console.WriteLine(File.ReadAllText(filePath));
//        try
//        {
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                string line;
               
//                //while ((line = reader.ReadLine()) != null)
//                //{
//                //    string[] columns = line.Split(',');
//                //    Console.WriteLine($" {columns[0]}, {columns[1]},  {columns[2]} ");
//                //}
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
