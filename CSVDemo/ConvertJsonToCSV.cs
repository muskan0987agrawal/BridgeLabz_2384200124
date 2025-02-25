//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Xml;
//using CsvHelper;
//using CsvHelper.Configuration;
//using Newtonsoft.Json;
//using Formatting = Newtonsoft.Json.Formatting;

//namespace CSVDemo
//{
//    internal class JsonCsvConverter
//    {
//        static void Main()
//        {
//            string jsonFilePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\students.json";
//            string csvFilePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\students.csv";
//            string outputJsonPath = "C:\\Users\\Himan\\OneDrive\\Desktop\\students_output.json";

//            // Convert JSON to CSV
//            ConvertJsonToCsv(jsonFilePath, csvFilePath);

//            // Convert CSV back to JSON
//            ConvertCsvToJson(csvFilePath, outputJsonPath);
//        }

//        static void ConvertJsonToCsv(string jsonFile, string csvFile)
//        {
//            try
//            {
//                string jsonData = File.ReadAllText(jsonFile);
//                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

//                using (var writer = new StreamWriter(csvFile))
//                using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
//                {
//                    csvWriter.WriteRecords(students);
//                }

//                Console.WriteLine($"✅ JSON converted to CSV successfully: {csvFile}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }

//        static void ConvertCsvToJson(string csvFile, string jsonFile)
//        {
//            try
//            {
//                using (var reader = new StreamReader(csvFile))
//                using (var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
//                {
//                    var students = csvReader.GetRecords<Student>();

//                    string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
//                    File.WriteAllText(jsonFile, jsonData);
//                }

//                Console.WriteLine($"✅ CSV converted back to JSON successfully: {jsonFile}");
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
//    }
//}
