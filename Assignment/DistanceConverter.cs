using System;

 class DistanceConverter{
 
  public static void Main(string[] args){
   
   //create a variable "distanceInKilometer" and initialize the distance in kilometers
    double distanceInKilometer = 10.8 ;
    
   // convert a Kilometers to miles 
   // 1km = 1.6 miles
   double distanceInMiles = distanceInKilometer * 1.6 ;
   
   //Printing the distance in Kilometers to Miles
   Console.WriteLine("The distance "+ distanceInKilometer +" km in miles is "+distanceInMiles);
}
}   
   