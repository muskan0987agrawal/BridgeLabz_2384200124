/*using System;

namespace ModularSorting
{
    internal class Program1
    {
        // Function to take user input
        public static int[] TakeInput()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        // Function to sort an array using Bubble Sort
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

       
         
        

        // Function to print an array manually
        public static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = TakeInput(); // Get user input
            BubbleSort(arr);         // Sort the array
            Console.WriteLine("Sorted array:");
           PrintArr(arr);           // Print the sorted array
           
        }
       

    }
}
*/