//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class ReadCsvToObjects
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\Student.csv";

//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
//                    HasHeaderRecord = true // Ensures CSV has a header
//                };

//                using (var reader = new StreamReader(filePath))
//                using (var csvReader = new CsvReader(reader, config))
//                {
//                    var students = csvReader.GetRecords<Student>(); // Converting CSV rows to Student objects

//                    Console.WriteLine("Students List:");
//                    foreach (var student in students)
//                    {
//                        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }
//    }

//    public class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public double Marks { get; set; }
//    }

//}