/*using System;
 class EvenOddArrays{
   static void Main(){
     Console.Write("Enter a natural number: ");
	 int number = int.Parse(Console.ReadLine()); //enter a number
        if(number <= 0) // validate user can't enter a negative number
            Console.Error.WriteLine("Enter a non-negative number ");
            Environment.Exit(0);
        }			
	 
	 // Create arrays for odd and even numbers
	 int[] oddArray = new int[number/2 + 1]; // Max possible size for even numbers
	 int[] evenArray = new int[number/2 + 1]; //Max possible size for odd numbers
	 int oddIndex=0, evenIndex=0;  //Index trackers for odd and even arrays
	 
	 //Iterate from 1 to the entered number
	 for(int i=1; i<number;i++)
	 {
	   if(i % 2 == 0) { // Check for even number
		   evenArray[oddIndex++] = i; 
		   
	   }
	   else {
		   oddArray[evenIndex++] = i; 
	  }
	}
	  //Printing the evenArray and oddArray
	  Console.WriteLine("Even Number: ");
	  for(int i=0;i<evenIndex;i++) Console.Write(evenArray[i] + " ");
	  
	  Console.WriteLine(); // New line for better formatting
	   
	  Console.WriteLine("Odd Number: ");
	  for(int i=0;i<oddIndex;i++) Console.Write(oddArray[i] + " ");
	  
    }
}
*/