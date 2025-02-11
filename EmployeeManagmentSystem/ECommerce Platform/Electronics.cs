using System;


namespace ECommerce_Platform
{
    public class Electronics: Product ,ITaxable
    {
        internal override double CalculateDiscount()
        {
           return Price * 0.10;
        }
         public double CalculateTax()
        {
            return Price * 0.15; // 15% tax
        }
       

        public string GetTaxDetails()
        {
            return "Electronics tax is 15%.";
        }
            

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(GetTaxDetails());
 
            Console.WriteLine($"Final Price is: {CalculateFinalPrice()}");
        }
       
      
    }
}
