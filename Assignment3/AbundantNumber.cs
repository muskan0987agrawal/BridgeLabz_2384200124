/* using System;
class AbundantNumber{
 
 static void IsAbundantNumber(){
       
       Console.Write("Enter the number: ");
	   int num = int.Parse(Console.ReadLine());
	   int sum=0, lastdig;
	   
	   for(int i=1; i<num ;i++){
	      if(num % i == 0){ //finds the divisor of number
     		  sum+= i; // sum of the divisor
		    }
		}
        if(sum > num)	Console.WriteLine($"The number {num} is Abundant Number");	
	  
		
		else Console.WriteLine($"The number {num} is not a Abundant Number");
		
	}
	static void Main(String[] args){ //Entry point of Program
	   IsAbundantNumber();
	}
}
	*/	 