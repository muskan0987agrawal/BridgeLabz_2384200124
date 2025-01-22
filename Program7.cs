using System;

class Program7{

  //creating a function to swap a two value
  
  void swapTwoNumber(){
  
   Console.Write("enter the first number: ");
   double num1 = double.Parse(Console.ReadLine()); //Converting a String to an double
	
   Console.Write("enter the first number: ");
   double num2 = double.Parse(Console.ReadLine()); //Converting a String to an double
	
    //create a new variable temp and store the value og number 1
	double temp = num1;
    num1 =num2 ; //store the num2 value in num1 variable
    num2 =temp ; //store the temp value  in num2 variable
	
	Console.WriteLine($"The swapped numbers are {num1} and {num2}");
	 Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program7 P = new Program7(); //creating an object of class
		P.swapTwoNumber();  // access the function
		}
	}