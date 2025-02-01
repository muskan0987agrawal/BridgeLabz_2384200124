using System;

class Employee
{
    public int employeeID;  // Public - Accessible everywhere
    protected string department;  // Protected - Accessible in derived class
    private double salary;  // Private - Only accessible within Employee

    public Employee(int id, string dept, double sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    public void SetSalary(double newSalary) // Public method to modify salary
    {
        salary = newSalary;
    }

    public double GetSalary() // Public method to access salary
    {
        return salary;
    }
}

class Manager : Employee
{
    public Manager(int id, string dept, double sal) : base(id, dept, sal) {}

    public void ShowManagerDetails()
    {
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: ₹{GetSalary()}");
    }
}

class EmployeeRecord
{
    static void Main()
    {
        Manager mgr = new Manager(1001, "IT", 75000);
        mgr.ShowManagerDetails();
    }
}
