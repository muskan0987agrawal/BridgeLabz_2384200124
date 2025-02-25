//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class WriteAFile
//    {
//        static void Main()
//        {
//            string path = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//                {
//                   // HasHeaderRecord = true, // Tells CsvHelper that there's no header
//                   // HeaderValidated = null,  // Disables header validation
//                };

//                using (StreamWriter writer = new StreamWriter(path))
//                {
//                    using (var csv = new CsvWriter(writer, config))
//                    {
                    
//                        var records = new List<Employee>
//                    {

//                        new Employee { Id = 101, Name = "Muskan", Department = "IT", Salary = 60000 },
//                        new Employee { Id = 102, Name = "ALice", Department = "Finance", Salary = 5000 },
//                        new Employee { Id = 103, Name = "Sweta", Department = "IT", Salary = 60000 },
//                        new Employee { Id = 104, Name = "John", Department = "Sales", Salary = 50000 },
//                        new Employee { Id = 105, Name = "XYZ", Department = " ", Salary = 40000 }

//                     };
                       
//                        csv.WriteRecords(records);
                        
//                    }
//                    Console.WriteLine("CSV file written successfully using CSV HElper" );
//                }
//            }
//            catch (Exception)
//            {

//                Console.WriteLine("Error Caught: File not found");
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
