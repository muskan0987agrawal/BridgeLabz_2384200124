/*using System;

class Program10{
  
   //create a function sum of number until user enters 0
    void calculateSum(){
	
        Console.Write("Enter the number: ");
       double number = double.Parse(Console.ReadLine());
		
		//create a variable sum to calculate the sum of all the number 
		double sum = 0;
		
		while(number != 0){ //execution of loop is stop when condition is false 
		 sum += number; //Shorthand method
		 
	   Console.Write("Enter the number again: ");
        number = double.Parse(Console.ReadLine()); // to re enter the number until the user press 0
		 
		 }
		 Console.WriteLine($"The Sum of number is {sum}");
		}
		
		static void Main(){
	Program10 p = new Program10(); //create a object of class
     p.calculateSum(); //access the function
}
}*/