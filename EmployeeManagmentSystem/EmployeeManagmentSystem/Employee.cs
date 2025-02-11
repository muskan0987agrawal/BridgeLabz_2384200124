using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    // Interface for Department Management
    internal interface IDepartment
    {
        void AssignDepartment(string departmentName);
       string GetDepartmentDetails();
    }

    // Abstract class Employee
    internal abstract class Employee: IDepartment
    {
        // Encapsulated Fields with Properties
        private int employeeId;
        private string name;
        private double baseSalary;
        private string department;

        //define the properties
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {//Validation 
                if (value > 0) this.employeeId = value;

                else { Console.WriteLine("Id never be negative"); Environment.Exit(0); }
            
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Name cannot be empty or spaces!");
                    Environment.Exit(0);
                }
                else name = value;

            }
        }
        public double BaseSalary
        {
            get { return baseSalary; }
            set {
                if (value <= 0) { Console.WriteLine("Error: Salary must be greater than 0."); Environment.Exit(0); }

                else baseSalary = value;
                }
        }

        // Implement Department Interface
        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }
        public string GetDepartmentDetails()
        {
            return department;
        }

        //define a abstract method which is mandatory to implemented by subclass
        public abstract double CalculateSalary(double baseSalary );

        //concrete Method
       public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"\nEmployee Id: {employeeId} \nEmployee Name: {name} \nDepartment: {department}  \nBase Salary: {baseSalary}");
        }
    }
}
