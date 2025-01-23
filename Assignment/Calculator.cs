using  System;

class Calculator{
    
	//create a function of add two float number	
    static double addOfTwoNumber(double num1, double num2){
	return (num1 + num2);
	}
	
	//create a function of sub two float number	
    static double subOfTwoNumber(double num1, double num2){
	return (num1 - num2);
	}
	
	//create a function of add two float number	
    static double MulOfTwoNumber(double num1, double num2){
	return (num1 * num2);
	}
		   
	//create a function of add two float number	
	 static double DivOfTwoNumber(double num1, double num2){
	 if(num2 == 0){
	    return 0;
	 }
	return (num1 / num2);
	}
	
     static void Main(String[] args){ //entry point of the program
	 
	 Console.Write("Enter the number 1: ");
	 double num1 = Convert.ToDouble(Console.ReadLine());
	 
	 Console.Write("Enter the number 1: ");
	 double num2 = Convert.ToDouble(Console.ReadLine());
	 
	 double add = addOfTwoNumber(num1, num2);
	 double sub = subOfTwoNumber(num1 ,num2);
	 double mul = MulOfTwoNumber(num1, num2);
	 double div = DivOfTwoNumber(num1 ,num2);
	 Console.WriteLine("The addition, subtraction and division value of two number " + num1 +" and "
+ num2 + " is "+ add +" " +sub+ " "+ mul +" " +div);
}
}	 