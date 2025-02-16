//using System;

//class Program12
//{
//  static int FindPeakElement(int[] arr)
//    {
//        int left = 0, right = arr.Length - 1;

//        while (left < right)
//        {
//            int mid = left + (right - left) / 2;

//            if (arr[mid] > arr[mid + 1])
//                right = mid; // Peak is in the left half
//            else
//                left = mid + 1; // Peak is in the right half
//        }

//        return left; // 'left' points to a peak element
//    }
//    static void Main()
//    {
//        int[] arr = { 1, 3, 20, 4, 1, 0 };

//        int peakIndex = FindPeakElement(arr);

//        Console.WriteLine($"Peak element found at index: {peakIndex}, Value: {arr[peakIndex]}");
//    }

//}
