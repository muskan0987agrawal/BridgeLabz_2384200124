//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class ModifyAValue
//    {
//        static void Main()
//        {

//            string inputFile = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\EmployeeData.csv";
//            string outputFile = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\CopyEmployeeData.csv";
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {

//                    HasHeaderRecord = true, 
//                    HeaderValidated = null,
//                };

//                using (var reader = new StreamReader(inputFile))
//                using (var csvReader = new CsvReader(reader, config))
//                using (var writer = new StreamWriter(outputFile))
//                using (var csvWriter = new CsvWriter(writer, config))
//                {
//                    // Read headers and write them to the new file
//                    csvReader.Read();
//                    csvReader.ReadHeader();
//                    csvWriter.WriteHeader<Employee>();
//                    csvWriter.NextRecord();
//                    foreach (var employee in csvReader.GetRecords<Employee>())
//                    {
//                        if (employee.Department.Equals("IT", StringComparison.OrdinalIgnoreCase))
//                        {
//                            employee.Salary *= 1.10; // Increase salary by 10%
//                        }
//                        csvWriter.WriteRecord(employee);
//                        csvWriter.NextRecord();
//                    }
//                    Console.WriteLine("CSV file updated successfully!");
//                }


//                       }
//            catch (Exception ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }
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
