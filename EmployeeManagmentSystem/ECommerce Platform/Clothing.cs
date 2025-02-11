using System;


namespace ECommerce_Platform
{
    public class Clothing: Product, ITaxable
    {
        internal override double CalculateDiscount()
        {
            return Price * 0.05; //5% discount
        }
        public double CalculateTax()
        {
            return Price * 0.08; //tax
        }
        public String GetTaxDetails()
        {
            return "Clothing tax is 8%";
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(GetTaxDetails());
        }

    }
    
}
