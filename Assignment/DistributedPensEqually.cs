using System;

class DistributedPensEqually{
	static void Main(string[] args){
	
	//create a variable "totalPens" and assign the value "14" to it
	int totalPens = 14 ;
	
	// create a variable "totalStudent" and assign the value "3 "
	int totalStudent = 3;
	
	//Calculate pens each student will get  
	int  pensPerStudent = totalPens / totalStudent ;
	
	//Calculate pens that is not distributed 
    int remainingPen = totalPens % totalStudent ;

	//Printing ....
	Console.WriteLine("The Pen Per Student is "+ pensPerStudent + " and the remaining Pen not distributed is "+ remainingPen);
	
	}
}
	
	
	
	