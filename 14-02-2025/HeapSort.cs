/*using System;

namespace _14_02_2025
{
    internal class HeapSort
    {
        // Function to heapify a subtree rooted at index 'i'
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Assume root is the largest
            int left = 2 * i + 1; // Left child index
            int right = 2 * i + 2; // Right child index

            // If left child is larger than root
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // If right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not root, swap and continue heapifying
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest); // Recursively heapify the affected subtree
            }
        }

        // Function to perform Heap Sort
        static void HeapSorts(int[] arr, int n)
        {
            // Build Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Extract elements one by one from the heap
            for (int i = n - 1; i > 0; i--)
            {
                // Swap current root (largest) with the last element
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0); // Heapify the reduced heap
            }
        }

        public static void Main()
        {
            int[] salaries = { 50000, 70000, 40000, 60000, 80000, 45000 };
            int n = salaries.Length;

            Console.WriteLine("Original Salaries:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(salaries[i] + " ");
            }
            Console.WriteLine();

            HeapSorts(salaries, n); // Sorting the array

            Console.WriteLine("Sorted Salaries:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(salaries[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/