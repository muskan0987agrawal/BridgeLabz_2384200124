/*using System;

class Program16
{ 
    // function to print even and odd number
    void evenOdd()
    {
        Console.Write("Enter the Integer number: ");
        int number = int.Parse(Console.ReadLine()); // Input number from user

        if (number >= 0 ) // Check if the number is positive and an integer
        {
              for(int i=0 ;i<=number ;i++){
			  if(i % 2 == 0){ // check for even number
			  Console.WriteLine($" {i} is even");
			  }
			  
			  else{ // check for odd number
			  Console.WriteLine($" {i} is odd");
		     } 
		     }
		}
		else
        {
            Console.WriteLine($" Non-Negative number {number} is not a even odd number");
        }
    }

    static void Main()
    {
        Program16 p = new Program16(); // Create an object of the class
        p.evenOdd(); // Access the method
    }
}
			
*/