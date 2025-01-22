using System;

class Program11
{
     void computeSimpleInterest()
    {
        // Input: Principal, Rate, and Time
        Console.Write("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time period (in years): ");
        double time = double.Parse(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}.");
     Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program11 P = new Program11(); //creating an object of class
		P.computeSimpleInterest();  // access the function
}
}