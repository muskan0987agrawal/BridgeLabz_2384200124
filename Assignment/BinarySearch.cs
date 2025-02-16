//using System;

//class BinarySearchSorted
//{
//    public int FindIndex(int[] arr, int targetValue)
//    {
//      //Sort the array
//        Array.Sort(arr); 

//        int lb = 0, ub = arr.Length - 1;

//        while (lb <= ub)
//        {
//            int mid = lb + (ub - lb) / 2;


//            if (arr[mid] < targetValue)
//                lb = mid + 1; // Search in the right half
//            else
//                ub = mid - 1; // Search in the left half
//        }

//        return -1; // Target not found
//    }

//    public static void Main()
//    {
//        BinarySearchSorted search = new BinarySearchSorted();

//        Console.Write("Enter the number of elements in the array: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine($"Enter {n} elements:");
//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nSorted Array: " + string.Join(", ", arr));

//        Console.Write("\nEnter the target value to search: ");
//        int targetValue = int.Parse(Console.ReadLine());

//        int result = search.FindIndex(arr, targetValue);

//        if (result != -1)
//            Console.WriteLine($"Target {targetValue} found at index {result}.");
//        else
//            Console.WriteLine("Target not found in the array.");
//    }
//}
