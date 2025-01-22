using System;

class Program6{

 //create a function to calculate the total income of the person
     void totalIncome(){
 	    Console.Write("Enter the salary of a person: ");
	    double salary = double.Parse(Console.ReadLine()); //Converting a String to an double
	 
	    Console.Write("Enter the Bonus of a person: ");
	    double bonus= double.Parse(Console.ReadLine()); //Converting a String to an double
	 
	    //calculate totalSalary
		double totalSalary = salary + bonus;
		
		Console.WriteLine($"The Salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalSalary}");
		 Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program6 P = new Program6(); //creating an object of class
		P.totalIncome();  // access the function 
	}
}