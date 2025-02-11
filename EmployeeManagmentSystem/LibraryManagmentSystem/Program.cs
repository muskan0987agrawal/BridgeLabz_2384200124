// See https://aka.ms/new-console-template for more information
using LibraryManagmentSystem;

class Program
{
    static void Main()
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        // Adding Items
        Book myBook = new Book { ItemId = 101, Title = "Harry Potter", Author = "J.K. Rowling" };
        Magazine myMagazine = new Magazine { ItemId = 202, Title = "Forbes", Author = "Editorial Team" };
        DVD myDVD = new DVD { ItemId = 303, Title = "Inception", Author = "Christopher Nolan" };

        // Adding to List
        libraryItems.Add(myBook);
        libraryItems.Add(myMagazine);
        libraryItems.Add(myDVD);

        // Displaying Details
        Console.WriteLine("\nLibrary Items:");
        foreach (var item in libraryItems)
        {
            item.GetItemDetails();
            Console.WriteLine("----------------------------");
        }

        // Reserving Items
        myBook.ReserveItem("Muskan");
        myDVD.ReserveItem("Ayaan");
       

        Console.WriteLine("\nChecking Availability:");
        Console.WriteLine($"Book Available: {myBook.CheckAvailability()}");
        Console.WriteLine($"DVD Available: {myDVD.CheckAvailability()}");
        Console.WriteLine($"IS MAgazine Available: {myMagazine.CheckAvailability()}");


    }
}