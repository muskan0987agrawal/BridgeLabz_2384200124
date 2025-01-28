/* using System;

class CalendarProgram
{
    // Method to get the name of the month
    static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to check if the year is a leap year
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in the month
    static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return daysInMonth[month - 1];
    }

    // Method to get the first day of the month using the Gregorian Calendar algorithm
    static int GetFirstDayOfMonth(int month, int year)
    {
        if (month < 3)
        {
            month += 12;
            year--;
        }
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }

    // Method to display the calendar
    static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine($"Calendar for {GetMonthName(month)} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDayOfMonth(month, year);
        int totalDays = GetDaysInMonth(month, year);

        // Printing leading spaces for the first day
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); // 4 spaces for alignment
        }

        // Print days of the month
        for (int day = 1; day <= totalDays; day++)
        {
            Console.Write($"{day,3} "); // Right-align the day number with width 3

            // Move to the next line after Saturday (Saturday = day 6)
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}

*/