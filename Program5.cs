 using System;

class Program5(){
   
   void temperatureConversion(){
     Console.Write("Enter the temperature in fahrenheit: ");
	 double fahrenheit = double.Parse(Console.ReadLine()); //Converting a String to an double
	double celsius = ((fahrenheit - 32) * 5) /9;
	  
	  //Printing the temperature in Celsius by string interpolation
	 Console.WriteLine($"The {fahrenheit} fahrenheit is {celsius} Celsius");
	 Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program5 P = new Program5(); //creating an object of class
		P.temperatureConversion();  // access the function
		}
	}
        	