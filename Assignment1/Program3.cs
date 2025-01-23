/* using System;
class Program3{ 

     //create a function to Check first number is smallest of the three numbers ?
     void checkGreatestNumber(){
   
     //get the input for different number
	  Console.Write("Enter the first number: ");
	  int number1 = int.Parse(Console.ReadLine());
	   
	  Console.Write("Enter the Second number : ");
	  int number2 = int.Parse(Console.ReadLine());
	  
	  Console.Write("Enter the third number : ");
	  int number3 = int.Parse(Console.ReadLine());
	  
     // Check for all the number one by one 
        bool isNumber1 = (number1 > number2) && (number1 > number3);
		bool isNumber2 = (number2 < number1) && (number2 > number3);
		bool isNumber3 = (number2 < number3) && (number1 < number3);
		
		
		

      // Output the result
        Console.WriteLine($"Is the first number {number1} the smallest? {isNumber1}");
		Console.WriteLine($"Is the second number {number2} the smallest? {isNumber2}");
		Console.WriteLine($"Is the third number {number3} the smallest? {isNumber3}");
    }
	
	static void Main(){
	Program3 p = new Program3(); //create a object of class
     p.checkGreatestNumber(); //access the function
}
}	
 */
	