/*using System;


class Program6
{
    // Function to check if the given date is within the Spring Season
    static bool CheckSpringSeason(int month, int day)
    {
        // Spring season is from March 20 to June 20
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true;
        }
        else
        {
           return false;
        }
    }


    static void Main(string[] args)
    {
        if(args.Length != 2){ //ensuring only two argument is passed one for month and other for day
            Console.WriteLine("Please provide arguments for day and month ");
              return;
        }
       
        int month = int.Parse(args[0]); // to take month from args array
        int day = int.Parse(args[0]); // to take day from args array


        // Call the function to check if it's Spring Season
         bool c = CheckSpringSeason(month, day);
         if(c) {
			 Console.WriteLine("Spring Season");
			 }
         else {
			 Console.WriteLine("Not");
		 }   
     }
}
*/