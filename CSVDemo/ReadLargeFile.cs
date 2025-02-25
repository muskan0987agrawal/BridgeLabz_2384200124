//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class ReadLargeCSV
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\LargeData.csv";
//            int batchSize = 100; // Process 100 lines at a time
//            int totalRecordsProcessed = 0;

//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
//                    HasHeaderRecord = true // CSV contains headers
//                };

//                using (var reader = new StreamReader(filePath))
//                using (var csvReader = new CsvReader(reader, config))
//                {
//                    while (csvReader.Read()) // Read each line one by one
//                    {
//                        List<Employee> batch = new List<Employee>();

//                        // Read the next 100 records
//                        for (int i = 0; i < batchSize && csvReader.Read(); i++)
//                        {
//                            var record = csvReader.GetRecord<Employee>();
//                            batch.Add(record);
//                        }

//                        // Process the batch (for now, just count records)
//                        totalRecordsProcessed += batch.Count;
//                        Console.WriteLine($"Processed {totalRecordsProcessed} records...");
//                    }
//                }

//                Console.WriteLine($"Finished processing {totalRecordsProcessed} records!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }
//    }

//    public class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//    }
//}
