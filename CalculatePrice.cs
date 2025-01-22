using System;
class CalculatePrice {
	
    void totalPrice(){
    Console.Write("Enter the Unit Price: ");
   double unitPrice = Convert.ToDouble(Console.ReadLine());
   
   Console.Write("Enter the quantity: ");
   double quantity = Convert.ToDouble(Console.ReadLine());
    //Calculate Price
 double calPrice = unitPrice * quantity;
 Console.WriteLine("The total purchase price is INR "+calPrice +" if the quantity "+ quantity+ "and unit price is INR "+ quantity);

 }
 
static void Main(string[] args){
  CalculatePrice P =new CalculatePrice();
  P.totalPrice();
}
}