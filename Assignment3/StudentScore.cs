/*using System;

class StudentScores
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Math
    static double[,] GenerateScores(int numStudents)
    {
        Random random = new Random();
        double[,] scores = new double[numStudents, 3]; // Columns: 0=Physics, 1=Chemistry, 2=Math

        for (int i = 0; i < numStudents; i++)
        {
            // Random score between 40 and 100 for each subject
            scores[i, 0] = random.Next(40, 101); // Physics
            scores[i, 1] = random.Next(40, 101); // Chemistry
            scores[i, 2] = random.Next(40, 101); // Math
        }

        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    static double[,] CalculateScores(double[,] scores, int numStudents)
    {
        double[,] results = new double[numStudents, 4]; // Columns: 0=Total, 1=Average, 2=Percentage

        for (int i = 0; i < numStudents; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            // Rounding to 2 decimal places
            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    // Method to display the scorecard of all students in a tabular format
    static void DisplayScorecard(double[,] scores, double[,] results, int numStudents)
    {
        Console.WriteLine("");
        Console.WriteLine("Student #\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        Console.WriteLine("");

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"{i + 1}\t\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
        }

        Console.WriteLine("");
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores for the students
        double[,] scores = GenerateScores(numStudents);

        // Calculate total, average, and percentage for each student
        double[,] results = CalculateScores(scores, numStudents);

        // Display the scorecard
        DisplayScorecard(scores, results, numStudents);
    }
}

*/