/*using System;

class Process
{
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
    public int Priority { get; set; }
    public int WaitingTime { get; set; } = 0;
    public int TurnAroundTime { get; set; } = 0;

    public Process(int id, int burstTime, int priority)
    {
        ProcessID = id;
        BurstTime = burstTime;
        Priority = priority;
    }
}

class Node
{
    public Process process;
    public Node next;

    public Node(Process process)
    {
        this.process = process;
        this.next = null;
    }
}

class CircularLinkedList
{
    private Node head;
    private Node tail;
    public int Size { get; private set; } = 0;

    public void AddProcess(Process process)
    {
        Node newNode = new Node(process);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            newNode.next = head;
        }
        else
        {
            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }
        Size++;
    }

    public void RemoveProcess(int processID)
    {
        if (head == null) return;

        Node temp = head, prev = null;
        do
        {
            if (temp.process.ProcessID == processID)
            {
                if (temp == head)
                {
                    tail.next = head.next;
                    head = head.next;
                }
                else if (temp == tail)
                {
                    prev.next = head;
                    tail = prev;
                }
                else
                {
                    prev.next = temp.next;
                }
                Size--;
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
    }

    public void RoundRobinScheduling(int timeQuantum)
    {
        if (head == null) return;

        Node temp = head;
        int totalTime = 0;
        while (Size > 0)
        {
            if (temp.process.BurstTime > 0)
            {
                int executionTime = Math.Min(temp.process.BurstTime, timeQuantum);
                temp.process.BurstTime -= executionTime;
                totalTime += executionTime;

                if (temp.process.BurstTime == 0)
                {
                    temp.process.TurnAroundTime = totalTime;
                    temp.process.WaitingTime = totalTime - executionTime;
                    Console.WriteLine($"Process {temp.process.ProcessID} completed. TAT: {temp.process.TurnAroundTime}, WT: {temp.process.WaitingTime}");
                    RemoveProcess(temp.process.ProcessID);
                }
            }
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        CircularLinkedList processList = new CircularLinkedList();
        processList.AddProcess(new Process(1, 10, 2));
        processList.AddProcess(new Process(2, 5, 1));
        processList.AddProcess(new Process(3, 8, 3));

        Console.Write("Enter time quantum: ");
        int timeQuantum = Convert.ToInt32(Console.ReadLine());

        processList.RoundRobinScheduling(timeQuantum);
    }
}*/
