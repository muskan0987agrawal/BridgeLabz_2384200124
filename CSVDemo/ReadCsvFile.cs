//using System;
//using System.Collections.Generic;
//using CsvHelper;
//using System.Globalization;
//using System.Collections.Generic;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class ReadCsvFile
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//            {
//                HasHeaderRecord = false, // Tells CsvHelper that there's no header
//                HeaderValidated = null,  // Disables header validation
//            };

//            using (var sr = new StreamReader(filePath))
//            {
//                using (var csv = new CsvReader(sr, config))
//                {
//                    var records = csv.GetRecords<Student>();
//                    foreach (var record in records)
//                    {
//                        Console.WriteLine($"ID: {record.Id}, Name:{record.Name}, Age:{record.Age}, Marks:{record.Marks}");

//                    }
//                }
//            }

//        }
//    }

//    public class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Age { get; set; }

//        public double Marks { get; set; }

//    }
//}
