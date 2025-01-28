/*using System;
class NumberChecker5{
	static bool IsPrimeNumber(int number){
		if (number <= 1) return false; // 0 and 1 are not prime numbers
        for(int i=1;i<Math.Sqrt(number);i++){
			if(number % i==0) 
				return true;
		}
		return false;
	}
	
	static bool IsNeonNumber(int number){
		int square = number * number;
		int originalNumber = number;
		int sum=0;
		while(square>0){
			int lastdig = square %10;
		    sum += lastdig; 
			square /= 10;
		}
		return originalNumber==sum;
	}
	
	
	static int SumOfDigit(int number){
		int sum =0;
		while(number>0){
			int lastdig = number %10;
		    sum += lastdig; 
			number /= 10;
		}
		return sum;
	} 
	
	static bool IsSpyNumber(int number){
		int prod =1;
		int sum = 0;
		while(number>0){
			int lastdig = number %10;
			sum += lastdig;
		    prod *= lastdig; 
			number /= 10;
		}
		return sum == prod;
	}
	
	static bool IsAutomorphicNumber(int number){
		int square = number * number;
		while (square > 0){
			 if (square % 10 == number) return true;
			 square /= 10;
			 number /= 10;
		}
		return false;
	}
	
    // Method to check if a number is a buzz number
    static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
	
	static void Main(){
		Console.Write("Enter a number:");
		int num=int.Parse(Console.ReadLine());
		Console.WriteLine($"Is Prime Number: {IsPrimeNumber(num)}");
		Console.WriteLine($"Is Neon Number: {IsNeonNumber(num)}");
		Console.WriteLine($"Is Spy Number: {IsSpyNumber(num)}");
		Console.WriteLine($"Is Automorphic Number: {IsAutomorphicNumber(num)}");
		 Console.WriteLine($"Is Buzz: {IsBuzz(num)}");
	}
}
		*/