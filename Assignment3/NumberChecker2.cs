/*using System;

class NumberChecker2{
	static int CountDigit(int num){
		int count=0;
		while(num>0){
			count++;
			num/=10;
		}
		return count;
	}
	
	// Extract digits from the number and store them in an array
	static int[] DigitArr(int number, int count){
		int[] digits = new int[count];
		for(int i=0;i<count;i++){
		  digits[i] = number % 10;
		  number /= 10;
		}
		return digits;
	} 
	
	static int SumArray(int[] arr){
			int sum=0;
			for(int i=0 ;i<arr.Length;i++){
				sum += arr[i];
			}
			return sum;
	}
	
	static double SumOfSquareDigit(int[] digits){
		double sumOfSquares=0;
		foreach(int digit in digits){
			sumOfSquares += Math.Pow(digit, 2);
		}
		return sumOfSquares;
	}
	
	static bool IsHarshadNumber(int number, int[] arr){
		int sumOfDigit = SumArray(arr);
		return number%sumOfDigit==0;
	}
	
	static void FrequencyOfEachDigit(int[] digitsArr){
		int[] freqArray = new int[10];
		for(int i=0;i<digitsArr.Length;i++){
			freqArray[digitsArr[i]]++;
		}
		for(int i=0;i<freqArray.Length;i++){
		if(freqArray[i]>0)	Console.WriteLine($"{i} {freqArray[i]} ");
		}
		Console.WriteLine();
	}
	
	static void Main(){
		Console.Write("Enter a number: ");
		int number =int.Parse(Console.ReadLine());
		int count = CountDigit(number);
		int[] digitsArr= DigitArr(number,count);
		
		int sumOfDigit =SumArray(digitsArr);
		Console.WriteLine($"Sum of the digit is: {sumOfDigit}");
		
		double sumOfSquares = SumOfSquareDigit(digitsArr);
		Console.WriteLine($"Sum of Square Digit is: {sumOfSquares}");
		
		if(IsHarshadNumber(number, digitsArr)) Console.WriteLine($"{number} is Harshad Number");
		else Console.WriteLine($"{number} is not a Harshad Number");
	    
		FrequencyOfEachDigit(digitsArr);
	
	}
}
*/