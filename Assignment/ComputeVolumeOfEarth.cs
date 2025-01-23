using System;

class ComputeVolumeOfEarth{
 
  static void Main(String[] args){
 
     // Radius of Earth in kilometer
    double radiusInKm = 6378;

    // Calculate the volume of Earth in cubic kilometers
    double volumeInKmCubed = (4 / 3) * Math.PI * Math.Pow(radiusInKm, 3);

    // Convert the volume to cubic miles
    double volumeInMilesCubed = volumeInKmCubed * Math.Pow(0.62, 3);
	
	//Printing..
	Console.WriteLine("The volume of earth in cubic kilometers is "+ volumeInKmCubed +" and cubic miles is " + volumeInMilesCubed);
	
	}
	
}


     