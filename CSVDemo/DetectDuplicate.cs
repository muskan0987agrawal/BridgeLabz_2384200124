//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class DetectDuplicateCSV
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\EmployeeData.csv";

//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
//                    HasHeaderRecord = true // CSV contains headers
//                };

//                using (var reader = new StreamReader(filePath))
//                using (var csvReader = new CsvReader(reader, config))
//                {
//                    var records = csvReader.GetRecords<Employee>();

//                    HashSet<int> seenIds = new HashSet<int>(); // Store unique IDs
//                    List<Employee> duplicates = new List<Employee>(); // Store duplicate records

//                    foreach (var record in records)
//                    {
//                        if (!seenIds.Add(record.Id))
//                        {
//                            // If Add() returns false, ID is duplicate
//                            duplicates.Add(record);
//                        }
//                    }

//                    // Print duplicate records
//                    if (duplicates.Count > 0)
//                    {
//                        Console.WriteLine("\nDuplicate Records Found:");
//                        foreach (var emp in duplicates)
//                        {
//                            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Email: {emp.Email}, Phone: {emp.PhoneNo}");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("No duplicate records found.");
//                    }
//                }
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
//        public string PhoneNo { get; set; }
//    }
//}
