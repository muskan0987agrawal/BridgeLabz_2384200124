/*using System;
class MultiplicativeTable{
   void PrintTable(){ 
     //input a number
     Console.Write("Enter a Number: ");
	 int numVar = int.Parse(Console.ReadLine());
	  
	  //declare a array to store the result 
	  int[] result= new int[10];
	  int fac; 
	  for(int i=1 ;i<=10;i++){
	    fac = i * numVar;
		result[i-1] = fac;
	  }
	  
	  //display the number
	  Console.WriteLine($"Printng the Multiplicative Table of {numVar}");
	  for(int i=1; i<=10;i++){
	   Console.WriteLine($"{numVar} * {i} = {result[i-1]}");
	  }
	}
	
	static void Main(){
	 MultiplicativeTable T = new MultiplicativeTable(); //create an object of class
	 T.PrintTable(); //Call the function
	 }
}
*/