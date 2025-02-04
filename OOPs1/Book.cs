//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPs1
//{
//    internal class Book
//    {
//        // Static variable shared across all accounts
//        private static string library_name = "DeenDayal Library";
//        //attribute
//        private readonly string ISBN; // readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
//        private string title;
//        private string author;
//        public static void DisplayLibraryName()
//        {
//            Console.WriteLine($"Library Name is: {library_name}");

//        }

//        //Constructor using "this" keyword
//        public Book(string title, string author, string ISBN)
//        {
//            this.ISBN = ISBN;  // Readonly value assigned once
//            this.title = title;
//            this.author = author;

//        }

//        //Display book detail
//        public void DisplayBookDetails()
//        {
//            if (this is Book)
//            {
//                Console.WriteLine("----Book Details-----");
//                Console.WriteLine($"title of the Book: {title}");
//                Console.WriteLine($"Author of the Book: {author}");
//                Console.WriteLine($"ISBN Number of the Book: {ISBN}");
//                Console.WriteLine();
//            }
//            else
//            {
//                Console.WriteLine("Invalid Books Details");
//            }

//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            // Display Library Name (Static Method)
//            Book.DisplayLibraryName();
//            Console.WriteLine();
//            // Creating book objects
//            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
//            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084");

//            // Displaying book details
//            book1.DisplayBookDetails();
//            book2.DisplayBookDetails();

//            // Using `is` operator to check object type
//            if (book1 is Book)
//            {
//                Console.WriteLine("\nbook1 is an instance of Book class.");
//            }
//        }
//    }
//}
