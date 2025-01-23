/* using System;

class Program14
{
    void factorial()
    {
        Console.Write("Enter the Integer number: ");
        int number = int.Parse(Console.ReadLine()); // Input number from user

        if (number >= 0 ) // Check if the number is positive and an integer
        {
            Console.WriteLine($"The number {number} is a positive number");
			
			int fact=1 ;//declare & initialize the variable to store the value 
			int i=1;
			while(i<=number){ //by using while Loop
			  fact*=i;
			  i++;
			  }
			  Console.WriteLine($"The factorial of {number} is {fact} by While Loop");
		}
		else
        {
            Console.WriteLine($"The number {number} is not a Postive number");
        }
    }

    static void Main()
    {
        Program14 p = new Program14(); // Create an object of the class
        p.factorial(); // Access the method
    }
}
			
*/