/* using System;

class Program2
{
  // Function to calculate grade based on marks
  void calculatorGrade(){
  
      // Input marks for Physics, Chemistry, and Maths
        Console.Write("Enter marks for Physics (out of 100): ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry (out of 100): ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths (out of 100): ");
        int maths = int.Parse(Console.ReadLine());

        // Calculate total marks, averagemarks and percentage 
        double totalMarks = physics + chemistry + maths;
		double averagemarks = Convert.ToDouble(totalMarks / 3);
        double percentage = Convert.ToDouble (totalMarks / 300) * 100;
		
		 //PRINTING AVERAGE Marks
		Console.WriteLine($"Average Marks is {averagemarks}");
		
		 // Determine Level and grade
		 string grade;
		 Console.WriteLine(percentage);
		 
		 if(percentage >= 80){
		  grade ="A" ;
		  Console.WriteLine($"grade {grade} and Remarks is Level 4, above agency-normalized standards");
		  }
		  
		 else if(percentage>70 && percentage <=79){
		  grade ="B" ;
		  Console.WriteLine($"grade {grade} and Remarks is Level 3, at agency-normalized standards");
		  }
		  
		 else if(percentage> 60 && percentage <=69){
		  grade ="C" ;
		  Console.WriteLine($"grade {grade} and Remarks is Level 2, below, but approaching agency-normalized standards");
		  }
		  
		 else if(percentage>50 && percentage <=59){
		  grade ="D" ;
		  Console.WriteLine($"grade {grade} and Remarks is Level 1, well below agency-normalized standards");
		  }
		  
		 else if(percentage>40 && percentage <=49){
		  grade ="E" ;
		  Console.WriteLine($"grade {grade} and Remarks is Level 1-, too below agency-normalized standards");
		  }
		  
		 else{
		  grade ="R" ;
		  Console.WriteLine($"grade {grade} and Remarks is Remedial standards");
		  }
		}
	// Main method
    static void Main()
    {
        Program2 p = new Program2(); // Create an object of the class
        p.calculatorGrade();
    }
}
*/
		  