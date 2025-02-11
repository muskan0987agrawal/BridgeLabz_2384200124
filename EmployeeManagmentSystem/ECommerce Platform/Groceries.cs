using System;

namespace ECommerce_Platform
{
    public class Groceries: Product, ITaxable
    {
        internal override double CalculateDiscount()
        {
            return Price * 0.02; //2% discount
        }
        
        public double CalculateTax()
        {
            return Price * 0.05; //5% tax
        }
        public string GetTaxDetails()
        {
            return "Clothing tax is 5%";
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("GetTaxDetails");
        }

    }
}
