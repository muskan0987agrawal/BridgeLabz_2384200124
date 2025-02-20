//using System;
//using System.Collections.Generic;

//class Program
//{
//    // Function to find symmetric difference manually
//    static List<int> SymmetricDifference(List<int> list1, List<int> list2)
//    {
//        List<int> result = new List<int>();

//        // Add elements from list1 that are NOT in list2
//        for (int i = 0; i < list1.Count; i++)
//        {
//            if (!IsPresent(list2, list1[i]) && !IsPresent(result, list1[i]))
//                result.Add(list1[i]);
//        }

//        // Add elements from list2 that are NOT in list1
//        for (int i = 0; i < list2.Count; i++)
//        {
//            if (!IsPresent(list1, list2[i]) && !IsPresent(result, list2[i]))
//                result.Add(list2[i]);
//        }

//        return result;
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

//    static void Main()
//    {
//        Console.WriteLine("Enter elements for the first list (space-separated):");
//        List<int> list1 = ReadList();

//        Console.WriteLine("Enter elements for the second list (space-separated):");
//        List<int> list2 = ReadList();

//        List<int> symmetricDifference = SymmetricDifference(list1, list2);

//        Console.Write("Symmetric Difference: ");
//        PrintList(symmetricDifference);
//    }

//    // ✅ Improved function to read input and convert it to a list
//    static List<int> ReadList()
//    {
//        List<int> list = new List<int>();
//        string input = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(input))  // Handle empty input
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
//            else
//            {
//                Console.WriteLine($"Skipping invalid input: {str}");
//            }
//        }
//        return list;
//    }

//    // Function to print list elements
//    static void PrintList(List<int> list)
//    {
//        if (list.Count == 0)
//        {
//            Console.WriteLine("No symmetric difference found.");
//        }
//        else
//        {
//            foreach (int num in list)
//            {
//                Console.Write(num + " ");
//            }
//            Console.WriteLine();
//        }
//    }
using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    //{
    //    HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

    //    // Convert HashSet to List manually
    //    List<int> list = ConvertSetToList(set);

    //    // Sort the list manually using Bubble Sort
    //    BubbleSort(list);

    //    // Print the sorted list
    //    Console.Write("Sorted List: ");
    //    PrintList(list);
    //}

    // Function to manually convert HashSet to List
    static List<int> ConvertSetToList(HashSet<int> set)
    {
        List<int> list = new List<int>();
        foreach (int num in set)
        {
            list.Add(num);
        }
        return list;
    }

    // Function to sort the list manually using Bubble Sort
    static void BubbleSort(List<int> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (list[j] > list[j + 1]) // Swap if elements are in wrong order
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }

    // Function to print the list
    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//}
