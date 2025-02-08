/*using System;


namespace Inheritance
{
    //  Base class: Book
    internal class Book
    {
        protected string title;
        protected string publicationYear;

        // Method to set book details
        public void SetBookDetails(string title, string publicationYear)
        {
            this.title = title;
            this.publicationYear = publicationYear;
        }

        // Method to display book details
        public void GetBookDetails()
        {
            Console.WriteLine($"Book Details: \nTitle: {title} \tPublication Year: {publicationYear} year.");
        }
    }

    // 📌 Derived class: Author (inherits from Book)
    internal class Author : Book
    {
        private string name;
        private string bio;

        // Method to set author details (including book details)
        public void SetAuthorDetails(string title, string publicationYear, string name, string bio)
        {
            SetBookDetails(title, publicationYear); // Calling base class method
            this.name = name;
            this.bio = bio;
        }

        // Method to display book and author details
        public void DisplayInfo()
        {
            base.GetBookDetails(); // Display book details from the base class
            Console.WriteLine($"Author Name: {name} \tBiography: {bio}");
        }
    }

    // 📌 Main class to execute the program
    internal class Program4
    {
        public static void Main()
        {
            // UPCASTING: Storing an Author object in a Book reference
            Book bookRef = new Author();
            bookRef.SetBookDetails("The Great Gatsby", "1925"); // Only Book class method can be accessed

            //  DOWNCASTING: Converting base class reference back to Author
            Author authorObj = (Author)bookRef; // Explicit casting
            authorObj.SetAuthorDetails("The Great Gatsby", "1925", "F. Scott Fitzgerald", "An American novelist.");

            // Displaying book and author details
            Console.WriteLine("\n Book and Author Details (Using Downcasting):");
            Console.WriteLine();
            authorObj.DisplayInfo(); // Now subclass-specific method can be called
        }
    }
}
*/