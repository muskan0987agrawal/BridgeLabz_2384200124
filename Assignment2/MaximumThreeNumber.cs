/*using System;

class MaximumOfThreeNumber{
		static int GetNumber(string prompt){
			return int.Parse(Console.ReadLine());
		}
		
		static int FindMaxNumber(int num1, int num2, int num3){
			int max = num1;
			if(num2>max){
				max=num2;
			}
			
			if(num3>max){
				max= num3;
			}
			
			return max;
		}
		
		static void Main(){
			 Console.WriteLine("Enter three numbers to find the maximum:");

			// Taking inputs
			int num1 = GetNumber("Enter first number: ");
			int num2 = GetNumber("Enter second number: ");
			int num3 = GetNumber("Enter third number: ");
			
			  // Finding the maximum
			int max = FindMaxNumber(num1, num2, num3);

			// Displaying the result
			Console.WriteLine($"The maximum number is: {max}");
    }
}
*/