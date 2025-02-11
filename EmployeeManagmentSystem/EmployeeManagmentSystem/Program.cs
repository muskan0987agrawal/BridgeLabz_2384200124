//// See https://aka.ms/new-console-template for more information
//using EmployeeManagmentSystem;

//class Program1
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>();

//        while (true)
//        {
//            Console.WriteLine("\nEmployee Management System:");
//            Console.WriteLine("1. Add Full-Time Employee");
//            Console.WriteLine("2. Add Part-Time Employee");
//            Console.WriteLine("3. Display All Employees");
//            Console.WriteLine("4. Exit");

//            Console.Write("\nEnter your choice: ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    FullTimeEmployee fullTimeEmp = new FullTimeEmployee();
//                    Console.Write("Enter Employee ID: ");
//                    fullTimeEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());

//                    Console.Write("Enter Name: ");
//                    fullTimeEmp.Name = Console.ReadLine();

//                    Console.Write("Enter Base Salary: ");
//                    fullTimeEmp.BaseSalary = Convert.ToDouble(Console.ReadLine());


//                    Console.Write("Enter Working Hours: ");
//                    fullTimeEmp.set(Convert.ToInt32(Console.ReadLine()));

//                    Console.Write("Enter Department: ");
//                    fullTimeEmp.AssignDepartment(Console.ReadLine());

//                    employees.Add(fullTimeEmp);
//                    Console.WriteLine("Full-Time Employee Added Successfully!\n");
//                    break;

//                case 2:
//                    PartTimeEmployee partTimeEmp = new PartTimeEmployee();

//                    Console.Write("Enter Employee ID: ");
//                    partTimeEmp.EmployeeId = Convert.ToInt32(Console.ReadLine());

//                    Console.Write("Enter Name: ");
//                    partTimeEmp.Name = Console.ReadLine();

//                    Console.Write("Enter Base Salary: ");
//                    partTimeEmp.BaseSalary = Convert.ToDouble(Console.ReadLine());


//                    Console.Write("Enter Working Hours: ");
//                    partTimeEmp.set(Convert.ToInt32(Console.ReadLine()));

//                    Console.Write("Enter Department: ");
//                    partTimeEmp.AssignDepartment(Console.ReadLine());

//                    employees.Add(partTimeEmp);
//                    Console.WriteLine("Part-Time Employee Added Successfully!\n");
//                    break;

//                case 3:
//                    if (employees.Count == 0)
//                    {
//                        Console.WriteLine("No Employees to Display!");
//                    }
//                    else
//                    {
//                        foreach (var emp in employees)
//                        {
//                            emp.DisplayDetails();
//                            Console.WriteLine("----------------------");
//                        }
//                    }
//                    break;
//                case 4:
//                    Console.WriteLine("Exiting Program...");
//                    return;

//                default:
//                    Console.WriteLine("Invalid Choice! Try Again.");
//                    break;
//            }




//        }
//    }
//}
