/*using System;

class Node
{
    public string TextState { get; set; }
    public Node Next { get; set; }
    public Node Prev { get; set; }

    public Node(string text)
    {
        TextState = text;
        Next = null;
        Prev = null;
    }
}

class TextEditor
{
    private Node head;
    private Node current;
    private int historyLimit = 10;
    private int size = 0;

    public TextEditor()
    {
        head = null;
        current = null;
    }

    public void AddState(string text)
    {
        Node newNode = new Node(text);
        if (head == null)
        {
            head = newNode;
            current = newNode;
        }
        else
        {
            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;
        }

        size++;
        if (size > historyLimit)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.TextState);
        }
        else
        {
            Console.WriteLine("No more undo available!");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.TextState);
        }
        else
        {
            Console.WriteLine("No more redo available!");
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current Text: " + current.TextState);
        }
        else
        {
            Console.WriteLine("No text available!");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        while (true)
        {
            Console.WriteLine("\n1. Type Text\n2. Undo\n3. Redo\n4. View Current Text\n5. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Text: ");
                    string text = Console.ReadLine();
                    editor.AddState(text);
                    break;
                case 2:
                    editor.Undo();
                    break;
                case 3:
                    editor.Redo();
                    break;
                case 4:
                    editor.DisplayCurrentState();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}*/
