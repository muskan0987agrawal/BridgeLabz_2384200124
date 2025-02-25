//using System;
//using System.Text.RegularExpressions;
//using System.Globalization;
//using CsvHelper;
//using CsvHelper.Configuration;


//namespace CSVDemo
//{
//    internal class ValidateCsvData
//    {
//        static void ValidateEmailPhoneNumber()
//        {

//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\EmployeeData.csv";
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
//                    HasHeaderRecord = true, // CSV has a header
//                    MissingFieldFound = null // Ignore missing fields
//                };

//                using (var reader = new StreamReader(filePath))
//                using (var csvReader = new CsvReader(reader, config))
//                {
//                    var records = csvReader.GetRecords<Employee>();
//                    List<Employee> employee = new List<Employee>();

//                    // Regex for validating Email
//                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

//                    // Regex for validating Phone Number (exactly 10 digits)
//                    string phonePattern = @"^\d{10}$";

//                    foreach (var record in records)
//                    {
//                        bool isValid = true;

//                        if (!Regex.IsMatch(record.Email, emailPattern)){
//                            Console.WriteLine("Invalid Email: " + record.Email + " for Employee " + record.Name);
//                            isValid = false;
//                        }

//                        if (!Regex.IsMatch(record.PhoneNo, phonePattern))
//                        {
//                            Console.WriteLine($"Invalid Phone Number: {record.PhoneNo} for Employee {record.Name}");
//                            isValid = false;
//                        }

//                        if (isValid)
//                        {
//                            employee.Add(record);
//                        }
//                    }
//                    Console.WriteLine("\n Valid Employee Records:\n");
//                    foreach (var emp in employee)
//                    {
//                        Console.WriteLine($"Id: {emp.Id},\t Name: {emp.Name}, \tEmail: {emp.Email},\t Phone: {emp.PhoneNo}");
//                    }
//                }
//            }
//            catch (Exception ex) {
//             Console.WriteLine(ex.Message);
//            }
//        }
//        static void Main()
//        {
//            ValidateEmailPhoneNumber();
//        }
//    }

//    public class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Email{ get; set; }
//        public string PhoneNo { get; set; }
//    }

//}
