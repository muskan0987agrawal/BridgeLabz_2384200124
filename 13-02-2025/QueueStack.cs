
namespace _13_02_2025
{
    internal class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    internal class Stack
    {
        Node top;
        int count;
        public Stack()
        {
            top = null;
            count = 0;
        }

        public void Push(int ele)
        {
            Node newData= new Node(ele);
            newData.next = top;
            top = newData;
            count++;
        }
        public void Display()
        {
            Node temp = top;
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            //Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
            Console.WriteLine();
        }

        public void Peek()
        {
            if(top == null) { Console.WriteLine("Empty"); }
            Console .WriteLine(top.data);
            return;
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int poppedElement = top.data;
            Console.WriteLine("Pop element is: " + top.data);
            top = top.next;
            return poppedElement;
        }

        public bool IsEmpty()
        {
            if (top == null) { return true; }
            else return false;
        }
        public void Show()
        {
            Push(10);
            Push(20);
            Display();
            Peek();
            Pop();
            Pop();
            Pop();
        }
    }

    class Queue
    {
        Stack s1 = new Stack();
        Stack s2 = new Stack();

        public void Enqueue(int n)
        {
            s1.Push(n);

        }
        public void Dequeue()
        {
            if (s1 == null && s2 == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            if (s2.IsEmpty())
            {
                while (!s1.IsEmpty())
                {
                    s2.Push(s1.Pop());
                }

            }
            s2.Pop();
        }
        public void Display()
        {
            if (s1.IsEmpty() && s2.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            // Move elements to s2 to get FIFO order
            if (s2.IsEmpty())
            {
                while (!s1.IsEmpty())
                {
                    s2.Push(s1.Pop());
                }
            }

            // Display elements in s2
            Console.WriteLine("Queue elements:");
            s2.Display();
        }
    }
    class DemoQueue
    {
        public static void Main()
        {
            Stack ele = new Stack();
            ele.Show();
            Queue que   = new Queue();
            que.Enqueue(2);
            que.Enqueue(21);
            que.Enqueue(22);
            que.Display();
            que.Dequeue();
            que.Dequeue();
            que.Dequeue();
            que.Display();

        }
    }
}
