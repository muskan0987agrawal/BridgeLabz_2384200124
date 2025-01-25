/*using System;
class EmployeeSalary {

    //function to calculate Employee Bonus by using array
    static void CalBonus(){
		
      int size = 10; // Numberof Employee
	  double[] salary =new double[size]; //declaration of the array
	  Console.WriteLine("Enter the Salary: ");
	  
	  //Take the Salary of the individual Employee 
	   for(int i=0; i<size; i++){
		  Console.Write($"Enter the Salary of Employee{i+1}: ");
	     salary[i] = Convert.ToDouble(Console.ReadLine());
		 }
		 
	  double[] yearService =new double[size]; //declaration of the array
	  Console.WriteLine("Enter the Year Of Service: ");
		  //Take the Year of Service of the individual Employee 
	   for(int i=0; i<size; i++){
		    Console.Write($"Enter the Year of Service of Employee{i+1}: ");
	     yearService[i] = Convert.ToDouble(Console.ReadLine());
		 }
		     
		   // Calculate Bonus and New Salary
        double[] bonus = new double[size];
        double[] newSalary = new double[size];

        for (int i = 0; i < size; i++)
        {
            bonus[i] = yearService[i] > 5 ? 0.05 * salary[i] : 0.02 * salary[i];
            newSalary[i] = salary[i] + bonus[i];
        }
			//Printing the New Salary
			Console.WriteLine("New Salary of the individual Employee is: ");
			   for(int i=0; i<size; i++){
Console.WriteLine($"Employee {i + 1}: Original Salary = {salary[i]}, Bonus = {bonus[i]}, New Salary = {newSalary[i]}");
        }
				
	    }
		
	static void Main(){ //entry point of the program
	  CalBonus(); //calling the function without creating the object
	 }
	}
*/