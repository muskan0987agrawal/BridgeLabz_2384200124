/* using System;

class BMICalculator{
 void CalculateBMI() {
   
   //take input 
   Console.Write("Enter the weight(in kg)");
   
   double weight = Convert.ToDouble(Console.ReadLine());
  
   Console.Write("Enter the height(in cm): ");
   double height = Convert.ToDouble(Console.ReadLine());
    
   //convert height in cm into m;
   double conversionHeight = height / 100;
	
	//calculate BMI by formula
	double findBMI = (weight) / (conversionHeight * conversionHeight);
	
	//use table to determine the weight status of person
	 string status ; //to show the status of the person
	 
	if(findBMI <= 18.4){
	 status = "Underweight";
	 Console.WriteLine($"The Body Mass of the person is {findBMI} and their status is {status}");
	}
	
	else if(findBMI >=18.5 && findBMI <=24.9){
	status ="Normal";
	 Console.WriteLine($"The Body Mass of the person is {findBMI} and their status is {status}");
	}
	 
	else if(findBMI >=25.0 && findBMI <=39.9){
	status ="Overweight";
	 Console.WriteLine($"The Body Mass of the person is {findBMI} and their status is {status}");
	}
	 
   else{
    status ="Obese";
	 Console.WriteLine($"The Body Mass of the person is {findBMI} and their status is {status}");
	}
 }
  static void Main()
    {
        BMICalculator C = new BMICalculator(); // Create an object of the class
        C.CalculateBMI ();
    }
}
*/
	