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
            return -1;  // Return -1 if stack is empty

        int value = top.data;
        top = top.next;
        return value;
    }

    public int Peek()
    {
        return (top != null) ? top.data : -1;  // Return -1 if stack is empty
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public void Display()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.Write("Stack (Top to Bottom): ");
        Node temp = top;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }

    public void SortStack()
    {
        if (!IsEmpty())
        {
            int temp = Pop();
            SortStack();
            SortedInsert(temp);
        }
    }

    private void SortedInsert(int value)
    {
        if (IsEmpty() || Peek() <= value)
        {
            Push(value);
            return;
        }

        int temp = Pop();
        SortedInsert(value);
        Push(temp);
    }
}

class DemoStack
{
    public static void Main()
    {
        Stack s = new Stack();
        s.Push(30);
        s.Push(10);
        s.Push(50);
        s.Push(20);
        s.Push(40);

        Console.WriteLine("\nOriginal Stack:");
        s.Display();

        s.SortStack();

        Console.WriteLine("\nSorted Stack:");
        s.Display();
    }
}*/