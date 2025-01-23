using System;

class UniversityFeeCalculator{
	static void Main(string[] args){
	
	//create a variable 'originalFee' and assign value "12500"
	double originalFee = 125000;

    // create the variable "offerDiscount" with value 10%
	double offerDiscount= 0.10;

    // Calculate discount amount
    double discountAmount = (originalFee * offerDiscount);

    // Calculate final fee after discount
     double finalFee = originalFee - discountAmount;
	 
	// Printing Final fee
	Console.WriteLine("The discount amount is INR "+offerDiscount +" and final discounted fee is INR "+ finalFee);
	 }
	 }
	 