//using System;
//using System.Globalization;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class SortCSVREcord
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
//                {
//                    List<Employee> employees = new List<Employee>();
//                    while (csvReader.Read())
//                    {
//                        Employee emp = csvReader.GetRecord<Employee>();
//                        employees.Add(emp);
//                    }

//                    for (int i = 0; i < employees.Count - 1; i++)
//                    {
//                        for (int j = 0; j < employees.Count - i - 1; j++)
//                        {
//                            if (employees[j].Salary < employees[j + 1].Salary)
//                            {
//                                // Swap employees[j] and employees[j + 1]
//                                Employee temp = employees[j];
//                                employees[j] = employees[j + 1];
//                                employees[j + 1] = temp;
//                            }


//                        }

//                    }


//                    // Print top 5 highest-paid employees
//                    Console.WriteLine("Top 5 Highest-Paid Employees:");
//                    int count = 0;
//                    foreach (var emp in employees)
//                    {
//                        if (count < 5)
//                        {
//                            Console.WriteLine($"Id: {emp.Id},\t Name: {emp.Name}, \tDepartment: {emp.Department},  \t Salary: {emp.Salary}");
//                            count++;
//                        }
//                        else
//                        {
//                            break;
//                        }
//                    }
//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            }

//    }

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public double Salary { get; set; }
//}
//}
