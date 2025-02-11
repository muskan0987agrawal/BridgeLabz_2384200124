using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineFoodSystem
{
    internal abstract class FoodItem
    {
        protected string itemName;
        protected double price;
        protected int quantity;

        // Encapsulation: Properties
        public string ItemName
        {
            get { return itemName; }
            set { itemName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value > 0 ? value : 0; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value > 0 ? value : 1; }
        }

        // Abstract method to calculate total price
        public abstract double CalculateTotalPrice();

        //Concrete method to display item details
        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}, Total: {CalculateTotalPrice()}");
        }
    }



}
