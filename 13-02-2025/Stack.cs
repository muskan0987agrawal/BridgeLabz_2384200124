//using System;
//using System.Collections.Generic;

//class Node
//{
//    public int data;
//    public Node next;
//    public Node(int data)
//    {
//        this.data = data;
//        this.next = null;
//    }
//}

//internal class Stack
//{
//    Node top;
//    int count = 0;
//    public Stack()
//    {
//        this.top = null;
//    }
//    public void Push(int data)
//    {
//        Node newNode = new Node(data);
//        newNode.next = top;
//        top = newNode;

//        return;
//    }

//    public void Pop()
//    {
//if (top == null)
//{
//    Console.WriteLine("Stack is Empty");
//    return;
//}
//Console.WriteLine("Pop element is: " + top.data);
//top = top.next;
//    }
//    public void Peek()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("Stack is Empty");
//            return;
//        }
//        Console.WriteLine(top.data);
//    }

//    public int Count()
//    {
//        int count = 0;
//        Node temp = top;
//        while (temp != null)
//        {
//            count++;
//            temp = temp.next;
//        }

//        return count;
//    }
//public void Display()
//{
//    Node temp = top;
//    if (top == null)
//    {
//        Console.WriteLine("Stack is Empty");
//        return;
//    }
//    //Node temp = top;
//    while (temp != null)
//    {
//        Console.WriteLine(temp.data + " ");
//        temp = temp.next;

//    }
//    Console.WriteLine();
//}

//    public void Delete()//Whole stack is empty
//    {

//        int count = Count();
//        while (count > 0)
//        {
//            Pop();
//            count--;


//        }

//    }
//    public void Show()
//    {
//        Push(4);

//        Push(5);
//        //Display();
//        //Console.Write("Peek:  ");
//        //  Peek();

//        Push(6);
//        Push(7);
//        Delete();
//        Display();
//        Console.WriteLine("Total count is : " + Count());

//        //Pop();
//        //Pop();
//        //Pop();
//        //Pop();
//        //Pop();
//        //Display();

//    }
//}
//class DemoStack
//{
//    public static void Main()
//    {
//        Stack ele = new Stack();
//        ele.Show();
//    }
//}