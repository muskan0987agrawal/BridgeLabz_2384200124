/*using System;
using System.Collections.Generic;

class Program
{
    // Function to find the union of two lists (manually)
    static List<int> FindUnion(List<int> list1, List<int> list2)
    {
        List<int> union = new List<int>();

        // Add elements from list1
        for (int i = 0; i < list1.Count; i++)
        {
            if (!IsPresent(union, list1[i])) // Checking manually
                union.Add(list1[i]);
        }

        // Add elements from list2 (only if not already present)
        for (int i = 0; i < list2.Count; i++)
        {
            if (!IsPresent(union, list2[i]))
                union.Add(list2[i]);
        }

        return union;
    }

    // Function to find the intersection of two lists (manually)
    static List<int> FindIntersection(List<int> list1, List<int> list2)
    {
        List<int> intersection = new List<int>();

        // Check if elements of list1 exist in list2
        for (int i = 0; i < list1.Count; i++)
        {
            if (IsPresent(list2, list1[i]) && !IsPresent(intersection, list1[i]))
                intersection.Add(list1[i]);
        }

        return intersection;
    }

    // Function to check if an element is present in a list (manually)
    static bool IsPresent(List<int> list, int num)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == num)
                return true;
        }
        return false;
    }

    static void Main()
    {
        Console.WriteLine("Enter elements for the first list (space-separated):");
        List<int> list1 = ReadList();

        Console.WriteLine("Enter elements for the second list (space-separated):");
        List<int> list2 = ReadList();

        List<int> union = FindUnion(list1, list2);
        List<int> intersection = FindIntersection(list1, list2);

        Console.Write("Union: ");
        PrintList(union);

        Console.Write("Intersection: ");
        PrintList(intersection);
    }

    // Function to read user input and convert to list
    static List<int> ReadList()
    {
        string[] input = Console.ReadLine().Split();
        List<int> list = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            list.Add(int.Parse(input[i]));
        }

        return list;
    }

    // Function to print a list manually
    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
}
*/


class UnionIntersection
{
    public static void FindUnion<T>(List<T> s1, List<T> s2 )
    {
         Dictionary<T,int> dic = new Dictionary<T, int>(s1);
     
    }
    public void Main()
    {

    }
}