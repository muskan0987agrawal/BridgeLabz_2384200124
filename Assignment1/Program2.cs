/* using System;
class Program2{ 

     //create a function to Check first number is smallest of the three numbers ?
     void isFirstNumberSmallest(){
   
     //get the input for different number
	  Console.Write("Enter the first number: ");
	  int number1 = int.Parse(Console.ReadLine());
	   
	  Console.Write("Enter the Second number : ");
	  int number2 = int.Parse(Console.ReadLine());
	  
	  Console.Write("Enter the third number : ");
	  int number3 = int.Parse(Console.ReadLine());
	  
     // Check if the number1 is smallest or  not 
        bool isNumber1 = (number1 < number2) && (number1 < number3);

      // Output the result
        Console.WriteLine($"Is the first number {number1} the smallest? {isNumber1}");
    }
	
	static void Main(){
	Program2 p = new Program2(); //create a object of class
     p.isFirstNumberSmallest(); //access the function
}
}	
 */
	