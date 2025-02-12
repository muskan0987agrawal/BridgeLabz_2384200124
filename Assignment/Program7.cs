/*using System;
using System.Collections.Generic;

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Friends { get; set; }

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        Friends = new List<int>();
    }
}

class Node
{
    public User user;
    public Node next;

    public Node(User user)
    {
        this.user = user;
        this.next = null;
    }
}

class SocialMedia
{
    private Node head;

    public void AddUser(User user)
    {
        Node newNode = new Node(user);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }

    public void AddFriend(int userID1, int userID2)
    {
        Node user1 = FindUserNode(userID1);
        Node user2 = FindUserNode(userID2);
        if (user1 != null && user2 != null)
        {
            user1.user.Friends.Add(userID2);
            user2.user.Friends.Add(userID1);
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        Node user1 = FindUserNode(userID1);
        Node user2 = FindUserNode(userID2);
        if (user1 != null && user2 != null)
        {
            user1.user.Friends.Remove(userID2);
            user2.user.Friends.Remove(userID1);
        }
    }

    public void DisplayFriends(int userID)
    {
        Node user = FindUserNode(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.user.Name}:");
            foreach (var friendID in user.user.Friends)
            {
                Console.Write(friendID + " ");
            }
            Console.WriteLine();
        }
    }

    public Node FindUserNode(int userID)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.user.UserID == userID)
                return temp;
            temp = temp.next;
        }
        return null;
    }

    public void DisplayUsers()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"User ID: {temp.user.UserID}, Name: {temp.user.Name}, Age: {temp.user.Age}");
            temp = temp.next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        SocialMedia sm = new SocialMedia();
        while (true)
        {
            Console.WriteLine("\nSocial Media Friend Management System");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add Friend");
            Console.WriteLine("3. Remove Friend");
            Console.WriteLine("4. Display Friends");
            Console.WriteLine("5. Display All Users");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter User ID: ");
                    int userID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    sm.AddUser(new User(userID, name, age));
                    break;
                case 2:
                    Console.Write("Enter First User ID: ");
                    int userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second User ID: ");
                    int userID2 = Convert.ToInt32(Console.ReadLine());
                    sm.AddFriend(userID1, userID2);
                    break;
                case 3:
                    Console.Write("Enter First User ID: ");
                    userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second User ID: ");
                    userID2 = Convert.ToInt32(Console.ReadLine());
                    sm.RemoveFriend(userID1, userID2);
                    break;
                case 4:
                    Console.Write("Enter User ID: ");
                    int displayID = Convert.ToInt32(Console.ReadLine());
                    sm.DisplayFriends(displayID);
                    break;
                case 5:
                    sm.DisplayUsers();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
*/