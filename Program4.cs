/*using System;

class HotelBooking
{
    // Attributes
    public string GuestName ;
    public string RoomType ;
    public int Nights;

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "John";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking existingBooking)
    {
        GuestName = existingBooking.GuestName;
        RoomType = existingBooking.RoomType;
        Nights = existingBooking.Nights;
    }

    // Display Method
    public void DisplayBooking()
    {
        Console.WriteLine($"Guest Name: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
    }
}

class Program4
{
    static void Main()
    {
        // Using Default Constructor
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Default Booking:");
        booking1.DisplayBooking();

        // Using Parameterized Constructor
        HotelBooking booking2 = new HotelBooking("Jame", "Deluxe", 3);
        Console.WriteLine("\nCustom Booking:");
        booking2.DisplayBooking();

        // Using Copy Constructor
        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("\nCopied Booking:");
        booking3.DisplayBooking();
    }
}
*/