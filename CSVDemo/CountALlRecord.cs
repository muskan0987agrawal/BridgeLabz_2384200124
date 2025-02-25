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
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
                  
//                };

//                using (var sr = new StreamReader(filePath))
//                {
//                    using (var csv = new CsvReader(sr, config))
//                    {
//                        var records = csv.GetRecords<Employee>().ToList(); // ✅ Convert to List for easy count
//                        Console.WriteLine($"Total Records (excluding header): {records.Count}");
//                        //OR

//                        //var records = csv.GetRecords<Employee>();
//                        //int count = 0;
//                        //foreach (var record in records)
//                        //{
//                        //    count++;

//                        //}
//                       // Console.WriteLine($"Total Records (excluding header): {count}");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine("Error Caught: " + ex.Message);
//            }

//        }
//    }

//    public class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Department { get; set; }

//        public double Salary { get; set; }

//    }
//}
