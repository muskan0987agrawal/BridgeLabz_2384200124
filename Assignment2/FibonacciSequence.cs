/*using System;
 class FibonacciSequenceGenerator{
	static void GenerateFibonacci(int number){
		int a=0, b=1, c;
		if(number <0){
			Console.WriteLine("Enter a Positive Number: ");
			return;
		}
		 Console.WriteLine("Fibonacci Sequence Generator");
		 
		 for(int i=0 ; i<number; i++){
			Console.Write(a + " "); // Print current term
			c=a+b;
			a=b;
			b=c;
		}
		Console.ReadLine();
	}
		
	static void Main(){
		 Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int terms = int.Parse(Console.ReadLine());

        // Generating Fibonacci sequence
        GenerateFibonacci(terms);
    }
}
*/