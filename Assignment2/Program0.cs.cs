/*using System;

class Program0
{
    // Function to check if a year is a leap year
    void LeapYear()
    {
        // Take input from the user
        Console.Write("Enter the year that you want to check is a leap year or not: ");
        int year = int.Parse(Console.ReadLine());
        
        
        // Leap year logic
        if (year >= 1582)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"The given year {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The given year {year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine($"The year {year} is less than 1582 and not considered for leap year calculation.");
        }
    }

    // Main method
    static void Main()
    {
        Program0 p = new Program0(); // Create an object of the class
        p.LeapYear();
    }
}
*/