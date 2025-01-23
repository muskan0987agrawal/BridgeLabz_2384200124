/* using System;

class Program3{
 
 void primeNumber(){
 
   // Take input from the userr  that you want to check is a Prime number or not: ");
    Console.Write("Enter the number that u want to check is a prime number or not: ");
	int primeNumber = int.Parse(Console.ReadLine());
	
	int i=2;
	int p=0;
	double number = primeNumber / 2;
	while(number >0){
	   if(primeNumber % i == 0){
	   p++;
	   break;
	  	}
		i++;
	}
	if(p>1){
	 Console.WriteLine($"{primeNumber} number is prime number");
	 }
	 else{
	  Console.WriteLine($"{primeNumber} number is not prime number");
	}
	
	}
	// Main method
    static void Main()
    {
        Program3 p = new Program3(); // Create an object of the class
        p.primeNumber();
    }
}
		*/
