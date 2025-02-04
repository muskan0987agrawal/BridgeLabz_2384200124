//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPs1
//{
//    internal class Employee
//    {
//        private static string company_name = "Capgemini";
//        private static int totalEmployees = 0;
//        private string name;
//        private readonly int id;
//        private string description;
//        public Employee(string name, int id, string description) { 
//            this.name = name;
//            this.id = id;
//            this.description = description;
//            totalEmployees++;
//        }

//        public static int DisplayEmployeeDetails()
//        {
//            return totalEmployees;
//        }

//        public  void DisplayTotalEmployee()
//        {
//            if (this is Employee)
//            {
//                Console.WriteLine($"Employee Name: " + name);
//                Console.WriteLine($"Employee id: {id}");
//                Console.WriteLine($"Employeen description: {description}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid Employee Details");
//            }
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            // Creating employee objects
//            Employee emp1 = new Employee("Muskan", 101, "Software Engineer");

//            // Display employee details
//            Employee.DisplayEmployeeDetails();
          
//            // Display total employees
//            emp1.DisplayTotalEmployee();
//        }
//    }
//}
