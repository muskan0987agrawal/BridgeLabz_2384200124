/*using System;

//create class Area of circle
public class ComputeArea{
	//Define attribute
	private readonly double pi = 3.1417;
	private double radius;
	
	// Constructor to initialize radius
	public ComputeArea(double radius){
		this.radius = radius;
	}
	
	//Method to Calculate Area of Circle
	public double CalculateArea(){
		 return pi *radius *radius;
	}
	
	//Method to Calculate Circumference of Circle
	public double CalculateCircumference(){
	      return  2 * pi *radius;
	}
	
	// Method to display the area and Circumference of  circle
	public  void DisplayArea(){
		Console.WriteLine($"Radius: {radius}");
		Console.WriteLine($"Area of circle is: {CalculateArea()}");
		Console.WriteLine($"Circumference of circle is: {CalculateCircumference()}");
		
	}
}

public class Program2{
	//Create the object of class computeArea
	public static void Main(){
		// User input for radius
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Creating Circle object
        ComputeArea c = new ComputeArea(radius);

        // Displaying results
		c.DisplayArea();
	}
}
		*/