using System;

/*namespace _14_02_2025
{
    internal class QuickSort
    {
        // Partition function to place pivot at correct position
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Taking the last element as the pivot
            int i = low - 1; // Index for smaller element

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap pivot element with the element at (i + 1)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1; // Returning partition index
        }

        // QuickSort function
        static void QuickSorts(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSorts(arr, low, pi - 1); // Left partition
                QuickSorts(arr, pi + 1, high); // Right partition
            }
        }

        public static void Main()
        {
            int[] prices = { 250, 100, 400, 150, 350, 200 };
            int n = prices.Length;

            Console.WriteLine("Original Prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(prices[i] + " ");
            }
            Console.WriteLine();

            QuickSorts(prices, 0, n - 1); // Sorting the array

            Console.WriteLine("Sorted Prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(prices[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/