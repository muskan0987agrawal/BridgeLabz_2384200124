
namespace EmployeeManagmentSystem
{
    // Part-Time Employee (inherits Employee, implements IDepartment)
    internal class PartTimeEmployee: Employee
    {
        private int workingHour;
       public void set(int workingHour) { this.workingHour = workingHour; }
        public int get() { return this.workingHour; }
        public override double CalculateSalary(double fixedSalary)
        {
            return (double)(workingHour * fixedSalary);
        }

       
        // Override DisplayDetails
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($" Total Salary: {CalculateSalary(BaseSalary)}");
        }
    }
}
