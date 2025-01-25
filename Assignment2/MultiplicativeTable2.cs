/*using System;
class MultiplicativeTable2{
   void PrintTable(){ 
     //input a number
     Console.Write("Enter a Number from [6-9]: ");
	 int numVar = int.Parse(Console.ReadLine());
	
	// Check if the number is between 6 and 9
        if (numVar < 6 || numVar > 9)
        {
            Console.Error.WriteLine("Invalid Number.");
            Environment.Exit(0);
        } 
       
	  
	  //declare a array to store the result 
	  int[] multiplicativeResult= new int[10];
	  for(int i=1 ;i<=10;i++){
	    multiplicativeResult[i-1] = i * numVar;
		
	  }
	  
	  //display the number
	  Console.WriteLine($"Printng the Multiplicative Table of {numVar}");
	  for(int i=1; i<=10;i++){
	   Console.WriteLine($"{numVar} * {i} = {multiplicativeResult[i-1]}");
	  }
	}
	
	static void Main(){
	 MultiplicativeTable2 T = new MultiplicativeTable2(); //create an object of class
	 T.PrintTable(); //Call the function
	 }
}
*/