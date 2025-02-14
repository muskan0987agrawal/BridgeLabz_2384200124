/*using System;

class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

internal class Stack
{
    Node top;
    public Stack()
    {
        this.top = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            return -1;
        }
        int value = top.data;
        top = top.next;
        return value;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

internal class QueueUsingStacks
{
    Stack stack1;
    Stack stack2;

    public QueueUsingStacks()
    {
        stack1 = new Stack();
        stack2 = new Stack();
    }

    public void Enqueue(int data)
    {
        stack1.Push(data);
        Console.WriteLine($"{data} enqueued successfully!");
    }

    public void Dequeue()
    {
        if (stack2.IsEmpty())
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
        }

        int val = stack2.Pop();
        if (val == -1)
            Console.WriteLine("Queue is empty! Nothing to dequeue.");
        else
            Console.WriteLine("Dequeued element is: " + val);
    }

    public void Show()
    {
        Console.WriteLine("\n--- Queue Operations ---");
        while (true)
        {
            Console.WriteLine("\n1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter value to enqueue: ");
                    int data = int.Parse(Console.ReadLine());
                    Enqueue(data);

                    break;
                case "2":
                    Dequeue();
                    break;
                case "3":
                    Console.WriteLine("Exiting program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}

class DemoQueue
{
    public static void Main()
    {
        QueueUsingStacks q = new QueueUsingStacks();
        q.Show();
    }
}*/
