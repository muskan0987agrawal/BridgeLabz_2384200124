/*using System;
class PrintNumber{
  void Number(){
     //create an array to store the value
	 double[] numArr = new double[10];
	  double sum=0.0;
	  int index=0;
	 Console.Write("Enter the number: ");

	 for( index=0; index<numArr.Length ;index++){
	   double input = double.Parse(Console.ReadLine());
	   
	   // Check if the input is 0 or negative
	   if(input == 0 || input < 0 || input== numArr.Length){
           break; //break the loop if the input is 0, negative or we have reached max length
        }
       else{
		  Console.Write("Enter the number until u pressed zero or negative: ");
	     numArr[index] = input;
		 }
	  }
	  
	 
	  Console.WriteLine("Printing the array: ");
	  for(int i=0;i<index ;i++){
	    sum+=numArr[i];
		Console.WriteLine($"Value at index {i+1} is {numArr[i]}");
	}
	 
	 //Printing the sum
	 Console.WriteLine("The Sum of the number is: "+sum);
	}
 static void Main(){
  PrintNumber p =new PrintNumber();
  p.Number();
  }
 }
 */