/* using System;

class Node
{
    public char data;
    public Node next;

    public Node(char data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    public Node head;

    public void InsertEnd(char value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public char FindNthFromEnd(int n)
    {
        Node first = head, second = head;

        // Move first pointer N steps ahead
        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("List is Empty");
                break;
            }
            first = first.next;
        }

        // Move both pointers until first reaches the end
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        return second.data;
    }
}

class Program
{
    public static void Main()
    {
        LinkedList list = new LinkedList();
        list.InsertEnd('A');
        list.InsertEnd('B');
        list.InsertEnd('C');
        list.InsertEnd('D');
        list.InsertEnd('E');

        int N = 5;
        Console.WriteLine($"The {N}th element from the end is: {list.FindNthFromEnd(N)}");
    }
}
*/