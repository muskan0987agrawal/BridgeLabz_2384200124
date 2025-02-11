using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OnineFoodSystem
{
    internal class VegItem: FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public void ApplyDiscount()
        {
            Console.WriteLine($"Discount Applied: {ItemName} - 5% off");
            Price -= Price * 0.05;
        }
        public string GetDiscountDetails()
        {
            return "Veg Items get a 5% discount!";
        }

        public override void GetItemDetails()
        {
            base.GetItemDetails();
            Console.WriteLine($"Discount offer: {GetDiscountDetails()}");
            ApplyDiscount();
       Console.WriteLine($"Total Price is: {CalculateTotalPrice()} \n");
       
        }

    }
}
