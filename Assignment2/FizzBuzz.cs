using System;
class FizzBuzz
{
  void PrintFizzBuzz()
  {
    Console.Write("Enter a number: ");
	 string input = Console.ReadLine();
	int num = int.Parse(input);
	
	 
	 string[] arr = new string[num]; //declare an array with size num
	 for(int idx=0;idx<arr.Length;idx++) // Loop through from 0 to num-1
	 { 
       int i =idx+1;// Actual number to evaluate (as array index starts at 0)
	   if(i%3==0 && i%5==0) 
		   arr[idx]="FizzBuzz";using System;

class FizzBuzz
{
    void PrintFizzBuzz()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Validate input is a positive integer
        if (!int.TryParse(input, out int num) || num <= 0)
        {
            Console.Error.WriteLine("Enter a valid positive number.");
            return; // Exit gracefully
        }

        string[] arr = new string[num]; // Declare an array with size `num`

        for (int i = 0; i < arr.Length; i++) // Loop from 0 to num-1
        {
            int value = i + 1; // Actual number for FizzBuzz logic
            if (value % 3 == 0 && value % 5 == 0)
                arr[i] = "FizzBuzz";
            else if (value % 3 == 0)
                arr[i] = "Fizz";
            else if (value % 5 == 0)
                arr[i] = "Buzz";
            else
                arr[i] = value.ToString(); // Store the number as a string
        }

        // Printing the FizzBuzz array
        Console.WriteLine("\nFizzBuzz Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"At index {i}, Position {i + 1} = {arr[i]}");
        }
    }

    static void Main()
    {
        FizzBuzz f = new FizzBuzz();
        f.PrintFizzBuzz();
    }
}

	   
	   else if(i%3==0) 
		   arr[idx]="Fizz";
	   
	   else if(i%5==0) 
		   arr[idx]="Buzz";
	   
	   else 
		   arr[idx] = i.ToString();
	 }
	  
	  //Printing the array...
	  Console.WriteLine("\nFizzBuzz Array:");
	  for(int i=0;i<arr.Length;i++){
	   Console.WriteLine($"At index {i}, Position {i+1} = {arr[i]}");
	  }
  }
 	 static void Main(){
	  FizzBuzz f =new FizzBuzz();
	  f.PrintFizzBuzz();
    }
}	
	  
   