/* using System;

namespace Inheritance
{
    // Base class Employee
    internal class Employee
    {
        private string name;
        private int id;
        private double salary;

        // Method to set employee details
        public void SetDetails(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Virtual method to display employee details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {name} \t ID: {id} \t Salary: {salary}");
        }
    }

    // Subclass Manager inheriting from Employee
    internal class Manager : Employee
    {
        private int teamSize;

        // Method to set manager-specific details
        public void SetDetails(string name, int id, double salary, int teamSize)
        {
            base.SetDetails(name, id, salary);
            this.teamSize = teamSize;
        }

        // Overriding DisplayDetails method to include team size
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size: {teamSize}");
        }
    }

    // Subclass Developer inheriting from Employee
    internal class Developer : Employee
    {
        private string programmingLang;

        // Method to set developer-specific details
        public void SetDetails(string name, int id, double salary, string programmingLang)
        {
            base.SetDetails(name, id, salary);
            this.programmingLang = programmingLang;
        }

        // Overriding DisplayDetails method to include programming language
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Programming Language: {programmingLang}");
        }
    }

    // Subclass Intern inheriting from Employee
    internal class Intern : Employee
    {
        private string internshipDuration;

        // Method to set intern-specific details
        public void SetDetails(string name, int id, double salary, string internshipDuration)
        {
            base.SetDetails(name, id, salary);
            this.internshipDuration = internshipDuration;
        }

        // Overriding DisplayDetails method to include internship duration
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {internshipDuration} year(s)");
        }
    }

    // Main Program Class
    internal class Program2
    {
        static void Main()
        {
            // Creating Employee Object
            Employee emp = new Employee();
            emp.SetDetails("Muskan", 101, 50000.00);
            Console.WriteLine("Displaying Employee Details:");
            emp.DisplayDetails();

            Console.WriteLine();

            // Creating Manager Object
            Manager manager = new Manager();
            manager.SetDetails("Qwerty", 102, 60000.00, 5);
            Console.WriteLine("Displaying Manager Details:");
            manager.DisplayDetails();

            Console.WriteLine();

            // Creating Developer Object
            Developer dev = new Developer();
            dev.SetDetails("ZXCV", 103, 60000.00, "C#");
            Console.WriteLine("Displaying Developer Details:");
            dev.DisplayDetails();

            Console.WriteLine();

            // Creating Intern Object using Parent Class Reference
            Employee employee = new Intern();
            ((Intern)employee).SetDetails("Monika", 104, 960000.0, "2");
            Console.WriteLine("Displaying Intern Details using Parent Class Reference:");
            employee.DisplayDetails();
        }
    }
}
*/