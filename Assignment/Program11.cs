//using System;

//class Program
//{
//    static int FindRotationPoint(int[] arr)
//    {
//        int left = 0, right = arr.Length - 1;

//        while (left < right)
//        {
//            int mid = left + (right - left) / 2;

//            if (arr[mid] > arr[right])
//                left = mid + 1; // Search in the right half
//            else
//                right = mid; // Search in the left half
//        }

//        return left; 
//    }
//    static void Main()
//    {
//        int[] arr = { 4, 5, 6, 7, 0, 1, 2 }; 

//        int rotationIndex = FindRotationPoint(arr);

//        Console.WriteLine($"The smallest element is at index: {rotationIndex}");
//    }

//}
