/* using System;
class Program5{
  void FizzBuzz(){
  
     Console.Write("Enter the number : ");
	int number = int.Parse(Console.ReadLine());
	
	 Console.WriteLine();
	 
	 //check number is positive or not 
	 
	 if(number > 0){
	 int i=0;// declaration and initialize variable
	  while(i<= number){
	    if(i % 3 == 0 && i % 5 == 0){ // executed when variable i is divisible by 3 and 5
		 Console.WriteLine("FizzBuzz");
		 }
	    
		else if(i % 3 == 0){ //executed when variable i is divisible by 3
		 Console.WriteLine("Fizz");
		 }
		
		else if(i % 5==0){ //executed when variable i is divisible by 5
		Console.WriteLine("Buzz");
		 }
		
		else{
		  Console.WriteLine(i);
		  }
		i++;
		}
	}
	else{ // executed when number is negative
	 Console.WriteLine($"{number} is not a positive number");
    }
	
   }
    static void Main()
    {
        Program5 p = new Program5(); // Create an object of the class
        p.FizzBuzz();
    }
}
	*/