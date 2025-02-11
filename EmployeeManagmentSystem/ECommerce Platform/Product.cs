using System;


namespace ECommerce_Platform
{
  public abstract class Product
    {
        private  int productID;
        private  string productName;
        private double price;

        //define the properties
        public int ProductId
        {
            get { return productID; }
            set
            {//Validation 
                if (value > 0) this.productID= value;

                else { Console.WriteLine("Id never be negative"); Environment.Exit(0); }

            }
        }
        public string Name
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Name cannot be empty or spaces!");
                    Environment.Exit(0);
                }
                else productName = value;

            }
        }
        
        public double Price
        {
            get { return price; }
            set
            {
                //Validation 
                if (value > 0) this.price = value;

                else { Console.WriteLine("price never be negative"); Environment.Exit(0); }
            }
        }
        // Abstract method for discount calculation
        internal abstract double CalculateDiscount();

        public double CalculateFinalPrice()
        {
            double discount = CalculateDiscount();
            double tax = this is ITaxable taxable ? taxable.CalculateTax() : 0;
            return Price + tax - discount;
        }
        // Virtual method to display product details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID:{productID}, Name:{productName}, Price:{price}, Final Price:{CalculateFinalPrice()}");
        }
      
    }
}
