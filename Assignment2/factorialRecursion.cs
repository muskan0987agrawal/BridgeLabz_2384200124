/*using System;

class FactorialRecursion{
	 static int GetNumber(){
		Console.Write("Enter a number: ");
		return int.Parse(Console.ReadLine());
	 }
	 
	 static int Factorial(int number){
		if(number<0){
			 Console.WriteLine("Invalid Number");
			 return -1;
		}
		 if(number==1 || number==0){
			return 1;
		 }

		return number * Factorial(number-1);
	}
	
	static void DisplayFactorial(int number, int factorial){
		if(factorial!=-1)
			Console.WriteLine($"{factorial} is the factorial of the number {number}");
		else
			Console.WriteLine("Factorial calculation could not be performed.");
	}
	
	static void Main(){
		int input=GetNumber();
		int fact = Factorial(input);
		DisplayFactorial(input, fact);
	}
}
		
	*/