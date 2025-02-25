//using System;
//using System.Globalization;

//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class SearchByName
//    {
//        static void Main()
//        {
//            string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\EmployeeData.csv";
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {

//                    HasHeaderRecord = true, // Tells CsvHelper that there's no header
//                    HeaderValidated = null,
//                };

//                Console.Write("Enter employee name to search: ");
//                string searchName = Console.ReadLine();

//                using (var reader = new StreamReader(filePath))
//                {
//                    using (var csv = new CsvReader(reader, config))
//                    {
//                        bool found = false;
//                        var records = csv.GetRecords<Employee>();
//                        foreach (var employee in records)
//                        {
//                            if (employee.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
//                            {

//                                Console.WriteLine("Department: " + employee.Department + "\tSalary: " + employee.Salary);
//                                found = true;
//                            }

//                        }
//                        if (!found)
//                        {
//                            Console.WriteLine("Employee Not Found");

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

//    class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Department { get; set; }

//        public string Salary { get; set; }
//    }
//}
