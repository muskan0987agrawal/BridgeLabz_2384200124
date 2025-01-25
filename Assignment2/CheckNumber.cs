/*using System;
class CheckNumber{
 static void Main(){
   
	  Console.WriteLine("Enter a number(positive, negative, zero): ");
	  int size =5; //size of the array
	  int[] nums = new int[size]; //declare an array
	 
     // Get user input and store in the array
	 for(int i=0;i<size;i++){
		 Console.Write($"Enter number {i + 1}: ");
	    nums[i] = Convert.ToInt32Console.ReadLine());
	  } 
	  
	  // Loop through the array to check for positive, negative, or zero
       Console.WriteLine("\nAnalysis of numbers:");
	   for (int i=0;i <size;i++){
	    if(nums[i] > 0){
		//check number is even or odd
		  if(nums[i]%2==0){
		      Console.WriteLine($"{nums[i]} is Positive and even number");
			 }
		  else{
		      Console.WriteLine($"{nums[i]} is negative and odd number");
			 }
		}
		
		else if(nums[i]<0){
		 Console.WriteLine($"{nums[i]} is negative number");
		 }
		 
		else {
		  Console.WriteLine($"{nums[i]} is Zero number");
	     }
	   }
	   
	   //Compare First and last number of the array
	    Console.WriteLine("\nComparison of the first and last elements:");
	   if(nums[0]== nums[nums.Length-1])  Console.WriteLine($"{nums[0]} is equals");
		   
	   else if(nums[0]<nums[nums.Length-1]) Console.WriteLine($"{nums[0]} is less than the {nums[nums.Length-1]}");
	   else  Console.WriteLine($"{nums[0]} is less than the {nums[nums.Length-1]}");
	   
    }
}
	 
	*/   