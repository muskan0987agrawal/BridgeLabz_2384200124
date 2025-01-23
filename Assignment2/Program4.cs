/* using System;
class Program4{
  void FizzBuzz(){
     Console.Write("Enter the number : ");
	int number = int.Parse(Console.ReadLine());
	 Console.WriteLine();
	 if(number > 0){
	  for(int i=0; i<=number;i++){
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
		}
	}
	else{ // executed when number is negative
	 Console.WriteLine($"{number} is not a positive number");
    }
   }
    static void Main()
    {
        Program4 p = new Program4(); // Create an object of the class
        p.FizzBuzz();
    }
}
	*/