/* using System;
class HarshadNumber{
  static void IsHarshadNumber(){
       
       Console.Write("Enter the number: ");
	   int num = int.Parse(Console.ReadLine());
	   int sum=0, lastdig;
	   int num2 = num;
		while(num>0){
		   lastdig = num/10;
		   sum+=lastdig;
		   num/=10;
		}
		if(num % sum == 0 ) Console.WriteLine($"The number {num2} is Harshad Number");
		
		else Console.WriteLine($"The number {num2} is Harshad Number");
		
	}
	static void Main(String[] args){ //Entry point of Program
	   IsHarshadNumber();
	}
}
		 */