/*using System;

class NumberChecker{
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
	
	static bool IsDuckNumber(int[] arr){
		for(int i=0; i<arr.Length ;i++){
			if(arr[i]!=0) return true;
		}
		return false;
	}
	
	static bool IsArmstrongNumber(int[] arr, int number){
		 int sum=0;
		 for(int i=0; i< arr.Length;i++){
			sum+= (int)Math.Pow(arr[i], 3);
		}
		return sum == number;
	}
	
	static (int largest, int secondLargest) LargestAndSecondLargest(int [] digits){
		int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;
        foreach (var digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit < secondLargest && digit != largest)
			 {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }
	
	static (int smallest, int secondSmallest) SmallestAndSecondSmallest(int [] digits){
		int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
        foreach (var digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
			 {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
	
	static void Main(){
		Console.Write("Enter a number: ");
		int num = int.Parse(Console.ReadLine());
		int countDigit = CountDigit(num);
		
	    int[] digits = DigitArr(num, countDigit);
		 
		if(IsDuckNumber(digits)) Console.WriteLine($"{num} is a Duck Number");
		else Console.WriteLine($"{num} is not a DuckNumber");
		
		if(IsArmstrongNumber(digits, num)) Console.WriteLine($"{num} is a Armstrong Number");
		else Console.WriteLine($"{num} is a Armstrong Number");
		
		//find Largest and secondLargest
        (int largest, int secondLargest) = LargestAndSecondLargest(digits);
        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");

       // Find Smallest and Second Smallest
        (int smallest, int secondSmallest) = SmallestAndSecondSmallest(digits);
        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {secondSmallest}");
	}
}
*/