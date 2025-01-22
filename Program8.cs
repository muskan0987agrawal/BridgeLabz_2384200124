using System;

class Program8{
	
  void travelComputation(){
  
        Console.Write("Enter the name: ");
        // Create a variable 'name' and take input 
        string name = Console.ReadLine();
	  
        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

       Console.Write("Enter via city: ");
	   string viaCity = Console.ReadLine();

       Console.Write("Enter to city: ");	  
	   string toCity = Console.ReadLine();
	   
	   Console.Write("Enter to distance from to via : ");	
       // Create variables for distances    	   
      double distanceFromToVia = double.Parse(Console.ReadLine());
	  
	   Console.Write("Enter to distance via to final cities : ");	
       // Create variables for distances    	   
      double distanceViaToFinalCity = double.Parse(Console.ReadLine());
	  
	   Console.Write("Enter the time in hour from to via : ");	
       // Create variables for time   	   
      int hour1 = int.Parse(Console.ReadLine());
	  
	  Console.Write("Enter the time in minutes from to via : ");
	   int minutes = int.Parse(Console.ReadLine());
	   
	   //calculate time in minute
      int timeFromToVia = 60 * (hour1) + minutes; 
     
	 Console.Write("Enter the time in hour via to from city : ");	
       // Create variables for time   	   
      int hour2 = int.Parse(Console.ReadLine());
	  
	  Console.Write("Enter the time in minutes from to via : ");
	   int minutes2 = int.Parse(Console.ReadLine());
	   
      int timeViaToFinalCity = (hour2) * 60 + minutes2; // Time in minutes

      // Compute the total distance and total time
      double totalDistance = distanceFromToVia + distanceViaToFinalCity;
      int totalTime = timeFromToVia + timeViaToFinalCity;

      // Print the travel details
      Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} km and the Total Time taken is {totalTime} minutes");
	  Console.ReadLine();
   }
   
   static void Main(string[] args){
        Program8 P = new Program8(); //creating an object of class
		P.travelComputation();  // access the function
	
	}
}
