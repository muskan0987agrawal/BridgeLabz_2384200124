/*using System;

class Book
{
    public string ISBN;        // Public - Accessible everywhere
    protected string title;    // Protected - Accessible in derived class
    private string author;     // Private - Only accessible within Book class

    // Constructor
    public Book(string isbn, string bookTitle, string bookAuthor)
    {
        ISBN = isbn;
        title = bookTitle;
        author = bookAuthor;
    }

    // Public method to set author
    public void SetAuthor(string authorName)
    {
        author = authorName;
    }

    // Public method to get author
    public string GetAuthor()
    {
        return author;
    }

    // Display method
    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
    }
}

// Subclass to demonstrate access modifiers
class EBook : Book
{
    public string fileFormat;

    // Constructor for EBook (calls base class constructor)
    public EBook(string isbn, string bookTitle, string bookAuthor, string format)
        : base(isbn, bookTitle, bookAuthor)
    {
        fileFormat = format;
    }

    // Method to display eBook details
    public void DisplayEBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");   //  Accessible (public)
        Console.WriteLine($"Title: {title}"); //  Accessible (protected)
        Console.WriteLine($"Author: {GetAuthor()}"); //  Accessing via method (since author is private)
        Console.WriteLine($"File Format: {fileFormat}\n");
    }
}

class BookLibrarySystem
{
    static void Main()
    {
        // Creating a Book object
        Book book1 = new Book("978-3-16-148410-0", "The Alchemist", "Paulo Coelho");
        Console.WriteLine("📖 Book Details:");
        book1.DisplayBookDetails();

        // Creating an EBook object
        EBook ebook1 = new EBook("978-0-06-231500-7", "Digital Fortress", "Dan Brown", "PDF");
        Console.WriteLine("\n📱 E-Book Details:");
        ebook1.DisplayEBookDetails();
    }
}
*/