using System;

class Program9
{
     void athleteTriangularPark()
    {
        // Get the sides of the triangle as input from the user
        Console.Write("Enter side 1 of the triangle (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        // The total distance the athlete wants to run in meters
		//1km =1000meter
        double totalDistance = 5000;

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds the athlete will run
        double rounds = totalDistance / perimeter;

        // Since the athlete can't run a fraction of a round, round up the result
        int roundsToComplete = (int)Math.Ceiling(rounds);

        // Output the result
        Console.WriteLine($"The total number of rounds the athlete will run is {roundsToComplete} to complete 5 km.");
       Console.ReadLine();
   }
   
   static void Main(string[] args){
        Program9 P = new Program9(); //creating an object of class
		P.athleteTriangularPark();  // access the function

}
}
