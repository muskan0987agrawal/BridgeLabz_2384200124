/*using System;

class Program11{
  
   //create a function sum of number until user enters 0
    void calculateSum(){
		
		//create a variable sum to calculate the sum of all the number 
		double sum = 0;  // Variable to hold the sum of numbers
		double number; // Variable to hold the user input
		
		while(true){ //execution of loop is stop when condition is false 
		  Console.Write("Enter the number : ");
        number = double.Parse(Console.ReadLine()); // to re enter the number until the user press 0
		  
		 if(number <= 0){ //by using break statement 
		 break; //it terminate the loop when conditionis true
		 }
		 
		   sum += number; //Shorthand method
		 }
		 Console.WriteLine($"The Sum of number is {sum}");
		}
		
		static void Main(){
	Program11 p = new Program11(); //create a object of class
     p.calculateSum(); //access the function
}
}*/