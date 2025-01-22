using System;

class Program4(){
   
   void temperatureConversion(){
     Console.Write("Enter the temperature in celsius: ");
	 double celsius = double.Parse(Console.ReadLine()); //Converting a String to an double
	 
	 //calculate Temperature in Fahrenheit
	 double fahrenheit = (celsius * 9 / 5)+32;
	  
	  //Printing the temperature in Fahrenheit by string interpolation
	 Console.WriteLine($"The {celsius} Celsius is {fahrenheit} fahrenheit");
	 Console.ReadLine(); // to holds the console screen
	 }

      static void Main(string[] args){
        Program4 P = new Program4(); //creating an object of class
		P.temperatureConversion();  // access the function
		}
	}
        	