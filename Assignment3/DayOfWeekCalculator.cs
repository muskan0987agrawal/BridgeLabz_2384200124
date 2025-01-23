using System;

class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        if (args.Length != 3) // Ensure the program receives exactly three command-line arguments
        {
            Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
            return;
        }

        // Parse the command-line arguments
        int m = int.Parse(args[0]); // for Month
        int d = int.Parse(args[1]); //for  Day
        int y = int.Parse(args[2]); // for Year

        // Apply the formulas
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the result
		Console.WriteLine();// for a new Line
        Console.WriteLine($"The day of the week for {m}/{d}/{y} is: {d0}");
          Console.WriteLine();// for a new Line
   	   Console.WriteLine("Day mapping: 0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday");
    }
}
