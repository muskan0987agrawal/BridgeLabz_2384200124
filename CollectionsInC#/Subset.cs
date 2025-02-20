//using System;
//using System.Collections.Generic;

//class Findsubset
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter elements for the first set (space-separated):");
//        List<int> subset = ReadList();

//        Console.WriteLine("Enter elements for the second set (space-separated):");
//        List<int> mainSet = ReadList();

//        bool isSubset = CheckSubset(subset, mainSet);

//        Console.WriteLine($"Is subset: {isSubset}");
//    }

//    // Function to manually check if set1 is a subset of set2
//    static bool CheckSubset(List<int> set1, List<int> set2)
//    {
//        for (int i = 0; i < set1.Count; i++)
//        {
//            if (!IsPresent(set2, set1[i]))
//            {
//                return false; // If any element of set1 is not in set2, return false
//            }
//        }
//        return true; // All elements of set1 exist in set2
//    }

//    // Function to manually check if an element exists in a list
//    static bool IsPresent(List<int> list, int num)
//    {
//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] == num)
//                return true;
//        }
//        return false;
//    }

//    // Function to read space-separated input and convert it to a list
//    static List<int> ReadList()
//    {
//        List<int> list = new List<int>();
//        string input = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(input))
//        {
//            Console.WriteLine("Invalid input. Please enter numbers.");
//            return list;
//        }

//        string[] elements = input.Split();
//        foreach (string str in elements)
//        {
//            if (int.TryParse(str, out int num))
//            {
//                list.Add(num);
//            }

//        }
//        return list;
//    }
//}

//using System;
//using System.Collections.Generic;
//class ReverseAQueue
//{
//    static void Main()
//    {
//        Queue<int> queue = new Queue<int>();
//        queue.Enqueue(10);
//        queue.Enqueue(20);
//        queue.Enqueue(30);

//        Console.WriteLine("Original Queue:");
//        PrintQueue(queue);

//        ReverseQueue(queue);

//        Console.WriteLine("Reversed Queue:");
//        PrintQueue(queue);
//    }

//    // Function to reverse a queue using a stack
//    static void ReverseQueue(Queue<int> queue)
//    {
//        Stack<int> stack = new Stack<int>();

//        // Dequeue all elements from the queue and push them onto the stack
//        while (queue.Count > 0)
//        {
//            stack.Push(queue.Dequeue());
//        }

//        // Pop all elements from the stack and enqueue them back into the queue
//        while (stack.Count > 0)
//        {
//            queue.Enqueue(stack.Pop());
//        }
//    }

//    // Function to print a queue
//    static void PrintQueue(Queue<int> queue)
//    {
//        foreach (int item in queue)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }
//}

//using System;
//using System.Collections.Generic;

//class GenerateBinaryNumbers
//{
//    public static void PrintBinaryNumbers(int N)
//    {
//        Queue<string> queue = new Queue<string>();
//        queue.Enqueue("1"); // Start with "1"

//        for (int i = 0; i < N; i++)
//        {
//            string front = queue.Dequeue();  // Get the front element
//            Console.Write(front + " ");  // Print the current binary number

//            // Generate next two binary numbers
//            queue.Enqueue(front + "0");
//            queue.Enqueue(front + "1");
//        }
//    }

//    static void Main()
//    {
//        Console.Write("Enter N: ");
//        int N = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"First {N} Binary Numbers:");
//        PrintBinaryNumbers(N);
//    }
//}
