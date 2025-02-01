/*using System;
class ProductInventory{
	//attribute
	string productName;
	float price;
	static int  totalProduct = 0;
	
	//Parametrized Constructor
	public ProductInventory(string productName,float price){
		this.productName = productName;
		this.price = price;
		 totalProduct++; // Increment the total product count whenever a new product is created
	}

	//Instance Method to display the detail
	public void DisplayProductDetails(){
		Console.WriteLine($"Product Name is: {productName}, Price = {price}");
	}
	
	// Class method to display total number of products created
    public static void DisplayTotalProducts()
    {
		
        Console.WriteLine($"Total Products Created: {totalProduct}");
    }
}

class Product{
	static void Main(){
		    
        // Create Product objects
        ProductInventory p1 = new ProductInventory("Laptop", 799.99F);
        ProductInventory p2 = new ProductInventory("Smartphone", 599.9F);
        ProductInventory p3 = new ProductInventory("Tablet", 399.99f);

        // Display product details using instance method
        Console.WriteLine("Product 1 Details:");
        p1.DisplayProductDetails();
        Console.WriteLine();

        Console.WriteLine("Product 2 Details:");
        p2.DisplayProductDetails();
        Console.WriteLine();

        Console.WriteLine("Product 3 Details:");
        p3.DisplayProductDetails();
        Console.WriteLine();

        // Display the total number of products created using class method
        ProductInventory.DisplayTotalProducts();
    }
}
*/