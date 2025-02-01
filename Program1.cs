/*using System;

//declare a Book Class
class Book{
	//Define attribute
	string title;
	string author;
	float price;
	
	//define default Constructor
	public Book(){
		title = "The Thing of Beauty";
		author="Ruskin Bond";
		price = 500.00f;
	}
	
	//define parameterized Constructor
	public Book(string title, string author, float price){
		this.title = title ;
		this.author = author;
		this.price = price;
	}
	
	//Display 
	public void Display(){
	Console.WriteLine($"Title of the Book: {title} \nAuthor of the Book : {author} \nPrice of the Book : {price}");
	}
	
}

class Program1{
	static void Main() {//Entry point of the Class
		//instance of the class
		
        // Default Constructor
        Book B1 = new Book();
		Console.WriteLine("By Default Constructor");
		B1.Display();

		Console.WriteLine("");
		Book B2 = new Book("Flamingo", "John James", 332.20f);
			
        // Parametrized Constructor
   
		Console.WriteLine("By Parametrized  Constructor");
		B2.Display();
     }
}
		
		*/