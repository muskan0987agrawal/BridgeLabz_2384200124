/*using System;

class NumberChecker3{
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
	
	static void PrintArr(int [] Arr){
		for(int i=0;i<Arr.Length;i++){
			Console.Write(Arr[i] + " ");
		}
		Console.WriteLine();
	}
	
	static int[] ReversedArr(int [] digitsArr){
		int [] reversedArr = new int[digitsArr.Length];
		int j=0;
		for(int i=digitsArr.Length-1; i>=0;i--){
			reversedArr[j++] = digitsArr[i];
		}
		return reversedArr;
	}
	
	// Method to compare two arrays and check if they are equal
	static bool AreArraysEqual(int[] arr1, int[] arr2){
		if(arr1.Length != arr2.Length) return false;
		for(int i=0; i<arr1.Length;i++){
			if(arr1[i]!=arr2[i]){
				return false;
			}
		}
		return true;
	}
	
	static bool IsPalindrome(int number){
		int num = number;
		int lastdig, sum=0;
		while(number>0){
			lastdig = number %10;
			sum = sum *10+ lastdig;
			number/=10;
		}
		return num==number;
	}
	
	static bool IsDuckNumber(int[] arr){
		for(int i=0; i<arr.Length ;i++){
			if(arr[i]!=0) return true;
		}
		return false;
	}
	
	static void Main(){
		Console.Write("Enter a number: ");
		int number =int.Parse(Console.ReadLine());
		int count = CountDigit(number);
		
		int[] digitsArr= DigitArr(number,count);
		Console.WriteLine("Printing the Array: ");
		PrintArr(digitsArr);
		
		int[] reverseArr = ReversedArr(digitsArr);
		Console.WriteLine("Printing the ReversedArray: ");
		PrintArr(reverseArr);
	    
		Console.WriteLine($"Are array Equal {AreArraysEqual(digitsArr, reverseArr)}");
		
		
		if(IsPalindrome(number)) Console.WriteLine($"{number} is a Palindrome Number");
		else Console.WriteLine($"{number} is not Palindrome Number");
		
		//Console.WriteLine($"Is Duck Number: {IsDuckNumber(digitsArr)}");
		
	}
}
*/
