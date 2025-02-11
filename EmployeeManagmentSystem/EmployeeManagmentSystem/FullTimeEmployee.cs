

namespace EmployeeManagmentSystem
{
    internal class FullTimeEmployee : Employee
    {
        private int workingHour;
        private string department;
       
        public string Department { 
            get { return department; }
            set { department = value; } 
        }
        public void set(int workingHour)
        {
            this.workingHour = workingHour;
        }

        public int get() {  return this.workingHour; }

        // Implement CalculateSalary
        public override double CalculateSalary(double fixedSalary)
        {
            return (double)(workingHour * fixedSalary);
        }
       

        // Override DisplayDetails
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($" Working Hour:{workingHour}\n Total Salary: {CalculateSalary(BaseSalary)}");
        }
    }
}
