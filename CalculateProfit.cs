using System;

class CalculateProfit{
	static void Main(string[] args){
		
		//create a vaiable "costPrice" and assign its value 129
		long costPrice = 129;
		
		//create a vaiable "sellingPrice" and assign its value 191
		long sellingPrice = 191;
		
		//printing CostPrice and sellingPrice
		Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice);
		
		//compute Profit = sellingPrice - costPrice
		double profit = sellingPrice - costPrice;
		
		//compute profitPercetage = (profit / costPrice) *100
		double profitPercentage = (profit / costPrice) *100 ;
		
		//printing Profit percentage
		Console.WriteLine("The Profit is INR " + profit + " and Profit Percentage is INR " + profitPercentage +"%");
		
	}
}
		
		
		