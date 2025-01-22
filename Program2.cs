using System;
class Program2 {

     //create a function to perform a IntOperation
	 void calculateIntOperation(){
	 
	 Console.Write("Enter the value of a: ");
	 int a = int.Parse(Console.ReadLine()); //Converting a String to an integer
	 
	 Console.Write("Enter the value of b: ");
	 int b = int.Parse(Console.ReadLine()); //Converting a String to an integer
	 
	 Console.Write("Enter the value of c: ");
	 int c = int.Parse(Console.ReadLine()); //Converting a String to an integer
	 
	 //Perform some Operation
	 int operation1 = a + b * c;
	 int operation2 = a * b + c;
	 int operation3 = c + a / b;
	 int operation4 = a % b + c;
	 
	 //Printing all the operations 
     Console.WriteLine($"the results of Int Operations are {operation1}, {operation2}, {operation3}, {operation4}");
     Console.ReadLine();
	 }

      static void Main(string[] args){
        Program2 P = new Program2(); //creating an object of class
		P.calculateIntOperation();  // access the function calculateIntOperation
		}
	}
        	  
	 