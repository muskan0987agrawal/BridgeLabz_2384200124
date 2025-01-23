/*using System;
class ArmstrongNumber{
   static void IsArmstrongNumber(){ 
          Console.Write("Enter the number that you want to check it is Armstrong or not: ");
		  int num = int.Parse(Console.ReadLine());
		  
		  //create variable 
		  int lastdig = 0, sum=0;
		  int num1 =num ;//stores the value of num in num1
		   
		   while(num>0){
		  
		     //logic
		     lastdig = num % 10; // to get the last digit of the  number
             sum = sum + (lastdig * lastdig *lastdig);
             num = num /10 ; 
			 
			 }
		   //check number is Armstrong or not
		   if(sum == num1)  Console.WriteLine($"{num1} is Armstrong Number");
		   else  Console.WriteLine($"{num1} is  not Armstrong Number");
   }
   static void Main(String[] args){
       IsArmstrongNumber(); //call the function
   }
}
*/