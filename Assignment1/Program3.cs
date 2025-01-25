 /* using System;

class Program3{
   static void Main(){
     Console.Write("Enter the number: ");
	 long num = long.Parse(Console.ReadLine()); //take user input 
	
	 int maxSize =10; //size of array
	 int[] digits = new int[maxSize]; //declare an array 
	 int count = 0, lastdig;
	 
	 // Extract digits and store in an array
	 while(num > 0 && count < maxSize){
	    lastdig = (int)(num % 10); //extract the last digit of a number
	   digits[count] = lastdig;
	   num/=10;
	   count++;
	   
	 }
	 
	  // Variables to store the largest and second-largest digits
        int largest = 0;
        int secondLargest = 0;

        // Loop through the array to find largest and second-largest digits
        for (int i = 0; i < count; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second-largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second-largest
            }
        }

        // Display results
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second-largest digit: {secondLargest}");
    }
	
}
*/
