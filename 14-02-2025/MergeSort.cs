using System;

namespace _14_02_2025
{
    internal class MergeSort
    {
        // Function to merge two sorted halves
        static void Conquer(int[] arr, int si, int mid, int ei)
        {
            int[] merged = new int[ei - si + 1];
            int idx1 = si;
            int idx2 = mid + 1;
            int x = 0;

            // Merge both sorted subarrays
            while (idx1 <= mid && idx2 <= ei)
            {
                if (arr[idx1] <= arr[idx2])
                {
                    merged[x++] = arr[idx1++];
                }
                else
                {
                    merged[x++] = arr[idx2++];
                }
            }

            // Copy remaining elements from left part
            while (idx1 <= mid)
            {
                merged[x++] = arr[idx1++];
            }

            // Copy remaining elements from right part
            while (idx2 <= ei)
            {
                merged[x++] = arr[idx2++];
            }

            // Copy merged array back to the original array
            for (int i = 0, j = si; i < merged.Length; i++, j++)
            {
                arr[j] = merged[i];
            }
        }

        // Function to divide the array
        static void Divide(int[] arr, int si, int ei)
        {
            if (si >= ei)
            {
                return;
            }

            int mid = si + (ei - si) / 2;
            Divide(arr, si, mid);
            Divide(arr, mid + 1, ei);
            Conquer(arr, si, mid, ei);
        }

        // Function to print array
        static void PrintArray(int[] arr)
        {
            foreach (int price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            Console.Write("Enter the number of book : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] bookPrices = new int[n];

            Console.WriteLine($"Enter {n} book prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Price {i + 1}: ");
                bookPrices[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Book Prices:");
            PrintArray(bookPrices);

            // Sorting the array using Merge Sort
            Divide(bookPrices, 0, n - 1);

            Console.WriteLine("\nSorted Book Prices (Ascending Order):");
            PrintArray(bookPrices);
        }
    }
}
