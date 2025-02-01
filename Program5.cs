/*using System;

//declare a Book Class
class Book{
	//Define attribute
	string title;
	string author;
	float price;
	string status;
	
	//define default Constructor
	public Book(){
		title = "The Thing of Beauty";
		author="Ruskin Bond";
		price = 500.00f;
		status = "Available"; //default status
	}
	
	//define parameterized Constructor
	public Book(string title, string author, float price, string status){
		this.title = title ;
		this.author = author;
		this.price = price;
		this.status = status;
	}
	
	//BorrowBook Method
	publ
	ic void BorrowBook(){
		
		if(status == "Available"){
		   Console.WriteLine($"You have successfully borrowed the book: {title} by {author}");
            status = "Borrowed"; // Update status after borrowing
		}
		 else
        {
            Console.WriteLine($"Sorry, the book '{title}' is currently {status}.");
        }
    }

	
	
	//Display Book Info
	public void DisplayBookInfo(){
	Console.WriteLine($"Title : {title}, Author : {author} Price  : {price}");
	}
	
}

class Program5{
	static void Main() {//Entry point of the Class
		//instance of the class
		
        // Default Constructor
        Book B1 = new Book();
		Console.WriteLine("By Default Constructor");
		B1.DisplayBookInfo();

		Console.WriteLine("");
		 // Using Parameterized Constructor to create a book
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 299.99f, "Available");
        Console.WriteLine("Book Details:");
        book1.DisplayBookInfo();

        // Trying to borrow the book
        Console.WriteLine("\nTrying to Borrow the Book...");
        book1.BorrowBook(); // Borrow the book

        // Checking the book info again after borrowing
        Console.WriteLine("\nUpdated Book Details:");
        book1.DisplayBookInfo();

        // Trying to borrow again (book is now unavailable)
        Console.WriteLine("\nTrying to Borrow Again...");
        book1.BorrowBook();
     }
}
		
	*/