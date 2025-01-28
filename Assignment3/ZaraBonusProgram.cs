/*using System;

class ZaraBonusProgram
{
    // Method to generate random salary and years of service for employees
    static double[,] GenerateEmployeeData(int size)
    {
        Random random = new Random();
        double[,] employeeData = new double[size, 2]; // Column 1: Salary, Column 2: Years of Service

        for (int i = 0; i < size; i++)
        {
            // Generating a random salary between 10000 and 99999
            employeeData[i, 0] = random.Next(10000, 100000);
            // Generating random years of service between 1 and 15
            employeeData[i, 1] = random.Next(1, 16);
        }

        return employeeData;
    }

    // Method to calculate the new salary and bonus based on years of service
    static double[,] CalculateNewSalaryAndBonus(double[,] employeeData, int size)
    {
        double[,] updatedData = new double[size, 3]; // Column 1: Old Salary, Column 2: Bonus, Column 3: New Salary

        for (int i = 0; i < size; i++)
        {
            double oldSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonus = 0;
            
            // Calculate bonus based on years of service
            if (yearsOfService > 5)
                bonus = oldSalary * 0.05; // 5% bonus for employees with more than 5 years of service
            else
                bonus = oldSalary * 0.02; // 2% bonus for employees with less than or equal to 5 years of service
            
            double newSalary = oldSalary + bonus;

            updatedData[i, 0] = oldSalary; // Old Salary
            updatedData[i, 1] = bonus;    // Bonus
            updatedData[i, 2] = newSalary; // New Salary
        }

        return updatedData;
    }

    // Method to calculate the sum of old salary, new salary, and total bonus
    static void CalculateSums(double[,] updatedData, int size)
    {
        double sumOldSalary = 0;
        double sumNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < size; i++)
        {
            sumOldSalary += updatedData[i, 0];
            sumNewSalary += updatedData[i, 2];
            totalBonus += updatedData[i, 1];
        }

        // Displaying the results in a tabular format
        Console.WriteLine("");
        Console.WriteLine("Employee # | Old Salary | Bonus | New Salary");
        Console.WriteLine("");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{i + 1,10} | {updatedData[i, 0],10:C} | {updatedData[i, 1],6:C} | {updatedData[i, 2],10:C}");
        }

        Console.WriteLine("");
        Console.WriteLine($"Total Old Salary: {sumOldSalary:C}");
        Console.WriteLine($"Total New Salary: {sumNewSalary:C}");
        Console.WriteLine($"Total Bonus Amount: {totalBonus:C}");
        Console.WriteLine("");
    }

    static void Main()
    {
        int numberOfEmployees = 10;
        
        // Generate employee data
        double[,] employeeData = GenerateEmployeeData(numberOfEmployees);
        
        // Calculate new salary and bonus for employees
        double[,] updatedData = CalculateNewSalaryAndBonus(employeeData, numberOfEmployees);
        
        // Calculate and display the sums
        CalculateSums(updatedData, numberOfEmployees);
    }
}
*/

