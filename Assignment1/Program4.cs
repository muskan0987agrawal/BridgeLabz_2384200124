/* using System;

class Program4{
 void isNaturalNumber(){
    Console.Write("Enter the number: ");
	  double number = double.Parse(Console.ReadLine());
	  
	  //check is number a natural number or not
	  if(number > 0){ // execute only if statement is true
	  double sum = (number * (number + 1) ) /2;
	  Console.WriteLine($"The number {number} is natural number and sum of {number} natural number is {sum}");
	  }
	  
	  //execute when if condition is false
	  else{
	  Console.WriteLine($"The number {number} is not a natural number");
	  }
	}
	static void Main(){
	Program4 p = new Program4(); //create a object of class
     p.isNaturalNumber(); //access the function
}
}
	  */