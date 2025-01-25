/*using System;

class PercentageCalculator
{
    //function to calculate Percentage of Marks
    static void PerGrade()
    {
        Console.Write("Enter the number of students:");
        int noOfStudent = int.Parse(Console.ReadLine());
		
        // create array to store marks, percentages
		 double[] totalMarks = new double[noOfStudent]; 
		  double[] percentage = new double[noOfStudent];
          double[] physicsMarks	= new double[noOfStudent];
		   double[] mathsMarks	= new double[noOfStudent];
		    double[] chemistryMarks	= new double[noOfStudent];
			string[] grade =new string[noOfStudent]; //to store the grade
		
        for (int i = 0; i < noOfStudent; i++)
        {    
		    //take input for marks in Physics Marks, Chemistry Marks, Maths Marks
            Console.Write($"Enter a Physics Marks of student {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out physicsMarks[i]) || physicsMarks[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                i--; // Retry for the same employee
            }
			
			Console.Write($"Enter a Mathemtics Marks of student {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out mathsMarks[i]) || mathsMarks[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                i--; // Retry for the same employee
            }
			
			Console.Write($"Enter a chemistry Marks of student {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out chemistryMarks[i]) || chemistryMarks[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                i--; // Retry for the same employee
            }
			
	   }

        // calculate total marks and percentage of each students
		for(int i=0;i<noOfStudent;i++){
		   totalMarks[i]= physicsMarks[i] + chemistryMarks[i] +mathsMarks[i];
		   percentage[i]= (totalMarks[i] /300)*100;
		}
		 // Giving the grade according the student percentage
		for(int i=0;i<noOfStudent;i++){
		 if(percentage[i] >= 80) grade[i] ="A" ;
		    
		 else if(percentage[i]>70 && percentage[i] <=79) grade[i] ="B" ;
		 
		 else if(percentage[i]>60  && percentage[i] <=70) grade[i] ="C" ;
		   
		 else if(percentage[i]>50 && percentage[i] <=60)  grade[i] ="D" ;
		
		 else if(percentage[i]>40 && percentage[i] <=50) grade[i] ="E" ;
		  
		 else  grade[i] ="R" ;
         
		}		 
             
		//Prints the marks, percentage, grade
		 Console.WriteLine($"\nResults:");
        Console.WriteLine( $"student\t\tTotalMarks\t\tPercentage\t\tGrade");
		
		for(int i=0;i<noOfStudent;i++){
		 Console.WriteLine($"{i+1} \t\t {totalMarks[i]}   \t\t  {percentage[i]}%   \t\t  {grade[i]}");
        }
   }

    // Entry point of the program
    static void Main()
    {
        PerGrade(); // Calling the function without creating an object
    }
}

*/
