﻿/* using System;
using System.Collections;

namespace CollectionAssignment
{
    //Reversed an element by arrayList
    static class ReversedElement
    {
        public static void ReversedList()
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            int i = 0, j = list.Count - 1;

            while (i < j)
            {
                // Swap elements
                object temp = list[i];
                list[i] = list[j];
                list[j] = temp;

                i++;
                j--;
            }

            // Display reversed list
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
        }
        //Reverse a LinkedList 
        class LinkedList
        {

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
            private Node head;
            public LinkedList()
            {
                this.head = null;
            }

            public void InsertEnd(int value)
            {
                Node newNode = new Node(value);
                if (head == null) { head = newNode; return; }// If list is empty

                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;


            }

            public void ReverseLL()
            {
                Node prev = null;
                Node curr = head;
                Node nextPtr;
                while (curr != null)
                {
                    nextPtr = curr.next;
                    curr.next = prev;

                    prev = curr;
                    curr = nextPtr;
                }

                head = prev;
            }

            public void Display()
            {
                Node temp = head;
                if (head == null)
                {
                    Console.WriteLine("No node exists!");
                    return;
                }

                while (temp != null)
                {
                    Console.Write($"{temp.data}   ");
                    temp = temp.next;
                }

                Console.WriteLine();

            }
        }
        internal class ReverseLinkedList
        {
            static void Main()
            {
                LinkedList l = new LinkedList();
                l.InsertEnd(1);
                l.InsertEnd(2);
                l.InsertEnd(3);
                l.InsertEnd(4);
                l.InsertEnd(5);
                l.Display();
                Console.WriteLine("Reversed array list by Linked List");
                l.ReverseLL();
                l.Display();

                Console.WriteLine();
                //Method call
                Console.WriteLine("Reversed array list by ArrayList");
                ReversedElement.ReversedList();
            }
        }
    }
}
*/