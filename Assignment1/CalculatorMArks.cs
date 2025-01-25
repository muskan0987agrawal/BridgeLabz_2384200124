/*using System;

class PercentageCalculator2
{
    // Function to calculate percentage and grade
    static void PerGrade()
    {
        Console.Write("Enter the number of students:");
        int noOfStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks for Physics, Chemistry, and Maths
        double[,] marks = new double[noOfStudents, 3]; // Rows = students, Columns = subjects
        double[] totalMarks = new double[noOfStudents];
        double[] percentages = new double[noOfStudents];
        string[] grades = new string[noOfStudents];

        // Take input for marks in Physics, Chemistry, and Maths for each student
        for (int i = 0; i < noOfStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}:");

            // Input for Physics Marks
            Console.Write("Physics: ");
            while (!double.TryParse(Console.ReadLine(), out marks[i, 0]) || marks[i, 0] < 0 || marks[i, 0] > 100) //validate the marks 
            {
                Console.WriteLine("Invalid input. Please enter a positive number (0-100) for Physics marks.");
            }

            // Input for Chemistry Marks
            Console.Write("Chemistry: ");
            while (!double.TryParse(Console.ReadLine(), out marks[i, 1]) || marks[i, 1] < 0 || marks[i, 1] > 100)
            {
                Console.WriteLine("Invalid input. Please enter a positive number (0-100) for Chemistry marks.");
            }

            // Input for Maths Marks
            Console.Write("Maths: ");
            while (!double.TryParse(Console.ReadLine(), out marks[i, 2]) || marks[i, 2] < 0 || marks[i, 2] > 100)
            {
                Console.WriteLine("Invalid input. Please enter a positive number (0-100) for Maths marks.");
            }
        }

        // Calculate total marks, percentage, and grade for each student
        for (int i = 0; i < noOfStudents; i++)
        {
            totalMarks[i] = marks[i, 0] + marks[i, 1] + marks[i, 2]; // Sum of marks in all subjects
            percentages[i] = (totalMarks[i] / 300) * 100; // Total out of 300

            // Assign grades based on percentage
            if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B";
            else if (percentages[i] >= 60)
                grades[i] = "C";
            else if (percentages[i] >= 50)
                grades[i] = "D";
            else if (percentages[i] >= 40)
                grades[i] = "E";
            else
                grades[i] = "R"; // Failed
        }

        // Output: Display marks, total, percentage, and grade for each student
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tPercentage\tGrade");

        for (int i = 0; i < noOfStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]:0.00}\t{marks[i, 1]:0.00}\t\t{marks[i, 2]:0.00}\t{totalMarks[i]:0.00}\t{percentages[i]:0.00}%\t{grades[i]}");
        }
    }

    // Entry point of the program
    static void Main()
    {
        PerGrade(); // Calling the function without creating an object
    }
}
*/