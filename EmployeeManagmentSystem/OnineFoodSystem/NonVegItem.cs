using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineFoodSystem
{
    internal class NonVegItem: FoodItem, IDiscountable
    {
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) * 1.10; // 10% extra charge
        }

        public void ApplyDiscount()
        {
            Console.WriteLine($"Discount Applied: {ItemName} - 3% off");
            Price -= Price * 0.03;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Items get a 3% discount!";
        }

        public override void GetItemDetails()
        {
            base.GetItemDetails();
            Console.WriteLine($"Discount offer: {GetDiscountDetails()}");
            ApplyDiscount();
            Console.WriteLine($"Total Price is: {CalculateTotalPrice()}\n");

        }
    }
}
