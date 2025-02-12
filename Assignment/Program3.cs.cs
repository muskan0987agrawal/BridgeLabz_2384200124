/*using System;

public class Task
{
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public string DueDate { get; set; }

    public Task(int taskID, string taskName, int priority, string dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
    }

    public void ShowTaskDetails()
    {
        Console.WriteLine($"Task ID: {TaskID}, Name: {TaskName}, Priority: {Priority}, Due: {DueDate}");
    }
}

class Node
{
    public Task task;
    public Node next;

    public Node(Task task)
    {
        this.task = task;
        this.next = null;
    }
}

class CircularLinkedList
{
    private Node head;
    private Node current;

    public CircularLinkedList()
    {
        this.head = null;
        this.current = null;
    }

    public void AddBeginning(Task task)
    {
        Node newNode = new Node(task);
        if (head == null)
        {
            head = newNode;
            head.next = head;
        }
        else
        {
            Node temp = head;
            while (temp.next != head)
                temp = temp.next;
            temp.next = newNode;
            newNode.next = head;
            head = newNode;
        }
    }

    public void AddEnd(Task task)
    {
        Node newNode = new Node(task);
        if (head == null)
        {
            head = newNode;
            head.next = head;
        }
        else
        {
            Node temp = head;
            while (temp.next != head)
                temp = temp.next;
            temp.next = newNode;
            newNode.next = head;
        }
    }

    public void RemoveTask(int taskID)
    {
        if (head == null) return;

        Node temp = head, prev = null;
        do
        {
            if (temp.task.TaskID == taskID)
            {
                if (temp == head)
                {
                    Node last = head;
                    while (last.next != head)
                        last = last.next;
                    head = head.next;
                    last.next = head;
                }
                else
                {
                    prev.next = temp.next;
                }
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
    }

    public void ViewCurrentTask()
    {
        if (current == null)
            current = head;
        current.task.ShowTaskDetails();
    }

    public void MoveToNextTask()
    {
        if (current != null)
            current = current.next;
    }

    public void DisplayTasks()
    {
        if (head == null) return;
        Node temp = head;
        do
        {
            temp.task.ShowTaskDetails();
            temp = temp.next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null) return;
        Node temp = head;
        do
        {
            if (temp.task.Priority == priority)
                temp.task.ShowTaskDetails();
            temp = temp.next;
        } while (temp != head);
    }
}

public class Program
{
    public static void Main()
    {
        CircularLinkedList scheduler = new CircularLinkedList();
        scheduler.AddEnd(new Task(1, "Task A", 3, "2025-02-15"));
        scheduler.AddEnd(new Task(2, "Task B", 1, "2025-02-10"));
        scheduler.AddEnd(new Task(3, "Task C", 2, "2025-02-12"));

        Console.WriteLine("All Tasks:");
        scheduler.DisplayTasks();

        Console.WriteLine("\nCurrent Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nMoving to next task...");
        scheduler.MoveToNextTask();
        scheduler.ViewCurrentTask();
    }
}
*/