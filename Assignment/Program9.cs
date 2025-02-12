using System;

class Ticket
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public int SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
    }
}

class Node
{
    public Ticket ticket;
    public Node next;

    public Node(Ticket ticket)
    {
        this.ticket = ticket;
        this.next = null;
    }
}

class CircularLinkedList
{
    private Node head;
    private Node tail;
    private int size = 0;

    public void AddTicket(Ticket ticket)
    {
        Node newNode = new Node(ticket);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.next = head;
        }
        else
        {
            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }
        size++;
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null) return;

        Node temp = head;
        Node prev = head;

        if (head.ticket.TicketID == ticketID)
        {
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail.next = head.next;
                head = head.next;
            }
            size--;
            return;
        }

        temp = head.next;
        while (temp != head)
        {
            if (temp.ticket.TicketID == ticketID)
            {
                prev.next = temp.next;
                if (temp == tail)
                    tail = prev;
                size--;
                return;
            }
            prev = temp;
            temp = temp.next;
        }
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked!");
            return;
        }

        Node temp = head;
        while (true)
        {
            Console.WriteLine($"Ticket ID: {temp.ticket.TicketID}, Customer: {temp.ticket.CustomerName}, Movie: {temp.ticket.MovieName}, Seat: {temp.ticket.SeatNumber}, Time: {temp.ticket.BookingTime}");
            temp = temp.next;
            if (temp == head) break;
        }
    }

    public int GetTotalTickets()
    {
        return size;
    }
}

class Program
{
    static void Main()
    {
        CircularLinkedList reservationSystem = new CircularLinkedList();

        while (true)
        {
            Console.WriteLine("\nTicket Reservation System");
            Console.WriteLine("1. Book a Ticket");
            Console.WriteLine("2. Cancel a Ticket");
            Console.WriteLine("3. View All Tickets");
            Console.WriteLine("4. Total Tickets");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movie = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    int seat = int.Parse(Console.ReadLine());
                    reservationSystem.AddTicket(new Ticket(id, name, movie, seat));
                    Console.WriteLine("Ticket booked successfully!");
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to cancel: ");
                    int removeId = int.Parse(Console.ReadLine());
                    reservationSystem.RemoveTicket(removeId);
                    Console.WriteLine("Ticket cancelled successfully!");
                    break;

                case 3:
                    Console.WriteLine("\nAll Booked Tickets:");
                    reservationSystem.DisplayTickets();
                    break;

                case 4:
                    Console.WriteLine("Total Tickets: " + reservationSystem.GetTotalTickets());
                    break;

                case 5:
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}