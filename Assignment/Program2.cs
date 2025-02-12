/*using System;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public string ReleaseYear { get; set; }
    public double Rating { get; set; }

    public Movie(string title, string director, string releaseYear, double rating)
    {
        Title = title;
        Director = director;
        ReleaseYear = releaseYear;
        Rating = rating;
    }
    public void ShowMovieDetails()
    {
        Console.WriteLine($"Title: {Title}, Director: {Director}, Year: {ReleaseYear}, Rating: {Rating}");
    }
}

class Node
{
    public Movie movie;
    public Node next;
    public Node prev;

    public Node(Movie movie)
    {
        this.movie = movie;
        this.next = null;
        this.prev = null;
    }
}

class LinkedList
{
    private Node head;
    private Node tail;
    public int Size { get; private set; }

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Size = 0;
    }

    public void AddBeginning(Movie movie)
    {
        Node newNode = new Node(movie);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        this.Size++;
    }

    public void AddEnd(Movie movie)
    {
        Node newNode = new Node(movie);
        if (head == null) head = tail = newNode;
        else
        {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
        }
        this.Size++;
    }

    public void AddPosition(int pos, Movie movie)
    {
        if (pos <= 1) { AddBeginning(movie); return; }
        if (pos > Size) { AddEnd(movie); return; }

        Node newNode = new Node(movie);
        Node temp = head;
        for (int i = 1; i < pos - 1; i++) temp = temp.next;

        newNode.next = temp.next;
        newNode.prev = temp;
        temp.next.prev = newNode;
        temp.next = newNode;

        this.Size++;
    }

    public void DeleteByTitle(string title)
    {
        Node temp = head;
        while (temp != null && temp.movie.Title != title)
            temp = temp.next;

        if (temp == null) { Console.WriteLine("Movie not found!"); return; }

        if (temp == head) { head = head.next; if (head != null) head.prev = null; }
        else if (temp == tail) { tail = tail.prev; tail.next = null; }
        else { temp.prev.next = temp.next; temp.next.prev = temp.prev; }

        this.Size--;
        Console.WriteLine("Movie deleted successfully!");
    }

    public void SearchByDirector(string director)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.movie.Director == director)
                temp.movie.ShowMovieDetails();
            temp = temp.next;
        }
    }

    public void SearchByRating(double rating)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.movie.Rating == rating)
                temp.movie.ShowMovieDetails();
            temp = temp.next;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.movie.Title == title)
            {
                temp.movie.Rating = newRating;
                Console.WriteLine("Rating updated successfully!");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Movie not found!");
    }

    public void DisplayForward()
    {
        Node temp = head;
        if (temp == null) { Console.WriteLine("No movies available."); return; }
        while (temp != null)
        {
            temp.movie.ShowMovieDetails();
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        Node temp = tail;
        if (temp == null) { Console.WriteLine("No movies available."); return; }
        while (temp != null)
        {
            temp.movie.ShowMovieDetails();
            temp = temp.prev;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        while (true)
        {
            Console.WriteLine("\nMovie Management System");
            Console.WriteLine("1. Add Movie at Beginning");
            Console.WriteLine("2. Add Movie at End");
            Console.WriteLine("3. Add Movie at Specific Position");
            Console.WriteLine("4. Delete Movie");
            Console.WriteLine("5. Search Movie by Director");
            Console.WriteLine("6. Search Movie by Rating");
            Console.WriteLine("7. Update Movie Rating");
            Console.WriteLine("8. Display Movies Forward");
            Console.WriteLine("9. Display Movies Reverse");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Year: ");
                    string year = Console.ReadLine();
                    Console.Write("Enter Rating: ");
                    double rating = Convert.ToDouble(Console.ReadLine());
                    Movie movie = new Movie(title, director, year, rating);
                    if (choice == 1) list.AddBeginning(movie);
                    else if (choice == 2) list.AddEnd(movie);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        list.AddPosition(pos, movie);
                    }
                    break;
                case 4:
                    Console.Write("Enter Movie Title to Delete: "); list.DeleteByTitle(Console.ReadLine()); break;
                case 5:
                    Console.Write("Enter Director Name: "); list.SearchByDirector(Console.ReadLine()); break;
                case 6:
                    Console.Write("Enter Rating: "); list.SearchByRating(Convert.ToDouble(Console.ReadLine())); break;
                case 7:
                    Console.Write("Enter Movie Title: "); string movieTitle = Console.ReadLine();
                    Console.Write("Enter New Rating: "); double newRating = Convert.ToDouble(Console.ReadLine());
                    list.UpdateRating(movieTitle, newRating); break;
                case 8: list.DisplayForward(); break;
                case 9: list.DisplayReverse(); break;
                case 10: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }
}*/
