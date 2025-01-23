/* using System;

class Program6{
 void numberIs(){
    Console.Write("Enter the number: ");
	  double number = double.Parse(Console.ReadLine());
	  
	  //check is number a positive, negative or zero
	  if(number > 0){ // execute only if statement is true

	  Console.WriteLine($"The number {number} is positive number ");
	  }
	  
	  else if(number < 0){ //execute when if condition is false 
	  	  Console.WriteLine($"The number {number} is negative number ");
       }
	  
	  //execute when else if condition is false
	  else{
	  Console.WriteLine($"The number {number} is Zero number");
	  }
	}
	static void Main(){
	Program6 p = new Program6(); //create a object of class
     p.numberIs(); //access the function
}
}
	 */