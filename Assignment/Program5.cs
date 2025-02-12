/*using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
    }

    public void ShowBookDetails()
    {
        Console.WriteLine($"ID: {BookID}, Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {IsAvailable}");
    }
}

class Node
{
    public Book book;
    public Node next;
    public Node prev;

    public Node(Book book)
    {
        this.book = book;
        this.next = null;
        this.prev = null;
    }
}

class Library
{
    private Node head;
    private Node tail;
    public int Count { get; private set; }

    public Library()
    {
        this.head = null;
        this.tail = null;
        this.Count = 0;
    }

    public void AddBookAtBeginning(Book book)
    {
        Node newNode = new Node(book);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        this.Count++;
    }

    public void AddBookAtEnd(Book book)
    {
        Node newNode = new Node(book);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
        }
        this.Count++;
    }

    public void RemoveBookByID(int bookID)
    {
        Node temp = head;
        while (temp != null && temp.book.BookID != bookID)
            temp = temp.next;

        if (temp == null) { Console.WriteLine("Book not found!"); return; }

        if (temp == head) { head = head.next; if (head != null) head.prev = null; }
        else if (temp == tail) { tail = tail.prev; tail.next = null; }
        else { temp.prev.next = temp.next; temp.next.prev = temp.prev; }

        this.Count--;
        Console.WriteLine("Book removed successfully!");
    }

    public void SearchByTitle(string title)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.book.Title == title)
                temp.book.ShowBookDetails();
            temp = temp.next;
        }
    }


    public void SearchByAuthor(string author)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.book.Author == author)
                temp.book.ShowBookDetails();
            temp = temp.next;
        }
    }


    public void UpdateAvailability(int bookID, bool status)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.book.BookID == bookID)
            {
                temp.book.IsAvailable = status;
                Console.WriteLine("Availability status updated successfully!");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found!");
    }

    public void DisplayForward()
    {
        Node temp = head;
        if (temp == null) { Console.WriteLine("No books available."); return; }
        while (temp != null)
        {
            temp.book.ShowBookDetails();
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        Node temp = tail;
        if (temp == null) { Console.WriteLine("No books available."); return; }
        while (temp != null)
        {
            temp.book.ShowBookDetails();
            temp = temp.prev;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book at Beginning");
            Console.WriteLine("2. Add Book at End");
            Console.WriteLine("3. Remove Book by ID");
            Console.WriteLine("4. Search Book by Title");
            Console.WriteLine("5. Search Book by Author");
            Console.WriteLine("6. Update Book Availability");
            Console.WriteLine("7. Display Books Forward");
            Console.WriteLine("8. Display Books Reverse");
            Console.WriteLine("9. Count Total Books");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    int bookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is Available (true/false): ");
                    bool isAvailable = Convert.ToBoolean(Console.ReadLine());
                    Book book = new Book(title, author, genre, bookID, isAvailable);
                    if (choice == 1) library.AddBookAtBeginning(book);
                    else library.AddBookAtEnd(book);
                    break;
                case 3:
                    Console.Write("Enter Book ID to Remove: ");
                    library.RemoveBookByID(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Console.Write("Enter Book Title: ");
                    library.SearchByTitle(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Enter Author Name: ");
                    library.SearchByAuthor(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Enter Book ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Availability Status (true/false): ");
                    bool status = Convert.ToBoolean(Console.ReadLine());
                    library.UpdateAvailability(id, status);
                    break;
                case 7: library.DisplayForward(); break;
                case 8: library.DisplayReverse(); break;
                case 9: Console.WriteLine($"Total Books: {library.Count}"); break;
                case 10: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }
}*/
