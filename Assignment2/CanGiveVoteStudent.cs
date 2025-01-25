/*using System;
class CanGiveVoteStudent
{
    static void Main()
    {
        int noOfStudent = 10;
        //create an array to store the ages of student
        int[] ages = new int[noOfStudent];

        //input the ages of 10 student
        for (int i = 0; i < noOfStudent; i++)
        {
            Console.Write($"Enter the age of student{i + 1}: ");
            string age = Console.ReadLine();
			// Validate and parse the input
            if (!int.TryParse(age,out ages[i]) || ages[i] <= 0){ //convert the age into number and store the value at age[i] 
            Console.WriteLine("Enter the valid age; ");
             i--; // Decrement the counter to retry the current student's input
        }
    }
	
	Console.WriteLine(); //
	// Check voting eligibility for each student
     for(int i=0;i<noOfStudent;i++){
    if(ages[i] >=18){
         Console.WriteLine($"Student{i+1} with the age {ages[i]} can give vote ");
        }

        else
       {
          Console.WriteLine($"Student{i + 1} with the age {ages[i]} can not give vote ");
        }
	 }
   }
}
*/