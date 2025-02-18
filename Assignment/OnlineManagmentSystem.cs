/* using System;


namespace _18_02_2024
{
    abstract public class Category
    {
        public string Name { set; get; }
        public string Price { set; get; }

        public abstract void ShowDetails();
        
    }

    // Specific Categories
    class BookCategory : Category { 
        public String Author { set; get; }
        public override void ShowDetails()
        {
          
          Console.WriteLine($"Name: {Name},Author: {Author}, Price: ${Price}");
            
        }
    }
    class ClothingCategory : Category {
        public String ClothType { set; get; }
        public override void ShowDetails()
        {

            Console.WriteLine($"Name: {Name},ClothType: {ClothType}, Price: ${Price}");

        }
    }

    // Generic Product Class with Constraint
    class Product<T> where T : Category
    {
        public T CategoryDetails { get; set; }

        // Constructor to initialize product with category details
        public Product(T categoryDetails)
        {
            CategoryDetails = categoryDetails;
        }

        // Method to show product details
        public void ShowProductDetails()
        {
            CategoryDetails.ShowDetails();
        }
    }

    // Generic method to apply discount
    public static class DiscountHelper
    {
        public static void ApplyDiscount<T>(T product, double percentage) where T : Category
        {
            // Apply discount to product's price
            double price = Convert.ToDouble(product.Price);
            price -= price * (percentage / 100);
            product.Price = price.ToString("0.00");

            Console.WriteLine($"Discount applied! New Price: ${product.Price}");
        }
    }
    internal class OnlineManagmentSystem
    {
        public static void Main()
        {
            // Create a BookCategory product
            BookCategory book = new BookCategory
            {
                Name = "C# Programming",
                Price = "45",
                Author = "John Doe"
            };

            // Create a ClothingCategory product
            ClothingCategory clothing = new ClothingCategory
            {
                Name = "T-Shirt",
                Price = "25",
                ClothType = "Cotton"
            };

            // Create generic product instances
            Product<BookCategory> bookProduct = new Product<BookCategory>(book);
            Product<ClothingCategory> clothingProduct = new Product<ClothingCategory>(clothing);

            // Show product details
            bookProduct.ShowProductDetails();
            clothingProduct.ShowProductDetails();

            // Apply Discount using generic method from DiscountHelper class
            Console.WriteLine("\nApplying Discount:");
            DiscountHelper.ApplyDiscount(book, 10);  // 10% Discount on Book
            DiscountHelper.ApplyDiscount(clothing, 15);  // 15% Discount on Clothing

            Console.WriteLine();
            // Show product details after discount
            bookProduct.ShowProductDetails();
            clothingProduct.ShowProductDetails();
        }
        }
    }
*/