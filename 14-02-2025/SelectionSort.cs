/* using System;

namespace _14_02_2025
{
    internal class SelectionSort
    {
        // Function to take user input
        public static int[] TakeInput()
        {
            Console.Write("Enter the marks of Student: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Enter {n} marks:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        // Function to perform Selection Sort
        static void SelectionSorts(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i; // Assume the current index is the minimum

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j; // Update the minimum index
                    }
                }

                // Swap arr[i] with the found minimum element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("Sorted Exam Scores: ");
            PrintArr(arr);
        }

        // Function to print an array
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
            int[] arr = TakeInput();
            SelectionSorts(arr);
        }
    }
}
*/