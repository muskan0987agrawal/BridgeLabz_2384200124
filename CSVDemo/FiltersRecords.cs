//using System;
//using System.Collections.Generic;
//using System.Globalization;

//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class FiltersRecords
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {

//                    HasHeaderRecord = false, // Tells CsvHelper that there's no header
//                    HeaderValidated = null, 
//                };

//                using (var reader = new StreamReader(filePath))
//                {
//                    using (var csv = new CsvReader(reader, config))
//                    {
//                        var records = csv.GetRecords<Student>();

//                        foreach (var record in records)
//                        {
//                            if (record.Marks > 85)
//                            {
//                                Console.WriteLine($"Id: {record.Id} \tName: {record.Name} \tMarks: {record.Marks}");

//                            }

//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }
//    }

//    public class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public double Marks { get; set; }

//    }
//}
