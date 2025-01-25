/*using System;
class ReverseDigit{
 static void ReverseArray(){
       // Take input for a number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int number) || number < 0)
        {// validate: user can't enter a long and invalid number
            Console.WriteLine("Invalid Number.");
            return;
        }
		
        // Find the count of digits
        int count = input.Length;
		
		// Extract digits and store in an array
        int[] digits=new int[count];
	      for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }
         
		 // Print the reverse of the digits
        Console.Write("Reverse of the number is: ");
        for(int digit=0 ; digit<count ;digit++)
        {
            Console.Write(digits[digit]);
        }
     }
	 
	static void Main(){ //entry point of the program
	  ReverseArray(); //calling the function without creating the object
	 }
   }
*/