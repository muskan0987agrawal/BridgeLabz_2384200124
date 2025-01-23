using System;

class DiscountFeeCalculator{
  static void Main(string[] args){
  
  Console.Write("Enter your University Fee: " );
  
  //ReadLine returns the value in the form of String. so we are converting it in Long Type
  long universityFee = Convert.ToInt64(Console.ReadLine());
  
  Console.Write("Enter the Discount offered from your University: ");
  
  //ReadLine returns the value in the form of String. so here we are converting it Double Type
  double discountOffered = Convert.ToDouble(Console.ReadLine());
  
  double changeInPercentage = discountOffered / 100;
  
  //calculate discount offered
  double calculateDiscount = universityFee * changeInPercentage ;
  
  //calculate final fee
  double finalFee = universityFee - calculateDiscount ;
  
  //Printing..fee
  Console.WriteLine("The discount amount is INR "+ discountOffered + " and final discounted fee is INR "+finalFee);
  Console.ReadLine();
  }
  }
  
  