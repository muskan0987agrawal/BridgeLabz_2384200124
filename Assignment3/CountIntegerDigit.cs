/* using System;
class CountIntegerDigit{
  static void CountDigit(){
  
       Console.Write("Enter the number: ");
	   int num = int.Parse(Console.ReadLine());
	   int count =0;//to count the digit
	   int lastdig;
		while(num>=0){
		   lastdig = num/10;
		   count++;
		   num/=10;
		}
		Console.WriteLine($"The number of digits in an integer is: {count}");
	}
	static void Main(String[] args){
	   CountDigit();
	}
}
*/
		 